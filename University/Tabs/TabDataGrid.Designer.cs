namespace University.Tabs
{
    partial class TabDataGrid
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
            this.dataGridTeachers = new System.Windows.Forms.DataGridView();
            this.NameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTeachers
            // 
            this.dataGridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameT,
            this.Surname,
            this.Age,
            this.Salary,
            this.Students});
            this.dataGridTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTeachers.Location = new System.Drawing.Point(0, 0);
            this.dataGridTeachers.Name = "dataGridTeachers";
            this.dataGridTeachers.Size = new System.Drawing.Size(800, 450);
            this.dataGridTeachers.TabIndex = 0;
            this.dataGridTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameT
            // 
            this.NameT.DataPropertyName = "String";
            this.NameT.HeaderText = "Name";
            this.NameT.Name = "NameT";
            this.NameT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // Students
            // 
            this.Students.HeaderText = "Students";
            this.Students.Name = "Students";
            // 
            // TabDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridTeachers);
            this.Name = "TabDataGrid";
            this.Text = "TabDataGreed";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Students;
    }
}