namespace atm
{
    partial class regjistrimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regjistrimi));
            Emri = new TextBox();
            RegjistrohuR = new Button();
            pinR = new TextBox();
            ibanR = new TextBox();
            CVC = new TextBox();
            Mbiemri = new TextBox();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Emri
            // 
            Emri.Font = new Font("SF Pro Display", 13.8F);
            Emri.Location = new Point(111, 140);
            Emri.Name = "Emri";
            Emri.PlaceholderText = "Emri";
            Emri.Size = new Size(332, 35);
            Emri.TabIndex = 0;
            // 
            // RegjistrohuR
            // 
            RegjistrohuR.BackColor = Color.FromArgb(222, 8, 20);
            RegjistrohuR.FlatAppearance.BorderSize = 0;
            RegjistrohuR.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            RegjistrohuR.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            RegjistrohuR.FlatStyle = FlatStyle.Flat;
            RegjistrohuR.Font = new Font("SF Pro Display", 13.8F);
            RegjistrohuR.Location = new Point(634, 376);
            RegjistrohuR.Name = "RegjistrohuR";
            RegjistrohuR.Size = new Size(334, 56);
            RegjistrohuR.TabIndex = 4;
            RegjistrohuR.Text = "Regjistrohu";
            RegjistrohuR.UseVisualStyleBackColor = true;
            RegjistrohuR.Click += RegjistrohuR_Click;
            // 
            // pinR
            // 
            pinR.Font = new Font("SF Pro Display", 13.8F);
            pinR.Location = new Point(634, 261);
            pinR.Name = "pinR";
            pinR.PlaceholderText = "PIN";
            pinR.Size = new Size(333, 35);
            pinR.TabIndex = 10;
            // 
            // ibanR
            // 
            ibanR.Font = new Font("SF Pro Display", 13.8F);
            ibanR.Location = new Point(111, 261);
            ibanR.Name = "ibanR";
            ibanR.PlaceholderText = "IBAN";
            ibanR.Size = new Size(332, 35);
            ibanR.TabIndex = 11;
            // 
            // CVC
            // 
            CVC.Font = new Font("SF Pro Display", 13.8F);
            CVC.Location = new Point(111, 392);
            CVC.Name = "CVC";
            CVC.PlaceholderText = "CVC";
            CVC.Size = new Size(332, 35);
            CVC.TabIndex = 12;
            // 
            // Mbiemri
            // 
            Mbiemri.Font = new Font("SF Pro Display", 13.8F);
            Mbiemri.Location = new Point(634, 140);
            Mbiemri.Name = "Mbiemri";
            Mbiemri.PlaceholderText = "Mbiemri";
            Mbiemri.Size = new Size(333, 35);
            Mbiemri.TabIndex = 13;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Display", 13F);
            linkLabel1.ForeColor = SystemColors.WindowText;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(634, 445);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 26);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Keni llogari? Kyçu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ibanR);
            panel1.Controls.Add(CVC);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(Mbiemri);
            panel1.Controls.Add(RegjistrohuR);
            panel1.Controls.Add(pinR);
            panel1.Controls.Add(Emri);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 572);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(874, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 122);
            panel2.TabIndex = 16;
            // 
            // regjistrimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1109, 572);
            Controls.Add(panel1);
            Name = "regjistrimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Emri;
        private Button RegjistrohuR;
        private TextBox pinR;
        private TextBox ibanR;
        private TextBox CVC;
        private TextBox Mbiemri;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}