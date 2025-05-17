namespace atm
{
    partial class dergo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dergo));
            send = new Button();
            kthehu = new Button();
            messagebox = new TextBox();
            marresiIBAN = new TextBox();
            shuma = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTitle = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // send
            // 
            send.Anchor = AnchorStyles.None;
            send.BackColor = Color.FromArgb(180, 190, 201);
            send.FlatAppearance.BorderSize = 0;
            send.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            send.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            send.FlatStyle = FlatStyle.Flat;
            send.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            send.Location = new Point(299, 492);
            send.Margin = new Padding(3, 4, 3, 4);
            send.Name = "send";
            send.Size = new Size(171, 53);
            send.TabIndex = 0;
            send.Text = "Dërgo";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // kthehu
            // 
            kthehu.Anchor = AnchorStyles.None;
            kthehu.BackColor = Color.FromArgb(180, 190, 201);
            kthehu.FlatAppearance.BorderSize = 0;
            kthehu.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 190, 201);
            kthehu.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 171, 181);
            kthehu.FlatStyle = FlatStyle.Flat;
            kthehu.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kthehu.Location = new Point(67, 492);
            kthehu.Margin = new Padding(3, 4, 3, 4);
            kthehu.Name = "kthehu";
            kthehu.Size = new Size(171, 53);
            kthehu.TabIndex = 1;
            kthehu.Text = "Kthehu";
            kthehu.UseVisualStyleBackColor = true;
            kthehu.Click += kthehu_Click;
            // 
            // messagebox
            // 
            messagebox.Font = new Font("SF Pro Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messagebox.Location = new Point(67, 267);
            messagebox.Margin = new Padding(3, 4, 3, 4);
            messagebox.Multiline = true;
            messagebox.Name = "messagebox";
            messagebox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messagebox.Size = new Size(403, 187);
            messagebox.TabIndex = 2;
            // 
            // marresiIBAN
            // 
            marresiIBAN.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marresiIBAN.Location = new Point(67, 134);
            marresiIBAN.Margin = new Padding(3, 4, 3, 4);
            marresiIBAN.Name = "marresiIBAN";
            marresiIBAN.PlaceholderText = "IBAN i marrësit";
            marresiIBAN.Size = new Size(403, 31);
            marresiIBAN.TabIndex = 3;
            // 
            // shuma
            // 
            shuma.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shuma.Location = new Point(67, 206);
            shuma.Margin = new Padding(3, 4, 3, 4);
            shuma.Name = "shuma";
            shuma.PlaceholderText = "Shuma";
            shuma.Size = new Size(403, 31);
            shuma.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(472, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 495);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(shuma);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(messagebox);
            panel2.Controls.Add(marresiIBAN);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(send);
            panel2.Controls.Add(kthehu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 572);
            panel2.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("SF Pro Display", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(67, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 34);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Dërgo Para";
            // 
            // dergo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 572);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dergo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dergo";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button send;
        private Button kthehu;
        private TextBox messagebox;
        private TextBox marresiIBAN;
        private TextBox shuma;
        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
    }
}