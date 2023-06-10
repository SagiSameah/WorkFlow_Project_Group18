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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginManeger mai = new loginManeger();
            this.Hide();
            mai.Show();
        }
    }
}
