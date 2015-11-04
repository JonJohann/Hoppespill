using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoppespill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        int sl = 30; //sleep-variabel     
        int mvDY = 270; //y-value of vehicle in left lane (move down y)  
        int mvUY = 230; //y-value of vehicle in right lane (move up y)
        int ps = 230; //y-value of vehicle (used for jumping) 
        bool laneU = true; //vehicle is in upper lane = true

        private void Form1_KeyDown(object sender, KeyEventArgs e) //vehicle jumping and lane-shifting
        {
            switch (e.KeyData)
            {
                case Keys.Space: //car jumps
                    {
                        for (int i = ps; i >= ps-90; i -= 15) //jumping up
                        {
                            this.car.Location = new System.Drawing.Point(50, i);
                            System.Threading.Thread.Sleep(sl);
                        }

                        for (int i = ps-90; i <= ps; i += 15) //gravitational pull
                        {
                            this.car.Location = new System.Drawing.Point(50, i);
                            System.Threading.Thread.Sleep(sl);
                        }

                        break;
                    }
                case Keys.Down: //moving the car to the bottom lane
                    {
                        this.car.Location = new System.Drawing.Point(50, mvDY);
                        ps = mvDY; 
                        laneU = false;

                        break;
                    }
                case Keys.Up: //moving the car to the upper lane
                    {
                        this.car.Location = new System.Drawing.Point(50, mvUY);
                        ps = mvUY;
                        laneU = true;
                        break;
                    }
            }
        }

        private void box_Tick(object sender, EventArgs e)
        {
            for (int i = 700; i >= -50; i -= 15) //jumping up
            {
                this.dirt.Location = new System.Drawing.Point(i, 230);
                
            }
        }
    }
}
