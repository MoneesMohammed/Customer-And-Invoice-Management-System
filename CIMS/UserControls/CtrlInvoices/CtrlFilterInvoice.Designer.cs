namespace CIMS.UserControls.CtrlInvoices
{
    partial class CtrlFilterInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlFilterInvoice));
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.txtFindBy = new System.Windows.Forms.TextBox();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlInvoiceInfo1 = new CIMS.UserControls.CtrlInvoices.CtrlInvoiceInfo();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.label1);
            this.gbFind.Controls.Add(this.btnSearchInvoice);
            this.gbFind.Controls.Add(this.txtFindBy);
            this.gbFind.Controls.Add(this.cbFindBy);
            this.gbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFind.Location = new System.Drawing.Point(3, 3);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(954, 82);
            this.gbFind.TabIndex = 5;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Find By :";
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchInvoice.Image")));
            this.btnSearchInvoice.Location = new System.Drawing.Point(692, 25);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(66, 43);
            this.btnSearchInvoice.TabIndex = 19;
            this.btnSearchInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // txtFindBy
            // 
            this.txtFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindBy.Location = new System.Drawing.Point(373, 34);
            this.txtFindBy.Name = "txtFindBy";
            this.txtFindBy.Size = new System.Drawing.Size(236, 29);
            this.txtFindBy.TabIndex = 19;
            this.txtFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindBy_KeyPress);
            this.txtFindBy.Validating += new System.ComponentModel.CancelEventHandler(this.txtFindBy_Validating);
            // 
            // cbFindBy
            // 
            this.cbFindBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Items.AddRange(new object[] {
            "Invoice ID"});
            this.cbFindBy.Location = new System.Drawing.Point(112, 34);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(231, 28);
            this.cbFindBy.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlInvoiceInfo1
            // 
            this.ctrlInvoiceInfo1.Location = new System.Drawing.Point(3, 91);
            this.ctrlInvoiceInfo1.Name = "ctrlInvoiceInfo1";
            this.ctrlInvoiceInfo1.Size = new System.Drawing.Size(965, 802);
            this.ctrlInvoiceInfo1.TabIndex = 6;
            this.ctrlInvoiceInfo1.Load += new System.EventHandler(this.ctrlInvoiceInfo1_Load);
            // 
            // CtrlFilterInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlInvoiceInfo1);
            this.Controls.Add(this.gbFind);
            this.Name = "CtrlFilterInvoice";
            this.Size = new System.Drawing.Size(968, 898);
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TextBox txtFindBy;
        private System.Windows.Forms.ComboBox cbFindBy;
        private CtrlInvoiceInfo ctrlInvoiceInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
