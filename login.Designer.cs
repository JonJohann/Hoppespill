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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(12, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 0;
            this.username.Text = "USERNAME";
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(118, 12);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 20);
            this.play.TabIndex = 1;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPACE to JUMP\r\nUP to SWITCH LANE\r\nDOWN to SWITCH LANE\r\nR to RESTART\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.username);
            this.Name = "login";
            this.Text = "USERNAME ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button play;
        public System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
    }
}