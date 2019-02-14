using GD_EE_ASS_MODESTAS_CEPULIS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_Modestas_Cepulis
{
    class Customers
    {
        private int Customer_ID;
        private string First_Name;
        private string Last_Name;
        private string Address;
        private string Date_Of_Birth;
        private string Phone_Number;
        private string Email_Address;
        private string Status;
        private string Username;
        private string Password;

        

        public Customers()
        {
            Customer_ID = 0;
            First_Name = "";
            Last_Name = "";
            Address = "";
            Date_Of_Birth = "";
            Phone_Number = "";
            Email_Address = "";
            Status = "";
            Username = "";
            Password = "";

        }

        public Customers(int cID, string fName, string lName, string aDdress, string dateOb, string phonNo, string emailAdd, string status, string uSer, string pAs)
        {
            Customer_ID = cID;
            First_Name = fName;
            Last_Name = lName;
            Address = aDdress;
            Date_Of_Birth = dateOb;
            Phone_Number = phonNo;
            Email_Address = emailAdd;
            Status = status;
            Username = uSer;
            Password = pAs;
        }


        //Setters
        public void setCustomer_ID(int Customer_ID)
        {
            this.Customer_ID = Customer_ID;
        }

        public void setFirst_Name(string First_Name)
        {
            this.First_Name = First_Name;
        }

        public void setLast_Name(string Last_Name)
        {
            this.Last_Name = Last_Name;
        }

        public void setAddress (string Address)
        {
            this.Address = Address;
        }

        public void setDate_Of_Birth (string Date_Of_Birth)
        {
            this.Date_Of_Birth = Date_Of_Birth;
        }

        public void setPhone_Number (string Phone_Number)
        {
            this.Phone_Number = Phone_Number;
        }

        public void setEmail_Address (string Email_Address)
        {
            this.Email_Address = Email_Address;
        }

        public void setStatus (string Status)
        {
            this.Status = Status;
        }

        public void setUsername (string Username)
        {
            this.Username = Username;
        }

        public void setPassword (string Password)
        {
            this.Password = Password;
        }

        //Getters
        public int getCustomer_ID()
        {
            return Customer_ID;
        }

        public string getFirst_Name()
        {
            return First_Name;
        }

        public string getLast_Name()
        {
            return Last_Name;
        }

        public string getAddress()
        {
            return Address;
        }

        public string getDate_Of_Birth()
        {
            return Date_Of_Birth;
        }

        public string getPhone_Number()
        {
            return Phone_Number;
        }

        public string getEmail_Address()
        {
            return Email_Address;
        }

        public string getStatus()
        {
            return Status;
        }

        public string getUser_name()
        {
            return Username;
        }

        public string get_Pass_Word()
        {
            return Password;
        }


        public static void addCustomer ()
        {
            OracleConnection comn = new OracleConnection(DBConnect.oradb);

        }

        public static int getNextCustomerID()
        {
            //Declare a return variable
            int intNextCustomerID;

            //Connect to the database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define sql query
            String strSQL = "SELECT MAX(CUSTOMER_ID) FROM Customers";

            //Create the oracleCommand

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute the oracleCommand -> Not gonna use a data adapter, gonna use a data reader instead
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the first (only_) value returned by query
            //it first stockNo, assign value 1

            dr.Read();

            //if there is null value it shows the first one

            if (dr.IsDBNull(0))
            {
                intNextCustomerID = 1;
            }
            //takes the highest value and adds 1 to it
            else
            {
                intNextCustomerID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //Close the database

            myConn.Close();

            //Return the int variable
            return intNextCustomerID;
        }

        public void regCustomer()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Customers VALUES(" + Customer_ID.ToString() +
                ",'" + this.First_Name + "'," + this.Last_Name + "," +
                this.Address + "," + this.Date_Of_Birth + ",'" + this.Phone_Number + "','" + this.Email_Address + "')";



            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

    }
}
