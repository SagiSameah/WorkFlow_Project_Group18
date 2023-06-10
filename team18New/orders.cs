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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginExsitCus b = new loginExsitCus();
            this.Hide();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findRoom b = new findRoom();
            this.Hide();
            b.Show();
        }
    }
}
