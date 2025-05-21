using System;
using System.Drawing;
using System.Windows.Forms;

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

        private void guna2Button3_Click(object sender, EventArgs e) // Nút Login
        {
            targetX = 0;
            animationTimer.Start();
            this.guna2PictureBox1.Visible=false;
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
            Form1 fr1 = new Form1();
            lgin = true;
            fr1.showfr();
            fr1.Show();
           this.Hide(); 
        }
    }
}