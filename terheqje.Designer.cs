namespace atm
{
    partial class terheqje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(terheqje));
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SF Pro Display", 13.8F);
            textBox1.Location = new Point(306, 340);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Shuma";
            textBox1.Size = new Size(511, 35);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(222, 8, 20);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SF Pro Display", 13.8F);
            button1.Location = new Point(150, 467);
            button1.Name = "button1";
            button1.Size = new Size(253, 68);
            button1.TabIndex = 1;
            button1.Text = "Kthehu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 572);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1109, 396);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(222, 8, 20);
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            button3.ForeColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("SF Pro Display", 13.8F);
            button3.Location = new Point(730, 467);
            button3.Name = "button3";
            button3.Size = new Size(253, 68);
            button3.TabIndex = 3;
            button3.Text = "Vazhdo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // terheqje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 572);
            Controls.Add(panel1);
            Name = "terheqje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
    }
}