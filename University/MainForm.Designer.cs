namespace University
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGrid = new System.Windows.Forms.Button();
            this.BtnCharts = new System.Windows.Forms.Button();
            this.BtnTeachers = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.BtnGrid);
            this.panel1.Controls.Add(this.BtnCharts);
            this.panel1.Controls.Add(this.BtnTeachers);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 457);
            this.panel1.TabIndex = 3;
            // 
            // BtnGrid
            // 
            this.BtnGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGrid.FlatAppearance.BorderSize = 0;
            this.BtnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrid.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGrid.ForeColor = System.Drawing.Color.White;
            this.BtnGrid.Location = new System.Drawing.Point(0, 136);
            this.BtnGrid.Name = "BtnGrid";
            this.BtnGrid.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnGrid.Size = new System.Drawing.Size(180, 45);
            this.BtnGrid.TabIndex = 4;
            this.BtnGrid.Text = "GridView";
            this.BtnGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrid.UseVisualStyleBackColor = true;
            this.BtnGrid.Click += new System.EventHandler(this.BtnGrid_Click);
            // 
            // BtnCharts
            // 
            this.BtnCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCharts.FlatAppearance.BorderSize = 0;
            this.BtnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCharts.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCharts.ForeColor = System.Drawing.Color.White;
            this.BtnCharts.Location = new System.Drawing.Point(0, 91);
            this.BtnCharts.Name = "BtnCharts";
            this.BtnCharts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnCharts.Size = new System.Drawing.Size(180, 45);
            this.BtnCharts.TabIndex = 3;
            this.BtnCharts.Text = "Charts";
            this.BtnCharts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCharts.UseVisualStyleBackColor = true;
            this.BtnCharts.Click += new System.EventHandler(this.BtnCharts_Click);
            // 
            // BtnTeachers
            // 
            this.BtnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeachers.FlatAppearance.BorderSize = 0;
            this.BtnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeachers.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTeachers.ForeColor = System.Drawing.Color.White;
            this.BtnTeachers.Location = new System.Drawing.Point(0, 46);
            this.BtnTeachers.Name = "BtnTeachers";
            this.BtnTeachers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnTeachers.Size = new System.Drawing.Size(180, 45);
            this.BtnTeachers.TabIndex = 2;
            this.BtnTeachers.Text = "Teachers ";
            this.BtnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTeachers.UseVisualStyleBackColor = true;
            this.BtnTeachers.Click += new System.EventHandler(this.TabTeachers_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(37)))), ((int)(((byte)(111)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 46);
            this.panel4.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(894, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnTeachers;
        private System.Windows.Forms.Button BtnCharts;
        private System.Windows.Forms.Button BtnGrid;
    }
}

