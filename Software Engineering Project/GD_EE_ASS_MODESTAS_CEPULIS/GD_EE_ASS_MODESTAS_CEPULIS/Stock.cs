using GD_EE_ASS_MODESTAS_CEPULIS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    class Stock
    {
        private int stockID;
        private string description;
        private decimal cost_price;
        private decimal sale_price;
        private int qty;
        private string stock_date;
        private string status;



        public Stock()
        {
            stockID = 0;
            description = "";
            cost_price = 0;
            sale_price = 0;
            qty = 0;
            stock_date = "";
            status = "";
        }

        //argument constructor
        public Stock(int sID, string Descrip, decimal Costp, decimal Salep, int Qty, string sDATE, string Status)
        {
            stockID = sID;
            description = Descrip;
            cost_price = Costp;
            sale_price = Salep;
            qty = Qty;
            stock_date = sDATE;
            status = Status;
        }


        //Setters
        public void setStockNo(int StockNo)
        {
            this.stockID = StockNo;
        }

        public void setDescription(string Description)
        {
            this.description = Description;
        }

        public void setCostPrice(decimal CostPrice)
        {
            this.cost_price = CostPrice;
        }

        public void setSalePrice(decimal SalePrice)
        {
            this.sale_price = SalePrice;
        }

        public void setQty(int Qty)
        {
            this.qty = Qty;
        }

        public void setStatus(string Status)
        {
            this.status = Status;
        }

        public void setStockDate(string stock_date)
        {
            this.stock_date = stock_date;
        }

        //Getters

        public int getStockNo()
        {
            return stockID;
        }

        public string getDescription()
        {
            return description;
        }

        public decimal getCostPrice()
        {
            return cost_price;
        }

        public decimal getSalePrice()
        {
            return sale_price;
        }

        public int getQty()
        {
            return qty;
        }

        public string getStatus()
        {
            return status;
        }

        public string getStockDate()
        {
            return stock_date;
        }

        //defining a static method to get data
        public static DataSet getAllStock(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT StockNo, Description,Qty FROM Stock ORDER BY StockNo";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void regStock()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Stock VALUES(" + this.stockID.ToString() +
                ",'" + this.description.ToUpper() + "'," + this.cost_price + "," +
                this.sale_price + "," + this.qty + ",'" + this.stock_date + "','" + this.status + "')";

            

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static int getNextStockID()
        {
            //Declare a return variable
            int intNextStockID;

            //Connect to the database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define sql query
            String strSQL = "SELECT MAX(STOCK_ID) FROM Stock";

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
                intNextStockID = 1;
            }
            //takes the highest value and adds 1 to it
            else
            {
                intNextStockID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }

            //Close the database

            myConn.Close();

            //Return the int variable
            return intNextStockID;
        }


        //define a static method to get data
        public static DataSet getStock(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT Stock_ID, Stock_Description, Stock_Quantity FROM Stock ORDER BY Stock_ID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void getStock(int Sno)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM Stock WHERE Stock_ID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setStockNo(dr.GetInt32(0));
                setDescription(dr.GetString(1));
                setCostPrice(dr.GetDecimal(2));
                setCostPrice(dr.GetDecimal(2));
                setSalePrice(dr.GetDecimal(3));
                setQty(dr.GetInt32(4));
                //setStatus(dr.GetValue(5));

            }
            //close DB connection
            myConn.Close();
        }

        public void updStock()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET Stock_Description = '" + this.description.ToUpper() + "', Cost_Price = " + this.cost_price +
                ", Sale_Price = " + this.sale_price + ", Stock_Quantity = " + this.qty + " WHERE Stock_ID = " + this.stockID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public void updStock(int Sno)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE Stock SET Stock_Description = '" + this.description.ToUpper() + "', Cost_Price = " + this.cost_price + ", Sale_Price = " +
                this.sale_price + ", Stock_Quantity = " + this.qty + " WHERE Stock_ID = " + Sno + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


    }




}
