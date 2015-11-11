using System.Windows.Forms;

namespace Hoppespill
{
    partial class Bouncy
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
            this.bakgrunn = new System.Windows.Forms.Panel();
            this.car1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bakgrunn.SuspendLayout();
            this.SuspendLayout();
            // 
            // bakgrunn
            // 
            this.bakgrunn.BackgroundImage = global::Hoppespill.Properties.Resources.Bakgrunn;
            this.bakgrunn.Controls.Add(this.label1);
            this.bakgrunn.Controls.Add(this.car1);
            this.bakgrunn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakgrunn.Location = new System.Drawing.Point(0, 0);
            this.bakgrunn.Name = "bakgrunn";
            this.bakgrunn.Size = new System.Drawing.Size(684, 311);
            this.bakgrunn.TabIndex = 0;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.BackgroundImage = global::Hoppespill.Properties.Resources.Bil;
            this.car1.Location = new System.Drawing.Point(50, 230);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(90, 30);
            this.car1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Bouncy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.bakgrunn);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Bouncy";
            this.Text = "Evasivehicle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bouncy_KeyDown);
            this.bakgrunn.ResumeLayout(false);
            this.bakgrunn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bakgrunn;
        private System.Windows.Forms.Panel car1;
        private Label label1;
    }
}

