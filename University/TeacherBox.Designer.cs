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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teacherName = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(24, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // teacherName
            // 
            this.teacherName.AutoSize = true;
            this.teacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherName.Location = new System.Drawing.Point(160, 14);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(191, 29);
            this.teacherName.TabIndex = 1;
            this.teacherName.Text = "Name Surname";
            // 
            // showList
            // 
            this.showList.Location = new System.Drawing.Point(165, 46);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(186, 35);
            this.showList.TabIndex = 2;
            this.showList.Text = "Show Student List";
            this.showList.UseVisualStyleBackColor = true;
            this.showList.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(165, 87);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(186, 39);
            this.addStudent.TabIndex = 3;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TeacherBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Name = "TeacherBox";
            this.Size = new System.Drawing.Size(447, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label teacherName;
        private System.Windows.Forms.Button showList;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
