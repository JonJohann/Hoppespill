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
            this.components = new System.ComponentModel.Container();
            this.bakgrunn = new System.Windows.Forms.Panel();
            this.dirt = new System.Windows.Forms.Panel();
            this.car = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bakgrunn.SuspendLayout();
            this.SuspendLayout();
            // 
            // bakgrunn
            // 
            this.bakgrunn.BackgroundImage = global::Hoppespill.Properties.Resources.Bakgrunn;
            this.bakgrunn.Controls.Add(this.dirt);
            this.bakgrunn.Controls.Add(this.car);
            this.bakgrunn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakgrunn.Location = new System.Drawing.Point(0, 0);
            this.bakgrunn.Name = "bakgrunn";
            this.bakgrunn.Size = new System.Drawing.Size(684, 311);
            this.bakgrunn.TabIndex = 0;
            // 
            // dirt
            // 
            this.dirt.Location = new System.Drawing.Point(514, 230);
            this.dirt.Name = "dirt";
            this.dirt.Size = new System.Drawing.Size(35, 30);
            this.dirt.TabIndex = 1;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.BackgroundImage = global::Hoppespill.Properties.Resources.Bil;
            this.car.Location = new System.Drawing.Point(50, 230);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(90, 30);
            this.car.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 700;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Bouncy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.bakgrunn);
            this.Name = "Bouncy";
            this.Text = "Evasivehicle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.bakgrunn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bakgrunn;
        private System.Windows.Forms.Panel car;
        private Panel dirt;
        private Timer timer;
    }
}

