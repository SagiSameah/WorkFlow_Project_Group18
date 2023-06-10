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
    public enum Country
    {
        [Description("Israel")] Israel,
        [Description("Lebanon")] Lebanon,
        [Description("France")] France,
        [Description("Italy")] Italy,
        [Description("Japan")] Japan,
        [Description("Greece")] Greece
    }
}
