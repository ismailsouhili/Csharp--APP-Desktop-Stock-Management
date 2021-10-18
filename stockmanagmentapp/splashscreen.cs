using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockmanagmentapp
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bunifuProgressBar1.Value += 1;
            if(bunifuProgressBar1.Value==100)
            {
                timer1.Enabled = false;
                login login = new login();
                login.Show();
                this.Hide();
            }
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
