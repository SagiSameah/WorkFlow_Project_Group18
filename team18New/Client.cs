using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace team18New
{
    public class Client
    {
        private string id;
        private ClientType cType;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime birthDate;
        private Gender gen;
        private Country cntry;
        private string addressZipCode;

        public string GetId() { return id; }
        public void SetId(string value) { id = value; }
        public ClientType GetEmptype() { return cType; }
        public void SetEmptype(ClientType value) { cType = value; }
        public string GetFirstName() { return firstName; }
        public void SetFirstName(string value) { firstName = value; }
        public string GetLastName() { return lastName; }
        public void SetLastName(string value) { lastName = value; }
        public string GetEmail() { return email; }
        public void SetEmail(string value) { email = value; }
        public string GetAddressZipCode() { return addressZipCode; }
        public void SetAddressZipCode(string value) { addressZipCode = value; }
        public string GetPhoneNumber() { return phoneNumber; }
        public void SetPhoneNumber(string value) { phoneNumber = value; }
        public Gender Getgen() { return gen; }
        public void Setgen(Gender value) { gen = value; }

        public Client(string id, ClientType ClientT, string FirstName, string LastName, string Email, string AddressZipCode, string PhoneNumber, DateTime BirthDate, Country Country, Gender gen, bool is_new)
        {
            this.id = id;
            this.cType = ClientT;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.email = Email;
            this.addressZipCode = AddressZipCode;
            this.phoneNumber = PhoneNumber;
            this.birthDate = BirthDate;
            this.cntry = Country;
            this.gen = gen;

            if (is_new)
            {
                this.CreateClient();
                Program.Clients.Add(this);
            }
        }

        public void CreateClient()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXCUTE dbo.SP_add_client @id, @ClientType, @FirstName, @LastName, @Email, @AddressZipCode, @PhoneNumber, @BirthDate, @Country, @Gender";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@ClientType", this.cType.ToString());
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@AddressZipCode", this.addressZipCode);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@Country", this.cntry);
            c.Parameters.AddWithValue("@Gender", this.gen.ToString());

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }

        public void UpdateClient()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXCUTE dbo.SP_update_client @id, @ClientType, @FirstName, @LastName, @Email, @AddressZipCode, @PhoneNumber, @BirthDate, @Country, @Gender";
            c.Parameters.AddWithValue("@id", this.id);
            c.Parameters.AddWithValue("@ClientType", this.cType.ToString());
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@AddressZipCode", this.addressZipCode);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@BirthDate", this.birthDate);
            c.Parameters.AddWithValue("@Country", this.cntry);
            c.Parameters.AddWithValue("@Gender", this.gen.ToString());

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }
    }

}
