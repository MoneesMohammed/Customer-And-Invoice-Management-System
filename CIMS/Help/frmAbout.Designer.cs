namespace CIMS.Help
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llblGitHub = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.llbllinkedin = new System.Windows.Forms.LinkLabel();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.piclinkedin = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclinkedin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 489);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(348, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "About";
            // 
            // llblGitHub
            // 
            this.llblGitHub.AutoSize = true;
            this.llblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblGitHub.Location = new System.Drawing.Point(29, 725);
            this.llblGitHub.Name = "llblGitHub";
            this.llblGitHub.Size = new System.Drawing.Size(78, 25);
            this.llblGitHub.TabIndex = 2;
            this.llblGitHub.TabStop = true;
            this.llblGitHub.Text = "GitHub";
            this.llblGitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(153, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer And Invoice Management System";
            // 
            // llbllinkedin
            // 
            this.llbllinkedin.AutoSize = true;
            this.llbllinkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbllinkedin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbllinkedin.Location = new System.Drawing.Point(197, 725);
            this.llbllinkedin.Name = "llbllinkedin";
            this.llbllinkedin.Size = new System.Drawing.Size(86, 25);
            this.llbllinkedin.TabIndex = 5;
            this.llbllinkedin.TabStop = true;
            this.llbllinkedin.Text = "linkedin";
            this.llbllinkedin.Click += new System.EventHandler(this.linkedin_Click);
            // 
            // picGitHub
            // 
            this.picGitHub.Image = global::CIMS.Properties.Resources.github;
            this.picGitHub.Location = new System.Drawing.Point(18, 659);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(100, 50);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.TabIndex = 7;
            this.picGitHub.TabStop = false;
            this.picGitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // piclinkedin
            // 
            this.piclinkedin.Image = global::CIMS.Properties.Resources.linkedin;
            this.piclinkedin.Location = new System.Drawing.Point(192, 659);
            this.piclinkedin.Name = "piclinkedin";
            this.piclinkedin.Size = new System.Drawing.Size(100, 50);
            this.piclinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclinkedin.TabIndex = 6;
            this.piclinkedin.TabStop = false;
            this.piclinkedin.Click += new System.EventHandler(this.linkedin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(90, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact links";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 787);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picGitHub);
            this.Controls.Add(this.piclinkedin);
            this.Controls.Add(this.llbllinkedin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.llblGitHub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclinkedin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llblGitHub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbllinkedin;
        private System.Windows.Forms.PictureBox piclinkedin;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.Label label4;
    }
}