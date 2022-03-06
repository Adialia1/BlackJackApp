namespace BlackJack.Pages
{
    partial class Lobby
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
            this.MultiPlayerPanel = new System.Windows.Forms.Panel();
            this.tableSizeLB = new System.Windows.Forms.Label();
            this.tableSizeTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.joinServerID = new System.Windows.Forms.TextBox();
            this.hostServerID = new System.Windows.Forms.TextBox();
            this.joinServerBtn = new System.Windows.Forms.PictureBox();
            this.createServerBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LobbyPanel = new System.Windows.Forms.Panel();
            this.colorBtn = new System.Windows.Forms.Button();
            this.messageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.slot4LB = new System.Windows.Forms.Label();
            this.slot3LB = new System.Windows.Forms.Label();
            this.slot2LB = new System.Windows.Forms.Label();
            this.slot1LB = new System.Windows.Forms.Label();
            this.chatTextLB = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MultiPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joinServerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createServerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LobbyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MultiPlayerPanel
            // 
            this.MultiPlayerPanel.Controls.Add(this.tableSizeLB);
            this.MultiPlayerPanel.Controls.Add(this.tableSizeTrackBar);
            this.MultiPlayerPanel.Controls.Add(this.guna2Separator2);
            this.MultiPlayerPanel.Controls.Add(this.guna2Separator1);
            this.MultiPlayerPanel.Controls.Add(this.joinServerID);
            this.MultiPlayerPanel.Controls.Add(this.hostServerID);
            this.MultiPlayerPanel.Controls.Add(this.joinServerBtn);
            this.MultiPlayerPanel.Controls.Add(this.createServerBtn);
            this.MultiPlayerPanel.Controls.Add(this.pictureBox1);
            this.MultiPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiPlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.MultiPlayerPanel.Name = "MultiPlayerPanel";
            this.MultiPlayerPanel.Size = new System.Drawing.Size(1264, 661);
            this.MultiPlayerPanel.TabIndex = 0;
            // 
            // tableSizeLB
            // 
            this.tableSizeLB.AutoSize = true;
            this.tableSizeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tableSizeLB.ForeColor = System.Drawing.Color.White;
            this.tableSizeLB.Location = new System.Drawing.Point(346, 270);
            this.tableSizeLB.Name = "tableSizeLB";
            this.tableSizeLB.Size = new System.Drawing.Size(187, 31);
            this.tableSizeLB.TabIndex = 24;
            this.tableSizeLB.Text = "Table SIze: 2";
            // 
            // tableSizeTrackBar
            // 
            this.tableSizeTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tableSizeTrackBar.HoverState.Parent = this.tableSizeTrackBar;
            this.tableSizeTrackBar.Location = new System.Drawing.Point(620, 278);
            this.tableSizeTrackBar.Maximum = 4;
            this.tableSizeTrackBar.Minimum = 2;
            this.tableSizeTrackBar.Name = "tableSizeTrackBar";
            this.tableSizeTrackBar.Size = new System.Drawing.Size(307, 23);
            this.tableSizeTrackBar.TabIndex = 23;
            this.tableSizeTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tableSizeTrackBar.Value = 2;
            this.tableSizeTrackBar.ValueChanged += new System.EventHandler(this.tableSizeTrackBar_ValueChanged);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(620, 235);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(307, 10);
            this.guna2Separator2.TabIndex = 22;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(620, 406);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(307, 10);
            this.guna2Separator1.TabIndex = 19;
            // 
            // joinServerID
            // 
            this.joinServerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(133)))), ((int)(((byte)(100)))));
            this.joinServerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.joinServerID.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinServerID.ForeColor = System.Drawing.Color.White;
            this.joinServerID.Location = new System.Drawing.Point(620, 363);
            this.joinServerID.Name = "joinServerID";
            this.joinServerID.Size = new System.Drawing.Size(307, 50);
            this.joinServerID.TabIndex = 21;
            this.joinServerID.Text = "Room ID";
            this.joinServerID.Enter += new System.EventHandler(this.joinServerID_Enter);
            this.joinServerID.Leave += new System.EventHandler(this.joinServerID_Leave);
            // 
            // hostServerID
            // 
            this.hostServerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(133)))), ((int)(((byte)(100)))));
            this.hostServerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hostServerID.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostServerID.ForeColor = System.Drawing.Color.White;
            this.hostServerID.Location = new System.Drawing.Point(620, 192);
            this.hostServerID.Name = "hostServerID";
            this.hostServerID.ReadOnly = true;
            this.hostServerID.Size = new System.Drawing.Size(307, 50);
            this.hostServerID.TabIndex = 20;
            this.hostServerID.Text = "Room ID";
            // 
            // joinServerBtn
            // 
            this.joinServerBtn.Image = global::BlackJack.Properties.Resources.JoinServerBtn;
            this.joinServerBtn.Location = new System.Drawing.Point(352, 345);
            this.joinServerBtn.Name = "joinServerBtn";
            this.joinServerBtn.Size = new System.Drawing.Size(235, 86);
            this.joinServerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.joinServerBtn.TabIndex = 18;
            this.joinServerBtn.TabStop = false;
            this.joinServerBtn.Click += new System.EventHandler(this.joinServerBtn_Click);
            // 
            // createServerBtn
            // 
            this.createServerBtn.Image = global::BlackJack.Properties.Resources.CreateServerBtn;
            this.createServerBtn.Location = new System.Drawing.Point(352, 174);
            this.createServerBtn.Name = "createServerBtn";
            this.createServerBtn.Size = new System.Drawing.Size(235, 86);
            this.createServerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createServerBtn.TabIndex = 16;
            this.createServerBtn.TabStop = false;
            this.createServerBtn.Click += new System.EventHandler(this.createServerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.MultiPlayerLogo;
            this.pictureBox1.Location = new System.Drawing.Point(445, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LobbyPanel
            // 
            this.LobbyPanel.Controls.Add(this.colorBtn);
            this.LobbyPanel.Controls.Add(this.messageTextBox);
            this.LobbyPanel.Controls.Add(this.sendMessageBtn);
            this.LobbyPanel.Controls.Add(this.startGameBtn);
            this.LobbyPanel.Controls.Add(this.slot4LB);
            this.LobbyPanel.Controls.Add(this.slot3LB);
            this.LobbyPanel.Controls.Add(this.slot2LB);
            this.LobbyPanel.Controls.Add(this.slot1LB);
            this.LobbyPanel.Controls.Add(this.chatTextLB);
            this.LobbyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LobbyPanel.Location = new System.Drawing.Point(0, 0);
            this.LobbyPanel.Name = "LobbyPanel";
            this.LobbyPanel.Size = new System.Drawing.Size(1264, 661);
            this.LobbyPanel.TabIndex = 25;
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(413, 467);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(47, 38);
            this.colorBtn.TabIndex = 10;
            this.colorBtn.Text = "Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageTextBox.DefaultText = "";
            this.messageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageTextBox.DisabledState.Parent = this.messageTextBox;
            this.messageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageTextBox.FocusedState.Parent = this.messageTextBox;
            this.messageTextBox.ForeColor = System.Drawing.Color.Black;
            this.messageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageTextBox.HoverState.Parent = this.messageTextBox;
            this.messageTextBox.Location = new System.Drawing.Point(66, 467);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.messageTextBox.PlaceholderText = "Enter Message";
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.ShadowDecoration.Parent = this.messageTextBox;
            this.messageTextBox.Size = new System.Drawing.Size(341, 38);
            this.messageTextBox.TabIndex = 9;
            this.messageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.messageTextBox_KeyPress);
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Location = new System.Drawing.Point(466, 467);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(148, 38);
            this.sendMessageBtn.TabIndex = 7;
            this.sendMessageBtn.Text = "Send Message";
            this.sendMessageBtn.UseVisualStyleBackColor = true;
            this.sendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(775, 463);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(192, 42);
            this.startGameBtn.TabIndex = 6;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Visible = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // slot4LB
            // 
            this.slot4LB.AutoSize = true;
            this.slot4LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.slot4LB.Location = new System.Drawing.Point(748, 158);
            this.slot4LB.Name = "slot4LB";
            this.slot4LB.Size = new System.Drawing.Size(89, 33);
            this.slot4LB.TabIndex = 5;
            this.slot4LB.Text = "Slot 4";
            this.slot4LB.Visible = false;
            // 
            // slot3LB
            // 
            this.slot3LB.AutoSize = true;
            this.slot3LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.slot3LB.Location = new System.Drawing.Point(748, 125);
            this.slot3LB.Name = "slot3LB";
            this.slot3LB.Size = new System.Drawing.Size(89, 33);
            this.slot3LB.TabIndex = 4;
            this.slot3LB.Text = "Slot 3";
            this.slot3LB.Visible = false;
            // 
            // slot2LB
            // 
            this.slot2LB.AutoSize = true;
            this.slot2LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.slot2LB.Location = new System.Drawing.Point(748, 92);
            this.slot2LB.Name = "slot2LB";
            this.slot2LB.Size = new System.Drawing.Size(89, 33);
            this.slot2LB.TabIndex = 3;
            this.slot2LB.Text = "Slot 2";
            this.slot2LB.Visible = false;
            // 
            // slot1LB
            // 
            this.slot1LB.AutoSize = true;
            this.slot1LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.slot1LB.Location = new System.Drawing.Point(748, 59);
            this.slot1LB.Name = "slot1LB";
            this.slot1LB.Size = new System.Drawing.Size(89, 33);
            this.slot1LB.TabIndex = 2;
            this.slot1LB.Text = "Slot 1";
            this.slot1LB.Visible = false;
            // 
            // chatTextLB
            // 
            this.chatTextLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatTextLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chatTextLB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chatTextLB.Location = new System.Drawing.Point(66, 20);
            this.chatTextLB.Name = "chatTextLB";
            this.chatTextLB.ReadOnly = true;
            this.chatTextLB.Size = new System.Drawing.Size(548, 441);
            this.chatTextLB.TabIndex = 0;
            this.chatTextLB.Text = "";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::BlackJack.Properties.Resources.Table;
            this.Controls.Add(this.LobbyPanel);
            this.Controls.Add(this.MultiPlayerPanel);
            this.Name = "Lobby";
            this.Size = new System.Drawing.Size(1264, 661);
            this.MultiPlayerPanel.ResumeLayout(false);
            this.MultiPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joinServerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createServerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LobbyPanel.ResumeLayout(false);
            this.LobbyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MultiPlayerPanel;
        private System.Windows.Forms.Label tableSizeLB;
        private Guna.UI2.WinForms.Guna2TrackBar tableSizeTrackBar;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.TextBox joinServerID;
        private System.Windows.Forms.TextBox hostServerID;
        private System.Windows.Forms.PictureBox joinServerBtn;
        private System.Windows.Forms.PictureBox createServerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LobbyPanel;
        private System.Windows.Forms.RichTextBox chatTextLB;
        private System.Windows.Forms.Label slot4LB;
        private System.Windows.Forms.Label slot3LB;
        private System.Windows.Forms.Label slot2LB;
        private System.Windows.Forms.Label slot1LB;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button sendMessageBtn;
        private Guna.UI2.WinForms.Guna2TextBox messageTextBox;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
