namespace atm
{
    partial class kerko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kerko));
            panel2 = new Panel();
            lblTitle = new Label();
            panel1 = new Panel();
            recipientIbanTextBox = new TextBox();
            returnButton = new Button();
            amountTextBox = new TextBox();
            messageTextBox = new TextBox();
            requestButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(recipientIbanTextBox);
            panel2.Controls.Add(returnButton);
            panel2.Controls.Add(amountTextBox);
            panel2.Controls.Add(messageTextBox);
            panel2.Controls.Add(requestButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 572);
            panel2.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(6, -33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 31);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Kërko Para";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(508, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 495);
            panel1.TabIndex = 6;
            // 
            // recipientIbanTextBox
            // 
            recipientIbanTextBox.Font = new Font("SF Pro Display", 12F);
            recipientIbanTextBox.Location = new Point(68, 91);
            recipientIbanTextBox.Margin = new Padding(3, 4, 3, 4);
            recipientIbanTextBox.Name = "recipientIbanTextBox";
            recipientIbanTextBox.PlaceholderText = "IBAN";
            recipientIbanTextBox.Size = new Size(396, 31);
            recipientIbanTextBox.TabIndex = 0;
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
            returnButton.Font = new Font("SF Pro Display", 12F);
            returnButton.ForeColor = Color.White;
            returnButton.Location = new Point(68, 494);
            returnButton.Margin = new Padding(3, 4, 3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(171, 53);
            returnButton.TabIndex = 4;
            returnButton.Text = "Kthehu";
            returnButton.UseVisualStyleBackColor = false;
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("SF Pro Display", 12F);
            amountTextBox.Location = new Point(68, 172);
            amountTextBox.Margin = new Padding(3, 4, 3, 4);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PlaceholderText = "Shuma";
            amountTextBox.Size = new Size(396, 31);
            amountTextBox.TabIndex = 1;
            // 
            // messageTextBox
            // 
            messageTextBox.Font = new Font("SF Pro Display", 10F);
            messageTextBox.Location = new Point(68, 239);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PlaceholderText = "Shkruani mesazhin tuaj këtu...";
            messageTextBox.Size = new Size(396, 209);
            messageTextBox.TabIndex = 2;
            // 
            // requestButton
            // 
            requestButton.Anchor = AnchorStyles.None;
            requestButton.BackColor = Color.FromArgb(222, 8, 20);
            requestButton.FlatAppearance.BorderSize = 1;
            requestButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 8, 20);
            requestButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 31, 40);
            requestButton.FlatAppearance.BorderColor = Color.Black;
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("SF Pro Display", 12F);
            requestButton.ForeColor = Color.White;
            requestButton.Location = new Point(265, 494);
            requestButton.Margin = new Padding(3, 4, 3, 4);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(199, 53);
            requestButton.TabIndex = 4;
            requestButton.Text = "Dërgo Kërkesën";
            requestButton.UseVisualStyleBackColor = false;
            // 
            // kerko
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 572);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "kerko";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kërko Para";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox messageTextBox;
        private TextBox recipientIbanTextBox;
        private TextBox amountTextBox;
        private Button requestButton;
        private Button returnButton;
        private Label lblTitle;
        private Panel panel2;
        private Panel panel1;
    }
}