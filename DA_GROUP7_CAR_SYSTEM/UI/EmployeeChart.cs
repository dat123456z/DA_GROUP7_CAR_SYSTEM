using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DA_GROUP7_CAR_SYSTEM.DBLayer;
using System.Drawing;
using System.Linq;

namespace DA_GROUP7_CAR_SYSTEM
{
    public partial class EmployeeChart : Form
    {
        private DBMain db = new DBMain();

        public EmployeeChart()
        {
            InitializeComponent();
            LoadChartData();
            this.BackColor = Color.WhiteSmoke;
            this.Padding = new Padding(10);
        }

        private void LoadChartData()
        {
            try
            {
                // Query to get employee sales data
                string sql = @"SELECT e.FullName, COUNT(i.InvoiceID) as SalesCount 
                             FROM Employee e 
                             LEFT JOIN Invoice i ON e.EmployeeID = i.EmployeeID 
                             WHERE e.Position = N'Sales'
                             GROUP BY e.EmployeeID, e.FullName";

                DataSet ds = db.ExecuteQueryDataSet(sql, CommandType.Text);
                DataTable dt = ds.Tables[0];

                // Clear existing data
                chart1.Series.Clear();
                chart1.Legends.Clear();

                // Create new series for pie chart
                Series series = new Series("Employee Sales");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                series["PieLabelStyle"] = "Inside";
                series["DoughnutRadius"] = "60";
                series.BorderWidth = 2;
                series.BorderColor = Color.White;

                // Add data points with custom colors
                Color[] customColors = new Color[] {
                    Color.FromArgb(255, 99, 132),
                    Color.FromArgb(54, 162, 235),
                    Color.FromArgb(255, 206, 86),
                    Color.FromArgb(75, 192, 192),
                    Color.FromArgb(153, 102, 255),
                    Color.FromArgb(255, 159, 64)
                };

                int colorIndex = 0;
                int totalSales = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string fullName = row["FullName"].ToString();
                    string[] nameParts = fullName.Split(' ');
                    string employeeName = fullName;
                    if (nameParts.Length > 0)
                    {
                        employeeName = nameParts[nameParts.Length - 1];
                    }

                    int salesCount = Convert.ToInt32(row["SalesCount"]);
                    totalSales += salesCount;
                    DataPoint point = new DataPoint();
                    point.SetValueXY(fullName, salesCount);
                    point.LegendText = fullName;
                    point.Label = $"{fullName}\n({salesCount} customers)";
                    point.Color = customColors[colorIndex % customColors.Length];
                    point.Font = new Font("Arial", 10, FontStyle.Bold);
                    series.Points.Add(point);
                    colorIndex++;
                }

                // Add series to chart
                chart1.Series.Add(series);

                // Configure chart appearance
                chart1.Titles.Clear();
                Title title = new Title("Employee Sales Distribution", Docking.Top);
                title.Font = new Font("Arial", 16, FontStyle.Bold);
                title.ForeColor = Color.FromArgb(64, 64, 64);
                chart1.Titles.Add(title);

                // Configure chart area
                chart1.ChartAreas[0].BackColor = Color.White;
                chart1.ChartAreas[0].BorderColor = Color.LightGray;
                chart1.ChartAreas[0].BorderWidth = 1;
                chart1.ChartAreas[0].ShadowOffset = 2;

                // Configure legend
                Legend legend = new Legend();
                legend.Name = "MainLegend";
                legend.Docking = Docking.Bottom;
                legend.Alignment = StringAlignment.Center;
                legend.Font = new Font("Arial", 10);
                legend.BackColor = Color.White;
                legend.BorderColor = Color.LightGray;
                legend.BorderWidth = 1;
                chart1.Legends.Add(legend);

                // Create main container panel
                Panel mainContainer = new Panel();
                mainContainer.Dock = DockStyle.Fill;
                mainContainer.Padding = new Padding(10);

                // Create header panel
                Panel headerPanel = new Panel();
                headerPanel.Dock = DockStyle.Top;
                headerPanel.Height = 80;
                headerPanel.BackColor = Color.FromArgb(240, 240, 240);
                headerPanel.Padding = new Padding(15);

                // Add header content
                Label headerLabel = new Label();
                headerLabel.Text = "Sales Performance Overview";
                headerLabel.Font = new Font("Arial", 16, FontStyle.Bold);
                headerLabel.ForeColor = Color.FromArgb(64, 64, 64);
                headerLabel.AutoSize = true;
                headerLabel.Location = new Point(15, 15);
                headerPanel.Controls.Add(headerLabel);

                // Create stats panel
                Panel statsPanel = new Panel();
                statsPanel.Dock = DockStyle.Right;
                statsPanel.Width = 250;
                statsPanel.BackColor = Color.White;
                statsPanel.Padding = new Padding(15);
                statsPanel.BorderStyle = BorderStyle.FixedSingle;

                // Add statistics
                Label totalSalesLabel = new Label();
                totalSalesLabel.Text = $"Total Customers: {totalSales}";
                totalSalesLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                totalSalesLabel.ForeColor = Color.FromArgb(64, 64, 64);
                totalSalesLabel.AutoSize = true;
                totalSalesLabel.Location = new Point(15, 15);
                statsPanel.Controls.Add(totalSalesLabel);

                Label employeeCountLabel = new Label();
                employeeCountLabel.Text = $"Total Employees: {dt.Rows.Count}";
                employeeCountLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                employeeCountLabel.ForeColor = Color.FromArgb(64, 64, 64);
                employeeCountLabel.AutoSize = true;
                employeeCountLabel.Location = new Point(15, 45);
                statsPanel.Controls.Add(employeeCountLabel);

                // Find top performer
                if (dt.Rows.Count > 0)
                {
                    DataRow topPerformer = dt.AsEnumerable()
                        .OrderByDescending(r => Convert.ToInt32(r["SalesCount"]))
                        .First();

                    Label topPerformerLabel = new Label();
                    topPerformerLabel.Text = $"Top Performer: {topPerformer["FullName"]}";
                    topPerformerLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                    topPerformerLabel.ForeColor = Color.FromArgb(64, 64, 64);
                    topPerformerLabel.AutoSize = true;
                    topPerformerLabel.Location = new Point(15, 75);
                    statsPanel.Controls.Add(topPerformerLabel);

                    Label topSalesLabel = new Label();
                    topSalesLabel.Text = $"Customers: {topPerformer["SalesCount"]}";
                    topSalesLabel.Font = new Font("Arial", 12);
                    topSalesLabel.ForeColor = Color.FromArgb(64, 64, 64);
                    topSalesLabel.AutoSize = true;
                    topSalesLabel.Location = new Point(15, 105);
                    statsPanel.Controls.Add(topSalesLabel);
                }

                // Add panels to form
                this.Controls.Add(mainContainer);
                mainContainer.Controls.Add(headerPanel);
                mainContainer.Controls.Add(statsPanel);
                mainContainer.Controls.Add(chart1);

                // Make chart fill the remaining space
                chart1.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}