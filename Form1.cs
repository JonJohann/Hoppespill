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
    public partial class Bouncy : Form
    {
        private Timer beveg = new Timer(); //made timer for movement of player
        private Timer obstMove = new Timer(); //made timer for movement of obstacle
        private Timer obstSpawn = new Timer(); //made timer for spawning of obstacles
        private List<Panel> obstacles = new List<Panel>(); //a list for all the obstacles
        public Bouncy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            beveg.Interval = 10;
            obstSpawn.Interval = 2000;
            obstSpawn.Tick += ObstSpawn_Tick; //adds the tick event for the timer
            obstSpawn.Start();
            obstMove.Interval = 10;
            obstMove.Tick += ObstMove_Tick; //adds the tick event for the timer
            obstMove.Start();
            beveg.Tick += beveg_event; //adds the tick event for the timer
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }
        

        //variables
        int mvDY = 270; //y-value of vehicle in left lane (move down y)  
        int mvUY = 230; //y-value of vehicle in right lane (move up y)
        int ps = 230; //y-value of vehicle (used for jumping) 
        bool jump = false;
        int jumphgt;
        bool laneU = true; //vehicle is in upper lane = true

        private void ObstSpawn_Tick(object sender, EventArgs e) //Spawning obstacles
        {
            addHind();
        }

        private void ObstMove_Tick(object sender, EventArgs e) //Moving obstacles
        {
            for (int i = 0; i < obstacles.Count; i++)
            {
                Panel o = obstacles[i];
                if(o.Right > 0 && o.Left < this.Width)
                {
                    o.Left -= 5;
                }
                else
                {
                    obstacles.Remove(o);
                }
            }
            chkCol();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
   
        

        private void beveg_event(object sender, EventArgs e) //moving the player
        {
            if(car1.Top > jumphgt && jump)
            {
                car1.Top -= 5;
            }
            else if(car1.Top < (laneU ? mvUY : mvDY))
            {
                car1.Top += 5;
                jump = false;
            }
            else
            {
                beveg.Stop();
            }
            
        }

        private void Bouncy_KeyDown(object sender, KeyEventArgs e) //vehicle jumping and lane-shifting
        {
            switch (e.KeyData)
            {
                case Keys.Space: //car jumps
                    {

                        jump = true;
                        jumphgt = car1.Top - 60;
                        beveg.Start();

                        break;
                    }
                case Keys.Down: //moving the car to the bottom lane
                    {
                        car1.Top = mvDY;
                        ps = mvDY; 
                        laneU = false;

                        break;
                    }
                case Keys.Up: //moving the car to the upper lane
                    {
                        car1.Top = mvUY;
                        ps = mvUY;
                        laneU = true;
                        break;
                    }
            }
        } 

        private void addHind()
        {
            Panel hind = new Panel();
            hind.Location = new System.Drawing.Point(514, 230);
            hind.Name = "hind";
            hind.Size = new System.Drawing.Size(35, 30);
            hind.TabIndex = 1;
            obstacles.Add(hind);
            this.Controls.Add(hind);
            hind.BringToFront();
            

        }

        private void chkCol()
        {
            foreach (Panel p in obstacles)
            {
                if (car1.Bounds.IntersectsWith(p.Bounds))
                {
                    label1.Text = "OV";
                }
            }


        }

        
    }
}
