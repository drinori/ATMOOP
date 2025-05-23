using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace atm
{
    public partial class historiku : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Documents\\atmoop.mdf;Integrated Security=True;Connect Timeout=30";
        private string currentUserIban;

        public historiku(string userIban)
        {
            InitializeComponent();
            currentUserIban = userIban;
            this.DoubleBuffered = true; // For smoother rendering
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
            if (transactionsDataGridView.Columns.Contains("Shuma"))
            {
                DataGridViewColumn shumaColumn = transactionsDataGridView.Columns["Shuma"];
                shumaColumn.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft, // Changed to MiddleLeft
                    Format = "N2"  // Formats as number with 2 decimal places
                };
            }
        }

        private void LoadTransactionHistory()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT 
                                    FORMAT(Tdata, 'dd/MM/yyyy HH:mm') AS 'Data',
                                    tipi AS 'Tipi',
                                    CAST(shuma AS decimal(18, 2)) AS 'Shuma',
                                    CASE 
                                        WHEN tipi = 'Depozit' THEN 'Depozit'
                                        WHEN tipi = 'Terheqje' THEN 'Terheqje'
                                        WHEN tipi = 'Transfer' AND iban = @UserIban THEN 'Dërguar tek: ' + iban_marresit
                                        WHEN tipi = 'Transfer' AND iban_marresit = @UserIban THEN 'Marrë nga: ' + iban
                                        ELSE 'Transaksion'
                                    END AS 'Detaje',
                                    ISNULL(mesazhi, '') AS 'Mesazhi'
                                FROM transaksionet
                                WHERE iban = @UserIban OR iban_marresit = @UserIban
                                ORDER BY Tdata DESC";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserIban", currentUserIban);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    transactionsDataGridView.DataSource = dataTable;
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë ngarkimit të historisë së transaksioneve: " + ex.Message,
                              "Gabim",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (transactionsDataGridView.Columns.Contains("Shuma"))
            {
                // Format amount column
                transactionsDataGridView.Columns["Shuma"].DefaultCellStyle.Format = "N2";
                transactionsDataGridView.Columns["Shuma"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // Color amounts based on transaction type
                foreach (DataGridViewRow row in transactionsDataGridView.Rows)
                {
                    if (row.Cells["Tipi"].Value != null && row.Cells["Detaje"].Value != null)
                    {
                        string transactionType = row.Cells["Tipi"].Value.ToString();
                        string details = row.Cells["Detaje"].Value.ToString();

                        if (transactionType == "Depozit" ||
                            (transactionType == "Transfer" && details.Contains("Marrë")))
                        {
                            row.Cells["Shuma"].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            row.Cells["Shuma"].Style.ForeColor = Color.Red;
                        }
                    }
                }
            }

            // Auto-size columns to fit content
            transactionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set specific sizing for certain columns
            if (transactionsDataGridView.Columns.Contains("Data"))
                transactionsDataGridView.Columns["Data"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (transactionsDataGridView.Columns.Contains("Tipi"))
                transactionsDataGridView.Columns["Tipi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Add some padding
            foreach (DataGridViewColumn column in transactionsDataGridView.Columns)
            {
                column.DefaultCellStyle.Padding = new Padding(5);
            }
        }

        private void returnButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}