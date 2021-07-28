using System.Windows.Forms;

namespace MSC_Shipping
{
    public partial class frmReporViwer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvReportViewer
            // 
            this.crvReportViewer.ActiveViewIndex = -1;
            this.crvReportViewer.AutoScroll = true;
            this.crvReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crvReportViewer.Name = "crvReportViewer";
            this.crvReportViewer.SelectionFormula = "";
            this.crvReportViewer.ShowCloseButton = false;
            this.crvReportViewer.ShowCopyButton = false;
            this.crvReportViewer.ShowGotoPageButton = false;
            this.crvReportViewer.ShowGroupTreeButton = false;
            this.crvReportViewer.ShowPageNavigateButtons = false;
            this.crvReportViewer.ShowParameterPanelButton = false;
            this.crvReportViewer.ShowRefreshButton = false;
            this.crvReportViewer.ShowTextSearchButton = false;
            this.crvReportViewer.ShowZoomButton = false;
            this.crvReportViewer.Size = new System.Drawing.Size(703, 513);
            this.crvReportViewer.TabIndex = 1;
            this.crvReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvReportViewer.ToolPanelWidth = 0;
            this.crvReportViewer.ViewTimeSelectionFormula = "";
            this.crvReportViewer.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvReportViewer_ReportRefresh);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(676, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(19, 19);
            this.btnExit.TabIndex = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReporViwer
            // 
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(703, 513);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.crvReportViewer);
            this.Name = "frmReporViwer";
            this.Load += new System.EventHandler(this.frmReporViwer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportViewer;
    }
}
