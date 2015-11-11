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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string user = "";

        private void username_TextChanged(object sender, EventArgs e)
        {
            this.username.ForeColor = System.Drawing.Color.Black;
        }

        private void play_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            new Bouncy().Show();




        }
    }
}
