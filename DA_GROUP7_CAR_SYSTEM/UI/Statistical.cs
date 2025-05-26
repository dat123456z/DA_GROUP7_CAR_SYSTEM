using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_GROUP7_CAR_SYSTEM.BSLayer;
using System.Windows.Forms.DataVisualization.Charting;


namespace DA_GROUP7_CAR_SYSTEM.UI
{
    public partial class Statistical : Form
    {
        private BLChart chartBL = new BLChart();

        public Statistical()
        {
            InitializeComponent();
        }

        private void btn_Brandchart_Click(object sender, EventArgs e)
        {
            Pn_Chart.Controls.Clear();
            DataTable dt = chartBL.GetVehicleLeftByBrand();

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.Area3DStyle.Enable3D = true;
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Inventory by brand");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            series.LabelForeColor = Color.Black;

            int total = dt.AsEnumerable().Sum(row => Convert.ToInt32(row["StockLeft"]));

            foreach (DataRow row in dt.Rows)
            {
                string brand = row["Brand"].ToString();
                int count = Convert.ToInt32(row["StockLeft"]);
                double percent = total > 0 ? (double)count / total : 0;

                DataPoint point = new DataPoint();
                point.SetValueXY(brand, count);
                point.Label = $"{brand}: {percent:P1}";
                point.LegendText = $"{brand}: {count} ({percent:P1})";
                series.Points.Add(point);
            }

            chart.Series.Add(series);
            chart.Titles.Add("Chart of remaining vehicles by brand");
            chart.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);

            chart.Legends.Add(new Legend("Legend"));
            chart.Legends[0].Docking = Docking.Right;
            chart.Legends[0].Font = new Font("Segoe UI", 10);

            series["PieLabelStyle"] = "Inside";
            series["PieStartAngle"] = "90";

            Pn_Chart.Controls.Add(chart);

        }


        private void btn_Colorchart_Click(object sender, EventArgs e)
        {
            Pn_Chart.Controls.Clear();
            DataTable dt = chartBL.GetVehicleCountByColor();

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);
            area.AxisX.Title = "Vehicle Color";
            area.AxisY.Title = "Quantity";
            area.AxisX.Interval = 1;
            area.AxisX.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            Series series = new Series("Vehicle Colors");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            Color[] colorSamples = new Color[]
            {
        Color.SteelBlue, Color.Orange, Color.MediumSeaGreen,
        Color.MediumPurple, Color.Crimson, Color.Goldenrod,
        Color.Teal, Color.SandyBrown
            };

            int colorIndex = 0;

            foreach (DataRow row in dt.Rows)
            {
                string colorName = row["Color"].ToString();
                int qty = Convert.ToInt32(row["SoLuong"]);
                int index = series.Points.AddXY(colorName, qty);

                try
                {
                    series.Points[index].Color = Color.FromName(colorName);
                }
                catch
                {
                    series.Points[index].Color = colorSamples[colorIndex % colorSamples.Length];
                }
                
                series.Points[index].BorderColor = Color.Black;

                series.Points[index].Label = qty.ToString();
                series.Points[index].LegendText = colorName;

                colorIndex++;
            }

            chart.Series.Add(series);
            chart.Titles.Add("Vehicle Stock by Color");
            chart.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);

            Pn_Chart.Controls.Add(chart);
        }

        private void btn_Employchart_Click(object sender, EventArgs e)
        {
            Pn_Chart.Controls.Clear();
            DataTable dt = chartBL.GetSalesCountByEmployee();

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea("MainArea");
            area.Area3DStyle.Enable3D = true;
            chart.ChartAreas.Add(area);

            Series series = new Series("Sales by Employee");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = false;
            series.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            int total = dt.AsEnumerable().Sum(row => Convert.ToInt32(row["SalesCount"]));

            foreach (DataRow row in dt.Rows)
            {
                string name = row["FullName"].ToString();
                int count = Convert.ToInt32(row["SalesCount"]);
                double percent = total > 0 ? (double)count / total : 0;

                DataPoint point = new DataPoint();
                point.SetValueXY(name, count);
                
                // Extract middle and last name
                string[] nameParts = name.Split(' ');
                string displayName = name;
                if (nameParts.Length > 1)
                {
                    displayName = string.Join(" ", nameParts.Skip(1));
                }

                point.Label = $"{displayName}: {percent:P1}"; // Display middle/last name and percentage
                point.LegendText = $"{name}: {count} invoices ({percent:P1})"; // Full name in legend
                series.Points.Add(point);
            }

            chart.Series.Add(series);

            chart.Titles.Add("Employee Sales Distribution");
            chart.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);

            // Add legend
            chart.Legends.Add(new Legend("Legend"));
            chart.Legends[0].Docking = Docking.Right;
            chart.Legends[0].Font = new Font("Segoe UI", 10);

            series["PieLabelStyle"] = "Inside"; // Show label inside slices
            series["PieStartAngle"] = "90";

            Pn_Chart.Controls.Add(chart);
        }
    }
}
