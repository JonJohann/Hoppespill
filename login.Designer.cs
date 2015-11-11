namespace Hoppespill
{
    partial class login
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
            this.username = new System.Windows.Forms.TextBox();
            this.play = new System.Windows.Forms.Button();
            this.hiscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(23, 43);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 0;
            this.username.Text = "USERNAME";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(130, 39);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 1;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // hiscore
            // 
            this.hiscore.Location = new System.Drawing.Point(23, 69);
            this.hiscore.Name = "hiscore";
            this.hiscore.Size = new System.Drawing.Size(182, 23);
            this.hiscore.TabIndex = 2;
            this.hiscore.Text = "HIGH SCORE";
            this.hiscore.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hiscore);
            this.Controls.Add(this.play);
            this.Controls.Add(this.username);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button hiscore;
        public System.Windows.Forms.TextBox username;
    }
}