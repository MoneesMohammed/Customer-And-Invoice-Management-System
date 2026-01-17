namespace CIMS.UserControls.CtrlProduct
{
    partial class CtrlProductInfo
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
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.llblEditProductInfo = new System.Windows.Forms.LinkLabel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.gbProductInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.lblQuantityInStock);
            this.gbProductInformation.Controls.Add(this.label4);
            this.gbProductInformation.Controls.Add(this.llblEditProductInfo);
            this.gbProductInformation.Controls.Add(this.pbProductImage);
            this.gbProductInformation.Controls.Add(this.lblPrice);
            this.gbProductInformation.Controls.Add(this.lblDescription);
            this.gbProductInformation.Controls.Add(this.lblName);
            this.gbProductInformation.Controls.Add(this.lblProductID);
            this.gbProductInformation.Controls.Add(this.label5);
            this.gbProductInformation.Controls.Add(this.label6);
            this.gbProductInformation.Controls.Add(this.label3);
            this.gbProductInformation.Controls.Add(this.label1);
            this.gbProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductInformation.Location = new System.Drawing.Point(3, 3);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(795, 439);
            this.gbProductInformation.TabIndex = 2;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Product Information";
            // 
            // llblEditProductInfo
            // 
            this.llblEditProductInfo.AutoSize = true;
            this.llblEditProductInfo.Enabled = false;
            this.llblEditProductInfo.Location = new System.Drawing.Point(555, 228);
            this.llblEditProductInfo.Name = "llblEditProductInfo";
            this.llblEditProductInfo.Size = new System.Drawing.Size(128, 20);
            this.llblEditProductInfo.TabIndex = 19;
            this.llblEditProductInfo.TabStop = true;
            this.llblEditProductInfo.Text = "Edit Product Info";
            this.llblEditProductInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditProductInfo_LinkClicked);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(232, 159);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 24);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "[???]";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(232, 283);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(552, 135);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "[???]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(227, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "[???]";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(232, 44);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(42, 24);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "N/A";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Image = global::CIMS.Properties.Resources.product_default;
            this.pbProductImage.Location = new System.Drawing.Point(439, 25);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(345, 191);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 18;
            this.pbProductImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::CIMS.Properties.Resources.best_price;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::CIMS.Properties.Resources.edit_info;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(22, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::CIMS.Properties.Resources.tag;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CIMS.Properties.Resources.tag__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::CIMS.Properties.Resources.in_stock;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(18, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantity In Stock :";
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityInStock.Location = new System.Drawing.Point(232, 228);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(50, 24);
            this.lblQuantityInStock.TabIndex = 21;
            this.lblQuantityInStock.Text = "[???]";
            // 
            // CtrlProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbProductInformation);
            this.Name = "CtrlProductInfo";
            this.Size = new System.Drawing.Size(803, 448);
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.LinkLabel llblEditProductInfo;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.Label label4;
    }
}
