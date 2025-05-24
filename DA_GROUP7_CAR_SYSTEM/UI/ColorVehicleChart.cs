using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System.Drawing;

namespace DA_GROUP7_CAR_SYSTEM
{
    internal class ColorVehicleChart : Form
    {
        private DBMain db = new DBMain();
        private Chart chart1;

        public ColorVehicleChart()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void InitializeComponent()
        {
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(800, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.BackColor = Color.FromArgb(240, 240, 240);
            this.chart1.BorderlineColor = Color.DarkGray;
            this.chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            this.chart1.Padding = new Padding(10);
            // 
            // ColorVehicleChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Name = "ColorVehicleChart";
            this.Text = "Vehicle Color Distribution";
            this.BackColor = Color.White;
            this.ResumeLayout(false);
        }

        private void LoadChartData()
        {
            try
            {
                // Query to get vehicle color statistics
                string sql = @"SELECT Color, COUNT(*) as ColorCount 
                             FROM Vehicle 
                             GROUP BY Color";

                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                DataTable dt = ds.Tables[0];

                // Clear existing data
                chart1.Series.Clear();
                chart1.Legends.Clear();
                chart1.Titles.Clear();

                // Create new series for column chart
                Series series = new Series("Vehicle Colors");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "{0}";
                series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                series.ShadowColor = Color.FromArgb(128, 0, 0, 0);
                series.ShadowOffset = 2;
                series["DrawingStyle"] = "Cylinder";
                series["PointWidth"] = "0.8";

                // Add data points
                foreach (DataRow row in dt.Rows)
                {
                    string colorName = row["Color"].ToString();
                    int count = Convert.ToInt32(row["ColorCount"]);
                    int pointIndex = series.Points.AddXY(colorName, count);
                    DataPoint point = series.Points[pointIndex];
                    point.Color = GetColorFromString(colorName);
                    point.BorderColor = Color.FromArgb(64, 0, 0, 0);
                    point.BorderWidth = 1;
                    point.LabelForeColor = Color.FromArgb(64, 64, 64);
                }

                // Add series to chart
                chart1.Series.Add(series);

                // Configure chart appearance
                Title title = new Title("Vehicle Color Distribution");
                title.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                title.ForeColor = Color.FromArgb(64, 64, 64);
                chart1.Titles.Add(title);

                // Configure chart area
                ChartArea chartArea = new ChartArea();
                chartArea.BackColor = Color.White;
                chartArea.BorderColor = Color.FromArgb(200, 200, 200);
                chartArea.BorderWidth = 1;
                chartArea.InnerPlotPosition = new ElementPosition(10, 10, 85, 80); // Left, Top, Width, Height in percentage
                
                // Configure axis
                chartArea.AxisX.Title = "Color";
                chartArea.AxisY.Title = "Number of Vehicles";
                chartArea.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 10);
                chartArea.AxisX.Interval = 1;
                chartArea.AxisY.Interval = 1;
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.AxisX.LineColor = Color.FromArgb(200, 200, 200);
                chartArea.AxisY.LineColor = Color.FromArgb(200, 200, 200);
                chartArea.AxisX.TitleForeColor = Color.FromArgb(64, 64, 64);
                chartArea.AxisY.TitleForeColor = Color.FromArgb(64, 64, 64);

                chart1.ChartAreas.Add(chartArea);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper function to get System.Drawing.Color from color name string
        private System.Drawing.Color GetColorFromString(string colorName)
        {
            switch (colorName.ToLower())
            {
                case "black":
                    return System.Drawing.Color.Black;
                case "blue":
                    return System.Drawing.Color.Blue;
                case "gray":
                    return System.Drawing.Color.Gray;
                case "red":
                    return System.Drawing.Color.Red;
                case "white":
                    return System.Drawing.Color.White;
                default:
                    // Return a default color if the color name is not recognized
                    return System.Drawing.Color.CornflowerBlue; // Or any other default color
            }
        }
    }
}