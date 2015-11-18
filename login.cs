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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           
        }

        public string user = "";

        private void username_TextChanged(object sender, EventArgs e)
        {
            this.username.ForeColor = System.Drawing.Color.Black;
        }

        public void play_Click(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                MessageBox.Show("YOU NEED A USERNAME");

            }
            else
            {
                this.Close();
                user = username.Text;
            }

        }

        
    }
}
