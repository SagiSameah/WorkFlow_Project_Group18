using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace team18New
{
    public class WorkSpace
    {
        private string WorkspaceId;
        private WorkSpaceType WSType;
        private string FullName;
        private RoomSize Size;
        private int MaxNumOfPeople;
        private float MinPriceForHour;
        private DateTime NearestAvailableDate;
        private string AddressZipCode;
        private Country cntry;

        public string GetId() { return WorkspaceId; }
        public void SetId(string value) { WorkspaceId = value; }
        public WorkSpaceType GetWStype() { return WSType; }
        public void SetWStype(WorkSpaceType value) { WSType = value; }
        public string GetFullName() { return FullName; }
        public void SetFullName(string value) { FullName = value; }
        public RoomSize Getsize() { return Size; }
        public void Setsize(RoomSize value) { Size = value; }
        public int GetMaxNumOfPeople() { return MaxNumOfPeople; }
        public void SetMaxNumOfPeople(int value) { MaxNumOfPeople = value; }
        public string GetAddressZipCode() { return AddressZipCode; }
        public void SetAddressZipCode(string value) { AddressZipCode = value; }
        public float GetMinPriceForHour() { return MinPriceForHour; }
        public void SetMinPriceForHour(float value) { MinPriceForHour = value; }
        public Country Getgen() { return cntry; }
        public void Setgen(Country value) { cntry = value; }
        public DateTime GetNearestAvailableDate() { return NearestAvailableDate; }
        public void SetNearestAvailableDate(DateTime value) { NearestAvailableDate = value; }

        public WorkSpace(string id, WorkSpaceType Worktype, string FullName, RoomSize size, int MaxNumOfPeople, float MinPriceForHour, DateTime NearestAvailableDate, string AddressZipCode, Country cntry, bool is_new)
        {
            this.WorkspaceId = id;
            this.WSType = Worktype;
            this.FullName = FullName;
            this.Size = size;
            this.MaxNumOfPeople = MaxNumOfPeople;
            this.MinPriceForHour = MinPriceForHour;
            this.NearestAvailableDate = NearestAvailableDate;
            this.cntry = cntry;
            this.AddressZipCode = AddressZipCode;

            if (is_new)
            {
                this.CreateWorkSpace();
                Program.workSpaces.Add(this);
            }
        }

        public void CreateWorkSpace()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXCUTE dbo.SP_add_workspace @id, @WorkspaceType, @FullName, @RoomSize, @MaxNumOfPeople, @MinPriceForHour, @NearestAvailableDate, @Country, @AddressZipCode";
            c.Parameters.AddWithValue("@id", this.WorkspaceId);
            c.Parameters.AddWithValue("@WorkspaceType", this.WSType.ToString());
            c.Parameters.AddWithValue("@FullName", this.FullName);
            c.Parameters.AddWithValue("@RoomSize", this.Size);
            c.Parameters.AddWithValue("@MaxNumOfPeople", this.MaxNumOfPeople);
            c.Parameters.AddWithValue("@MinPriceForHour", this.MinPriceForHour);
            c.Parameters.AddWithValue("@NearestAvailableDate", this.NearestAvailableDate);
            c.Parameters.AddWithValue("@Country", this.cntry);
            c.Parameters.AddWithValue("@AddressZipCode", this.AddressZipCode);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }

        public void updateWorkSpace()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXCUTE dbo.SP_update_workspace @id, @WorkspaceType, @FullName, @RoomSize, @MaxNumOfPeople, @MinPriceForHour, @NearestAvailableDate, @Country, @AddressZipCode";
            c.Parameters.AddWithValue("@id", this.WorkspaceId);
            c.Parameters.AddWithValue("@WorkspaceType", this.WSType.ToString());
            c.Parameters.AddWithValue("@FullName", this.FullName);
            c.Parameters.AddWithValue("@RoomSize", this.Size);
            c.Parameters.AddWithValue("@MaxNumOfPeople", this.MaxNumOfPeople);
            c.Parameters.AddWithValue("@MinPriceForHour", this.MinPriceForHour);
            c.Parameters.AddWithValue("@NearestAvailableDate", this.NearestAvailableDate);
            c.Parameters.AddWithValue("@Country", this.cntry);
            c.Parameters.AddWithValue("@AddressZipCode", this.AddressZipCode);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }
    }

}
