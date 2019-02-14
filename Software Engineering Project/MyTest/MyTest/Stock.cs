using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Stock
    {

        // instance variables
        private int stock_No;
        private string description;
        private decimal cost_price;
        private decimal sale_price;
        private int qty;
        private string status;

        //no argument constructors

        public Stock()
        {
            stock_No = 0;
            description = "";
            cost_price = 0;
            sale_price = 0;
            qty = 0;
            status = "";
        }

        public Stock(int sNO, string dESCRIPTION, decimal costP, decimal saleP, int qUANTITY, string sTAT)
        {
            stock_No = sNO;
            description = dESCRIPTION;
            cost_price = costP;
            sale_price = saleP;
            qty = qUANTITY;
            status = sTAT;

        }

        public static DataSet getAllStock(DataSet DS)
        {
            //Create an oracleConnection object using the connection string defined
            OracleConnection comn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Stock";

            //Create an oracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, comn);

            //Create an oracleAdapter to hold the result of the executed OracleConnection
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "stk");

            //close the DB connection
            comn.Close();

            //return the dataset with the required data to the windows form which
            return DS;
        }

        public static int getNextStockNumber()
        {
            //Declare a return variable
            int intNextStockNo;

            //Connect to the database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define sql query
            String strSQL = "SELECT MAX(stockNo) FROM Stock";

            //Create the oracleCommand

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute the oracleCommand -> Not gonna use a data adapter, gonna use a data reader instead
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the first (only_) value returned by query
            //it first stockNo, assign value 1

            dr.Read();

            //if there is null value it shows the first one

            if(dr.IsDBNull(0))
            {
                intNextStockNo = 1;
            }
            //takes the highest value and adds 1 to it
            else
            {
                intNextStockNo = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //Close the database

            myConn.Close();

            //Return the int variable
            return intNextStockNo;
        }

        public void regStock()
        {
            //1. Create stock object
            //2. Instantiate object variables.
            //3. Invoke the addStock method.

            //connect to the database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define the SQL query
            String strSQL = "INSERT INTO Stock VALUES(" + this.stock_No.ToString() + ",'"+ this.description.ToUpper()+ "'," +
                                                      this.cost_price + "," + this.sale_price + "," + this.qty + ",'" + this.status + "')" ;

            //Create the oracleCommand

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute the oracleCommand
            cmd.ExecuteNonQuery();

            //close database
            myConn.Close();
        }

    }
}
