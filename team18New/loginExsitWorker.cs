using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team18New
{
    public partial class loginExsitWorker : Form
    {
        public loginExsitWorker()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            worker b = new worker();
            this.Hide();
            b.Show();
        }

        private void loginManger_Click(object sender, EventArgs e)
        {
            loginManeger l = new loginManeger();
            this.Hide();
            l.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
