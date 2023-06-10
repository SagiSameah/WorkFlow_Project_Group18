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
    public enum OrderStatus
    {
        [Description("Confirmed")] confirmed,
        [Description("In Progress")] inProgress,
        [Description("Not confirmed")] notconfirmed,
        [Description("Order cancelled")] ordercancelled
    }
}
