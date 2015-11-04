namespace Hoppespill
{
    partial class Form1
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
            this.car = new System.Windows.Forms.Panel();
            this.bakgrunn.SuspendLayout();
            this.SuspendLayout();
            // 
            // bakgrunn
            // 
            this.bakgrunn.BackgroundImage = global::Hoppespill.Properties.Resources.Bakgrunn;
            this.bakgrunn.Controls.Add(this.car);
            this.bakgrunn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bakgrunn.Location = new System.Drawing.Point(0, 0);
            this.bakgrunn.Name = "bakgrunn";
            this.bakgrunn.Size = new System.Drawing.Size(684, 311);
            this.bakgrunn.TabIndex = 0;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.BackgroundImage = global::Hoppespill.Properties.Resources.Bil;
            this.car.Location = new System.Drawing.Point(50, 230);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(90, 30);
            this.car.TabIndex = 0;
            this.car.Click += new System.EventHandler(this.car_Click);
            this.car.Paint += new System.Windows.Forms.PaintEventHandler(this.car_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.bakgrunn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bakgrunn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bakgrunn;
        private System.Windows.Forms.Panel car;
    }
}

