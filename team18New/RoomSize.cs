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
    public enum RoomSize
    {
        [Description("For 0ne people")] up2one,
        [Description("Small – up to five people")] up2five,
        [Description("Small – up to ten people")] up2ten,
        [Description("Medium - up to twenty people")] up2twenty,
        [Description("Big- up to hundred peopleBig- up to hundred people")] up2hundred
    }
}
