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
    public enum EmployeeType
    {
        [Description("Client service Worker")] CSworker,
        [Description("Client service Manager")] CSmanager,
        [Description("Operation Manager")] Omanager,
        [Description("CEO")] CEO
    }
}
