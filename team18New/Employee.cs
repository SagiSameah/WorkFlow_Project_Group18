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
    public class Employee
    {
        private string id;
        private EmployeeType emptype;
        private string firstName;
        private string lastName;
        private string email;
        private string addressZipCode;
        private string phoneNumber;
        private int daysOff;
        private string bankAccount;
        private double totalMonthlyWorkingHours;
        private Gender gen;
   
        public string GetId() { return id;  }
        public void SetId(string value) { id = value;  }
        public EmployeeType GetEmptype() {  return emptype;  }
        public void SetEmptype(EmployeeType value) { emptype = value;  }
        public string GetFirstName() { return firstName;  }
        public void SetFirstName(string value) { firstName = value;  }
        public string GetLastName() { return lastName; }
        public void SetLastName(string value) { lastName = value; }
        public string GetEmail()  { return email; }
        public void SetEmail(string value)  {  email = value;   }
        public string GetAddressZipCode()  {  return addressZipCode;  }
        public void SetAddressZipCode(string value)  {  addressZipCode = value;   }
        public string GetPhoneNumber()  {  return phoneNumber;   }
        public void SetPhoneNumber(string value)  {  phoneNumber = value;  }
        public int GetDaysOff()  { return daysOff;  }
        public void SetDaysOff(int value)  { daysOff = value;  }
        public string GetBankAccount()  {  return bankAccount;  }
        public void SetBankAccount(string value)  { bankAccount = value; }
        public double GetTotalMonthlyWorkingHours() { return totalMonthlyWorkingHours;  }
        public void SetTotalMonthlyWorkingHours(double value)  { totalMonthlyWorkingHours = value;  }
        public Gender Getgen()  { return gen; }
        public void Setgen(Gender value)  { gen = value; }

        public Employee(string id, EmployeeType Emptype, string FirstName, string LastName, string Email, string AddressZipCode, string PhoneNumber, int DaysOff, string BankAccount, double TotalMonthlyWorkingHours, Gender gen, bool is_new)
        {
            this.SetId(id);
            this.SetEmptype(Emptype);
            this.SetFirstName(FirstName);
            this.SetLastName(LastName);
            this.SetEmail(Email);
            this.SetAddressZipCode(AddressZipCode);
            this.SetPhoneNumber(PhoneNumber);
            this.SetDaysOff(DaysOff);
            this.SetBankAccount(BankAccount);
            this.Setgen(gen);

            if (is_new)
            {
                this.CreateEmployee();
                Program.Employees.Add(this);
            }
        }

        public void CreateEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXCUTE dbo.SP_add_employee @id, @EmployeeType, @FirstName, @LastName, @Email, @AddressZipCode, @PhoneNumber, @DaysOff, @BankAccount, @TotalMonthlyWorkingHours, @Gender";
            c.Parameters.AddWithValue("@id", this.GetId());
            c.Parameters.AddWithValue("@EmployeeType", this.GetEmptype().ToString());
            c.Parameters.AddWithValue("@FirstName", this.GetFirstName());
            c.Parameters.AddWithValue("@LastName", this.GetLastName());
            c.Parameters.AddWithValue("@Email", this.GetEmail());
            c.Parameters.AddWithValue("@AddressZipCode", this.GetAddressZipCode());
            c.Parameters.AddWithValue("@PhoneNumber", this.GetPhoneNumber());
            c.Parameters.AddWithValue("@DaysOff", this.GetDaysOff());
            c.Parameters.AddWithValue("@BankAccount", this.GetBankAccount());
            c.Parameters.AddWithValue("@TotalMonthlyWorkingHours", this.GetTotalMonthlyWorkingHours());
            c.Parameters.AddWithValue("@Gender", this.Getgen().ToString());

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }

        public void UpdateEmployee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXCUTE dbo.SP_update_employee @id, @EmployeeType, @FirstName, @LastName, @Email, @AddressZipCode, @PhoneNumber, @DaysOff, @BankAccount, @TotalMonthlyWorkingHours, @Gender";
            c.Parameters.AddWithValue("@id", this.GetId());
            c.Parameters.AddWithValue("@EmployeeType", this.GetEmptype().ToString());
            c.Parameters.AddWithValue("@FirstName", this.GetFirstName());
            c.Parameters.AddWithValue("@LastName", this.GetLastName());
            c.Parameters.AddWithValue("@Email", this.GetEmail());
            c.Parameters.AddWithValue("@AddressZipCode", this.GetAddressZipCode());
            c.Parameters.AddWithValue("@PhoneNumber", this.GetPhoneNumber());
            c.Parameters.AddWithValue("@DaysOff", this.GetDaysOff());
            c.Parameters.AddWithValue("@BankAccount", this.GetBankAccount());
            c.Parameters.AddWithValue("@TotalMonthlyWorkingHours", this.GetTotalMonthlyWorkingHours());
            c.Parameters.AddWithValue("@Gender", this.Getgen().ToString());

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }

        public void AddWorkingHours(double hours)
        {
            // Code to add working hours for the employee
        }

        public void UpdateWorkingHours(double hours)
        {
            // Code to update the working hours for the employee
        }
        public float calculateRateAverage(list<Review> reviews)
        {
            return 0;
        }
    }

}
