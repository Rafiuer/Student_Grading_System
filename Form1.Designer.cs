﻿namespace Univesity_Grade_Calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_StudentID = new System.Windows.Forms.Label();
            this.lb_Semester = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_studentID = new System.Windows.Forms.TextBox();
            this.tb_semester = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.tb_attendance = new System.Windows.Forms.TextBox();
            this.tb_Mid = new System.Windows.Forms.TextBox();
            this.tb_Final = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_quiz1 = new System.Windows.Forms.TextBox();
            this.tb_quiz2 = new System.Windows.Forms.TextBox();
            this.tb_quiz3 = new System.Windows.Forms.TextBox();
            this.tb_quiz4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_displayresult = new System.Windows.Forms.Label();
            this.lb_Grade = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_Final = new System.Windows.Forms.Label();
            this.lb_quiz = new System.Windows.Forms.Label();
            this.lb_mid = new System.Windows.Forms.Label();
            this.lb_attendance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(543, 83);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(51, 20);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name";
            // 
            // lb_StudentID
            // 
            this.lb_StudentID.AutoSize = true;
            this.lb_StudentID.Location = new System.Drawing.Point(543, 132);
            this.lb_StudentID.Name = "lb_StudentID";
            this.lb_StudentID.Size = new System.Drawing.Size(87, 20);
            this.lb_StudentID.TabIndex = 2;
            this.lb_StudentID.Text = "Student ID";
            // 
            // lb_Semester
            // 
            this.lb_Semester.AutoSize = true;
            this.lb_Semester.Location = new System.Drawing.Point(543, 180);
            this.lb_Semester.Name = "lb_Semester";
            this.lb_Semester.Size = new System.Drawing.Size(78, 20);
            this.lb_Semester.TabIndex = 3;
            this.lb_Semester.Text = "Semester";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(633, 80);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(260, 26);
            this.tb_Name.TabIndex = 4;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // tb_studentID
            // 
            this.tb_studentID.Location = new System.Drawing.Point(633, 129);
            this.tb_studentID.Name = "tb_studentID";
            this.tb_studentID.Size = new System.Drawing.Size(260, 26);
            this.tb_studentID.TabIndex = 5;
            // 
            // tb_semester
            // 
            this.tb_semester.Location = new System.Drawing.Point(633, 175);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(260, 26);
            this.tb_semester.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(918, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate Grade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Semester Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "No. of Attended \r\nClasses (Out of 28)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Location = new System.Drawing.Point(543, 442);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(114, 20);
            this.mid.TabIndex = 11;
            this.mid.Text = "Mid (Out of 75)";
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Location = new System.Drawing.Point(543, 512);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(132, 20);
            this.final.TabIndex = 12;
            this.final.Text = "Final (Out of 150)";
            // 
            // tb_attendance
            // 
            this.tb_attendance.Location = new System.Drawing.Point(702, 363);
            this.tb_attendance.Name = "tb_attendance";
            this.tb_attendance.Size = new System.Drawing.Size(112, 26);
            this.tb_attendance.TabIndex = 13;
            // 
            // tb_Mid
            // 
            this.tb_Mid.Location = new System.Drawing.Point(702, 437);
            this.tb_Mid.Name = "tb_Mid";
            this.tb_Mid.Size = new System.Drawing.Size(112, 26);
            this.tb_Mid.TabIndex = 14;
            // 
            // tb_Final
            // 
            this.tb_Final.Location = new System.Drawing.Point(702, 512);
            this.tb_Final.Name = "tb_Final";
            this.tb_Final.Size = new System.Drawing.Size(112, 26);
            this.tb_Final.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(519, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6, 585);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quiz I (Out of 15)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(882, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quiz II (Out of 15)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(882, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quiz III (Out of 15)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(882, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Quiz IV (Out of 15)";
            // 
            // tb_quiz1
            // 
            this.tb_quiz1.Location = new System.Drawing.Point(1023, 363);
            this.tb_quiz1.Name = "tb_quiz1";
            this.tb_quiz1.Size = new System.Drawing.Size(112, 26);
            this.tb_quiz1.TabIndex = 21;
            // 
            // tb_quiz2
            // 
            this.tb_quiz2.Location = new System.Drawing.Point(1023, 426);
            this.tb_quiz2.Name = "tb_quiz2";
            this.tb_quiz2.Size = new System.Drawing.Size(112, 26);
            this.tb_quiz2.TabIndex = 22;
            // 
            // tb_quiz3
            // 
            this.tb_quiz3.Location = new System.Drawing.Point(1023, 485);
            this.tb_quiz3.Name = "tb_quiz3";
            this.tb_quiz3.Size = new System.Drawing.Size(112, 26);
            this.tb_quiz3.TabIndex = 23;
            // 
            // tb_quiz4
            // 
            this.tb_quiz4.Location = new System.Drawing.Point(1023, 543);
            this.tb_quiz4.Name = "tb_quiz4";
            this.tb_quiz4.Size = new System.Drawing.Size(112, 26);
            this.tb_quiz4.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(990, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 51);
            this.button2.TabIndex = 40;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_displayresult
            // 
            this.lb_displayresult.AutoSize = true;
            this.lb_displayresult.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_displayresult.Location = new System.Drawing.Point(40, 469);
            this.lb_displayresult.Name = "lb_displayresult";
            this.lb_displayresult.Size = new System.Drawing.Size(58, 22);
            this.lb_displayresult.TabIndex = 55;
            this.lb_displayresult.Text = "label16";
            this.lb_displayresult.Visible = false;
            // 
            // lb_Grade
            // 
            this.lb_Grade.AutoSize = true;
            this.lb_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Grade.ForeColor = System.Drawing.Color.Red;
            this.lb_Grade.Location = new System.Drawing.Point(176, 386);
            this.lb_Grade.Name = "lb_Grade";
            this.lb_Grade.Size = new System.Drawing.Size(82, 25);
            this.lb_Grade.TabIndex = 54;
            this.lb_Grade.Text = "label16";
            this.lb_Grade.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(88, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 25);
            this.label15.TabIndex = 53;
            this.label15.Text = "Grade :";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(228, 314);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(67, 20);
            this.lb_total.TabIndex = 52;
            this.lb_total.Text = "label15";
            this.lb_total.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(162, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 51;
            this.label14.Text = "Total :";
            // 
            // lb_Final
            // 
            this.lb_Final.AutoSize = true;
            this.lb_Final.Location = new System.Drawing.Point(228, 237);
            this.lb_Final.Name = "lb_Final";
            this.lb_Final.Size = new System.Drawing.Size(60, 20);
            this.lb_Final.TabIndex = 50;
            this.lb_Final.Text = "label17";
            this.lb_Final.Visible = false;
            // 
            // lb_quiz
            // 
            this.lb_quiz.AutoSize = true;
            this.lb_quiz.Location = new System.Drawing.Point(228, 194);
            this.lb_quiz.Name = "lb_quiz";
            this.lb_quiz.Size = new System.Drawing.Size(60, 20);
            this.lb_quiz.TabIndex = 49;
            this.lb_quiz.Text = "label16";
            this.lb_quiz.Visible = false;
            // 
            // lb_mid
            // 
            this.lb_mid.AutoSize = true;
            this.lb_mid.Location = new System.Drawing.Point(228, 151);
            this.lb_mid.Name = "lb_mid";
            this.lb_mid.Size = new System.Drawing.Size(60, 20);
            this.lb_mid.TabIndex = 48;
            this.lb_mid.Text = "label15";
            this.lb_mid.Visible = false;
            // 
            // lb_attendance
            // 
            this.lb_attendance.AutoSize = true;
            this.lb_attendance.Location = new System.Drawing.Point(228, 106);
            this.lb_attendance.Name = "lb_attendance";
            this.lb_attendance.Size = new System.Drawing.Size(60, 20);
            this.lb_attendance.TabIndex = 47;
            this.lb_attendance.Text = "label14";
            this.lb_attendance.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "Final :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Quiz :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Mid :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Attendance :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(45, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 6);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 36);
            this.label9.TabIndex = 41;
            this.label9.Text = "Obtained Marks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1148, 583);
            this.Controls.Add(this.lb_displayresult);
            this.Controls.Add(this.lb_Grade);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_Final);
            this.Controls.Add(this.lb_quiz);
            this.Controls.Add(this.lb_mid);
            this.Controls.Add(this.lb_attendance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_quiz4);
            this.Controls.Add(this.tb_quiz3);
            this.Controls.Add(this.tb_quiz2);
            this.Controls.Add(this.tb_quiz1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Final);
            this.Controls.Add(this.tb_Mid);
            this.Controls.Add(this.tb_attendance);
            this.Controls.Add(this.final);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_semester);
            this.Controls.Add(this.tb_studentID);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Semester);
            this.Controls.Add(this.lb_StudentID);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_StudentID;
        private System.Windows.Forms.Label lb_Semester;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_studentID;
        private System.Windows.Forms.TextBox tb_semester;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.TextBox tb_attendance;
        private System.Windows.Forms.TextBox tb_Mid;
        private System.Windows.Forms.TextBox tb_Final;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_quiz1;
        private System.Windows.Forms.TextBox tb_quiz2;
        private System.Windows.Forms.TextBox tb_quiz3;
        private System.Windows.Forms.TextBox tb_quiz4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_displayresult;
        private System.Windows.Forms.Label lb_Grade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_Final;
        private System.Windows.Forms.Label lb_quiz;
        private System.Windows.Forms.Label lb_mid;
        private System.Windows.Forms.Label lb_attendance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
}

