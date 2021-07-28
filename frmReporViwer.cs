using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

using CrystalDecisions.Shared;

namespace MSC_Shipping
{
    public partial class frmReporViwer : Form
    {
        TableLogOnInfo info = new TableLogOnInfo();
        ConnectionInfo con = new ConnectionInfo();


        public frmReporViwer()
        {
            InitializeComponent();
            this.RightToLeft = RightToLeft.Yes;

            crvReportViewer.ShowPrintButton = true;
            crvReportViewer.ShowExportButton = true;
            crvReportViewer.RightToLeft = RightToLeft.Yes;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            this.Location = new Point(0, 0);
            this.BringToFront();


            ConfigureReport();


        }

        private void ConfigureReport()
        {

            foreach (Table t in GlobalVariables.ReportDocument.Database.Tables)
            {
                SetLogOnInfo(t);
            }
            foreach (ReportDocument r in GlobalVariables.ReportDocument.Subreports)
            {
                foreach (Table t in r.Database.Tables)
                {
                    SetLogOnInfo(t);
                }
            }
        }

        private void frmReporViwer_Load(object sender, EventArgs e)
        {
            //ConfigureReport();
            crvReportViewer.ReportSource = GlobalVariables.ReportDocument;
            //crvReportViewer.Zoom(85);
        }

        private void SetLogOnInfo(Table t)
        {
            con = new ConnectionInfo();
          
            con.ServerName =  GlobalVariables.Server;
            con.DatabaseName = GlobalVariables.DatabaseName;
            con.UserID =  GlobalVariables.dbUserID;
            con.Password =  GlobalVariables.dbPassword;
            info = t.LogOnInfo;
            info.ConnectionInfo = con;
            t.ApplyLogOnInfo(info);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalVariables.ReportDocument.Close();
            GlobalVariables.ReportDocument = null;
            crvReportViewer.ReportSource = null;
            GlobalVariables.ReportDocument = new ReportDocument();

            this.Dispose();
        }

        private void crvReportViewer_Error(object source, CrystalDecisions.Windows.Forms.ExceptionEventArgs e)
        {

            e.Handled = true;


            this.Close();
        }

        private void crvReportViewer_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
        }

    }
}

