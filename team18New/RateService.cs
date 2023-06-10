using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team18New
{
    public class RateService
    {
        private string employeeId;
        private string requestId;
        private int rate;

        public string GetEmployeeId() {  return employeeId;  }
        public void SetEmployeeId(string value)  { employeeId = value;  }
        public string GetRequestId()  {  return requestId;  }
        public void SetRequestId(string value)  {  requestId = value;  }
        public int GetRate()  {  return rate;  }
        public void SetRate(int value)  { rate = value; }

        public RateService(string employeeId, string requestId, int rate, Boolean isNew)
        {
            SetEmployeeId(employeeId);
            SetRequestId(requestId);
            SetRate(rate);
            if(isNew)
            {
                this.addRating();
                Program.Rating.Add(this);
            }
        }

        private void addRating()
        {
            throw new NotImplementedException();
        }
    }
}
