using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Data;
using System.Linq;
using DA_GROUP7_CAR_SYSTEM.DBLayer;

namespace DA_GROUP7_CAR_SYSTEM
{
    internal class BrandVehicleChart : Form
    {
        private DBMain db = new DBMain();
        private Chart chartBrand;

        public BrandVehicleChart()
        {
            InitializeComponent();
            CheckInvoiceDetailData();
            LoadBrandData();
        }

        private void InitializeComponent()
        {
            this.chartBrand = new Chart();
            this.SuspendLayout();
            // 
            // chartBrand
            // 
            this.chartBrand.Dock = DockStyle.Fill;
            this.chartBrand.Location = new Point(0, 0);
            this.chartBrand.Name = "chartBrand";
            this.chartBrand.Size = new Size(800, 600);
            this.chartBrand.TabIndex = 0;
            // 
            // BrandVehicleChart
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.chartBrand);
            this.Name = "BrandVehicleChart";
            this.Text = "Brand Distribution Chart";
            this.ResumeLayout(false);
        }

        private void CheckInvoiceDetailData()
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM InvoiceDetail";
                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                if (count == 0)
                {
                    MessageBox.Show("No sales data available in InvoiceDetail table. The chart will be empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking InvoiceDetail data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrandData()
        {
            try
            {
                // Query to get brand statistics from purchased vehicles through Invoice and InvoiceDetail
                string sql = @"SELECT v.Brand, SUM(i.Quantity) as BrandCount 
                             FROM InvoiceDetail i
                             INNER JOIN Vehicle v ON i.VehicleID = v.VehicleID
                             GROUP BY v.Brand 
                             ORDER BY BrandCount DESC";

                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data returned from the query. Please check if there are any records in InvoiceDetail and Vehicle tables.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Clear existing data
                chartBrand.Series.Clear();
                chartBrand.Legends.Clear();
                chartBrand.Titles.Clear();

                // Clear existing chart areas and add a new one
                chartBrand.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.Area3DStyle.Enable3D = true;
                chartBrand.ChartAreas.Add(chartArea);

                // Create new series for pie chart
                Series series = new Series("Brand Distribution");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "{0} ({1:P})"; // Show both count and percentage
                series.Font = new Font("Arial", 10, FontStyle.Bold);
                series.LabelForeColor = Color.Black; // Make label color black for better visibility on colored slices

                // Calculate total for percentage
                int total = dt.AsEnumerable().Sum(row => Convert.ToInt32(row["BrandCount"]));

                // Add data points
                foreach (DataRow row in dt.Rows)
                {
                    string brandName = row["Brand"].ToString();
                    // Handle potential DBNull for BrandCount
                    int count = row["BrandCount"] != DBNull.Value ? Convert.ToInt32(row["BrandCount"]) : 0;
                    double percentage = (double)count / total;

                    DataPoint point = new DataPoint();
                    point.SetValueXY(brandName, count);
                    if (total > 0) // Avoid division by zero if total is 0
                    {
                        point.Label = $"{brandName}\n{percentage:P1}";
                    }
                    else
                    {
                        point.Label = $"{brandName}\n0.0%";
                    }
                    point.LegendText = brandName;
                    series.Points.Add(point);
                }

                // Add series to chart
                chartBrand.Series.Add(series);

                // Configure chart appearance
                chartBrand.Titles.Add("Brand Distribution");
                chartBrand.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

                // Configure legend
                chartBrand.Legends.Add(new Legend("Legend"));
                chartBrand.Legends[0].Docking = Docking.Right;
                chartBrand.Legends[0].Font = new Font("Arial", 10);

                // Configure series
                series["PieLabelStyle"] = "Inside";
                series["DoughnutRadius"] = "60";
                series["PieStartAngle"] = "90";

                // Force chart to refresh
                chartBrand.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}