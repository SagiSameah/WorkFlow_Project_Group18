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
    public enum WorkSpaceType
    {
        [Description("Meeting Room")] meetingroom,
        [Description("Presentation Room")] presentationroom,
        [Description("Assembly Hole")] assemblyhole,
        [Description("Working Room")] workingroom,
        [Description("Shared Space")] sharedspace
    }
}
