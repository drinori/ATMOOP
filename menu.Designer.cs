namespace atm
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            labelWelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            terheqja = new Button();
            bilanci = new Button();
            deponim = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            kerko = new Button();
            mesazhet = new Button();
            historiku = new Button();
            qkyqu = new Button();
            dergo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.FromArgb(41, 39, 46);
            labelWelcome.Location = new Point(33, 29);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 29);
            labelWelcome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(163, 229);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.Location = new Point(432, 229);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.Location = new Point(642, 229);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 29);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.Location = new Point(163, 277);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 29);
            label4.TabIndex = 8;
            // 
            // terheqja
            // 
            terheqja.BackColor = Color.FromArgb(222, 8, 20);
            terheqja.FlatAppearance.BorderColor = Color.Black;
            terheqja.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            terheqja.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            terheqja.FlatStyle = FlatStyle.Flat;
            terheqja.Font = new Font("SF Pro Display", 12F);
            terheqja.ForeColor = SystemColors.Window;
            terheqja.Location = new Point(794, 127);
            terheqja.Margin = new Padding(4, 3, 4, 3);
            terheqja.Name = "terheqja";
            terheqja.Size = new Size(290, 56);
            terheqja.TabIndex = 10;
            terheqja.Text = "Tërheqje e mjeteve";
            terheqja.UseVisualStyleBackColor = false;
            terheqja.Click += terheqja_Click;
            // 
            // bilanci
            // 
            bilanci.BackColor = Color.FromArgb(222, 8, 20);
            bilanci.FlatAppearance.BorderColor = Color.Black;
            bilanci.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            bilanci.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            bilanci.FlatStyle = FlatStyle.Flat;
            bilanci.Font = new Font("SF Pro Display", 12F);
            bilanci.ForeColor = SystemColors.Window;
            bilanci.Location = new Point(39, 127);
            bilanci.Margin = new Padding(4, 3, 4, 3);
            bilanci.Name = "bilanci";
            bilanci.Size = new Size(290, 56);
            bilanci.TabIndex = 11;
            bilanci.Text = "Shiko bilancin";
            bilanci.UseVisualStyleBackColor = false;
            bilanci.Click += bilanci_Click;
            // 
            // deponim
            // 
            deponim.BackColor = Color.FromArgb(222, 8, 20);
            deponim.FlatAppearance.BorderColor = Color.Black;
            deponim.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            deponim.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            deponim.FlatStyle = FlatStyle.Flat;
            deponim.Font = new Font("SF Pro Display", 12F);
            deponim.ForeColor = SystemColors.Window;
            deponim.Location = new Point(423, 127);
            deponim.Margin = new Padding(4, 3, 4, 3);
            deponim.Name = "deponim";
            deponim.Size = new Size(290, 56);
            deponim.TabIndex = 13;
            deponim.Text = "Deponim i mjeteve";
            deponim.UseVisualStyleBackColor = false;
            deponim.Click += deponim_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(bilanci);
            panel1.Controls.Add(kerko);
            panel1.Controls.Add(mesazhet);
            panel1.Controls.Add(terheqja);
            panel1.Controls.Add(historiku);
            panel1.Controls.Add(qkyqu);
            panel1.Controls.Add(dergo);
            panel1.Controls.Add(deponim);
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 577);
            panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(945, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // kerko
            // 
            kerko.BackColor = Color.FromArgb(222, 8, 20);
            kerko.FlatAppearance.BorderColor = Color.Black;
            kerko.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            kerko.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            kerko.FlatStyle = FlatStyle.Flat;
            kerko.Font = new Font("SF Pro Display", 12F);
            kerko.ForeColor = Color.White;
            kerko.Location = new Point(39, 285);
            kerko.Margin = new Padding(4);
            kerko.Name = "kerko";
            kerko.Size = new Size(290, 56);
            kerko.TabIndex = 14;
            kerko.Text = "Kërko Para";
            kerko.UseVisualStyleBackColor = false;
            kerko.Click += this.kerko_Click;
            // 
            // mesazhet
            // 
            mesazhet.BackColor = Color.FromArgb(222, 8, 20);
            mesazhet.FlatAppearance.BorderColor = Color.Black;
            mesazhet.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            mesazhet.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            mesazhet.FlatStyle = FlatStyle.Flat;
            mesazhet.Font = new Font("SF Pro Display", 12F);
            mesazhet.ForeColor = SystemColors.Window;
            mesazhet.Location = new Point(39, 423);
            mesazhet.Margin = new Padding(4);
            mesazhet.Name = "mesazhet";
            mesazhet.Size = new Size(290, 56);
            mesazhet.TabIndex = 16;
            mesazhet.Text = "Mesazhet";
            mesazhet.UseVisualStyleBackColor = false;
            mesazhet.Click += this.mesazhet_Click;
            // 
            // historiku
            // 
            historiku.BackColor = Color.FromArgb(222, 8, 20);
            historiku.FlatAppearance.BorderColor = Color.Black;
            historiku.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            historiku.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            historiku.FlatStyle = FlatStyle.Flat;
            historiku.Font = new Font("SF Pro Display", 12F);
            historiku.ForeColor = SystemColors.Window;
            historiku.ImageAlign = ContentAlignment.MiddleRight;
            historiku.Location = new Point(794, 285);
            historiku.Margin = new Padding(4);
            historiku.Name = "historiku";
            historiku.Size = new Size(290, 56);
            historiku.TabIndex = 15;
            historiku.Text = "Historiku i transfereve";
            historiku.UseVisualStyleBackColor = false;
            historiku.Click += this.historiku_Click;
            // 
            // qkyqu
            // 
            qkyqu.BackColor = Color.FromArgb(217, 37, 37);
            qkyqu.FlatAppearance.BorderColor = Color.Black;
            qkyqu.FlatAppearance.MouseDownBackColor = Color.FromArgb(217, 37, 37);
            qkyqu.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            qkyqu.FlatStyle = FlatStyle.Flat;
            qkyqu.Font = new Font("SF Pro Display", 12F);
            qkyqu.ForeColor = SystemColors.ButtonFace;
            qkyqu.Location = new Point(794, 423);
            qkyqu.Margin = new Padding(4, 3, 4, 3);
            qkyqu.Name = "qkyqu";
            qkyqu.Size = new Size(290, 56);
            qkyqu.TabIndex = 9;
            qkyqu.Text = "Çkyçu";
            qkyqu.UseVisualStyleBackColor = false;
            qkyqu.Click += this.qkyqu_Click;
            // 
            // dergo
            // 
            dergo.BackColor = Color.FromArgb(222, 8, 20);
            dergo.FlatAppearance.BorderColor = Color.Black;
            dergo.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            dergo.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            dergo.FlatStyle = FlatStyle.Flat;
            dergo.Font = new Font("SF Pro Display", 12F);
            dergo.ForeColor = SystemColors.Window;
            dergo.Location = new Point(423, 285);
            dergo.Margin = new Padding(4, 3, 4, 3);
            dergo.Name = "dergo";
            dergo.Size = new Size(290, 56);
            dergo.TabIndex = 12;
            dergo.Text = "Dërgo Para";
            dergo.UseVisualStyleBackColor = false;
            dergo.Click += transfer_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 576);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button qkyqu;
        private Button terheqja;
        private Button bilanci;
        private Button transfer;
        private Button deponim;
        private Button kerko;
        private Button historiku;
        private Button mesazhet;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button dergo;
    }
}