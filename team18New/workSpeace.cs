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
    public partial class workSpeace : Form
    {
        public workSpeace()
        {
            InitializeComponent();
        }


        private void back_Click(object sender, EventArgs e)
        {
            loginManeger b = new loginManeger();
            this.Hide();
            b.Show();
        }

        private void newWorkSpece_Click(object sender, EventArgs e)
        {
            newWorkSpeace n = new newWorkSpeace();
            this.Hide();
            n.Show();
        }

        private void exsitWorkSpeace_Click(object sender, EventArgs e)
        {
            exsitWorkSpece exs = new exsitWorkSpece();
            this.Hide();
            exs.Show();
        }
    }
}
