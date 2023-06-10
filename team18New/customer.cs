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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mai = new Form1();
            this.Hide();
            mai.Show();
        }

        private void newCus_Click(object sender, EventArgs e)
        {
            creatCustProfile mai = new creatCustProfile();
            this.Hide();
            mai.Show();
        }

        private void existCust_Click(object sender, EventArgs e)
        {
            loginExsitCus ma = new loginExsitCus();
            this.Hide();
            ma.Show();
        }
    }
}
