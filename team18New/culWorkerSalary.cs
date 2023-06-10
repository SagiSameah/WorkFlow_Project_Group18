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
    public partial class culWorkerSalary : Form
    {
        public culWorkerSalary()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginManeger b = new loginManeger();
            this.Hide();
            b.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void culWorkerSalary_Load(object sender, EventArgs e)
        {

        }
    }
}
