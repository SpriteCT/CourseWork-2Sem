namespace CourseWork
{
    partial class AddStudent
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
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentSurName = new System.Windows.Forms.TextBox();
            this.StudentThirdName = new System.Windows.Forms.TextBox();
            this.BoxSubjects = new System.Windows.Forms.ComboBox();
            this.SubjectScore = new System.Windows.Forms.TextBox();
            this.UniversitysBox = new System.Windows.Forms.ComboBox();
            this.DirectionsBox = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.AddDirection = new System.Windows.Forms.Button();
            this.GoldMedal = new System.Windows.Forms.CheckBox();
            this.GTO = new System.Windows.Forms.CheckBox();
            this.Volunteering = new System.Windows.Forms.CheckBox();
            this.FirstDirection = new System.Windows.Forms.Label();
            this.ThirdDirection = new System.Windows.Forms.Label();
            this.SecondDirection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IncorrectInput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(30, 35);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(100, 23);
            this.StudentName.TabIndex = 0;
            // 
            // StudentSurName
            // 
            this.StudentSurName.Location = new System.Drawing.Point(30, 90);
            this.StudentSurName.Name = "StudentSurName";
            this.StudentSurName.Size = new System.Drawing.Size(100, 23);
            this.StudentSurName.TabIndex = 1;
            // 
            // StudentThirdName
            // 
            this.StudentThirdName.Location = new System.Drawing.Point(30, 145);
            this.StudentThirdName.Name = "StudentThirdName";
            this.StudentThirdName.Size = new System.Drawing.Size(100, 23);
            this.StudentThirdName.TabIndex = 2;
            // 
            // BoxSubjects
            // 
            this.BoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxSubjects.FormattingEnabled = true;
            this.BoxSubjects.Location = new System.Drawing.Point(30, 233);
            this.BoxSubjects.Name = "BoxSubjects";
            this.BoxSubjects.Size = new System.Drawing.Size(121, 23);
            this.BoxSubjects.TabIndex = 3;
            this.BoxSubjects.SelectedIndexChanged += new System.EventHandler(this.BoxSubjects_SelectedIndexChanged);
            // 
            // SubjectScore
            // 
            this.SubjectScore.Enabled = false;
            this.SubjectScore.Location = new System.Drawing.Point(30, 294);
            this.SubjectScore.Name = "SubjectScore";
            this.SubjectScore.Size = new System.Drawing.Size(100, 23);
            this.SubjectScore.TabIndex = 4;
            // 
            // UniversitysBox
            // 
            this.UniversitysBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UniversitysBox.FormattingEnabled = true;
            this.UniversitysBox.Location = new System.Drawing.Point(401, 178);
            this.UniversitysBox.Name = "UniversitysBox";
            this.UniversitysBox.Size = new System.Drawing.Size(121, 23);
            this.UniversitysBox.TabIndex = 5;
            this.UniversitysBox.SelectedIndexChanged += new System.EventHandler(this.University_SelectedIndexChanged);
            // 
            // DirectionsBox
            // 
            this.DirectionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectionsBox.FormattingEnabled = true;
            this.DirectionsBox.Location = new System.Drawing.Point(557, 178);
            this.DirectionsBox.Name = "DirectionsBox";
            this.DirectionsBox.Size = new System.Drawing.Size(215, 23);
            this.DirectionsBox.TabIndex = 6;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(557, 374);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(215, 64);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Отправить";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddDirection
            // 
            this.AddDirection.Location = new System.Drawing.Point(557, 240);
            this.AddDirection.Name = "AddDirection";
            this.AddDirection.Size = new System.Drawing.Size(215, 38);
            this.AddDirection.TabIndex = 8;
            this.AddDirection.Text = "Добавить направление";
            this.AddDirection.UseVisualStyleBackColor = true;
            this.AddDirection.Click += new System.EventHandler(this.AddDirection_Click);
            // 
            // GoldMedal
            // 
            this.GoldMedal.AutoSize = true;
            this.GoldMedal.Location = new System.Drawing.Point(200, 240);
            this.GoldMedal.Name = "GoldMedal";
            this.GoldMedal.Size = new System.Drawing.Size(114, 19);
            this.GoldMedal.TabIndex = 9;
            this.GoldMedal.Text = "Золотая медаль";
            this.GoldMedal.UseVisualStyleBackColor = true;
            // 
            // GTO
            // 
            this.GTO.AutoSize = true;
            this.GTO.Location = new System.Drawing.Point(200, 270);
            this.GTO.Name = "GTO";
            this.GTO.Size = new System.Drawing.Size(90, 19);
            this.GTO.TabIndex = 10;
            this.GTO.Text = "Значок ГТО";
            this.GTO.UseVisualStyleBackColor = true;
            // 
            // Volunteering
            // 
            this.Volunteering.AutoSize = true;
            this.Volunteering.Location = new System.Drawing.Point(200, 300);
            this.Volunteering.Name = "Volunteering";
            this.Volunteering.Size = new System.Drawing.Size(103, 19);
            this.Volunteering.TabIndex = 11;
            this.Volunteering.Text = "Волонтерство";
            this.Volunteering.UseVisualStyleBackColor = true;
            // 
            // FirstDirection
            // 
            this.FirstDirection.AutoSize = true;
            this.FirstDirection.Location = new System.Drawing.Point(190, 40);
            this.FirstDirection.Name = "FirstDirection";
            this.FirstDirection.Size = new System.Drawing.Size(41, 15);
            this.FirstDirection.TabIndex = 12;
            this.FirstDirection.Text = "firstdir";
            this.FirstDirection.Visible = false;
            // 
            // ThirdDirection
            // 
            this.ThirdDirection.AutoSize = true;
            this.ThirdDirection.Location = new System.Drawing.Point(190, 140);
            this.ThirdDirection.Name = "ThirdDirection";
            this.ThirdDirection.Size = new System.Drawing.Size(46, 15);
            this.ThirdDirection.TabIndex = 13;
            this.ThirdDirection.Text = "thirddir";
            this.ThirdDirection.Visible = false;
            // 
            // SecondDirection
            // 
            this.SecondDirection.AutoSize = true;
            this.SecondDirection.Location = new System.Drawing.Point(190, 90);
            this.SecondDirection.Name = "SecondDirection";
            this.SecondDirection.Size = new System.Drawing.Size(59, 15);
            this.SecondDirection.TabIndex = 14;
            this.SecondDirection.Text = "seconddir";
            this.SecondDirection.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Предмет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Баллы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Доп. заслуги";
            // 
            // IncorrectInput
            // 
            this.IncorrectInput.AutoSize = true;
            this.IncorrectInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncorrectInput.Location = new System.Drawing.Point(222, 388);
            this.IncorrectInput.Name = "IncorrectInput";
            this.IncorrectInput.Size = new System.Drawing.Size(281, 28);
            this.IncorrectInput.TabIndex = 21;
            this.IncorrectInput.Text = "Неправильный ввод данных!";
            this.IncorrectInput.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "ВУЗ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Направление";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IncorrectInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondDirection);
            this.Controls.Add(this.ThirdDirection);
            this.Controls.Add(this.FirstDirection);
            this.Controls.Add(this.Volunteering);
            this.Controls.Add(this.GTO);
            this.Controls.Add(this.GoldMedal);
            this.Controls.Add(this.AddDirection);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.DirectionsBox);
            this.Controls.Add(this.UniversitysBox);
            this.Controls.Add(this.SubjectScore);
            this.Controls.Add(this.BoxSubjects);
            this.Controls.Add(this.StudentThirdName);
            this.Controls.Add(this.StudentSurName);
            this.Controls.Add(this.StudentName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox StudentName;
        private TextBox StudentSurName;
        private TextBox StudentThirdName;
        private ComboBox BoxSubjects;
        private TextBox SubjectScore;
        private ComboBox UniversitysBox;
        private ComboBox DirectionsBox;
        private Button Submit;
        private Button AddDirection;
        private CheckBox GoldMedal;
        private CheckBox GTO;
        private CheckBox Volunteering;
        private Label FirstDirection;
        private Label ThirdDirection;
        private Label SecondDirection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label IncorrectInput;
        private Label label7;
        private Label label8;
    }
}