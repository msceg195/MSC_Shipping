namespace MSC_Shipping
{
    partial class Form1
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblShippingLine = new System.Windows.Forms.Label();
            this.cboLines = new System.Windows.Forms.ComboBox();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.cboVessel = new System.Windows.Forms.ComboBox();
            this.lblVessel = new System.Windows.Forms.Label();
            this.dtpVoyDate = new System.Windows.Forms.DateTimePicker();
            this.lblVoyDate = new System.Windows.Forms.Label();
            this.txtVoyNo = new System.Windows.Forms.TextBox();
            this.lblVoyNo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.dtpFromdate = new System.Windows.Forms.DateTimePicker();
            this.lblFromdate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblCntNo = new System.Windows.Forms.Label();
            this.txtCntNo = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(849, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "الاسكندرية فى";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(500, 45);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDate.Size = new System.Drawing.Size(347, 24);
            this.dtpDate.TabIndex = 4;
            // 
            // lblShippingLine
            // 
            this.lblShippingLine.AutoSize = true;
            this.lblShippingLine.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblShippingLine.Location = new System.Drawing.Point(369, 49);
            this.lblShippingLine.Name = "lblShippingLine";
            this.lblShippingLine.Size = new System.Drawing.Size(98, 17);
            this.lblShippingLine.TabIndex = 5;
            this.lblShippingLine.Text = "الخط الملاحى";
            // 
            // cboLines
            // 
            this.cboLines.FormattingEnabled = true;
            this.cboLines.Location = new System.Drawing.Point(8, 45);
            this.cboLines.Name = "cboLines";
            this.cboLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboLines.Size = new System.Drawing.Size(356, 24);
            this.cboLines.TabIndex = 6;
            this.cboLines.SelectedIndexChanged += new System.EventHandler(this.cboLines_SelectedIndexChanged);
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblTerminal.Location = new System.Drawing.Point(894, 111);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(57, 17);
            this.lblTerminal.TabIndex = 11;
            this.lblTerminal.Text = "الرصيف";
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(500, 108);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTerminal.Size = new System.Drawing.Size(347, 51);
            this.txtTerminal.TabIndex = 12;
            // 
            // cboVessel
            // 
            this.cboVessel.FormattingEnabled = true;
            this.cboVessel.Location = new System.Drawing.Point(500, 75);
            this.cboVessel.Name = "cboVessel";
            this.cboVessel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboVessel.Size = new System.Drawing.Size(347, 24);
            this.cboVessel.TabIndex = 8;
            // 
            // lblVessel
            // 
            this.lblVessel.AutoSize = true;
            this.lblVessel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblVessel.Location = new System.Drawing.Point(898, 79);
            this.lblVessel.Name = "lblVessel";
            this.lblVessel.Size = new System.Drawing.Size(53, 17);
            this.lblVessel.TabIndex = 7;
            this.lblVessel.Text = "الباخرة";
            // 
            // dtpVoyDate
            // 
            this.dtpVoyDate.Location = new System.Drawing.Point(8, 75);
            this.dtpVoyDate.Name = "dtpVoyDate";
            this.dtpVoyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpVoyDate.Size = new System.Drawing.Size(356, 24);
            this.dtpVoyDate.TabIndex = 10;
            // 
            // lblVoyDate
            // 
            this.lblVoyDate.AutoSize = true;
            this.lblVoyDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblVoyDate.Location = new System.Drawing.Point(383, 79);
            this.lblVoyDate.Name = "lblVoyDate";
            this.lblVoyDate.Size = new System.Drawing.Size(85, 17);
            this.lblVoyDate.TabIndex = 9;
            this.lblVoyDate.Text = "تاريخ الرحلة";
            // 
            // txtVoyNo
            // 
            this.txtVoyNo.Location = new System.Drawing.Point(8, 108);
            this.txtVoyNo.Multiline = true;
            this.txtVoyNo.Name = "txtVoyNo";
            this.txtVoyNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVoyNo.Size = new System.Drawing.Size(356, 51);
            this.txtVoyNo.TabIndex = 14;
            // 
            // lblVoyNo
            // 
            this.lblVoyNo.AutoSize = true;
            this.lblVoyNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblVoyNo.Location = new System.Drawing.Point(389, 111);
            this.lblVoyNo.Name = "lblVoyNo";
            this.lblVoyNo.Size = new System.Drawing.Size(77, 17);
            this.lblVoyNo.TabIndex = 13;
            this.lblVoyNo.Text = "رقم الرحلة";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(880, 170);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(69, 17);
            this.lblFrom.TabIndex = 15;
            this.lblFrom.Text = "من سعت";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(764, 170);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFrom.Size = new System.Drawing.Size(83, 24);
            this.txtFrom.TabIndex = 16;
            // 
            // dtpFromdate
            // 
            this.dtpFromdate.Location = new System.Drawing.Point(500, 170);
            this.dtpFromdate.Name = "dtpFromdate";
            this.dtpFromdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFromdate.Size = new System.Drawing.Size(217, 24);
            this.dtpFromdate.TabIndex = 18;
            // 
            // lblFromdate
            // 
            this.lblFromdate.AutoSize = true;
            this.lblFromdate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblFromdate.Location = new System.Drawing.Point(728, 170);
            this.lblFromdate.Name = "lblFromdate";
            this.lblFromdate.Size = new System.Drawing.Size(30, 17);
            this.lblFromdate.TabIndex = 17;
            this.lblFromdate.Text = "يوم";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(9, 170);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpToDate.Size = new System.Drawing.Size(217, 24);
            this.dtpToDate.TabIndex = 22;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblToDate.Location = new System.Drawing.Point(238, 170);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(30, 17);
            this.lblToDate.TabIndex = 21;
            this.lblToDate.Text = "يوم";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(390, 170);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(73, 17);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "الى سعت";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(279, 170);
            this.txtTo.Name = "txtTo";
            this.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTo.Size = new System.Drawing.Size(83, 24);
            this.txtTo.TabIndex = 20;
            // 
            // lblCntNo
            // 
            this.lblCntNo.AutoSize = true;
            this.lblCntNo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCntNo.Location = new System.Drawing.Point(863, 212);
            this.lblCntNo.Name = "lblCntNo";
            this.lblCntNo.Size = new System.Drawing.Size(93, 17);
            this.lblCntNo.TabIndex = 23;
            this.lblCntNo.Text = "عدد الحاويات";
            // 
            // txtCntNo
            // 
            this.txtCntNo.Location = new System.Drawing.Point(500, 209);
            this.txtCntNo.Multiline = true;
            this.txtCntNo.Name = "txtCntNo";
            this.txtCntNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCntNo.Size = new System.Drawing.Size(347, 51);
            this.txtCntNo.TabIndex = 24;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Green;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(372, 359);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(253, 48);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "حفــظ && طباعــــــة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(8, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 48);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "الغاء";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCode.Location = new System.Drawing.Point(909, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 17);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "الكود";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(731, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(116, 24);
            this.txtCode.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 419);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblCntNo);
            this.Controls.Add(this.txtCntNo);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.dtpFromdate);
            this.Controls.Add(this.lblFromdate);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblVoyNo);
            this.Controls.Add(this.txtVoyNo);
            this.Controls.Add(this.dtpVoyDate);
            this.Controls.Add(this.lblVoyDate);
            this.Controls.Add(this.cboVessel);
            this.Controls.Add(this.lblVessel);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.cboLines);
            this.Controls.Add(this.lblShippingLine);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحصيل عوائد تفريغ وشحن";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblShippingLine;
        private System.Windows.Forms.ComboBox cboLines;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.ComboBox cboVessel;
        private System.Windows.Forms.Label lblVessel;
        private System.Windows.Forms.DateTimePicker dtpVoyDate;
        private System.Windows.Forms.Label lblVoyDate;
        private System.Windows.Forms.TextBox txtVoyNo;
        private System.Windows.Forms.Label lblVoyNo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.DateTimePicker dtpFromdate;
        private System.Windows.Forms.Label lblFromdate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblCntNo;
        private System.Windows.Forms.TextBox txtCntNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
    }
}

