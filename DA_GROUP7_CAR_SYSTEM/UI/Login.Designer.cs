using Guna.UI2.WinForms;

namespace DA_GROUP7_CAR_SYSTEM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SignIn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelSignUp = new Guna.UI2.WinForms.Guna2Panel();
            this.picBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtEmailAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoginName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelLogin.BorderRadius = 5;
            this.panelLogin.BorderThickness = 2;
            this.panelLogin.Controls.Add(this.guna2PictureBox1);
            this.panelLogin.Controls.Add(this.guna2Button2);
            this.panelLogin.Controls.Add(this.btn_SignIn);
            this.panelLogin.Controls.Add(this.guna2TextBox2);
            this.panelLogin.Controls.Add(this.guna2TextBox1);
            this.panelLogin.Controls.Add(this.guna2HtmlLabel2);
            this.panelLogin.Controls.Add(this.guna2HtmlLabel1);
            this.panelLogin.Location = new System.Drawing.Point(362, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(432, 589);
            this.panelLogin.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.Image = global::DA_GROUP7_CAR_SYSTEM.Properties.Resources.logo_audi1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-17, -16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(495, 633);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Visible = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.Red;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Red;
            this.guna2Button2.Location = new System.Drawing.Point(233, 409);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(126, 45);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "Sign up";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Animated = true;
            this.btn_SignIn.AutoRoundedCorners = true;
            this.btn_SignIn.BorderThickness = 1;
            this.btn_SignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SignIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(74, 409);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(126, 45);
            this.btn_SignIn.TabIndex = 7;
            this.btn_SignIn.Text = "Sign in";
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox2.BorderRadius = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconLeft = global::DA_GROUP7_CAR_SYSTEM.Properties.Resources._lock;
            this.guna2TextBox2.Location = new System.Drawing.Point(74, 329);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBox2.PlaceholderText = "**************";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(285, 48);
            this.guna2TextBox2.TabIndex = 6;
            this.guna2TextBox2.UseSystemPasswordChar = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(32, 32);
            this.guna2TextBox1.Location = new System.Drawing.Point(74, 253);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2TextBox1.PlaceholderText = "Login name...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(285, 48);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(109, 192);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(214, 30);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "or use your account info";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(100, 132);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(223, 47);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Sign in to App";
            // 
            // panelSignUp
            // 
            this.panelSignUp.BorderColor = System.Drawing.Color.Red;
            this.panelSignUp.BorderRadius = 5;
            this.panelSignUp.BorderThickness = 2;
            this.panelSignUp.Controls.Add(this.picBox);
            this.panelSignUp.Controls.Add(this.txtEmailAddress);
            this.panelSignUp.Controls.Add(this.btnSignIn);
            this.panelSignUp.Controls.Add(this.txtAddress);
            this.panelSignUp.Controls.Add(this.txtPhoneNumber);
            this.panelSignUp.Controls.Add(this.txtPassword);
            this.panelSignUp.Controls.Add(this.txtLoginName);
            this.panelSignUp.Controls.Add(this.guna2HtmlLabel3);
            this.panelSignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSignUp.Location = new System.Drawing.Point(0, 0);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(356, 589);
            this.panelSignUp.TabIndex = 2;
            this.panelSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignUp_Paint);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BorderRadius = 30;
            this.picBox.Image = global::DA_GROUP7_CAR_SYSTEM.Properties.Resources.car1;
            this.picBox.ImageRotate = 0F;
            this.picBox.Location = new System.Drawing.Point(-41, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(406, 633);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 14;
            this.picBox.TabStop = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderColor = System.Drawing.Color.Black;
            this.txtEmailAddress.BorderRadius = 5;
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.DefaultText = "";
            this.txtEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddress.Location = new System.Drawing.Point(40, 434);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmailAddress.PlaceholderText = "E-Mail Address";
            this.txtEmailAddress.SelectedText = "";
            this.txtEmailAddress.Size = new System.Drawing.Size(285, 48);
            this.txtEmailAddress.TabIndex = 14;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Animated = true;
            this.btnSignIn.AutoRoundedCorners = true;
            this.btnSignIn.BorderThickness = 2;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.LightCoral;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(35, 503);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(285, 45);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(40, 357);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(285, 48);
            this.txtAddress.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.BorderRadius = 5;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(40, 282);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhoneNumber.PlaceholderText = "Phone number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(285, 48);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(40, 207);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PlaceholderText = "password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(285, 48);
            this.txtPassword.TabIndex = 10;
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderColor = System.Drawing.Color.Black;
            this.txtLoginName.BorderRadius = 5;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.DefaultText = "";
            this.txtLoginName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginName.Location = new System.Drawing.Point(40, 132);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Padding = new System.Windows.Forms.Padding(5);
            this.txtLoginName.PlaceholderText = "Login name...";
            this.txtLoginName.SelectedText = "";
            this.txtLoginName.Size = new System.Drawing.Size(285, 48);
            this.txtLoginName.TabIndex = 9;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(40, 65);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(280, 39);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Sign Up New Account";
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 589);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelLogin;
        private Guna2TextBox txtPassword;
        private Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button btn_SignIn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel panelSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2TextBox txtAddress;
        private Guna2Button btnSignIn;
        private Guna2PictureBox picBox;
        private System.Windows.Forms.Timer animationTimer;
        private Guna2TextBox txtEmailAddress;
        private Guna2PictureBox guna2PictureBox1;
    }
}