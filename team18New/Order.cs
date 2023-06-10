using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team18New
{
    public class Order
    {
        private string Id { get; set; }
        private DateTime BookingDate { get; set; }
        private DateTime StartHour { get; set; }
        private DateTime EndHour { get; set; }
        private string OrderStatus { get; set; }
        private string WorkspaceId { get; set; } // NEED TO CHECK IF NOT NULL CONSTRAIN IS EXIST

        // Additional properties and methods
    }
}
