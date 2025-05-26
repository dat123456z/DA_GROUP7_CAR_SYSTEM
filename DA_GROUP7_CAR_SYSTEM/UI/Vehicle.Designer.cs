namespace DA_GROUP7_CAR_SYSTEM
{
    partial class VehicleFr
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Filter = new Guna.UI2.WinForms.Guna2Button();
            this.txtPriceMax = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceMin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtColorFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboBrandFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Cbb_Brand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSaveVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.btn_Addbrand = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Brandname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Updatebrand = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Savebrand = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvBrand);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvVehicle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 745);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle";
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(12, 45);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.RowHeadersWidth = 51;
            this.dgvVehicle.RowTemplate.Height = 24;
            this.dgvVehicle.Size = new System.Drawing.Size(1226, 131);
            this.dgvVehicle.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Savebrand);
            this.panel2.Controls.Add(this.btn_Updatebrand);
            this.panel2.Controls.Add(this.txt_Brandname);
            this.panel2.Controls.Add(this.guna2HtmlLabel6);
            this.panel2.Controls.Add(this.btn_Addbrand);
            this.panel2.Controls.Add(this.btn_Filter);
            this.panel2.Controls.Add(this.txtPriceMax);
            this.panel2.Controls.Add(this.txtPriceMin);
            this.panel2.Controls.Add(this.guna2HtmlLabel5);
            this.panel2.Controls.Add(this.guna2HtmlLabel4);
            this.panel2.Controls.Add(this.txtColorFilter);
            this.panel2.Controls.Add(this.guna2HtmlLabel3);
            this.panel2.Controls.Add(this.cboBrandFilter);
            this.panel2.Controls.Add(this.guna2HtmlLabel2);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Controls.Add(this.Cbb_Brand);
            this.panel2.Controls.Add(this.btnSaveVehicle);
            this.panel2.Controls.Add(this.btnDeleteVehicle);
            this.panel2.Controls.Add(this.btnUpdateVehicle);
            this.panel2.Controls.Add(this.btnAddVehicle);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtVehicleName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 349);
            this.panel2.TabIndex = 1;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Filter.AutoRoundedCorners = true;
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Filter.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(727, 276);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(125, 45);
            this.btn_Filter.TabIndex = 35;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPriceMax.AutoRoundedCorners = true;
            this.txtPriceMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceMax.DefaultText = "";
            this.txtPriceMax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceMax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceMax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPriceMax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceMax.Location = new System.Drawing.Point(727, 229);
            this.txtPriceMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.PlaceholderText = "";
            this.txtPriceMax.SelectedText = "";
            this.txtPriceMax.Size = new System.Drawing.Size(200, 31);
            this.txtPriceMax.TabIndex = 34;
            // 
            // txtPriceMin
            // 
            this.txtPriceMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPriceMin.AutoRoundedCorners = true;
            this.txtPriceMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceMin.DefaultText = "";
            this.txtPriceMin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceMin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceMin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceMin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPriceMin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceMin.Location = new System.Drawing.Point(727, 168);
            this.txtPriceMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceMin.Name = "txtPriceMin";
            this.txtPriceMin.PlaceholderText = "";
            this.txtPriceMin.SelectedText = "";
            this.txtPriceMin.Size = new System.Drawing.Size(200, 31);
            this.txtPriceMin.TabIndex = 33;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(606, 229);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(85, 21);
            this.guna2HtmlLabel5.TabIndex = 32;
            this.guna2HtmlLabel5.Text = "End price:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(578, 177);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(113, 21);
            this.guna2HtmlLabel4.TabIndex = 31;
            this.guna2HtmlLabel4.Text = "Starting price:";
            // 
            // txtColorFilter
            // 
            this.txtColorFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtColorFilter.AutoRoundedCorners = true;
            this.txtColorFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColorFilter.DefaultText = "";
            this.txtColorFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColorFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColorFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColorFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColorFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColorFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtColorFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColorFilter.Location = new System.Drawing.Point(727, 108);
            this.txtColorFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorFilter.Name = "txtColorFilter";
            this.txtColorFilter.PlaceholderText = "";
            this.txtColorFilter.SelectedText = "";
            this.txtColorFilter.Size = new System.Drawing.Size(200, 31);
            this.txtColorFilter.TabIndex = 30;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(639, 109);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 21);
            this.guna2HtmlLabel3.TabIndex = 29;
            this.guna2HtmlLabel3.Text = "Color:";
            // 
            // cboBrandFilter
            // 
            this.cboBrandFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboBrandFilter.AutoRoundedCorners = true;
            this.cboBrandFilter.BackColor = System.Drawing.Color.Transparent;
            this.cboBrandFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBrandFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrandFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBrandFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBrandFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBrandFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboBrandFilter.ItemHeight = 30;
            this.cboBrandFilter.Location = new System.Drawing.Point(727, 52);
            this.cboBrandFilter.Name = "cboBrandFilter";
            this.cboBrandFilter.Size = new System.Drawing.Size(200, 36);
            this.cboBrandFilter.TabIndex = 28;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(631, 52);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 21);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "Brand\r\n:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(689, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(142, 29);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Find Vehicle";
            // 
            // Cbb_Brand
            // 
            this.Cbb_Brand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cbb_Brand.AutoRoundedCorners = true;
            this.Cbb_Brand.BackColor = System.Drawing.Color.Transparent;
            this.Cbb_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cbb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Brand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbb_Brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cbb_Brand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cbb_Brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cbb_Brand.ItemHeight = 30;
            this.Cbb_Brand.Location = new System.Drawing.Point(177, 93);
            this.Cbb_Brand.Name = "Cbb_Brand";
            this.Cbb_Brand.Size = new System.Drawing.Size(200, 36);
            this.Cbb_Brand.TabIndex = 25;
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveVehicle.AutoRoundedCorners = true;
            this.btnSaveVehicle.BackColor = System.Drawing.Color.White;
            this.btnSaveVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveVehicle.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveVehicle.ForeColor = System.Drawing.Color.White;
            this.btnSaveVehicle.Location = new System.Drawing.Point(407, 200);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(125, 45);
            this.btnSaveVehicle.TabIndex = 24;
            this.btnSaveVehicle.Text = "Save";
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteVehicle.AutoRoundedCorners = true;
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteVehicle.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(407, 276);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(125, 45);
            this.btnDeleteVehicle.TabIndex = 23;
            this.btnDeleteVehicle.Text = "Delete";
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateVehicle.AutoRoundedCorners = true;
            this.btnUpdateVehicle.BackColor = System.Drawing.Color.White;
            this.btnUpdateVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateVehicle.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateVehicle.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVehicle.Location = new System.Drawing.Point(407, 123);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(125, 45);
            this.btnUpdateVehicle.TabIndex = 22;
            this.btnUpdateVehicle.Text = "Update";
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddVehicle.AutoRoundedCorners = true;
            this.btnAddVehicle.BackColor = System.Drawing.Color.White;
            this.btnAddVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddVehicle.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddVehicle.ForeColor = System.Drawing.Color.White;
            this.btnAddVehicle.Location = new System.Drawing.Point(407, 40);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(125, 45);
            this.btnAddVehicle.TabIndex = 21;
            this.btnAddVehicle.Text = "Add";
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(177, 271);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 31);
            this.txtQuantity.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity:";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(177, 214);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 31);
            this.txtPrice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price:";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(177, 163);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(200, 31);
            this.txtColor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brand:";
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleName.Location = new System.Drawing.Point(177, 42);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(200, 31);
            this.txtVehicleName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "VehicleName:";
            // 
            // dgvBrand
            // 
            this.dgvBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrand.Location = new System.Drawing.Point(13, 252);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.RowHeadersWidth = 51;
            this.dgvBrand.RowTemplate.Height = 24;
            this.dgvBrand.Size = new System.Drawing.Size(1224, 119);
            this.dgvBrand.TabIndex = 2;
            // 
            // btn_Addbrand
            // 
            this.btn_Addbrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Addbrand.AutoRoundedCorners = true;
            this.btn_Addbrand.BackColor = System.Drawing.Color.White;
            this.btn_Addbrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Addbrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Addbrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Addbrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Addbrand.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Addbrand.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addbrand.ForeColor = System.Drawing.Color.White;
            this.btn_Addbrand.Location = new System.Drawing.Point(1003, 110);
            this.btn_Addbrand.Name = "btn_Addbrand";
            this.btn_Addbrand.Size = new System.Drawing.Size(152, 50);
            this.btn_Addbrand.TabIndex = 36;
            this.btn_Addbrand.Text = "Add brand";
            this.btn_Addbrand.Click += new System.EventHandler(this.btn_Addbrand_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(1020, 11);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(111, 21);
            this.guna2HtmlLabel6.TabIndex = 37;
            this.guna2HtmlLabel6.Text = "Brand Name:";
            // 
            // txt_Brandname
            // 
            this.txt_Brandname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Brandname.AutoRoundedCorners = true;
            this.txt_Brandname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Brandname.DefaultText = "";
            this.txt_Brandname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Brandname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Brandname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Brandname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Brandname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Brandname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Brandname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Brandname.Location = new System.Drawing.Point(981, 55);
            this.txt_Brandname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Brandname.Name = "txt_Brandname";
            this.txt_Brandname.PlaceholderText = "";
            this.txt_Brandname.SelectedText = "";
            this.txt_Brandname.Size = new System.Drawing.Size(200, 31);
            this.txt_Brandname.TabIndex = 38;
            // 
            // btn_Updatebrand
            // 
            this.btn_Updatebrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Updatebrand.AutoRoundedCorners = true;
            this.btn_Updatebrand.BackColor = System.Drawing.Color.White;
            this.btn_Updatebrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Updatebrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Updatebrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Updatebrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Updatebrand.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Updatebrand.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Updatebrand.ForeColor = System.Drawing.Color.White;
            this.btn_Updatebrand.Location = new System.Drawing.Point(1003, 170);
            this.btn_Updatebrand.Name = "btn_Updatebrand";
            this.btn_Updatebrand.Size = new System.Drawing.Size(152, 50);
            this.btn_Updatebrand.TabIndex = 39;
            this.btn_Updatebrand.Text = "Update Brand";
            this.btn_Updatebrand.Click += new System.EventHandler(this.btn_Updatebrand_Click);
            // 
            // btn_Savebrand
            // 
            this.btn_Savebrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Savebrand.AutoRoundedCorners = true;
            this.btn_Savebrand.BackColor = System.Drawing.Color.White;
            this.btn_Savebrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Savebrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Savebrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Savebrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Savebrand.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Savebrand.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Savebrand.ForeColor = System.Drawing.Color.White;
            this.btn_Savebrand.Location = new System.Drawing.Point(1003, 232);
            this.btn_Savebrand.Name = "btn_Savebrand";
            this.btn_Savebrand.Size = new System.Drawing.Size(152, 50);
            this.btn_Savebrand.TabIndex = 40;
            this.btn_Savebrand.Text = "Save Brand";
            this.btn_Savebrand.Click += new System.EventHandler(this.btn_Savebrand_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // VehicleFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleFr";
            this.Text = "Vehicle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSaveVehicle;
        private Guna.UI2.WinForms.Guna2Button btnDeleteVehicle;
        private Guna.UI2.WinForms.Guna2Button btnUpdateVehicle;
        private Guna.UI2.WinForms.Guna2Button btnAddVehicle;
        private Guna.UI2.WinForms.Guna2ComboBox Cbb_Brand;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtColorFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cboBrandFilter;
        private Guna.UI2.WinForms.Guna2Button btn_Filter;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceMax;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceMin;
        private System.Windows.Forms.DataGridView dgvBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btn_Addbrand;
        private Guna.UI2.WinForms.Guna2Button btn_Savebrand;
        private Guna.UI2.WinForms.Guna2Button btn_Updatebrand;
        private Guna.UI2.WinForms.Guna2TextBox txt_Brandname;
        private System.Windows.Forms.Label label2;
    }
}