using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_Shipping
{
    class DataLayer
    {

        public static string Server=".";
        public static string DataBase="DB";
        public static string UserID;
        public static string Password;
        public static OleDbConnection myConnection;

        public DataLayer()
        {
            //
            // TODO: Add constructor logic here
            //
           
            CreateConnection();
            CloseConnection();
        }

        public static bool CreateConnection()
        {
            string Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb;Persist Security Info=False;";


             myConnection = new OleDbConnection(Connectionstring);


            try
            {

                myConnection.Open();
                myConnection.Close();
                return true;
            }
            catch (Exception x)
            {
                
                return false;
            }
        }

        public static void CloseConnection()
        {
            if (myConnection.State == ConnectionState.Open)
                myConnection.Close();
        }

        public static void OpenConnection()
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
        }


        public static OleDbDataReader ExecuteQuery(string mySelectQuery)
        {
            ConnectionState OriginalConnectionStatus = myConnection.State;
            OleDbDataReader myReader;
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            //Open Connenction
            OpenConnection();
            //Create Command
            myReader = myCommand.ExecuteReader();
            //Close Connection
            CloseConnection();
            //return myReader;
            return myReader;
        }

        public static int ExecuteNonQuery(string mySelectQuery)
        {
            
            ConnectionState OriginalConnectionStatus = myConnection.State;
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.CommandTimeout = 0;
            //Open Connenction
            OpenConnection();
            //Create Command
            int rowsAffected = myCommand.ExecuteNonQuery();
            //Close Connection
            CloseConnection();

            return rowsAffected;


         
        }

        public static DataTable ExecuteQuery_DataTable(string mySelectQuery)
        {
            DataTable dataTable = new DataTable();
            OleDbDataReader SDRResult;
            //Open Connenction
            OpenConnection();
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);
            myCommand.CommandTimeout = 0;
            //Create Command
            SDRResult = myCommand.ExecuteReader();
            for (int intIndex = 0; intIndex < SDRResult.FieldCount; intIndex++)
            {
                // create and add a column
                dataTable.Columns.Add(SDRResult.GetName(intIndex), SDRResult.GetFieldType(intIndex));
            }
            while (SDRResult.Read())
            {
                // add a row
                DataRow row = dataTable.NewRow();
                for (int intIndex = 0; intIndex < SDRResult.FieldCount; intIndex++)
                {
                    row[SDRResult.GetName(intIndex)] = SDRResult[SDRResult.GetName(intIndex)];
                }
                dataTable.Rows.Add(row);
            }
            //Close Reader
            SDRResult.Close();
            //Close Connection
            CloseConnection();
            //Return Result of Executed Query
            return dataTable;
        }

    }
}
