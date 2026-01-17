namespace CIMS.Services.Manage_Invoices
{
    partial class frmInvoiceHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlFilterCustomer1 = new CIMS.UserControls.CtrlPerson.CtrlFilterCustomer();
            this.ctrlInvoicesDGV1 = new CIMS.UserControls.CtrlInvoices.CtrlInvoicesDGV();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 36;
            this.label1.Text = "Invoice History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIMS.Properties.Resources.transaction_history;
            this.pictureBox1.Location = new System.Drawing.Point(19, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::CIMS.Properties.Resources.close_1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1092, 945);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 40);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlFilterCustomer1
            // 
            this.ctrlFilterCustomer1.FilterEnabled = true;
            this.ctrlFilterCustomer1.Location = new System.Drawing.Point(250, 9);
            this.ctrlFilterCustomer1.Name = "ctrlFilterCustomer1";
            this.ctrlFilterCustomer1.ShowAddCustomer = true;
            this.ctrlFilterCustomer1.Size = new System.Drawing.Size(1024, 451);
            this.ctrlFilterCustomer1.TabIndex = 37;
            this.ctrlFilterCustomer1.OnCustomerSelected += new System.Action<int>(this.ctrlFilterCustomer1_OnCustomerSelected);
            // 
            // ctrlInvoicesDGV1
            // 
            this.ctrlInvoicesDGV1.Location = new System.Drawing.Point(19, 452);
            this.ctrlInvoicesDGV1.Name = "ctrlInvoicesDGV1";
            this.ctrlInvoicesDGV1.Size = new System.Drawing.Size(1253, 473);
            this.ctrlInvoicesDGV1.TabIndex = 54;
            // 
            // frmInvoiceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 997);
            this.Controls.Add(this.ctrlInvoicesDGV1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlFilterCustomer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInvoiceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice History";
            this.Load += new System.EventHandler(this.frmInvoiceHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.CtrlPerson.CtrlFilterCustomer ctrlFilterCustomer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.CtrlInvoices.CtrlInvoicesDGV ctrlInvoicesDGV1;
    }
}