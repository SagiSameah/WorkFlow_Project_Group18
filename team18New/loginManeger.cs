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
    public partial class loginManeger : Form
    {
        public loginManeger()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            loginExsitWorker b = new loginExsitWorker();
            this.Hide();
            b.Show();
        }

        private void report_Click(object sender, EventArgs e)
        {
            report mai = new report();
            this.Hide();
            mai.Show();
        }

        private void workSpeace_Click(object sender, EventArgs e)
        {
            workSpeace b = new workSpeace();
            this.Hide();
            b.Show();
        }

        private void salery_Click(object sender, EventArgs e)
        {
            culWorkerSalary b = new culWorkerSalary();
            this.Hide();
            b.Show();
        }
    }
}
