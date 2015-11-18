using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hoppespill
{
    public partial class Bouncy : Form
    {
        private Timer beveg = new Timer(); //made timer for movement of player
        public Timer obstMove = new Timer(); //made timer for movement of obstacle
        public Timer obstSpawn = new Timer(); //made timer for spawning of obstacles
        private List<Panel> obstacles = new List<Panel>(); //a list for all the obstacles
        public Bouncy()
        
        {
            InitializeComponent();
            login login = new login();
            login.ShowDialog();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            beveg.Interval = 10;
            obstSpawn.Interval = new Random().Next(1500,3000);
            obstSpawn.Tick += ObstSpawn_Tick; //adds the tick event for the timer
            obstSpawn.Start();
            obstMove.Interval = 10;
            obstMove.Tick += ObstMove_Tick; //adds the tick event for the timer
            obstMove.Start();
            beveg.Tick += beveg_event; //adds the tick event for the timer
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            user2.Text = login.user;
            button1.Enabled = false;
            
        }
        //variables
        int mvDY = 270; //y-value of vehicle in left lane (move down y)  
        int mvUY = 230; //y-value of vehicle in right lane (move up y)
        int ps = 230; //y-value of vehicle (used for jumping) 
        bool jump = false;
        int jumphgt;
        bool laneU = true; //vehicle is in upper lane = true
        int t = 0; //used for point-adding
        string fileName = @".\brukere.txt"; //@"C:\Temp\brukere.txt";
        





        public void ObstSpawn_Tick(object sender, EventArgs e) //Spawning obstacles
        {
          
            obstSpawn.Interval = new Random().Next(800, 1500);
            int uod = new Random().Next(0, 100);
            
            if (uod > 60)
            {
                addHind(mvUY);
            }
            else if (uod <40 )
            {
                addHind(mvDY);
            }
            else
            {
                addHind(mvDY);
                addHind(mvUY);
            }
            



        }

        public void addHind(int lanePosition) //adding obstacles
        {
            Panel hind = new Panel();
            hind.Location = new System.Drawing.Point(this.Width-1, lanePosition);
            hind.Name = "hind";
            hind.Size = new System.Drawing.Size(35, 30);
            hind.TabIndex = 1;
            obstacles.Add(hind);
            this.Controls.Add(hind);
            hind.BringToFront();
            car1.BringToFront();


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
                    life.Text = Convert.ToString(t++); //adds point
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
                car1.Top -= 8;
            }
            else if(car1.Top < (laneU ? mvUY : mvDY))
            {
                car1.Top += 8;
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

                        if (car1.Top == mvDY || car1.Top == mvUY)
                        {
                            jump = true;
                            jumphgt = car1.Top - 160;
                            beveg.Start();
                        }
                        

                        break;
                    }
                case Keys.Down: //moving the car to the bottom lane
                    {
                        if (car1.Location.Y == mvUY)
                        {
                            car1.Top = mvDY;
                            ps = mvDY;
                            laneU = false;
                        }

                        break;
                    }
                case Keys.Up: //moving the car to the upper lane
                    {
                        if (car1.Location.Y == mvDY)
                        {
                            car1.Top = mvUY;
                            ps = mvUY;
                            laneU = true;
                        }
                        break;
                    }
                case Keys.R:
                    {       
                        this.obstMove.Start();
                        this.obstSpawn.Start();
                        rudrevyen.Text = "";
                        t = 0;
                        highscoreAdd();
                        obstacles.Clear();
                        for(int i = 0; i < this.Controls.Count; i++)
                        {
                            if(this.Controls[i] is Panel && this.Controls[i].Name != "bakgrunn" && this.Controls[i].Name != "car1" )
                            {
                                this.Controls.Remove(this.Controls[i]);
                            }
                            {
                                
                            }
                        }
                        label1.Visible = false;
                        button1.Enabled = false;
                        button1.Visible = false;
                        break;
                        
                        
                    }
            }
        }
        private void chkCol() //checking if the game is lost
        {
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (collides(car1, obstacles[i]))
                {
                    this.obstMove.Stop();
                    this.obstSpawn.Stop();
                    rudrevyen.Text = "GAME OVER";
                    this.Controls.Remove(obstacles[i]);
                    this.obstacles.Remove(obstacles[i]);
                    button1.Visible = true;
                    button1.Enabled = true;
                    
                    break;

                }
            }


        }
        private bool collides(Panel p1, Panel p2)
        {
            if (!laneU && p2.Location.Y == mvUY)
            { return false; }
            else if (!laneU && p2.Location.Y != mvUY && p1.Right >= p2.Left && p1.Left <= p2.Right && p1.Bottom >= p2.Top && p1.Top <= p2.Bottom)
            {
                return true;
            }
            else if (laneU && p2.Location.Y == mvUY && p1.Right >= p2.Left && p1.Left <= p2.Right && p1.Bottom >= p2.Top && p1.Top <= p2.Bottom)
            {
                return true;
            }

            else

            {
                return false;
            }
        }
        public void highscoreAdd()
        {
            
            if(!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            FileInfo fi = new FileInfo(fileName);
            StreamWriter writer = fi.AppendText();
            writer.WriteLine(user2.Text + ":" + life.Text);
            writer.Close();
            writer.Dispose();

            


        }
        

        public void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                label1.Text = "";
                StreamReader reader = new StreamReader(fileName);
                string l;
                while((l = reader.ReadLine()) != null)
                {
                    label1.Text += l + Environment.NewLine;
                }
                reader.Close();
                reader.Dispose();
                label1.Visible = true;
                
                

            }



        }
    }
}
