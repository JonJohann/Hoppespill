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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bouncy));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.car1 = new System.Windows.Forms.Panel();
            this.life = new System.Windows.Forms.Label();
            this.rudrevyen = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.pla = new System.Windows.Forms.Label();
            this.user2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bakgrunn = new System.Windows.Forms.Panel();
            this.bakgrunn.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            // life
            // 
            this.life.AutoSize = true;
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.life.ForeColor = System.Drawing.Color.White;
            this.life.Location = new System.Drawing.Point(147, 4);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(32, 33);
            this.life.TabIndex = 1;
            this.life.Text = "0";
            // 
            // rudrevyen
            // 
            this.rudrevyen.AutoSize = true;
            this.rudrevyen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rudrevyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rudrevyen.Location = new System.Drawing.Point(227, 129);
            this.rudrevyen.Name = "rudrevyen";
            this.rudrevyen.Size = new System.Drawing.Size(0, 31);
            this.rudrevyen.TabIndex = 2;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.Color.Transparent;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.Color.White;
            this.points.Location = new System.Drawing.Point(3, 4);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(138, 33);
            this.points.TabIndex = 3;
            this.points.Text = "POINTS:";
            // 
            // pla
            // 
            this.pla.AutoSize = true;
            this.pla.BackColor = System.Drawing.Color.Transparent;
            this.pla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pla.ForeColor = System.Drawing.Color.White;
            this.pla.Location = new System.Drawing.Point(412, 4);
            this.pla.Name = "pla";
            this.pla.Size = new System.Drawing.Size(144, 33);
            this.pla.TabIndex = 4;
            this.pla.Text = "PLAYER:";
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.BackColor = System.Drawing.Color.Transparent;
            this.user2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2.ForeColor = System.Drawing.Color.White;
            this.user2.Location = new System.Drawing.Point(562, 4);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(0, 33);
            this.user2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "HIGHSCORE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 269);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // bakgrunn
            // 
            this.bakgrunn.BackgroundImage = global::Hoppespill.Properties.Resources.output_sHKwcW;
            this.bakgrunn.Controls.Add(this.label1);
            this.bakgrunn.Controls.Add(this.button1);
            this.bakgrunn.Controls.Add(this.user2);
            this.bakgrunn.Controls.Add(this.pla);
            this.bakgrunn.Controls.Add(this.points);
            this.bakgrunn.Controls.Add(this.rudrevyen);
            this.bakgrunn.Controls.Add(this.life);
            this.bakgrunn.Controls.Add(this.car1);
            this.bakgrunn.Location = new System.Drawing.Point(0, 0);
            this.bakgrunn.Name = "bakgrunn";
            this.bakgrunn.Size = new System.Drawing.Size(684, 302);
            this.bakgrunn.TabIndex = 0;
            // 
            // Bouncy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 302);
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
        private PrintPreviewDialog printPreviewDialog1;
        private Panel car1;
        private Label life;
        private Label rudrevyen;
        private Label points;
        private Label pla;
        private Label user2;
        private Button button1;
        public Label label1;
        private Panel bakgrunn;
    }
}

