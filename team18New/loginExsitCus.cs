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
    public partial class loginExsitCus : Form
    {
        public loginExsitCus()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            customer mai = new customer();
            this.Hide();
            mai.Show();
        }

        private void rating_Click(object sender, EventArgs e)
        {
            custServiRating m = new custServiRating();
            this.Hide();
            m.Show();
        }

        private void orders_Click(object sender, EventArgs e)
        {
           orders ma = new orders();
            this.Hide();
            ma.Show();
        }
    }
}
