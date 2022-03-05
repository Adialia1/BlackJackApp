namespace BlackJack.Pages
{
    partial class Admin
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
            this.toLoginBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toLoginBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // toLoginBtn
            // 
            this.toLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toLoginBtn.Image = global::BlackJack.Properties.Resources.toLoginBtn;
            this.toLoginBtn.Location = new System.Drawing.Point(1192, 0);
            this.toLoginBtn.Name = "toLoginBtn";
            this.toLoginBtn.Size = new System.Drawing.Size(72, 70);
            this.toLoginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toLoginBtn.TabIndex = 61;
            this.toLoginBtn.TabStop = false;
            this.toLoginBtn.Click += new System.EventHandler(this.toLoginBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::BlackJack.Properties.Resources.Table;
            this.Controls.Add(this.toLoginBtn);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(1264, 661);
            ((System.ComponentModel.ISupportInitialize)(this.toLoginBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toLoginBtn;
    }
}
