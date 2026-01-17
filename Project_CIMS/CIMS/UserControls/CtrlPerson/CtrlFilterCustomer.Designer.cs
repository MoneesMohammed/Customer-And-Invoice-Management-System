namespace CIMS.UserControls.CtrlPerson
{
    partial class CtrlFilterCustomer
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
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtFindBy = new System.Windows.Forms.TextBox();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonInfo1 = new CIMS.UserControls.CtrlCustomer.CtrlPersonInfo();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.label1);
            this.gbFind.Controls.Add(this.btnAddNewCustomer);
            this.gbFind.Controls.Add(this.btnSearchCustomer);
            this.gbFind.Controls.Add(this.txtFindBy);
            this.gbFind.Controls.Add(this.cbFindBy);
            this.gbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFind.Location = new System.Drawing.Point(3, 3);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(1011, 100);
            this.gbFind.TabIndex = 4;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Find By :";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.Image = global::CIMS.Properties.Resources.add_user_1;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(801, 38);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(66, 43);
            this.btnAddNewCustomer.TabIndex = 20;
            this.btnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = global::CIMS.Properties.Resources.user_avatar;
            this.btnSearchCustomer.Location = new System.Drawing.Point(702, 38);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(66, 43);
            this.btnSearchCustomer.TabIndex = 19;
            this.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtFindBy
            // 
            this.txtFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindBy.Location = new System.Drawing.Point(383, 47);
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
            "Customer ID"});
            this.cbFindBy.Location = new System.Drawing.Point(122, 47);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(231, 28);
            this.cbFindBy.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(3, 109);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(1021, 339);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // CtrlFilterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFind);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "CtrlFilterCustomer";
            this.Size = new System.Drawing.Size(1024, 451);
            this.Load += new System.EventHandler(this.CtrlFilterCustomer_Load);
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlCustomer.CtrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtFindBy;
        private System.Windows.Forms.ComboBox cbFindBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
