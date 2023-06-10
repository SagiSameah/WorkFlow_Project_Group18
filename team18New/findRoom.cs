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
    public partial class findRoom : Form
    {
        public findRoom()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            orders b = new orders();
            this.Hide();
            b.Show();
        }
    }
}
