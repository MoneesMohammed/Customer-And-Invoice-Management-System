namespace CIMS.Services.Payments
{
    partial class frmAddEditPaymentInfo
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
            this.components = new System.ComponentModel.Container();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInvoiceInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlFilterInvoice1 = new CIMS.UserControls.CtrlInvoices.CtrlFilterInvoice();
            this.tabPaymentInfo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrlSelectedMethod1 = new CIMS.UserControls.CtrlPayment.CtrlSelectedMethod();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaidInFull = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblRemainingAmountT = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabInvoiceInfo.SuspendLayout();
            this.tabPaymentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(441, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(65, 33);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Pay";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(419, 699);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(192, 38);
            this.txtAmountPaid.TabIndex = 1;
            this.txtAmountPaid.Text = "0";
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            this.txtAmountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPaid_KeyPress);
            this.txtAmountPaid.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountPaid_Validating);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInvoiceInfo);
            this.tabControl1.Controls.Add(this.tabPaymentInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 994);
            this.tabControl1.TabIndex = 49;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabInvoiceInfo
            // 
            this.tabInvoiceInfo.Controls.Add(this.btnNext);
            this.tabInvoiceInfo.Controls.Add(this.ctrlFilterInvoice1);
            this.tabInvoiceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInvoiceInfo.Location = new System.Drawing.Point(4, 29);
            this.tabInvoiceInfo.Name = "tabInvoiceInfo";
            this.tabInvoiceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoiceInfo.Size = new System.Drawing.Size(972, 961);
            this.tabInvoiceInfo.TabIndex = 0;
            this.tabInvoiceInfo.Text = "Invoice Info";
            this.tabInvoiceInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::CIMS.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(827, 905);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 43);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlFilterInvoice1
            // 
            this.ctrlFilterInvoice1.FilterEnabled = true;
            this.ctrlFilterInvoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFilterInvoice1.Location = new System.Drawing.Point(6, 11);
            this.ctrlFilterInvoice1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ctrlFilterInvoice1.Name = "ctrlFilterInvoice1";
            this.ctrlFilterInvoice1.Size = new System.Drawing.Size(969, 911);
            this.ctrlFilterInvoice1.TabIndex = 48;
            this.ctrlFilterInvoice1.OnInvoiceSelected += new System.Action<int>(this.ctrlFilterInvoice1_OnInvoiceSelected);
            // 
            // tabPaymentInfo
            // 
            this.tabPaymentInfo.Controls.Add(this.lblRemainingAmount);
            this.tabPaymentInfo.Controls.Add(this.lblRemainingAmountT);
            this.tabPaymentInfo.Controls.Add(this.groupBox1);
            this.tabPaymentInfo.Controls.Add(this.lblTotalAmount);
            this.tabPaymentInfo.Controls.Add(this.label1);
            this.tabPaymentInfo.Controls.Add(this.btnSave);
            this.tabPaymentInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPaymentInfo.Name = "tabPaymentInfo";
            this.tabPaymentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaymentInfo.Size = new System.Drawing.Size(972, 961);
            this.tabPaymentInfo.TabIndex = 1;
            this.tabPaymentInfo.Text = "Payment Info";
            this.tabPaymentInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPaymentID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ctrlSelectedMethod1);
            this.groupBox1.Controls.Add(this.txtAmountPaid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPaidInFull);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.lblPaymentDate);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 850);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.Location = new System.Drawing.Point(508, 558);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(75, 31);
            this.lblPaymentID.TabIndex = 50;
            this.lblPaymentID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 49;
            this.label4.Text = "Payment ID";
            // 
            // ctrlSelectedMethod1
            // 
            this.ctrlSelectedMethod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSelectedMethod1.Location = new System.Drawing.Point(241, 27);
            this.ctrlSelectedMethod1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSelectedMethod1.Name = "ctrlSelectedMethod1";
            this.ctrlSelectedMethod1.Size = new System.Drawing.Size(342, 502);
            this.ctrlSelectedMethod1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 706);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount Paid";
            // 
            // btnPaidInFull
            // 
            this.btnPaidInFull.Image = global::CIMS.Properties.Resources.check__1_;
            this.btnPaidInFull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaidInFull.Location = new System.Drawing.Point(670, 699);
            this.btnPaidInFull.Name = "btnPaidInFull";
            this.btnPaidInFull.Size = new System.Drawing.Size(157, 38);
            this.btnPaidInFull.TabIndex = 48;
            this.btnPaidInFull.Text = "Paid in Full";
            this.btnPaidInFull.UseVisualStyleBackColor = true;
            this.btnPaidInFull.Click += new System.EventHandler(this.btnPaidInFull_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(101, 772);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(706, 24);
            this.lblMessage.TabIndex = 47;
            this.lblMessage.Text = "The Amount Paid you entered is invalid because it is greater than the Total Amoun" +
    "t.";
            this.lblMessage.Visible = false;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(476, 630);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(135, 31);
            this.lblPaymentDate.TabIndex = 5;
            this.lblPaymentDate.Text = "07/4/2022";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(242, 902);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(59, 31);
            this.lblTotalAmount.TabIndex = 50;
            this.lblTotalAmount.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 902);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Total Amount";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CIMS.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(777, 900);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 43);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::CIMS.Properties.Resources.close_1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(793, 1045);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 43);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingAmount.ForeColor = System.Drawing.Color.Green;
            this.lblRemainingAmount.Location = new System.Drawing.Point(596, 905);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(55, 29);
            this.lblRemainingAmount.TabIndex = 69;
            this.lblRemainingAmount.Text = "000";
            this.lblRemainingAmount.Visible = false;
            // 
            // lblRemainingAmountT
            // 
            this.lblRemainingAmountT.AutoSize = true;
            this.lblRemainingAmountT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingAmountT.ForeColor = System.Drawing.Color.Green;
            this.lblRemainingAmountT.Location = new System.Drawing.Point(358, 905);
            this.lblRemainingAmountT.Name = "lblRemainingAmountT";
            this.lblRemainingAmountT.Size = new System.Drawing.Size(232, 29);
            this.lblRemainingAmountT.TabIndex = 68;
            this.lblRemainingAmountT.Text = "Remaining Amount";
            this.lblRemainingAmountT.Visible = false;
            // 
            // frmAddEditPaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 1100);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPaymentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment Info";
            this.Load += new System.EventHandler(this.frmAddEditPaymentInfo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInvoiceInfo.ResumeLayout(false);
            this.tabPaymentInfo.ResumeLayout(false);
            this.tabPaymentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private UserControls.CtrlPayment.CtrlSelectedMethod ctrlSelectedMethod1;
        private System.Windows.Forms.Button btnClose;
        private UserControls.CtrlInvoices.CtrlFilterInvoice ctrlFilterInvoice1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInvoiceInfo;
        private System.Windows.Forms.TabPage tabPaymentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnPaidInFull;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label lblRemainingAmountT;
    }
}