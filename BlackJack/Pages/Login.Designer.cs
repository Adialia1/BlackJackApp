namespace BlackJack.Pages
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.OpenImage = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new System.Windows.Forms.PictureBox();
            this.LoadingScreenPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.loginOutput = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.PictureBox();
            this.PasswordTextIMG = new System.Windows.Forms.PictureBox();
            this.UsernameTextIMG = new System.Windows.Forms.PictureBox();
            this.LoginTextIMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            this.LoadingScreenPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenImage
            // 
            this.OpenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenImage.Image = global::BlackJack.Properties.Resources.LoadingLogo;
            this.OpenImage.Location = new System.Drawing.Point(229, 21);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(862, 360);
            this.OpenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OpenImage.TabIndex = 0;
            this.OpenImage.TabStop = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayBtn.Image = global::BlackJack.Properties.Resources.playBtn;
            this.PlayBtn.Location = new System.Drawing.Point(515, 399);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(290, 99);
            this.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // LoadingScreenPanel
            // 
            this.LoadingScreenPanel.Controls.Add(this.PlayBtn);
            this.LoadingScreenPanel.Controls.Add(this.OpenImage);
            this.LoadingScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingScreenPanel.Name = "LoadingScreenPanel";
            this.LoadingScreenPanel.Size = new System.Drawing.Size(1264, 661);
            this.LoadingScreenPanel.TabIndex = 2;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.guna2Separator2);
            this.LoginPanel.Controls.Add(this.guna2Separator1);
            this.LoginPanel.Controls.Add(this.loginOutput);
            this.LoginPanel.Controls.Add(this.passwordTextBox);
            this.LoginPanel.Controls.Add(this.usernameTextBox);
            this.LoginPanel.Controls.Add(this.RegisterButton);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordTextIMG);
            this.LoginPanel.Controls.Add(this.UsernameTextIMG);
            this.LoginPanel.Controls.Add(this.LoginTextIMG);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1264, 661);
            this.LoginPanel.TabIndex = 2;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(676, 187);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(193, 10);
            this.guna2Separator2.TabIndex = 19;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(676, 256);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(193, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // loginOutput
            // 
            this.loginOutput.Location = new System.Drawing.Point(376, 387);
            this.loginOutput.Name = "loginOutput";
            this.loginOutput.Size = new System.Drawing.Size(535, 60);
            this.loginOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loginOutput.TabIndex = 18;
            this.loginOutput.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(133)))), ((int)(((byte)(100)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(677, 222);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(193, 36);
            this.passwordTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(133)))), ((int)(((byte)(100)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(676, 152);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(193, 36);
            this.usernameTextBox.TabIndex = 16;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Image = global::BlackJack.Properties.Resources.RegisterBtnIMG;
            this.RegisterButton.Location = new System.Drawing.Point(651, 295);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(260, 72);
            this.RegisterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RegisterButton.TabIndex = 15;
            this.RegisterButton.TabStop = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Image = global::BlackJack.Properties.Resources.loginBtnImg;
            this.LoginButton.Location = new System.Drawing.Point(376, 295);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(260, 72);
            this.LoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginButton.TabIndex = 13;
            this.LoginButton.TabStop = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextIMG
            // 
            this.PasswordTextIMG.Image = global::BlackJack.Properties.Resources.passwordIMG;
            this.PasswordTextIMG.Location = new System.Drawing.Point(381, 214);
            this.PasswordTextIMG.Name = "PasswordTextIMG";
            this.PasswordTextIMG.Size = new System.Drawing.Size(260, 53);
            this.PasswordTextIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PasswordTextIMG.TabIndex = 12;
            this.PasswordTextIMG.TabStop = false;
            // 
            // UsernameTextIMG
            // 
            this.UsernameTextIMG.Image = global::BlackJack.Properties.Resources.usernameIMG;
            this.UsernameTextIMG.Location = new System.Drawing.Point(381, 144);
            this.UsernameTextIMG.Name = "UsernameTextIMG";
            this.UsernameTextIMG.Size = new System.Drawing.Size(260, 53);
            this.UsernameTextIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UsernameTextIMG.TabIndex = 11;
            this.UsernameTextIMG.TabStop = false;
            // 
            // LoginTextIMG
            // 
            this.LoginTextIMG.Image = global::BlackJack.Properties.Resources.LoginIMG;
            this.LoginTextIMG.Location = new System.Drawing.Point(506, 41);
            this.LoginTextIMG.Name = "LoginTextIMG";
            this.LoginTextIMG.Size = new System.Drawing.Size(260, 53);
            this.LoginTextIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LoginTextIMG.TabIndex = 10;
            this.LoginTextIMG.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LoadingScreenPanel);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1264, 661);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            this.LoadingScreenPanel.ResumeLayout(false);
            this.LoadingScreenPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OpenImage;
        private System.Windows.Forms.PictureBox PlayBtn;
        private System.Windows.Forms.Panel LoadingScreenPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox loginOutput;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.PictureBox RegisterButton;
        private System.Windows.Forms.PictureBox LoginButton;
        private System.Windows.Forms.PictureBox PasswordTextIMG;
        private System.Windows.Forms.PictureBox UsernameTextIMG;
        private System.Windows.Forms.PictureBox LoginTextIMG;
    }
}
