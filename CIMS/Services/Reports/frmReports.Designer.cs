namespace CIMS.Services.Reports
{
    partial class frmReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSalesDate = new System.Windows.Forms.ComboBox();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.txtFilterProductsBy = new System.Windows.Forms.TextBox();
            this.cbFilterSalesBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCustomersReport = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowCustomerInvoiceHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterCustomersBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterProductsBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilterCustomersBy = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSRSaveToPDF = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCRSaveToPDF = new System.Windows.Forms.Button();
            this.btnTPRSaveToPDF = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersReport)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSalesDate
            // 
            this.cbSalesDate.BackColor = System.Drawing.SystemColors.Window;
            this.cbSalesDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalesDate.FormattingEnabled = true;
            this.cbSalesDate.Location = new System.Drawing.Point(243, 683);
            this.cbSalesDate.Name = "cbSalesDate";
            this.cbSalesDate.Size = new System.Drawing.Size(164, 28);
            this.cbSalesDate.TabIndex = 43;
            this.cbSalesDate.Visible = false;
            this.cbSalesDate.SelectedIndexChanged += new System.EventHandler(this.cbSalesDate_SelectedIndexChanged);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.AllowUserToAddRows = false;
            this.dgvSalesReport.AllowUserToDeleteRows = false;
            this.dgvSalesReport.AllowUserToOrderColumns = true;
            this.dgvSalesReport.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesReport.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvSalesReport.Location = new System.Drawing.Point(12, 289);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesReport.Size = new System.Drawing.Size(395, 378);
            this.dgvSalesReport.TabIndex = 42;
            // 
            // txtFilterProductsBy
            // 
            this.txtFilterProductsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterProductsBy.Location = new System.Drawing.Point(689, 676);
            this.txtFilterProductsBy.Name = "txtFilterProductsBy";
            this.txtFilterProductsBy.Size = new System.Drawing.Size(183, 29);
            this.txtFilterProductsBy.TabIndex = 41;
            this.txtFilterProductsBy.Visible = false;
            this.txtFilterProductsBy.TextChanged += new System.EventHandler(this.txtFilterProductsBy_TextChanged);
            // 
            // cbFilterSalesBy
            // 
            this.cbFilterSalesBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterSalesBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterSalesBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterSalesBy.FormattingEnabled = true;
            this.cbFilterSalesBy.Items.AddRange(new object[] {
            "None",
            "Date"});
            this.cbFilterSalesBy.Location = new System.Drawing.Point(102, 683);
            this.cbFilterSalesBy.Name = "cbFilterSalesBy";
            this.cbFilterSalesBy.Size = new System.Drawing.Size(124, 28);
            this.cbFilterSalesBy.TabIndex = 40;
            this.cbFilterSalesBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterSalesBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(9, 683);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Filter By :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(5, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1650, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTopProducts
            // 
            this.dgvTopProducts.AllowUserToAddRows = false;
            this.dgvTopProducts.AllowUserToDeleteRows = false;
            this.dgvTopProducts.AllowUserToOrderColumns = true;
            this.dgvTopProducts.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTopProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopProducts.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopProducts.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTopProducts.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvTopProducts.Location = new System.Drawing.Point(477, 289);
            this.dgvTopProducts.Name = "dgvTopProducts";
            this.dgvTopProducts.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTopProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopProducts.Size = new System.Drawing.Size(395, 378);
            this.dgvTopProducts.TabIndex = 45;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowProductInfo});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(264, 50);
            // 
            // tsmShowProductInfo
            // 
            this.tsmShowProductInfo.Image = global::CIMS.Properties.Resources.product;
            this.tsmShowProductInfo.Name = "tsmShowProductInfo";
            this.tsmShowProductInfo.Size = new System.Drawing.Size(263, 46);
            this.tsmShowProductInfo.Text = "Show Product Info";
            this.tsmShowProductInfo.Click += new System.EventHandler(this.tsmShowProductInfo_Click);
            // 
            // dgvCustomersReport
            // 
            this.dgvCustomersReport.AllowUserToAddRows = false;
            this.dgvCustomersReport.AllowUserToDeleteRows = false;
            this.dgvCustomersReport.AllowUserToOrderColumns = true;
            this.dgvCustomersReport.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCustomersReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersReport.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomersReport.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCustomersReport.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvCustomersReport.Location = new System.Drawing.Point(935, 289);
            this.dgvCustomersReport.Name = "dgvCustomersReport";
            this.dgvCustomersReport.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomersReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCustomersReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersReport.Size = new System.Drawing.Size(710, 378);
            this.dgvCustomersReport.TabIndex = 46;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowCustomerInvoiceHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(370, 50);
            // 
            // tsmShowCustomerInvoiceHistory
            // 
            this.tsmShowCustomerInvoiceHistory.Image = global::CIMS.Properties.Resources.transaction_history;
            this.tsmShowCustomerInvoiceHistory.Name = "tsmShowCustomerInvoiceHistory";
            this.tsmShowCustomerInvoiceHistory.Size = new System.Drawing.Size(369, 46);
            this.tsmShowCustomerInvoiceHistory.Text = "Show Customer Invoice History";
            this.tsmShowCustomerInvoiceHistory.Click += new System.EventHandler(this.tsmShowCustomerInvoiceHistory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(99, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Sales Report";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(516, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Top Products Report";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1160, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "Customers Report";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilterCustomersBy
            // 
            this.cbFilterCustomersBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterCustomersBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCustomersBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterCustomersBy.FormattingEnabled = true;
            this.cbFilterCustomersBy.Items.AddRange(new object[] {
            "None",
            "Customer ID",
            "Customer Name"});
            this.cbFilterCustomersBy.Location = new System.Drawing.Point(1050, 682);
            this.cbFilterCustomersBy.Name = "cbFilterCustomersBy";
            this.cbFilterCustomersBy.Size = new System.Drawing.Size(155, 28);
            this.cbFilterCustomersBy.TabIndex = 59;
            this.cbFilterCustomersBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterCustomersBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(473, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Filter By :";
            // 
            // cbFilterProductsBy
            // 
            this.cbFilterProductsBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterProductsBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterProductsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterProductsBy.FormattingEnabled = true;
            this.cbFilterProductsBy.Items.AddRange(new object[] {
            "None",
            "Name"});
            this.cbFilterProductsBy.Location = new System.Drawing.Point(566, 679);
            this.cbFilterProductsBy.Name = "cbFilterProductsBy";
            this.cbFilterProductsBy.Size = new System.Drawing.Size(106, 28);
            this.cbFilterProductsBy.TabIndex = 61;
            this.cbFilterProductsBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterProductsBy_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(957, 682);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Filter By :";
            // 
            // txtFilterCustomersBy
            // 
            this.txtFilterCustomersBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCustomersBy.Location = new System.Drawing.Point(1233, 682);
            this.txtFilterCustomersBy.Name = "txtFilterCustomersBy";
            this.txtFilterCustomersBy.Size = new System.Drawing.Size(268, 29);
            this.txtFilterCustomersBy.TabIndex = 62;
            this.txtFilterCustomersBy.Visible = false;
            this.txtFilterCustomersBy.TextChanged += new System.EventHandler(this.txtFilterCustomersBy_TextChanged);
            this.txtFilterCustomersBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterCustomersBy_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CIMS.Properties.Resources.sales;
            this.pictureBox4.Location = new System.Drawing.Point(787, 224);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CIMS.Properties.Resources.analystics;
            this.pictureBox3.Location = new System.Drawing.Point(1401, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CIMS.Properties.Resources.forecast;
            this.pictureBox2.Location = new System.Drawing.Point(276, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // btnSRSaveToPDF
            // 
            this.btnSRSaveToPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRSaveToPDF.Image = global::CIMS.Properties.Resources.down;
            this.btnSRSaveToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSRSaveToPDF.Location = new System.Drawing.Point(13, 717);
            this.btnSRSaveToPDF.Name = "btnSRSaveToPDF";
            this.btnSRSaveToPDF.Size = new System.Drawing.Size(180, 40);
            this.btnSRSaveToPDF.TabIndex = 53;
            this.btnSRSaveToPDF.Text = "Save to PDF";
            this.btnSRSaveToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSRSaveToPDF.UseVisualStyleBackColor = true;
            this.btnSRSaveToPDF.Click += new System.EventHandler(this.btnSRSaveToPDF_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::CIMS.Properties.Resources.close_1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1483, 773);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 40);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIMS.Properties.Resources.analysis;
            this.pictureBox1.Location = new System.Drawing.Point(759, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnCRSaveToPDF
            // 
            this.btnCRSaveToPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRSaveToPDF.Image = global::CIMS.Properties.Resources.down;
            this.btnCRSaveToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRSaveToPDF.Location = new System.Drawing.Point(961, 717);
            this.btnCRSaveToPDF.Name = "btnCRSaveToPDF";
            this.btnCRSaveToPDF.Size = new System.Drawing.Size(180, 40);
            this.btnCRSaveToPDF.TabIndex = 65;
            this.btnCRSaveToPDF.Text = "Save to PDF";
            this.btnCRSaveToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCRSaveToPDF.UseVisualStyleBackColor = true;
            this.btnCRSaveToPDF.Click += new System.EventHandler(this.btnCRSaveToPDF_Click);
            // 
            // btnTPRSaveToPDF
            // 
            this.btnTPRSaveToPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPRSaveToPDF.Image = global::CIMS.Properties.Resources.down;
            this.btnTPRSaveToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTPRSaveToPDF.Location = new System.Drawing.Point(477, 717);
            this.btnTPRSaveToPDF.Name = "btnTPRSaveToPDF";
            this.btnTPRSaveToPDF.Size = new System.Drawing.Size(180, 40);
            this.btnTPRSaveToPDF.TabIndex = 66;
            this.btnTPRSaveToPDF.Text = "Save to PDF";
            this.btnTPRSaveToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTPRSaveToPDF.UseVisualStyleBackColor = true;
            this.btnTPRSaveToPDF.Click += new System.EventHandler(this.btnTPRSaveToPDF_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(974, 760);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Customers Report to PDF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 760);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Top Products Report to PDF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 760);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Sales Report to PDF";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 829);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTPRSaveToPDF);
            this.Controls.Add(this.btnCRSaveToPDF);
            this.Controls.Add(this.txtFilterCustomersBy);
            this.Controls.Add(this.cbFilterProductsBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFilterCustomersBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSRSaveToPDF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCustomersReport);
            this.Controls.Add(this.dgvTopProducts);
            this.Controls.Add(this.cbSalesDate);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.txtFilterProductsBy);
            this.Controls.Add(this.cbFilterSalesBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersReport)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSalesDate;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.TextBox txtFilterProductsBy;
        private System.Windows.Forms.ComboBox cbFilterSalesBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTopProducts;
        private System.Windows.Forms.DataGridView dgvCustomersReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSRSaveToPDF;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbFilterCustomersBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterProductsBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilterCustomersBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowCustomerInvoiceHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmShowProductInfo;
        private System.Windows.Forms.Button btnCRSaveToPDF;
        private System.Windows.Forms.Button btnTPRSaveToPDF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}