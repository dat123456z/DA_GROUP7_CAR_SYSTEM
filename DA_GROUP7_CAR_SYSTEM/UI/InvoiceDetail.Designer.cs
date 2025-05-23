namespace DA_GROUP7_CAR_SYSTEM
{
    partial class InvoiceDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSaveInvoiceDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteInvoiceDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateInvoiceDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddInvoiceDetail = new Guna.UI2.WinForms.Guna2Button();
            this.txtLineTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtVehicleID);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.btnSaveInvoiceDetail);
            this.panel1.Controls.Add(this.btnDeleteInvoiceDetail);
            this.panel1.Controls.Add(this.btnUpdateInvoiceDetail);
            this.panel1.Controls.Add(this.btnAddInvoiceDetail);
            this.panel1.Controls.Add(this.txtLineTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInvoiceID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 745);
            this.panel1.TabIndex = 2;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVehicleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.Location = new System.Drawing.Point(163, 150);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(213, 31);
            this.txtVehicleID.TabIndex = 38;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(163, 205);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(213, 31);
            this.txtQuantity.TabIndex = 37;
            // 
            // btnSaveInvoiceDetail
            // 
            this.btnSaveInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveInvoiceDetail.AutoRoundedCorners = true;
            this.btnSaveInvoiceDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveInvoiceDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveInvoiceDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveInvoiceDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveInvoiceDetail.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveInvoiceDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveInvoiceDetail.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoiceDetail.Location = new System.Drawing.Point(241, 532);
            this.btnSaveInvoiceDetail.Name = "btnSaveInvoiceDetail";
            this.btnSaveInvoiceDetail.Size = new System.Drawing.Size(135, 59);
            this.btnSaveInvoiceDetail.TabIndex = 36;
            this.btnSaveInvoiceDetail.Text = "Save";
            this.btnSaveInvoiceDetail.Click += new System.EventHandler(this.btnSaveDetail_Click);
            // 
            // btnDeleteInvoiceDetail
            // 
            this.btnDeleteInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteInvoiceDetail.AutoRoundedCorners = true;
            this.btnDeleteInvoiceDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteInvoiceDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteInvoiceDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteInvoiceDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteInvoiceDetail.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteInvoiceDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteInvoiceDetail.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoiceDetail.Location = new System.Drawing.Point(45, 532);
            this.btnDeleteInvoiceDetail.Name = "btnDeleteInvoiceDetail";
            this.btnDeleteInvoiceDetail.Size = new System.Drawing.Size(135, 59);
            this.btnDeleteInvoiceDetail.TabIndex = 35;
            this.btnDeleteInvoiceDetail.Text = "Delete";
            this.btnDeleteInvoiceDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnUpdateInvoiceDetail
            // 
            this.btnUpdateInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateInvoiceDetail.AutoRoundedCorners = true;
            this.btnUpdateInvoiceDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInvoiceDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInvoiceDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateInvoiceDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateInvoiceDetail.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateInvoiceDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateInvoiceDetail.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInvoiceDetail.Location = new System.Drawing.Point(241, 427);
            this.btnUpdateInvoiceDetail.Name = "btnUpdateInvoiceDetail";
            this.btnUpdateInvoiceDetail.Size = new System.Drawing.Size(135, 59);
            this.btnUpdateInvoiceDetail.TabIndex = 34;
            this.btnUpdateInvoiceDetail.Text = "Update";
            this.btnUpdateInvoiceDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnAddInvoiceDetail
            // 
            this.btnAddInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddInvoiceDetail.AutoRoundedCorners = true;
            this.btnAddInvoiceDetail.BackColor = System.Drawing.Color.White;
            this.btnAddInvoiceDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInvoiceDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInvoiceDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddInvoiceDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddInvoiceDetail.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddInvoiceDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddInvoiceDetail.ForeColor = System.Drawing.Color.White;
            this.btnAddInvoiceDetail.Location = new System.Drawing.Point(48, 427);
            this.btnAddInvoiceDetail.Name = "btnAddInvoiceDetail";
            this.btnAddInvoiceDetail.Size = new System.Drawing.Size(135, 59);
            this.btnAddInvoiceDetail.TabIndex = 33;
            this.btnAddInvoiceDetail.Text = "Add";
            this.btnAddInvoiceDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // txtLineTotal
            // 
            this.txtLineTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLineTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineTotal.Location = new System.Drawing.Point(163, 336);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(213, 31);
            this.txtLineTotal.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "LineTotal:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(163, 272);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(213, 31);
            this.txtUnitPrice.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "UnitPrice:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "VehicleID:";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceID.Location = new System.Drawing.Point(163, 86);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(213, 31);
            this.txtInvoiceID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "InvoiceID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvInvoiceDetail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(421, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 745);
            this.panel2.TabIndex = 3;
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(23, 59);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            this.dgvInvoiceDetail.RowHeadersWidth = 51;
            this.dgvInvoiceDetail.RowTemplate.Height = 24;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(755, 614);
            this.dgvInvoiceDetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "InvoiceDetail";
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceDetail";
            this.Text = "InvoiceDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2Button btnSaveInvoiceDetail;
        private Guna.UI2.WinForms.Guna2Button btnDeleteInvoiceDetail;
        private Guna.UI2.WinForms.Guna2Button btnUpdateInvoiceDetail;
        private Guna.UI2.WinForms.Guna2Button btnAddInvoiceDetail;
        private System.Windows.Forms.TextBox txtLineTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInvoiceDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehicleID;
    }
}