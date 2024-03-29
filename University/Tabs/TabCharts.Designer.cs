﻿namespace University.Tabs
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
            this.BtnSendNotification = new System.Windows.Forms.Button();
            this.panelNode = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersChart)).BeginInit();
            this.panelNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeachersChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TeachersChart.ChartAreas.Add(chartArea1);
            this.TeachersChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.TeachersChart.Legends.Add(legend1);
            this.TeachersChart.Location = new System.Drawing.Point(0, 46);
            this.TeachersChart.Name = "TeachersChart";
            this.TeachersChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Students";
            this.TeachersChart.Series.Add(series1);
            this.TeachersChart.Size = new System.Drawing.Size(524, 405);
            this.TeachersChart.TabIndex = 0;
            this.TeachersChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Count of Students";
            this.TeachersChart.Titles.Add(title1);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(280, 363);
            this.treeView1.TabIndex = 2;
            // 
            // BtnSendNotification
            // 
            this.BtnSendNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSendNotification.FlatAppearance.BorderSize = 0;
            this.BtnSendNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.BtnSendNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendNotification.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSendNotification.ForeColor = System.Drawing.Color.White;
            this.BtnSendNotification.Location = new System.Drawing.Point(0, 363);
            this.BtnSendNotification.Name = "BtnSendNotification";
            this.BtnSendNotification.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnSendNotification.Size = new System.Drawing.Size(280, 42);
            this.BtnSendNotification.TabIndex = 4;
            this.BtnSendNotification.Text = "Send Notification";
            this.BtnSendNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSendNotification.UseVisualStyleBackColor = true;
            this.BtnSendNotification.Click += new System.EventHandler(this.BtnSendNotification_Click);
            // 
            // panelNode
            // 
            this.panelNode.Controls.Add(this.treeView1);
            this.panelNode.Controls.Add(this.BtnSendNotification);
            this.panelNode.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNode.Location = new System.Drawing.Point(524, 46);
            this.panelNode.Name = "panelNode";
            this.panelNode.Size = new System.Drawing.Size(280, 405);
            this.panelNode.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(166)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 46);
            this.panel1.TabIndex = 3;
            // 
            // TabCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.TeachersChart);
            this.Controls.Add(this.panelNode);
            this.Controls.Add(this.panel1);
            this.Name = "TabCharts";
            this.Text = "TabCharts";
            ((System.ComponentModel.ISupportInitialize)(this.TeachersChart)).EndInit();
            this.panelNode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeachersChart;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button BtnSendNotification;
        private System.Windows.Forms.Panel panelNode;
        private System.Windows.Forms.Panel panel1;
    }
}