namespace DA_GROUP7_CAR_SYSTEM.UI
{
    partial class ReportAnnual
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
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(521, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 92);
            this.label1.TabIndex = 7;
            this.label1.Text = "MONTHLY\r\nREPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSalary.Location = new System.Drawing.Point(477, 143);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(256, 26);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "EMPLOYEE SALARY TABLE";
            // 
            // lblInvoice
            // 
            this.lblInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Arial Narrow", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInvoice.Location = new System.Drawing.Point(477, 403);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(260, 26);
            this.lblInvoice.TabIndex = 5;
            this.lblInvoice.Text = "CAR SALES INVOICE TABLE";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::DA_GROUP7_CAR_SYSTEM.Properties.Resources._666bl;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(54, 29);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(178, 116);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dgvSalary
            // 
            this.dgvSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.ColumnHeadersHeight = 29;
            this.dgvSalary.Location = new System.Drawing.Point(54, 196);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSalary.Size = new System.Drawing.Size(1149, 188);
            this.dgvSalary.TabIndex = 9;
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.ColumnHeadersHeight = 29;
            this.dgvInvoice.Location = new System.Drawing.Point(54, 451);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInvoice.Size = new System.Drawing.Size(1149, 198);
            this.dgvInvoice.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoad.Location = new System.Drawing.Point(990, 29);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 44);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "VIEW REPORT";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbbMonth
            // 
            this.cbbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.Location = new System.Drawing.Point(938, 97);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(80, 24);
            this.cbbMonth.TabIndex = 12;
            // 
            // cbbYear
            // 
            this.cbbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYear.Location = new System.Drawing.Point(1042, 97);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(100, 24);
            this.cbbYear.TabIndex = 13;
            // 
            // ReportAnnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 698);
            this.Controls.Add(this.cbbYear);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.dgvSalary);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.label1);
            this.Name = "ReportAnnual";
            this.Text = "ReportAnnual";
            this.Load += new System.EventHandler(this.ReportAnnual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblInvoice;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbYear;
    }
}