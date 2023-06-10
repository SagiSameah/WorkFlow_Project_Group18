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
    public partial class custServiRating : Form
    {
        public custServiRating()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginExsitCus mai = new loginExsitCus();
            this.Hide();
            mai.Show();
        }
    }
}
