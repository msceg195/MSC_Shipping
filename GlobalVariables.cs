using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace MSC_Shipping
{
	/// <summary>
	/// Summary description for GlobalVariables.
	/// </summary>
	public class GlobalVariables
	{
        public GlobalVariables()
        {
        }

       

        //Application Variables
        public static string Server= "DB.accdb";
        public static string dbUserID="Admin";
        public static string dbPassword="";
        public static string DatabaseName="";
        
        
      
       
        

       
       

      

        //Screen resolution
        public static int ScreenWidth;
        public static int ScreenHeight;

       

     

        //Reports Variables
        public static ReportDocument ReportDocument = new ReportDocument();
        public static CrystalDecisions.Shared.TableLogOnInfo LogonInfo;
        public static string ReportsPath;
        public static string CVsPath;
        public static string DocumentsPath;


    

        //Searching Variables
        public static int ID;

        
        
       


    }
}
