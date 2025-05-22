using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace atm
{
    partial class historiku
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiku));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            returnButton = new Button();
            transactionsDataGridView = new DataGridView();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("SF Pro Display", 13F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(26, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 53);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Historia e Transaksioneve";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(23, 27, 23, 27);
            panel1.Size = new Size(1109, 572);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(returnButton);
            panel2.Controls.Add(transactionsDataGridView);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 571);
            panel2.TabIndex = 3;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.None;
            returnButton.BackColor = Color.FromArgb(222, 8, 20);
            returnButton.FlatAppearance.BorderSize = 1;
            returnButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            returnButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            returnButton.FlatAppearance.BorderColor = Color.Black;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new System.Drawing.Font("SF Pro Display", 12F);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(26, 513);
            returnButton.Margin = new Padding(3, 4, 3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(187, 53);
            returnButton.TabIndex = 27;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click_1;
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.AllowUserToAddRows = false;
            transactionsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            transactionsDataGridView.BackgroundColor = Color.FromArgb(217, 217, 217);
            transactionsDataGridView.BorderStyle = BorderStyle.None;
            transactionsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            transactionsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 7, 20);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 7, 20);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            transactionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            transactionsDataGridView.ColumnHeadersHeight = 40;
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            transactionsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            transactionsDataGridView.EnableHeadersVisualStyles = false;
            transactionsDataGridView.GridColor = Color.FromArgb(230, 230, 230);
            transactionsDataGridView.Location = new Point(26, 91);
            transactionsDataGridView.Margin = new Padding(3, 4, 3, 4);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.ReadOnly = true;
            transactionsDataGridView.RowHeadersVisible = false;
            transactionsDataGridView.RowHeadersWidth = 51;
            transactionsDataGridView.RowTemplate.Height = 35;
            transactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            transactionsDataGridView.Size = new Size(1057, 414);
            transactionsDataGridView.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(922, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // historiku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 247);
            ClientSize = new Size(1109, 572);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "historiku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historia e Transaksioneve";
            Load += TransactionHistory_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private DataGridView transactionsDataGridView;
        private Button returnButton;
    }
}