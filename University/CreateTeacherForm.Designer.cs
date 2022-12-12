namespace University
{
    partial class CreateTeacherForm
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
            this._name = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._age = new System.Windows.Forms.TextBox();
            this._country = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this._city = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._street = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._house = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SavePerson = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._salary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(97, 12);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(116, 20);
            this._name.TabIndex = 0;
            this._name.TextChanged += new System.EventHandler(this._name_TextChanged);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 15);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // _surname
            // 
            this._surname.Location = new System.Drawing.Point(97, 38);
            this._surname.Name = "_surname";
            this._surname.Size = new System.Drawing.Size(116, 20);
            this._surname.TabIndex = 2;
            this._surname.TextChanged += new System.EventHandler(this._surname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // _age
            // 
            this._age.Location = new System.Drawing.Point(97, 64);
            this._age.Name = "_age";
            this._age.Size = new System.Drawing.Size(116, 20);
            this._age.TabIndex = 4;
            this._age.TextChanged += new System.EventHandler(this._age_TextChanged);
            // 
            // _country
            // 
            this._country.Location = new System.Drawing.Point(97, 146);
            this._country.Name = "_country";
            this._country.Size = new System.Drawing.Size(116, 20);
            this._country.TabIndex = 6;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(12, 149);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(43, 13);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "Country";
            // 
            // _city
            // 
            this._city.Location = new System.Drawing.Point(97, 172);
            this._city.Name = "_city";
            this._city.Size = new System.Drawing.Size(116, 20);
            this._city.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "City";
            // 
            // _street
            // 
            this._street.Location = new System.Drawing.Point(97, 198);
            this._street.Name = "_street";
            this._street.Size = new System.Drawing.Size(116, 20);
            this._street.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Street";
            // 
            // _house
            // 
            this._house.Location = new System.Drawing.Point(97, 224);
            this._house.Name = "_house";
            this._house.Size = new System.Drawing.Size(116, 20);
            this._house.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "House";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adress";
            // 
            // SavePerson
            // 
            this.SavePerson.Location = new System.Drawing.Point(41, 335);
            this.SavePerson.Name = "SavePerson";
            this.SavePerson.Size = new System.Drawing.Size(172, 31);
            this.SavePerson.TabIndex = 15;
            this.SavePerson.Text = "Save";
            this.SavePerson.UseVisualStyleBackColor = true;
            this.SavePerson.Click += new System.EventHandler(this.SavePerson_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Salary";
            // 
            // _salary
            // 
            this._salary.Location = new System.Drawing.Point(97, 93);
            this._salary.Name = "_salary";
            this._salary.Size = new System.Drawing.Size(116, 20);
            this._salary.TabIndex = 26;
            // 
            // CreateTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._salary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SavePerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._house);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._street);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._city);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this._country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._surname);
            this.Controls.Add(this.LName);
            this.Controls.Add(this._name);
            this.Name = "CreateTeacherForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _age;
        private System.Windows.Forms.TextBox _country;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox _city;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _street;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _house;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SavePerson;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _salary;
    }
}