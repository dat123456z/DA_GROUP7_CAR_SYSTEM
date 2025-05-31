using System;
using System.Drawing;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.BSLayer;
using System.Linq;
using DA_GROUP7_CAR_SYSTEM.UI;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class Login : Form
    {
        private int targetX;
        private const int ANIMATION_STEP = 5;
        public bool lgin = false;
        public Login()
        {
            InitializeComponent();
            InitializeAnimationTimer();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new Timer
            {
                Interval = 20
            };
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e) // Nút Sign Up
        {
            targetX = this.ClientSize.Width - picBox.Width;
            animationTimer.Start();
            this.guna2PictureBox1.Visible = true;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (picBox.Left < targetX)
            {
                // Di chuyển sang phải
                picBox.Left += ANIMATION_STEP;
                if (picBox.Left >= targetX)
                {
                    picBox.Left = targetX;
                    FinishAnimation();
                }
            }
            else if (picBox.Left > targetX)
            {
                // Di chuyển sang trái
                picBox.Left -= ANIMATION_STEP;
                if (picBox.Left <= targetX)
                {
                    picBox.Left = targetX;
                    FinishAnimation();
                }
            }
        }

        private void FinishAnimation()
        {
            animationTimer.Stop();


        }

        private void panelSignUp_Paint(object sender, PaintEventArgs e)
        {
            // Có thể thêm custom painting nếu cần
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string loginName = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;
            string error = "";

            while (loginName == "" || password == "")
            {
                MessageBox.Show("Please enter your account and password!", "Error");
                return;
            }
            BLLogin blLogin = new BLLogin();
            if (blLogin.CheckLogin(loginName, password, ref error))
            {
                FormPage fr1 = new FormPage(loginName);
                lgin = true;
                fr1.showfr();
                fr1.Show();
                this.Hide();
            }else if(loginName == "admin" && password == "admin")
            {
                FRMain fr1 = new FRMain();
                lgin = true;
                fr1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string loginName = txtLoginName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmailAddress.Text.Trim();
            string error = "";

            if (string.IsNullOrEmpty(loginName) || string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address) || 
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate phone number format (assuming Vietnamese phone number)
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Phone number is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BLSignUp blSignUp = new BLSignUp();

            bool isValid = blSignUp.CheckLogin(loginName, password, phoneNumber, address, email, ref error);
            if (isValid)
            {
                MessageBox.Show("Registration successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear input fields
                txtLoginName.Text = "";
                txtPassword.Text = "";
                txtPhoneNumber.Text = "";
                txtAddress.Text = "";
                txtEmailAddress.Text = "";
                
                // Switch back to login state
                targetX = 0;
                animationTimer.Start();
                this.guna2PictureBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Registration failed! " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Remove any spaces or special characters
            phoneNumber = new string(phoneNumber.Where(c => char.IsDigit(c)).ToArray());
            
            // Check if it's a valid Vietnamese phone number
            // Vietnamese phone numbers typically start with 03, 05, 07, 08, 09 and have 10 digits
            return phoneNumber.Length == 10 && 
                   (phoneNumber.StartsWith("03") || phoneNumber.StartsWith("05") || 
                    phoneNumber.StartsWith("07") || phoneNumber.StartsWith("08") || 
                    phoneNumber.StartsWith("09"));
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            targetX = 0;
            animationTimer.Start();
            this.guna2PictureBox1.Visible = false;
        }
    }
}