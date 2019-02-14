using GD_EE_ASS_MODESTAS_CEPULIS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    class Orders
    {
        private int Order_ID;
        private string Order_Type;
        private int Value;
        private int Amount;
        private string Delivery_Address;
        private string Delivery_Date;
        private string Status;
        private int Customer_ID;

        //Setters
        public void setOrder_ID(int Order_ID)
        {
            this.Order_ID = Order_ID;
        }

        public void setOrder_Type(string Order_Type)
        {
            this.Order_Type = Order_Type;
        }

        public void setValue(int Value)
        {
            this.Value = Value;
        }

        public void setAmount(int Amount)
        {
            this.Amount = Amount;
        }

        public void setDelivery_Address(string Delivery_Address)
        {
            this.Delivery_Address = Delivery_Address;
        }

        public void setDelivery_Date(string Delivery_Date)
        {
            this.Delivery_Date = Delivery_Date;
        }

        public void setStatus(string Status)
        {
            this.Status = Status;
        }
        public void setCustomer_ID(int Customer_ID)
        {
            this.Customer_ID = Customer_ID;
        }

        //Getters
        public int getOrder_ID()
        {
            return Order_ID;
        }

        public string getOrder_Type()
        {
            return Order_Type;
        }

        public int getValue()
        {
            return Value;
        }

        public int getAmount()
        {
            return Amount;
        }

        public string getDeliver_Address()
        {
            return Delivery_Address;
        }

        public string getDelivery_Date()
        {
            return Delivery_Date;
        }

        public string getStatus()
        {
            return Status;
        }

        public int getCustomer_ID()
        {
            return Customer_ID;
        }



        public static void addOrder()
        {
            OracleConnection comn = new OracleConnection(DBConnect.oradb);

        }

        public static int getNextOrderID()
        {
            //Declare a return variable
            int intNextOrderID;

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
                intNextOrderID = 1;
            }
            //takes the highest value and adds 1 to it
            else
            {
                intNextOrderID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //Close the database

            myConn.Close();

            //Return the int variable
            return intNextOrderID;
        }

    }
}
