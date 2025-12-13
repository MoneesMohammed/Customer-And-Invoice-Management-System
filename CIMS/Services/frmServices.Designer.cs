namespace CIMS
{
    partial class frmServices
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
            this.llblManageInvoices = new System.Windows.Forms.LinkLabel();
            this.llblCustomers = new System.Windows.Forms.LinkLabel();
            this.llblPayments = new System.Windows.Forms.LinkLabel();
            this.llblReports = new System.Windows.Forms.LinkLabel();
            this.llblCreateInvoices = new System.Windows.Forms.LinkLabel();
            this.llblProducts = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbCreateInvoices = new System.Windows.Forms.PictureBox();
            this.pbPayments = new System.Windows.Forms.PictureBox();
            this.pbReports = new System.Windows.Forms.PictureBox();
            this.pbCustomers = new System.Windows.Forms.PictureBox();
            this.pbManageInvoices = new System.Windows.Forms.PictureBox();
            this.pbProducts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // llblManageInvoices
            // 
            this.llblManageInvoices.AutoSize = true;
            this.llblManageInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblManageInvoices.Location = new System.Drawing.Point(204, 166);
            this.llblManageInvoices.Name = "llblManageInvoices";
            this.llblManageInvoices.Size = new System.Drawing.Size(175, 25);
            this.llblManageInvoices.TabIndex = 0;
            this.llblManageInvoices.TabStop = true;
            this.llblManageInvoices.Text = "Manage Invoices";
            this.llblManageInvoices.Click += new System.EventHandler(this.ManageInvoices_Click);
            // 
            // llblCustomers
            // 
            this.llblCustomers.AutoSize = true;
            this.llblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCustomers.Location = new System.Drawing.Point(413, 166);
            this.llblCustomers.Name = "llblCustomers";
            this.llblCustomers.Size = new System.Drawing.Size(115, 25);
            this.llblCustomers.TabIndex = 2;
            this.llblCustomers.TabStop = true;
            this.llblCustomers.Text = "Customers";
            this.llblCustomers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // llblPayments
            // 
            this.llblPayments.AutoSize = true;
            this.llblPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblPayments.Location = new System.Drawing.Point(52, 377);
            this.llblPayments.Name = "llblPayments";
            this.llblPayments.Size = new System.Drawing.Size(107, 25);
            this.llblPayments.TabIndex = 3;
            this.llblPayments.TabStop = true;
            this.llblPayments.Text = "Payments";
            this.llblPayments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // llblReports
            // 
            this.llblReports.AutoSize = true;
            this.llblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblReports.Location = new System.Drawing.Point(246, 377);
            this.llblReports.Name = "llblReports";
            this.llblReports.Size = new System.Drawing.Size(87, 25);
            this.llblReports.TabIndex = 4;
            this.llblReports.TabStop = true;
            this.llblReports.Text = "Reports";
            // 
            // llblCreateInvoices
            // 
            this.llblCreateInvoices.AutoSize = true;
            this.llblCreateInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCreateInvoices.Location = new System.Drawing.Point(397, 377);
            this.llblCreateInvoices.Name = "llblCreateInvoices";
            this.llblCreateInvoices.Size = new System.Drawing.Size(150, 25);
            this.llblCreateInvoices.TabIndex = 10;
            this.llblCreateInvoices.TabStop = true;
            this.llblCreateInvoices.Text = "Create Invoice";
            this.llblCreateInvoices.Click += new System.EventHandler(this.CreateInvoices_Click);
            // 
            // llblProducts
            // 
            this.llblProducts.AutoSize = true;
            this.llblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblProducts.Location = new System.Drawing.Point(52, 166);
            this.llblProducts.Name = "llblProducts";
            this.llblProducts.Size = new System.Drawing.Size(97, 25);
            this.llblProducts.TabIndex = 1;
            this.llblProducts.TabStop = true;
            this.llblProducts.Text = "Products";
            this.llblProducts.Click += new System.EventHandler(this.Products_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::CIMS.Properties.Resources.close_1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(467, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbCreateInvoices
            // 
            this.pbCreateInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCreateInvoices.Image = global::CIMS.Properties.Resources.financial_statements;
            this.pbCreateInvoices.Location = new System.Drawing.Point(427, 236);
            this.pbCreateInvoices.Name = "pbCreateInvoices";
            this.pbCreateInvoices.Size = new System.Drawing.Size(92, 124);
            this.pbCreateInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreateInvoices.TabIndex = 11;
            this.pbCreateInvoices.TabStop = false;
            this.pbCreateInvoices.Click += new System.EventHandler(this.CreateInvoices_Click);
            // 
            // pbPayments
            // 
            this.pbPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPayments.Image = global::CIMS.Properties.Resources.credit_card;
            this.pbPayments.Location = new System.Drawing.Point(57, 236);
            this.pbPayments.Name = "pbPayments";
            this.pbPayments.Size = new System.Drawing.Size(92, 124);
            this.pbPayments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPayments.TabIndex = 9;
            this.pbPayments.TabStop = false;
            this.pbPayments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // pbReports
            // 
            this.pbReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReports.Image = global::CIMS.Properties.Resources.analysis;
            this.pbReports.Location = new System.Drawing.Point(242, 236);
            this.pbReports.Name = "pbReports";
            this.pbReports.Size = new System.Drawing.Size(92, 124);
            this.pbReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReports.TabIndex = 8;
            this.pbReports.TabStop = false;
            // 
            // pbCustomers
            // 
            this.pbCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCustomers.Image = global::CIMS.Properties.Resources.customer;
            this.pbCustomers.Location = new System.Drawing.Point(427, 30);
            this.pbCustomers.Name = "pbCustomers";
            this.pbCustomers.Size = new System.Drawing.Size(92, 124);
            this.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomers.TabIndex = 7;
            this.pbCustomers.TabStop = false;
            this.pbCustomers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // pbManageInvoices
            // 
            this.pbManageInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbManageInvoices.Image = global::CIMS.Properties.Resources.invoice1;
            this.pbManageInvoices.Location = new System.Drawing.Point(242, 30);
            this.pbManageInvoices.Name = "pbManageInvoices";
            this.pbManageInvoices.Size = new System.Drawing.Size(92, 124);
            this.pbManageInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageInvoices.TabIndex = 6;
            this.pbManageInvoices.TabStop = false;
            this.pbManageInvoices.Click += new System.EventHandler(this.ManageInvoices_Click);
            // 
            // pbProducts
            // 
            this.pbProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProducts.Image = global::CIMS.Properties.Resources.product;
            this.pbProducts.Location = new System.Drawing.Point(57, 30);
            this.pbProducts.Name = "pbProducts";
            this.pbProducts.Size = new System.Drawing.Size(92, 124);
            this.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducts.TabIndex = 5;
            this.pbProducts.TabStop = false;
            this.pbProducts.Click += new System.EventHandler(this.Products_Click);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 487);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbCreateInvoices);
            this.Controls.Add(this.llblCreateInvoices);
            this.Controls.Add(this.pbPayments);
            this.Controls.Add(this.pbReports);
            this.Controls.Add(this.pbCustomers);
            this.Controls.Add(this.pbManageInvoices);
            this.Controls.Add(this.pbProducts);
            this.Controls.Add(this.llblReports);
            this.Controls.Add(this.llblPayments);
            this.Controls.Add(this.llblCustomers);
            this.Controls.Add(this.llblProducts);
            this.Controls.Add(this.llblManageInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblManageInvoices;
        private System.Windows.Forms.LinkLabel llblCustomers;
        private System.Windows.Forms.LinkLabel llblPayments;
        private System.Windows.Forms.LinkLabel llblReports;
        private System.Windows.Forms.PictureBox pbManageInvoices;
        private System.Windows.Forms.PictureBox pbCustomers;
        private System.Windows.Forms.PictureBox pbReports;
        private System.Windows.Forms.PictureBox pbPayments;
        private System.Windows.Forms.PictureBox pbCreateInvoices;
        private System.Windows.Forms.LinkLabel llblCreateInvoices;
        private System.Windows.Forms.LinkLabel llblProducts;
        private System.Windows.Forms.PictureBox pbProducts;
        private System.Windows.Forms.Button btnClose;
    }
}