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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer mai = new customer ();
            this.Hide();
            mai.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            worker ma = new worker();
            this.Hide();
            ma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
