namespace University
{
    partial class TeacherBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherBox));
            this.teacherName = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.photoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherName.Location = new System.Drawing.Point(104, 12);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(193, 30);
            this.teacherName.TabIndex = 1;
            this.teacherName.Text = "Name Surname";
            // 
            // showList
            // 
            this.showList.FlatAppearance.BorderSize = 0;
            this.showList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showList.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showList.ForeColor = System.Drawing.Color.Transparent;
            this.showList.Location = new System.Drawing.Point(109, 72);
            this.showList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(186, 33);
            this.showList.TabIndex = 2;
            this.showList.Text = "Show Student List";
            this.showList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showList.UseVisualStyleBackColor = true;
            this.showList.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudent
            // 
            this.addStudent.FlatAppearance.BorderSize = 0;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudent.ForeColor = System.Drawing.Color.Transparent;
            this.addStudent.Location = new System.Drawing.Point(109, 43);
            this.addStudent.Margin = new System.Windows.Forms.Padding(0);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(186, 29);
            this.addStudent.TabIndex = 3;
            this.addStudent.Text = "Add Student";
            this.addStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // photoBox
            // 
            this.photoBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("photoBox.ErrorImage")));
            this.photoBox.Image = ((System.Drawing.Image)(resources.GetObject("photoBox.Image")));
            this.photoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("photoBox.InitialImage")));
            this.photoBox.Location = new System.Drawing.Point(8, 12);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(90, 90);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 4;
            this.photoBox.TabStop = false;
            this.photoBox.Click += new System.EventHandler(this._photoBox_Click);
            // 
            // TeacherBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.teacherName);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Name = "TeacherBox";
            this.Size = new System.Drawing.Size(355, 108);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Button showList;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox photoBox;
    }
}
