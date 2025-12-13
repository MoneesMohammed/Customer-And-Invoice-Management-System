namespace CIMS.UserControls.CtrlCustomer
{
    partial class CtrlPersonInfo
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
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.llblEditCustomerInfo = new System.Windows.Forms.LinkLabel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCustomerImage = new System.Windows.Forms.PictureBox();
            this.gbCustomerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.llblEditCustomerInfo);
            this.gbCustomerInformation.Controls.Add(this.pbCustomerImage);
            this.gbCustomerInformation.Controls.Add(this.lblPhone);
            this.gbCustomerInformation.Controls.Add(this.lblcountry);
            this.gbCustomerInformation.Controls.Add(this.label15);
            this.gbCustomerInformation.Controls.Add(this.lblDateOfBirth);
            this.gbCustomerInformation.Controls.Add(this.label17);
            this.gbCustomerInformation.Controls.Add(this.label18);
            this.gbCustomerInformation.Controls.Add(this.lblEmail);
            this.gbCustomerInformation.Controls.Add(this.lblAddress);
            this.gbCustomerInformation.Controls.Add(this.lblGendor);
            this.gbCustomerInformation.Controls.Add(this.lblName);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerID);
            this.gbCustomerInformation.Controls.Add(this.label5);
            this.gbCustomerInformation.Controls.Add(this.label6);
            this.gbCustomerInformation.Controls.Add(this.label3);
            this.gbCustomerInformation.Controls.Add(this.label4);
            this.gbCustomerInformation.Controls.Add(this.label1);
            this.gbCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerInformation.Location = new System.Drawing.Point(3, 3);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(1010, 329);
            this.gbCustomerInformation.TabIndex = 1;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Customer Information";
            // 
            // llblEditCustomerInfo
            // 
            this.llblEditCustomerInfo.AutoSize = true;
            this.llblEditCustomerInfo.Enabled = false;
            this.llblEditCustomerInfo.Location = new System.Drawing.Point(829, 39);
            this.llblEditCustomerInfo.Name = "llblEditCustomerInfo";
            this.llblEditCustomerInfo.Size = new System.Drawing.Size(142, 20);
            this.llblEditCustomerInfo.TabIndex = 19;
            this.llblEditCustomerInfo.TabStop = true;
            this.llblEditCustomerInfo.Text = "Edit Customer Info";
            this.llblEditCustomerInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEditCustomerInfo_LinkClicked);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(636, 190);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(120, 24);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "[??????????]";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(636, 238);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(50, 24);
            this.lblcountry.TabIndex = 16;
            this.lblcountry.Text = "[???]";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::CIMS.Properties.Resources.europe;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(482, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 27);
            this.label15.TabIndex = 15;
            this.label15.Text = "Country :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(636, 150);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(110, 24);
            this.lblDateOfBirth.TabIndex = 14;
            this.lblDateOfBirth.Text = "[????/??/??]";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = global::CIMS.Properties.Resources.telephone_call;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(491, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 24);
            this.label17.TabIndex = 13;
            this.label17.Text = "Phone :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = global::CIMS.Properties.Resources.calendar;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(438, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 27);
            this.label18.TabIndex = 12;
            this.label18.Text = "Date Of Birth  :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(200, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 24);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "[???]";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(200, 273);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 24);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "[???]";
            // 
            // lblGendor
            // 
            this.lblGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.Image = global::CIMS.Properties.Resources.Male;
            this.lblGendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGendor.Location = new System.Drawing.Point(156, 150);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(145, 27);
            this.lblGendor.TabIndex = 8;
            this.lblGendor.Text = "Male";
            this.lblGendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(203, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "[???]";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(203, 44);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(50, 24);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "[???]";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::CIMS.Properties.Resources.arroba;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(23, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::CIMS.Properties.Resources.info;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(23, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::CIMS.Properties.Resources.business_card;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(23, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gendor :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CIMS.Properties.Resources.face_id;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCustomerImage
            // 
            this.pbCustomerImage.Image = global::CIMS.Properties.Resources.man;
            this.pbCustomerImage.Location = new System.Drawing.Point(798, 82);
            this.pbCustomerImage.Name = "pbCustomerImage";
            this.pbCustomerImage.Size = new System.Drawing.Size(200, 231);
            this.pbCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomerImage.TabIndex = 18;
            this.pbCustomerImage.TabStop = false;
            // 
            // CtrlCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCustomerInformation);
            this.Name = "CtrlCustomerInfo";
            this.Size = new System.Drawing.Size(1021, 343);
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.LinkLabel llblEditCustomerInfo;
        private System.Windows.Forms.PictureBox pbCustomerImage;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
