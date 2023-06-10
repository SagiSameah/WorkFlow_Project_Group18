using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace team18New
{

    static class Program
    {

        public static System.Collections.Generic.List<Client> Clients;
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<WorkSpace> workSpaces;
        public static System.Collections.Generic.List<Order> Orders;
        public static System.Collections.Generic.List<Request> Requests;
        public static System.Collections.Generic.List<RateService> Rating;
        //  public static System.Collections.Generic.List<Review> Reviews;
        // public static System.Collections.Generic.List<Shift> Shifts;
        // public static System.Collections.Generic.List<Schedual> Scheduals;


        [STAThread]


        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Client seekClient(string id)
        {
            foreach (Client c in Clients)
            {
                if (c.GetId().Equals(id))
                    return c;
            }
            return null;
        }

        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.GetId().Equals(id))
                    return e;
            }
            return null;
        }

        public static WorkSpace seekWorkSpace(string id)
        {
            foreach (WorkSpace w in workSpaces)
            {
                if (w.GetId().Equals(id))
                    return w;
            }
            return null;
        }

        public static Client seekClient(string id)
        {
            foreach (Client c in Clients)
            {
                if (c.GetId().Equals(id))
                    return c;
            }
            return null;
        }

        public static Employee seekEmployee(string id)
        {
            foreach (Employee e in Employees)
            {
                if (e.GetId().Equals(id))
                    return e;
            }
            return null;
        }

        public static RateService seekRateService(string id)
        {
            foreach (RateService rs in Rating)
            {
                if ()
                    return w;
            }
            return null;
        }

        public static Budget seekBudget(int year, int month)
        {
            foreach (Budget b in Budgets)
            {
                if ((b.get_monthOfBudget() == month) && (b.get_yearOfBudget() == year))
                    return b;
            }
            return null;
        }
        public static Budget seekBudgetYear(int year)
        {
            foreach (Budget b in Budgets)
            {
                if (b.get_yearOfBudget() == year)
                    return b;
            }
            return null;
        }
        public static Participant seekParticipant(string id)
        {
            foreach (Participant p in Participants)
            {
                if (p.getID() == id)
                    return p;
            }
            return null;
        }

        public static bool seekWorkshopID(string id)
        {
            foreach (Workshop w in Workshops)
            {
                if (w.get_Workshop() == id)
                    return true;
            }
            return false;
        }

        public static Workshop seekWorkshop(string id)
        {
            foreach (Workshop w in Workshops)
            {
                if (w.get_Workshop() == id)
                    return w;
            }
            return null;
        }


        public static bool numOfActors(string workshopID)
        {
            Workshop w = seekWorkshop(workshopID);
            int totalActors = 0;
            foreach (ScheduleRequest sr in ScheduleRequests)
            {
                if (sr.get_status().ToString() == "Approved")
                {
                    totalActors = totalActors + 1;
                }
            }
            if (w.get_NumberOfActors() < totalActors)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ScheduleRequest seekScheduleRequest(string actorID, string workshopID, string rDT)
        {
            foreach (ScheduleRequest sr in ScheduleRequests)
            {
                if (sr.get_ActorID() == actorID && sr.get_workshopID() == workshopID && sr.get_requestDT().ToString() == rDT)
                    return sr;
            }
            return null;
        }

        /////////////////////regex
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w!#$%&'+\-/=?\^_`{|}~]+(\.[\w!#$%&'+\-/=?\^_`{|}~]+)*"
                           + "@"
                           + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidID(string ID)
        {
            string pattern = @"^[0-9]{9}$";


            return Regex.IsMatch(ID, pattern);
        }


        public static bool IsValidPhone(string ID)
        {
            string pattern = @"^[0-9]{10}$";


            return Regex.IsMatch(ID, pattern);
        }

        public static bool IsExistIDActor(string ID)
        {
            Actor exist = seekActor(ID);
            if (exist == null)
                return false;
            return true;
        }
        public static bool IsExistIDContact(string ID)
        {
            Contact exist = seekContact(ID);
            if (exist == null)
                return false;
            return true;
        }

        public static bool IsDateINFuture(DateTime date)
        {
            if (date > DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public static bool IsAtLeast18YearsOld(DateTime date)
        {
            if (date > DateTime.Now.Subtract(new TimeSpan(365 * 18, 0, 0, 0)))
            {
                return false;
            }
            return true;
        }

        public static bool ValidDOB(DateTime date)
        {
            if (date > DateTime.Now)
            {
                return false;
            }
            return true;
        }

        ///////for budget regex
        public static bool IsValidYear(string year)
        {
            int y;
            if (int.TryParse(year, out y) && y >= 2023 && y <= 2040)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsValidBudget(string inp)
        {
            int y;
            string pattern = @"^[0-9]*[1-9][0-9]*$";


            return Regex.IsMatch(inp, pattern);
        }

        //if (int.TryParse(year, out y) && y >= 2023 && y <= 2040)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false;
        //}

        public static bool IsValidInteger(string input)
        {
            int number;
            if (int.TryParse(input, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_Contacts();
            init_Actors();
            init_Budgets();
            init_Orders();
            init_Coordinators();
            init_Workshops();
            init_Participants();
            init_ScheduleRequests();
            init_ParticipantsAttendingWorkshops();
            init_ParticipantFeedbacks();
            init_ActorsWorkshop();
            init_ActorsFeedbacks();
        }




        public static void init_Contacts()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand a = new SqlCommand();
            a.CommandText = "EXECUTE dbo.Get_all_contacts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(a);

            Contacts = new List<Contact>();

            while (rdr.Read())
            {
                Contact b = new Contact(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString()), rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(),
                DateTime.Parse((rdr.GetValue(7).ToString())), (Institution)Enum.Parse(typeof(Institution), rdr.GetValue(8).ToString()), false);
                Contacts.Add(b);
            }
        }

        public static void init_Budgets()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand a = new SqlCommand();
            a.CommandText = "EXECUTE dbo.Get_all_Budgets";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(a);

            Budgets = new List<Budget>();

            while (rdr.Read())
            {

                Budget b = new Budget(Convert.ToInt32(rdr.GetValue(0)), Convert.ToInt32(rdr.GetValue(1)), Convert.ToDouble(rdr.GetValue(2)),
                     Convert.ToDouble(rdr.GetValue(3)), Convert.ToDouble(rdr.GetValue(4)), Convert.ToDouble(rdr.GetValue(5)), Convert.ToDouble(rdr.GetValue(6)), Convert.ToDouble(rdr.GetValue(7)),
                     rdr.GetValue(8).ToString(), false);
                Budgets.Add(b);
            }
        }


        public static void init_Orders()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Orders = new List<Order>();


            while (rdr.Read())
            {
                Order o = new Order(rdr.GetValue(0).ToString(), DateTime.Parse((rdr.GetValue(1).ToString())), Convert.ToInt32(rdr.GetValue(2)),
                   Convert.ToDouble(rdr.GetValue(3)), (OrderStatus)Enum.Parse(typeof(OrderStatus), rdr.GetValue(4).ToString()), Convert.ToInt32(rdr.GetValue(5)), Convert.ToInt32(rdr.GetValue(6)), false);
                Orders.Add(o);

            }
        }
        public static void init_ScheduleRequests()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_SchedualRequests";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            ScheduleRequests = new List<ScheduleRequest>();
            while (rdr.Read())
            {
                ScheduleRequest o = new ScheduleRequest(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    DateTime.Parse((rdr.GetValue(2).ToString())),
                  (ScheduleStatus)Enum.Parse(typeof(ScheduleStatus), rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), false);
                ScheduleRequests.Add(o);

            }
        }


        public static void init_Actors()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Actors";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Actors = new List<Actor>();
            while (rdr.Read())
            {
                Gender g = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString());
                FamilyStatus fs = (FamilyStatus)Enum.Parse(typeof(FamilyStatus), rdr.GetValue(9).ToString());
                Actor o = new Actor(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), g,
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    DateTime.Parse((rdr.GetValue(8).ToString())), fs,
                    DateTime.Parse((rdr.GetValue(10).ToString())), false);
                Actors.Add(o);

            }
        }

        public static void init_Coordinators()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Coordinators";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Coordinators = new List<Coordinator>();
            while (rdr.Read())
            {
                Gender g = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString());
                FamilyStatus fs = (FamilyStatus)Enum.Parse(typeof(FamilyStatus), rdr.GetValue(9).ToString());
                Coordinator o = new Coordinator(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                     rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), g,
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    DateTime.Parse((rdr.GetValue(8).ToString())), fs,
                    DateTime.Parse((rdr.GetValue(10).ToString())), false);
                Coordinators.Add(o);

            }
        }



        public static void init_Workshops()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Workshops";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Workshops = new List<Workshop>();
            while (rdr.Read())
            {
                TypeWorkshop t = (TypeWorkshop)Enum.Parse(typeof(TypeWorkshop), rdr.GetValue(3).ToString());
                Language l = (Language)Enum.Parse(typeof(Language), rdr.GetValue(4).ToString());
                ParticipantsAudience pa = (ParticipantsAudience)Enum.Parse(typeof(ParticipantsAudience), rdr.GetValue(5).ToString());
                Institution i = (Institution)Enum.Parse(typeof(Institution), rdr.GetValue(6).ToString());
                WorkshopStatus s = (WorkshopStatus)Enum.Parse(typeof(WorkshopStatus), rdr.GetValue(11).ToString());

                Workshop o = new Workshop(rdr.GetValue(0).ToString(), DateTime.Parse((rdr.GetValue(1).ToString())), Convert.ToInt32(rdr.GetValue(2)), t, l, pa, i,
                    rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), Convert.ToInt32(rdr.GetValue(9)), Convert.ToInt32(rdr.GetValue(10)), s, false);
                Workshops.Add(o);

            }
        }


        public static void init_Participants()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Participants";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Participants = new List<Participant>();
            while (rdr.Read())
            {
                Gender g = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(4).ToString());
                Institution i = (Institution)Enum.Parse(typeof(Institution), rdr.GetValue(9).ToString());
                Participant o = new Participant(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                     rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), g,
                    rdr.GetValue(5).ToString(), rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString(),
                    DateTime.Parse((rdr.GetValue(8).ToString())), i, false);
                Participants.Add(o);

            }
        }



        public static void init_ParticipantFeedbacks()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Get_all_PatricipantFeedbacks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            ParticipantFeedbacks = new List<ParticipantFeedback>();
            while (rdr.Read())
            {
                int rait = Convert.ToInt32(rdr.GetValue(2));

                // Rating r = (Rating)Enum.Parse(typeof(Rating), rait);
                ParticipantFeedback o = new ParticipantFeedback(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString()
                 , rait, rdr.GetValue(3).ToString(), DateTime.Parse((rdr.GetValue(4).ToString())), false);
                ParticipantFeedbacks.Add(o);

            }
        }
        public static void init_ParticipantsAttendingWorkshops()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_Get_WorkshopParticapants";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            ParticipantsAttendingWorkshops = new List<ParticipantsAttendingWorkshop>();
            while (rdr.Read())
            {
                Gender g = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(3).ToString());
                ParticipantsAttendingWorkshop o = new ParticipantsAttendingWorkshop(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), g, false);
                ParticipantsAttendingWorkshops.Add(o);

            }
        }


        public static void init_ActorsWorkshop()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_ListOfWorkshops";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Actorsworkshop = new List<Actorsworkshops>();
            while (rdr.Read())
            {
                WorkshopStatus w = (WorkshopStatus)Enum.Parse(typeof(WorkshopStatus), rdr.GetValue(3).ToString());
                Actorsworkshops aw = new Actorsworkshops(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), DateTime.Parse((rdr.GetValue(2).ToString())), w, false);
                Actorsworkshop.Add(aw);

            }
        }

        public static void init_ActorsFeedbacks()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE Get_all_ActorsFeedbacks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Actorsfeedbacks = new List<Actorfeedback>();
            while (rdr.Read())
            {
                Actorfeedback af = new Actorfeedback(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), false);
                Actorsfeedbacks.Add(af);

            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
