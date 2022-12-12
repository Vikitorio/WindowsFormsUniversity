namespace University.Tabs
{
    partial class TabCharts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TeachersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TeachersChart.ChartAreas.Add(chartArea1);
            this.TeachersChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.TeachersChart.Legends.Add(legend1);
            this.TeachersChart.Location = new System.Drawing.Point(0, 0);
            this.TeachersChart.Name = "TeachersChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Students";
            this.TeachersChart.Series.Add(series1);
            this.TeachersChart.Size = new System.Drawing.Size(564, 451);
            this.TeachersChart.TabIndex = 0;
            this.TeachersChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Count of Students";
            this.TeachersChart.Titles.Add(title1);
            this.TeachersChart.Click += new System.EventHandler(this.TeachersChart_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView1.Location = new System.Drawing.Point(564, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 451);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // TabCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.TeachersChart);
            this.Controls.Add(this.treeView1);
            this.Name = "TabCharts";
            this.Text = "TabCharts";
            ((System.ComponentModel.ISupportInitialize)(this.TeachersChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeachersChart;
        private System.Windows.Forms.TreeView treeView1;
    }
}