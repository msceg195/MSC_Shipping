using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSC_Shipping
{
    public partial class Form1 : Form
    {
        DataTable dtlines;
        DataTable dtVessels;
        string Code, frmDate, LineID, VesselID, VoyDate, Terminal, VoyNumber, TxtFrom, FromDate, TxtTo, ToDate, CntNo;
        public Form1()
        {
            InitializeComponent();
            DataLayer.CreateConnection();
            txtCode.Text = GetCode();

            dtlines = DataLayer.ExecuteQuery_DataTable("select ID, LineName from Ship_Lines");
            cboLines.DataSource = dtlines;
            cboLines.DisplayMember = "LineName";
            cboLines.ValueMember = "ID";


            


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Code = txtCode.Text.Trim();
            frmDate = dtpDate.Value.Date.ToString("yyyy/MM/dd");
            LineID = (cboLines.SelectedItem as DataRowView)["ID"].ToString();
            VesselID = (cboVessel.SelectedItem as DataRowView)["ID"].ToString();
            VoyDate = dtpVoyDate.Value.Date.ToString("yyyy/MM/dd");
            Terminal = txtTerminal.Text.Trim();
            VoyNumber = txtVoyNo.Text.Trim();
            TxtFrom = txtFrom.Text.Trim();
            FromDate = dtpFromdate.Value.Date.ToString("yyyy/MM/dd");
            TxtTo = txtTo.Text.Trim();
            ToDate = dtpToDate.Value.Date.ToString("yyyy/MM/dd");
            CntNo = txtCntNo.Text.Trim();

            DataLayer.ExecuteNonQuery(@"insert into [Ship_CashInVouchers] (Code,FrmDate,LineID,VesselID,VoyDate,Terminal,VoyNumber,TxtFrom,FromDate,TxtTo,ToDate,CntNo)
                Values ('" + Code + "','" + frmDate + "', " + LineID + ", " + VesselID + ", '" + VoyDate + "', '" + Terminal + "', '" + VoyNumber + "', '" + TxtFrom + "', '" + FromDate + "', '" + TxtTo + "', '" + ToDate + "', '" + CntNo + "')");





            GlobalVariables.ReportDocument.Load(Application.StartupPath + @"\Rpt_Receipt.rpt");
            frmReporViwer frm = new frmReporViwer();
            GlobalVariables.ReportDocument.SetParameterValue("myID", Code);
            frm.ShowDialog();

            ClearControls();

        }

        private string GetCode()
        {
            // "select (max(CLng(IIF(IsNull([Code]), 0.0, [Code]))) + 1.0)  AS [mycode]  from [Ship_CashInVouchers] "

            DataTable dt = DataLayer.ExecuteQuery_DataTable(@"select (max(CInt([Code])) + CInt(1) )  AS [mycode]  from [Ship_CashInVouchers]");
            return Convert.ToString(dt.Rows[0]["mycode"]).Length == 0 ? "1" : dt.Rows[0]["mycode"].ToString();
        }

        private void cboLines_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboVessel.SelectedIndex = -1;
            cboVessel.DataSource = null;
            if (cboLines.SelectedIndex > -1)
            {
                string LineID = (cboLines.SelectedItem as DataRowView)["id"].ToString();
                dtVessels = DataLayer.ExecuteQuery_DataTable("select [ID], [VesselName] from [Ship_Vessels] where [LineID] = " + LineID);


                cboVessel.DataSource = dtVessels;
                cboVessel.DisplayMember = "VesselName";
                cboVessel.ValueMember = "ID";

            }



        }

        private void ClearControls()
        {

            txtCode.Text = GetCode();
            dtpDate.Value = DateTime.Now;
            cboLines.SelectedIndex = 0;
            cboVessel.SelectedIndex = 0;
            dtpVoyDate.Value = DateTime.Now;
            txtTerminal.Text = "";
            txtVoyNo.Text = "";
            txtFrom.Text = "";
            dtpFromdate.Value = DateTime.Now;
            txtTo.Text = "";
            dtpToDate.Value = DateTime.Now;
            txtCntNo.Text = "";


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }







    }
}



