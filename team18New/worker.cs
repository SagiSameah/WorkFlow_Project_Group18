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
    public partial class worker : Form
    {
        public worker()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 mai = new Form1();
            this.Hide();
            mai.Show();
        }

        private void exsitWorker_Click(object sender, EventArgs e)
        {
            loginExsitWorker l = new loginExsitWorker();
            this.Hide();
            l.Show();
        }

        private void newWorker_Click(object sender, EventArgs e)
        {
            creatWorkerProfile m = new creatWorkerProfile();
            this.Hide();
            m.Show();
        }
    }
}
