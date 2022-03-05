namespace BlackJack.Pages
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.adminBtn = new System.Windows.Forms.PictureBox();
            this.multiPlayerBtn = new System.Windows.Forms.PictureBox();
            this.singlePlayerBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiPlayerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlePlayerBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.Image = global::BlackJack.Properties.Resources.adminBtn;
            this.adminBtn.Location = new System.Drawing.Point(498, 292);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(282, 99);
            this.adminBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.adminBtn.TabIndex = 5;
            this.adminBtn.TabStop = false;
            this.adminBtn.Visible = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // multiPlayerBtn
            // 
            this.multiPlayerBtn.Image = global::BlackJack.Properties.Resources.multiPlayerBtnIMG;
            this.multiPlayerBtn.Location = new System.Drawing.Point(498, 62);
            this.multiPlayerBtn.Name = "multiPlayerBtn";
            this.multiPlayerBtn.Size = new System.Drawing.Size(282, 99);
            this.multiPlayerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.multiPlayerBtn.TabIndex = 4;
            this.multiPlayerBtn.TabStop = false;
            this.multiPlayerBtn.Click += new System.EventHandler(this.multiPlayerBtn_Click);
            // 
            // singlePlayerBtn
            // 
            this.singlePlayerBtn.Image = global::BlackJack.Properties.Resources.singlePlayerBtnIMG;
            this.singlePlayerBtn.Location = new System.Drawing.Point(498, 177);
            this.singlePlayerBtn.Name = "singlePlayerBtn";
            this.singlePlayerBtn.Size = new System.Drawing.Size(282, 99);
            this.singlePlayerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.singlePlayerBtn.TabIndex = 3;
            this.singlePlayerBtn.TabStop = false;
            this.singlePlayerBtn.Click += new System.EventHandler(this.singlePlayerBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.multiPlayerBtn);
            this.Controls.Add(this.singlePlayerBtn);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1264, 661);
            ((System.ComponentModel.ISupportInitialize)(this.adminBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiPlayerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlePlayerBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox adminBtn;
        private System.Windows.Forms.PictureBox multiPlayerBtn;
        private System.Windows.Forms.PictureBox singlePlayerBtn;
    }
}
