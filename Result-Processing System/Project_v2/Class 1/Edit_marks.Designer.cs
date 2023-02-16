namespace Project_v2
{
    partial class Edit_marks
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_rollno = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maths = new System.Windows.Forms.TextBox();
            this.txt_english = new System.Windows.Forms.TextBox();
            this.txt_social = new System.Windows.Forms.TextBox();
            this.txt_nepali = new System.Windows.Forms.TextBox();
            this.txt_science = new System.Windows.Forms.TextBox();
            this.txt_drawing = new System.Windows.Forms.TextBox();
            this.txt_gk = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Attendance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mosk Bold 700", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.button1.Location = new System.Drawing.Point(317, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 37;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_rollno
            // 
            this.txt_rollno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_rollno.Location = new System.Drawing.Point(249, 30);
            this.txt_rollno.MaxLength = 2;
            this.txt_rollno.Name = "txt_rollno";
            this.txt_rollno.Size = new System.Drawing.Size(33, 20);
            this.txt_rollno.TabIndex = 36;
            this.txt_rollno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(189, 32);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(54, 15);
            this.lbl_fname.TabIndex = 35;
            this.lbl_fname.Text = "Roll no:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Maths:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "English:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Social:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nepali:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Science:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Drawing:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "G.K:";
            // 
            // txt_maths
            // 
            this.txt_maths.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_maths.Location = new System.Drawing.Point(129, 76);
            this.txt_maths.MaxLength = 3;
            this.txt_maths.Name = "txt_maths";
            this.txt_maths.Size = new System.Drawing.Size(33, 20);
            this.txt_maths.TabIndex = 45;
            this.txt_maths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // txt_english
            // 
            this.txt_english.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_english.Location = new System.Drawing.Point(129, 129);
            this.txt_english.MaxLength = 3;
            this.txt_english.Name = "txt_english";
            this.txt_english.Size = new System.Drawing.Size(33, 20);
            this.txt_english.TabIndex = 46;
            this.txt_english.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // txt_social
            // 
            this.txt_social.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_social.Location = new System.Drawing.Point(129, 183);
            this.txt_social.MaxLength = 3;
            this.txt_social.Name = "txt_social";
            this.txt_social.Size = new System.Drawing.Size(33, 20);
            this.txt_social.TabIndex = 47;
            this.txt_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // txt_nepali
            // 
            this.txt_nepali.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nepali.Location = new System.Drawing.Point(129, 233);
            this.txt_nepali.MaxLength = 3;
            this.txt_nepali.Name = "txt_nepali";
            this.txt_nepali.Size = new System.Drawing.Size(33, 20);
            this.txt_nepali.TabIndex = 48;
            this.txt_nepali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // txt_science
            // 
            this.txt_science.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_science.Location = new System.Drawing.Point(440, 76);
            this.txt_science.MaxLength = 3;
            this.txt_science.Name = "txt_science";
            this.txt_science.Size = new System.Drawing.Size(33, 20);
            this.txt_science.TabIndex = 49;
            this.txt_science.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // txt_drawing
            // 
            this.txt_drawing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_drawing.Location = new System.Drawing.Point(440, 130);
            this.txt_drawing.MaxLength = 3;
            this.txt_drawing.Name = "txt_drawing";
            this.txt_drawing.Size = new System.Drawing.Size(33, 20);
            this.txt_drawing.TabIndex = 50;
            this.txt_drawing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // txt_gk
            // 
            this.txt_gk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_gk.Location = new System.Drawing.Point(440, 185);
            this.txt_gk.MaxLength = 3;
            this.txt_gk.Name = "txt_gk";
            this.txt_gk.Size = new System.Drawing.Size(33, 20);
            this.txt_gk.TabIndex = 51;
            this.txt_gk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mosk Bold 700", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.button2.Location = new System.Drawing.Point(472, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 52;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Attendance
            // 
            this.txt_Attendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Attendance.Location = new System.Drawing.Point(442, 231);
            this.txt_Attendance.MaxLength = 3;
            this.txt_Attendance.Name = "txt_Attendance";
            this.txt_Attendance.Size = new System.Drawing.Size(33, 20);
            this.txt_Attendance.TabIndex = 132;
            this.txt_Attendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate_num);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 131;
            this.label8.Text = "Attendance:";
            // 
            // Edit_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 335);
            this.Controls.Add(this.txt_Attendance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_gk);
            this.Controls.Add(this.txt_drawing);
            this.Controls.Add(this.txt_science);
            this.Controls.Add(this.txt_nepali);
            this.Controls.Add(this.txt_social);
            this.Controls.Add(this.txt_english);
            this.Controls.Add(this.txt_maths);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_rollno);
            this.Controls.Add(this.lbl_fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_marks";
            this.Text = "Edit_marks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_rollno;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maths;
        private System.Windows.Forms.TextBox txt_english;
        private System.Windows.Forms.TextBox txt_social;
        private System.Windows.Forms.TextBox txt_nepali;
        private System.Windows.Forms.TextBox txt_science;
        private System.Windows.Forms.TextBox txt_drawing;
        private System.Windows.Forms.TextBox txt_gk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Attendance;
        private System.Windows.Forms.Label label8;
    }
}