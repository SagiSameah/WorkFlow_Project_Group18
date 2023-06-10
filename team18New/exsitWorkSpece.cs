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
    public partial class exsitWorkSpece : Form
    {
        public exsitWorkSpece()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            workSpeace b = new workSpeace();
            this.Hide();
            b.Show();
        }
    }
}
