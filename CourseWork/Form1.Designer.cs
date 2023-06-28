namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 74);
            this.button1.TabIndex = 4;
            this.button1.Text = "Список направлений";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(91, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить абитуриента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(326, 416);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 33);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Открыть список направлений";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 69);
            this.button4.TabIndex = 9;
            this.button4.Text = "Список абитуриентов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(216, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 48);
            this.button5.TabIndex = 10;
            this.button5.Text = "Открыть список абитуриентов";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(91, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 82);
            this.button6.TabIndex = 12;
            this.button6.Text = "Распределить абитуриентов";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Абитуриенты распределены!";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private Button ExitButton;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label3;
    }
}