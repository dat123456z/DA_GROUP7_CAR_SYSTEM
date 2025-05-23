using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class FormPage : Form
    {
        //1. Khai báo biến (field) ở đầu class
        private string projectRoot;
        private string carImageFolder;

        //2. Hàm helper để lấy đường dẫn ảnh
        private string GetCarImagePath(string fileName)
        {
            return Path.Combine(carImageFolder, fileName);
        }

        int cpt = 1;
        Dictionary<Control, Rectangle> originalBounds = new Dictionary<Control, Rectangle>();
        Size originalFormSize;


        public FormPage(string loginName)
        {
            InitializeComponent();
            label1.Text = loginName;
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.FullName;
            carImageFolder = Path.Combine(projectRoot, "Car_Audi");


            gunaDataGridView1.Rows.Add(8);
            gunaDataGridView1.Rows[0].Cells[0].Value = Image.FromFile(GetCarImagePath("1.png"));
            gunaDataGridView1.Rows[1].Cells[0].Value = Image.FromFile(GetCarImagePath("2.png"));
            gunaDataGridView1.Rows[2].Cells[0].Value = Image.FromFile(GetCarImagePath("3.png"));
            gunaDataGridView1.Rows[3].Cells[0].Value = Image.FromFile(GetCarImagePath("4.png"));
            gunaDataGridView1.Rows[4].Cells[0].Value = Image.FromFile(GetCarImagePath("5.png"));
            gunaDataGridView1.Rows[5].Cells[0].Value = Image.FromFile(GetCarImagePath("6.png"));
            gunaDataGridView1.Rows[6].Cells[0].Value = Image.FromFile(GetCarImagePath("7.png"));
            gunaDataGridView1.Rows[7].Cells[0].Value = Image.FromFile(GetCarImagePath("8.png"));


            gunaDataGridView1.Rows[0].Cells[1].Value = "Audi RS 7";
            gunaDataGridView1.Rows[1].Cells[1].Value = "Audi RS 5";
            gunaDataGridView1.Rows[2].Cells[1].Value = "Audi Q3";
            gunaDataGridView1.Rows[3].Cells[1].Value = "Audi A3";
            gunaDataGridView1.Rows[4].Cells[1].Value = "Audi A4";
            gunaDataGridView1.Rows[5].Cells[1].Value = "Audi A5";
            gunaDataGridView1.Rows[6].Cells[1].Value = "Audi R8 Spyder";
            gunaDataGridView1.Rows[7].Cells[1].Value = "Audi TTS Coupe";
            originalFormSize = this.Size;

            SaveOriginalBounds(this);

            // Gắn sự kiện resize
            this.Resize += Form1_Resize;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            ResizeAllControls(this, xRatio, yRatio);
        }

        private void ResizeAllControls(Control parent, float xRatio, float yRatio)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (originalBounds.ContainsKey(ctrl))
                {
                    Rectangle original = originalBounds[ctrl];
                    ctrl.SetBounds(
                        (int)(original.X * xRatio),
                        (int)(original.Y * yRatio),
                        (int)(original.Width * xRatio),
                        (int)(original.Height * yRatio)
                    );
                }

                if (ctrl.HasChildren)
                    ResizeAllControls(ctrl, xRatio, yRatio); // đệ quy
            }
        }

        private void SaveOriginalBounds(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                originalBounds[ctrl] = ctrl.Bounds;

                if (ctrl.HasChildren)
                    SaveOriginalBounds(ctrl); // gọi đệ quy để lưu tất cả control trong panel
            }
        }



        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < gunaDataGridView1.Rows.Count)
            {
                cpt++;
                if (cpt == 9)
                {
                    cpt = 1;
                }
                gunaPictureBox_Car.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                gunaLabel_name.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                switch (gunaLabel_name.Text)
                {
                    case "Audi RS 7":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 600 hp / 441 kW  \r\nFiscal horsepower: 53 CV  \r\nCombined fuel consumption: 11.4 L/100 km  \r\nCO2 emissions: 261 g/km  \r\nTransmission: Automatic  \r\n";
                        gunaLabel6.Text = "305 Km/h";
                        gunaLabel7.Text = "600 hp / 441 kW";
                        gunaLabel8.Text = "9.2/10";
                        gunaLabel9.Text = "125000$";

                        break;

                    case "Audi RS 5":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 444 hp / 331 kW  \r\nFiscal horsepower: ~40 CV  \r\nCombined fuel consumption: 9.4 L/100 km  \r\nCO2 emissions: 215 g/km  \r\nTransmission: 8-speed automatic";
                        gunaLabel6.Text = "280 Km/h";
                        gunaLabel7.Text = "444 hp / 331 kW";
                        gunaLabel8.Text = "8.8/10";
                        gunaLabel9.Text = "80000$";

                        break;
                    case "Audi Q3":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 228 hp / 169 kW  \r\nFiscal horsepower: ~17 CV  \r\nCombined fuel consumption: 9.8 L/100 km  \r\nCO2 emissions: 223 g/km  \r\nTransmission: 8-speed automatic  ";
                        gunaLabel6.Text = "210 Km/h";
                        gunaLabel7.Text = "228 hp / 169 kW";
                        gunaLabel8.Text = "7.5/10";
                        gunaLabel9.Text = "38000$";

                        break;
                    case "Audi A3":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 201 hp / 150 kW  \r\nFiscal horsepower: ~15 CV  \r\nCombined fuel consumption: 7.1 L/100 km  \r\nCO2 emissions: 163 g/km  \r\nTransmission: 7-speed automatic";
                        gunaLabel6.Text = "240 Km/h";
                        gunaLabel7.Text = "201 hp / 150 kW";
                        gunaLabel8.Text = "7.8/10";
                        gunaLabel9.Text = "35000$";

                        break;
                    case "Audi A4":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 261 hp / 194 kW  \r\nFiscal horsepower: ~19 CV  \r\nCombined fuel consumption: 8.5 L/100 km  \r\nCO2 emissions: 195 g/km  \r\nTransmission: 7-speed automatic ";
                        gunaLabel6.Text = "250 Km/h";
                        gunaLabel7.Text = "261 hp / 194 kW";
                        gunaLabel8.Text = "8.0/10";
                        gunaLabel9.Text = "42000$";

                        break;
                    case "Audi A5":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 261 hp / 194 kW  \r\nFiscal horsepower: ~19 CV  \r\nCombined fuel consumption: 8.5 L/100 km  \r\nCO2 emissions: 195 g/km  \r\nTransmission: 7-speed automatic";
                        gunaLabel6.Text = "250 Km/h";
                        gunaLabel7.Text = "261 hp / 194 kW";
                        gunaLabel8.Text = "8.2/10";
                        gunaLabel9.Text = "46000$";

                        break;
                    case "Audi R8 Spyder":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 602 hp / 449 kW  \r\nFiscal horsepower: ~50 CV  \r\nCombined fuel consumption: 13.5 L/100 km  \r\nCO2 emissions: 312 g/km  \r\nTransmission: 7-speed automatic ";
                        gunaLabel6.Text = "330 Km/h";
                        gunaLabel7.Text = "602 hp / 449 kW";
                        gunaLabel8.Text = "9.7/10";
                        gunaLabel9.Text = "160000$";

                        break;
                    case "Audi TTS Coupe":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 320 hp / 235 kW  \r\nFiscal horsepower: ~24 CV  \r\nCombined fuel consumption: 8.3 L/100 km  \r\nCO2 emissions: 189 g/km  \r\nTransmission: 7-speed automatic";
                        gunaLabel6.Text = "250 Km/h";
                        gunaLabel7.Text = "320 hp / 235 kW";
                        gunaLabel8.Text = "8.5/10";
                        gunaLabel9.Text = "62000$";


                        break;
                    default:
                        gunaLabel1.Text = "Specification not available.";
                        break;
                }


                gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + ".png"));
                gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png"));
                gunaPictureBox_Car3.Image = gunaPictureBox_Car.Image;
            }
            else cpt = 1;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

            if (cpt > 1)
            {
                cpt--;
                gunaPictureBox_Car.Image = (Image)gunaDataGridView1.Rows[cpt - 1].Cells[0].Value;
                gunaLabel_name.Text = gunaDataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                switch (gunaLabel_name.Text)
                {
                    case "Audi RS 7":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 600 hp / 441 kW  \r\nFiscal horsepower: 53 CV  \r\nCombined fuel consumption: 11.4 L/100 km  \r\nCO2 emissions: 261 g/km  \r\nTransmission: Automatic  \r\n";
                        gunaLabel6.Text = "305 Km/h";
                        gunaLabel7.Text = "600 hp / 441 kW";
                        gunaLabel8.Text = "9.2/10";
                        gunaLabel9.Text = "125000$";

                        break;

                    case "Audi RS 5":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 444 hp / 331 kW  \r\nFiscal horsepower: ~40 CV  \r\nCombined fuel consumption: 9.4 L/100 km  \r\nCO2 emissions: 215 g/km  \r\nTransmission: 8-speed automatic";
                        gunaLabel6.Text = "280 Km/h";
                        gunaLabel7.Text = "444 hp / 331 kW";
                        gunaLabel8.Text = "8.8/10";
                        gunaLabel9.Text = "80000$";

                        break;
                    case "Audi Q3":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 228 hp / 169 kW  \r\nFiscal horsepower: ~17 CV  \r\nCombined fuel consumption: 9.8 L/100 km  \r\nCO2 emissions: 223 g/km  \r\nTransmission: 8-speed automatic  ";
                        gunaLabel6.Text = "210 Km/h";
                        gunaLabel7.Text = "228 hp / 169 kW";
                        gunaLabel8.Text = "7.5/10";
                        gunaLabel9.Text = "38000$";

                        break;
                    case "Audi A3":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 201 hp / 150 kW  \r\nFiscal horsepower: ~15 CV  \r\nCombined fuel consumption: 7.1 L/100 km  \r\nCO2 emissions: 163 g/km  \r\nTransmission: 7-speed automatic";
                        gunaLabel6.Text = "240 Km/h";
                        gunaLabel7.Text = "201 hp / 150 kW";
                        gunaLabel8.Text = "7.8/10";
                        gunaLabel9.Text = "35000$";

                        break;
                    case "Audi A4":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 261 hp / 194 kW  \r\nFiscal horsepower: ~19 CV  \r\nCombined fuel consumption: 8.5 L/100 km  \r\nCO2 emissions: 195 g/km  \r\nTransmission: 7-speed automatic ";
                        gunaLabel6.Text = "250 Km/h";
                        gunaLabel7.Text = "261 hp / 194 kW";
                        gunaLabel8.Text = "8.0/10";
                        gunaLabel9.Text = "42000$";

                        break;
                    case "Audi A5":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 261 hp / 194 kW  \r\nFiscal horsepower: ~19 CV  \r\nCombined fuel consumption: 8.5 L/100 km  \r\nCO2 emissions: 195 g/km  \r\nTransmission: 7-speed automatic";
                        gunaLabel6.Text = "250 Km/h";
                        gunaLabel7.Text = "261 hp / 194 kW";
                        gunaLabel8.Text = "8.2/10";
                        gunaLabel9.Text = "46000$";

                        break;
                    case "Audi R8 Spyder":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 602 hp / 449 kW  \r\nFiscal horsepower: ~50 CV  \r\nCombined fuel consumption: 13.5 L/100 km  \r\nCO2 emissions: 312 g/km  \r\nTransmission: 7-speed automatic ";
                        gunaLabel6.Text = "330 Km/h";
                        gunaLabel7.Text = "602 hp / 449 kW";
                        gunaLabel8.Text = "9.7/10";
                        gunaLabel9.Text = "160000$";

                        break;
                    case "Audi TTS Coupe":
                        gunaLabel1.Text = "Fuel type: Petrol  \r\nMaximum power: 320 hp / 235 kW  \r\nFiscal horsepower: ~24 CV  \r\nCombined fuel consumption: 8.3 L/100 km  \r\nCO2 emissions: 189 g/km  \r\nTransmission: 7-speed automatic";
                        gunaLabel6.Text = "250 Km/h";
                        gunaLabel7.Text = "320 hp / 235 kW";
                        gunaLabel8.Text = "8.5/10";
                        gunaLabel9.Text = "62000$";


                        break;
                    default:
                        gunaLabel1.Text = "Specification not available.";
                        break;
                }


                gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + ".png"));
                gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png"));
                gunaPictureBox_Car3.Image = gunaPictureBox_Car.Image;
            }
            else cpt = 1;

        }

        private void gunaPictureBox_Car1_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Image = gunaPictureBox_Car1.Image;
        }

        private void gunaPictureBox_Car2_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Image = gunaPictureBox_Car2.Image;
        }

        private void gunaPictureBox_Car3_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Image = gunaPictureBox_Car3.Image;
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Load(GetCarImagePath(cpt.ToString() + ".png"));

            gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + ".png"));
            gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png"));
            gunaPictureBox_Car3.Load(GetCarImagePath(cpt.ToString() + ".png"));

        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Load(GetCarImagePath(cpt.ToString() + "bl.png"));

            gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + "bl.png"));
            gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + "bl.png"));
            gunaPictureBox_Car3.Load(GetCarImagePath(cpt.ToString() + "bl.png"));
        }

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Load(GetCarImagePath(cpt.ToString() + "r.png"));

            gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + "r.png"));
            gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + "r.png"));
            gunaPictureBox_Car3.Load(GetCarImagePath(cpt.ToString() + "r.png"));
        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Load(GetCarImagePath(cpt.ToString() + "g.png"));

            gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + "g.png"));
            gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + "g.png"));
            gunaPictureBox_Car3.Load(GetCarImagePath(cpt.ToString() + "g.png"));
        }

        private void gunaCirclePictureBox5_Click(object sender, EventArgs e)
        {
            gunaPictureBox_Car.Load(GetCarImagePath(cpt.ToString() + "w.png"));

            gunaPictureBox_Car1.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + "w.png"));
            gunaPictureBox_Car2.Load(GetCarImagePath(cpt.ToString() + cpt.ToString() + cpt.ToString() + "w.png"));
            gunaPictureBox_Car3.Load(GetCarImagePath(cpt.ToString() + "w.png"));
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
            if (lg.lgin == true)
            {
                label1.Visible = true;
                btnLogout.Visible = true;
            }
        }
        public void showfr()
        {
            label1.Visible = true;
            btnLogout.Visible = true;
            btn_Login.Visible = false;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
