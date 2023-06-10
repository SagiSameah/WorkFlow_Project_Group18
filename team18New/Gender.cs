using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace team18New
{
    public enum Gender
    {
        [Description("Male")] male,
        [Description("Female")] female,
        [Description("Other")] other
    }
}
