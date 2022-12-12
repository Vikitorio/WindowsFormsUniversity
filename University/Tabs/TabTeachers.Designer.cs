namespace University.Tabs
{
    partial class TabTeachers
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
            this.humanListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.createElementForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CreateDefaultTeacher = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // humanListBox
            // 
            this.humanListBox.AutoScroll = true;
            this.humanListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(219)))));
            this.humanListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humanListBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.humanListBox.Location = new System.Drawing.Point(0, 46);
            this.humanListBox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.humanListBox.Name = "humanListBox";
            this.humanListBox.Padding = new System.Windows.Forms.Padding(0, 5, 247, 0);
            this.humanListBox.Size = new System.Drawing.Size(597, 405);
            this.humanListBox.TabIndex = 10;
            this.humanListBox.WrapContents = false;
            // 
            // createElementForm
            // 
            this.createElementForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.createElementForm.Location = new System.Drawing.Point(597, 46);
            this.createElementForm.Name = "createElementForm";
            this.createElementForm.Size = new System.Drawing.Size(207, 405);
            this.createElementForm.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.CreateDefaultTeacher);
            this.panel3.Controls.Add(this.AddElement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 46);
            this.panel3.TabIndex = 9;
            // 
            // CreateDefaultTeacher
            // 
            this.CreateDefaultTeacher.ForeColor = System.Drawing.Color.White;
            this.CreateDefaultTeacher.Location = new System.Drawing.Point(139, 12);
            this.CreateDefaultTeacher.Name = "CreateDefaultTeacher";
            this.CreateDefaultTeacher.Size = new System.Drawing.Size(125, 23);
            this.CreateDefaultTeacher.TabIndex = 1;
            this.CreateDefaultTeacher.Text = "Add Default Teacher";
            this.CreateDefaultTeacher.UseVisualStyleBackColor = true;
            this.CreateDefaultTeacher.Click += new System.EventHandler(this.CreateDefaultTeacher_Click);
            // 
            // AddElement
            // 
            this.AddElement.ForeColor = System.Drawing.Color.White;
            this.AddElement.Location = new System.Drawing.Point(18, 12);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(115, 23);
            this.AddElement.TabIndex = 0;
            this.AddElement.Text = "AddTeacher";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // TabTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.humanListBox);
            this.Controls.Add(this.createElementForm);
            this.Controls.Add(this.panel3);
            this.Name = "TabTeachers";
            this.Text = "TabTeachers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TabTeachers_Close);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel humanListBox;
        private System.Windows.Forms.Panel createElementForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CreateDefaultTeacher;
        private System.Windows.Forms.Button AddElement;
    }
}