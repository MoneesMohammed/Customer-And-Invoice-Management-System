namespace CIMS.Services.Create_Invoices
{
    partial class frmCreateInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateInvoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomerInfo = new System.Windows.Forms.TabPage();
            this.ctrlFilterCustomer1 = new CIMS.UserControls.CtrlPerson.CtrlFilterCustomer();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabInvoiceInfo = new System.Windows.Forms.TabPage();
            this.btnBackTabCreateInvoice = new System.Windows.Forms.Button();
            this.btnNextToAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabAddProductToInvoice = new System.Windows.Forms.TabPage();
            this.btnDeleteAllProduct = new System.Windows.Forms.Button();
            this.btnBackTabAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalAmount_1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmReadMore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabCustomerInfo.SuspendLayout();
            this.tabInvoiceInfo.SuspendLayout();
            this.tabAddProductToInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMode.Location = new System.Drawing.Point(1, 151);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(1043, 39);
            this.lblMode.TabIndex = 42;
            this.lblMode.Text = "Create New Invoices";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCustomerInfo);
            this.tabControl1.Controls.Add(this.tabInvoiceInfo);
            this.tabControl1.Controls.Add(this.tabAddProductToInvoice);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 193);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 583);
            this.tabControl1.TabIndex = 44;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabCustomerInfo
            // 
            this.tabCustomerInfo.Controls.Add(this.ctrlFilterCustomer1);
            this.tabCustomerInfo.Controls.Add(this.btnNext);
            this.tabCustomerInfo.Location = new System.Drawing.Point(4, 29);
            this.tabCustomerInfo.Name = "tabCustomerInfo";
            this.tabCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerInfo.Size = new System.Drawing.Size(1028, 550);
            this.tabCustomerInfo.TabIndex = 0;
            this.tabCustomerInfo.Text = "Customer Info";
            this.tabCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlFilterCustomer1
            // 
            this.ctrlFilterCustomer1.FilterEnabled = true;
            this.ctrlFilterCustomer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFilterCustomer1.Location = new System.Drawing.Point(1, 8);
            this.ctrlFilterCustomer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlFilterCustomer1.Name = "ctrlFilterCustomer1";
            this.ctrlFilterCustomer1.ShowAddCustomer = true;
            this.ctrlFilterCustomer1.Size = new System.Drawing.Size(1022, 451);
            this.ctrlFilterCustomer1.TabIndex = 23;
            this.ctrlFilterCustomer1.OnCustomerSelected += new System.Action<int>(this.ctrlFilterCustomer1_OnCustomerSelected);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::CIMS.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(887, 488);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 43);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabInvoiceInfo
            // 
            this.tabInvoiceInfo.Controls.Add(this.btnBackTabCreateInvoice);
            this.tabInvoiceInfo.Controls.Add(this.btnNextToAdd);
            this.tabInvoiceInfo.Controls.Add(this.btnCreate);
            this.tabInvoiceInfo.Controls.Add(this.lblCustomerID);
            this.tabInvoiceInfo.Controls.Add(this.label2);
            this.tabInvoiceInfo.Controls.Add(this.lblCreatedBy);
            this.tabInvoiceInfo.Controls.Add(this.lblInvoiceStatus);
            this.tabInvoiceInfo.Controls.Add(this.lblInvoiceDate);
            this.tabInvoiceInfo.Controls.Add(this.lblInvoiceID);
            this.tabInvoiceInfo.Controls.Add(this.label8);
            this.tabInvoiceInfo.Controls.Add(this.label9);
            this.tabInvoiceInfo.Controls.Add(this.lblTotalAmount);
            this.tabInvoiceInfo.Controls.Add(this.label5);
            this.tabInvoiceInfo.Controls.Add(this.label6);
            this.tabInvoiceInfo.Controls.Add(this.label7);
            this.tabInvoiceInfo.Location = new System.Drawing.Point(4, 29);
            this.tabInvoiceInfo.Name = "tabInvoiceInfo";
            this.tabInvoiceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoiceInfo.Size = new System.Drawing.Size(1028, 550);
            this.tabInvoiceInfo.TabIndex = 1;
            this.tabInvoiceInfo.Text = "Create Invoice";
            this.tabInvoiceInfo.UseVisualStyleBackColor = true;
            // 
            // btnBackTabCreateInvoice
            // 
            this.btnBackTabCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTabCreateInvoice.Image = global::CIMS.Properties.Resources.arrow;
            this.btnBackTabCreateInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTabCreateInvoice.Location = new System.Drawing.Point(15, 510);
            this.btnBackTabCreateInvoice.Name = "btnBackTabCreateInvoice";
            this.btnBackTabCreateInvoice.Size = new System.Drawing.Size(135, 34);
            this.btnBackTabCreateInvoice.TabIndex = 50;
            this.btnBackTabCreateInvoice.Text = "Back";
            this.btnBackTabCreateInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackTabCreateInvoice.UseVisualStyleBackColor = true;
            this.btnBackTabCreateInvoice.Click += new System.EventHandler(this.btnBackTabCreateInvoice_Click);
            // 
            // btnNextToAdd
            // 
            this.btnNextToAdd.Enabled = false;
            this.btnNextToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToAdd.Image = global::CIMS.Properties.Resources.next;
            this.btnNextToAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNextToAdd.Location = new System.Drawing.Point(878, 490);
            this.btnNextToAdd.Name = "btnNextToAdd";
            this.btnNextToAdd.Size = new System.Drawing.Size(135, 43);
            this.btnNextToAdd.TabIndex = 49;
            this.btnNextToAdd.Text = "Next";
            this.btnNextToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextToAdd.UseVisualStyleBackColor = true;
            this.btnNextToAdd.Click += new System.EventHandler(this.btnNextToAdd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = global::CIMS.Properties.Resources.design;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(878, 427);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 43);
            this.btnCreate.TabIndex = 48;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(362, 49);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(26, 29);
            this.lblCustomerID.TabIndex = 22;
            this.lblCustomerID.Text = "1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::CIMS.Properties.Resources.receive_amount;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(52, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Amount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(362, 394);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(49, 29);
            this.lblCreatedBy.TabIndex = 20;
            this.lblCreatedBy.Text = "???";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceStatus.Location = new System.Drawing.Point(362, 256);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(90, 29);
            this.lblInvoiceStatus.TabIndex = 19;
            this.lblInvoiceStatus.Text = "Unpaid";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(362, 187);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(131, 29);
            this.lblInvoiceDate.TabIndex = 18;
            this.lblInvoiceDate.Text = "01/01/1800";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.Location = new System.Drawing.Point(362, 118);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(63, 29);
            this.lblInvoiceID.TabIndex = 17;
            this.lblInvoiceID.Text = "[???]";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::CIMS.Properties.Resources.profile;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(52, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Created By:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::CIMS.Properties.Resources.loading;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(52, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Invoice Status:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalAmount.Location = new System.Drawing.Point(362, 325);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(26, 29);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::CIMS.Properties.Resources.face_id;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(52, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::CIMS.Properties.Resources.calendar;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(52, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Invoice Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::CIMS.Properties.Resources.invoice;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(52, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Invoice ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabAddProductToInvoice
            // 
            this.tabAddProductToInvoice.Controls.Add(this.btnDeleteAllProduct);
            this.tabAddProductToInvoice.Controls.Add(this.btnBackTabAddProduct);
            this.tabAddProductToInvoice.Controls.Add(this.label1);
            this.tabAddProductToInvoice.Controls.Add(this.label10);
            this.tabAddProductToInvoice.Controls.Add(this.lblTotalAmount_1);
            this.tabAddProductToInvoice.Controls.Add(this.btnAddProduct);
            this.tabAddProductToInvoice.Controls.Add(this.dgvAllProducts);
            this.tabAddProductToInvoice.Location = new System.Drawing.Point(4, 29);
            this.tabAddProductToInvoice.Name = "tabAddProductToInvoice";
            this.tabAddProductToInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProductToInvoice.Size = new System.Drawing.Size(1028, 550);
            this.tabAddProductToInvoice.TabIndex = 2;
            this.tabAddProductToInvoice.Text = "Add Product To Invoice";
            this.tabAddProductToInvoice.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAllProduct
            // 
            this.btnDeleteAllProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllProduct.Image = global::CIMS.Properties.Resources.delete__1_;
            this.btnDeleteAllProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllProduct.Location = new System.Drawing.Point(15, 13);
            this.btnDeleteAllProduct.Name = "btnDeleteAllProduct";
            this.btnDeleteAllProduct.Size = new System.Drawing.Size(200, 34);
            this.btnDeleteAllProduct.TabIndex = 52;
            this.btnDeleteAllProduct.Text = "Delete All Product";
            this.btnDeleteAllProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllProduct.UseVisualStyleBackColor = true;
            this.btnDeleteAllProduct.Click += new System.EventHandler(this.btnDeleteAllProduct_Click);
            // 
            // btnBackTabAddProduct
            // 
            this.btnBackTabAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTabAddProduct.Image = global::CIMS.Properties.Resources.arrow;
            this.btnBackTabAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTabAddProduct.Location = new System.Drawing.Point(15, 510);
            this.btnBackTabAddProduct.Name = "btnBackTabAddProduct";
            this.btnBackTabAddProduct.Size = new System.Drawing.Size(135, 34);
            this.btnBackTabAddProduct.TabIndex = 47;
            this.btnBackTabAddProduct.Text = "Back";
            this.btnBackTabAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackTabAddProduct.UseVisualStyleBackColor = true;
            this.btnBackTabAddProduct.Click += new System.EventHandler(this.btnBackTabAddProduct_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CIMS.Properties.Resources.receive_amount;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(597, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Total Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Location = new System.Drawing.Point(323, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(375, 39);
            this.label10.TabIndex = 51;
            this.label10.Text = "Add Product To Invoice";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount_1
            // 
            this.lblTotalAmount_1.AutoSize = true;
            this.lblTotalAmount_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount_1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalAmount_1.Location = new System.Drawing.Point(907, 511);
            this.lblTotalAmount_1.Name = "lblTotalAmount_1";
            this.lblTotalAmount_1.Size = new System.Drawing.Size(26, 29);
            this.lblTotalAmount_1.TabIndex = 47;
            this.lblTotalAmount_1.Text = "0";
            this.lblTotalAmount_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.Location = new System.Drawing.Point(854, 6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(168, 46);
            this.btnAddProduct.TabIndex = 50;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.AllowUserToAddRows = false;
            this.dgvAllProducts.AllowUserToDeleteRows = false;
            this.dgvAllProducts.AllowUserToOrderColumns = true;
            this.dgvAllProducts.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllProducts.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvAllProducts.Location = new System.Drawing.Point(6, 58);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProducts.Size = new System.Drawing.Size(1016, 446);
            this.dgvAllProducts.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReadMore,
            this.toolStripSeparator2,
            this.tsmEdit,
            this.tsmDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 148);
            // 
            // tsmReadMore
            // 
            this.tsmReadMore.Image = global::CIMS.Properties.Resources.read_more;
            this.tsmReadMore.Name = "tsmReadMore";
            this.tsmReadMore.Size = new System.Drawing.Size(199, 46);
            this.tsmReadMore.Text = "Read More";
            this.tsmReadMore.Click += new System.EventHandler(this.tsmReadMore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::CIMS.Properties.Resources.edit;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(199, 46);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::CIMS.Properties.Resources.delete;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(199, 46);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::CIMS.Properties.Resources.close_1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(720, 812);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 43);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::CIMS.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(890, 812);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 43);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pBox1
            // 
            this.pBox1.Image = global::CIMS.Properties.Resources.financial_statements;
            this.pBox1.Location = new System.Drawing.Point(426, 12);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(179, 136);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox1.TabIndex = 43;
            this.pBox1.TabStop = false;
            // 
            // frmCreateInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 867);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.lblMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCreateInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Invoices";
            this.Activated += new System.EventHandler(this.frmCreateInvoices_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateInvoices_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateInvoices_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCustomerInfo.ResumeLayout(false);
            this.tabInvoiceInfo.ResumeLayout(false);
            this.tabInvoiceInfo.PerformLayout();
            this.tabAddProductToInvoice.ResumeLayout(false);
            this.tabAddProductToInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCustomerInfo;
        private System.Windows.Forms.TabPage tabInvoiceInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private UserControls.CtrlPerson.CtrlFilterCustomer ctrlFilterCustomer1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnNextToAdd;
        private System.Windows.Forms.TabPage tabAddProductToInvoice;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmReadMore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Button btnBackTabAddProduct;
        private System.Windows.Forms.Button btnBackTabCreateInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount_1;
        private System.Windows.Forms.Button btnDeleteAllProduct;
    }
}