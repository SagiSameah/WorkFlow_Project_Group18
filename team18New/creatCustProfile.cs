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
    public partial class creatCustProfile : Form
    {
        public creatCustProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            customer b = new customer();
            this.Hide();
            b.Show();
        }

        private void creatCustProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
