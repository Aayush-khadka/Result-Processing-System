namespace Project_v2
{
    partial class Insert_Class_One
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
            this.combo_Subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_std_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_marks = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.Data_View = new System.Windows.Forms.DataGridView();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_s_zero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_Subject
            // 
            this.combo_Subject.FormattingEnabled = true;
            this.combo_Subject.Items.AddRange(new object[] {
            "Maths",
            "Science",
            "Social",
            "English",
            "Nepali",
            "Drawing",
            "G.K"});
            this.combo_Subject.Location = new System.Drawing.Point(88, 25);
            this.combo_Subject.Name = "combo_Subject";
            this.combo_Subject.Size = new System.Drawing.Size(89, 21);
            this.combo_Subject.TabIndex = 0;
            this.combo_Subject.SelectedIndexChanged += new System.EventHandler(this.combo_Subject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // lbl_std_name
            // 
            this.lbl_std_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_std_name.AutoSize = true;
            this.lbl_std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_std_name.Location = new System.Drawing.Point(162, 68);
            this.lbl_std_name.Name = "lbl_std_name";
            this.lbl_std_name.Size = new System.Drawing.Size(86, 15);
            this.lbl_std_name.TabIndex = 3;
            this.lbl_std_name.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marks Obtained:";
            // 
            // txt_marks
            // 
            this.txt_marks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_marks.Location = new System.Drawing.Point(481, 66);
            this.txt_marks.MaxLength = 2;
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(33, 20);
            this.txt_marks.TabIndex = 6;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Mosk Bold 700", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.btn_Submit.Location = new System.Drawing.Point(542, 61);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(99, 29);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Enter";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Roll no:";
            // 
            // lbl_num
            // 
            this.lbl_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.Location = new System.Drawing.Point(313, 68);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(34, 15);
            this.lbl_num.TabIndex = 10;
            this.lbl_num.Text = "Num";
            // 
            // Data_View
            // 
            this.Data_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roll});
            this.Data_View.Location = new System.Drawing.Point(213, 101);
            this.Data_View.Name = "Data_View";
            this.Data_View.ReadOnly = true;
            this.Data_View.Size = new System.Drawing.Size(282, 439);
            this.Data_View.TabIndex = 11;
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "roll_no";
            this.Roll.HeaderText = "Roll No";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            this.Roll.Width = 120;
            // 
            // btn_s_zero
            // 
            this.btn_s_zero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_s_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.btn_s_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_s_zero.Font = new System.Drawing.Font("Mosk Bold 700", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s_zero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.btn_s_zero.Location = new System.Drawing.Point(542, 27);
            this.btn_s_zero.Name = "btn_s_zero";
            this.btn_s_zero.Size = new System.Drawing.Size(99, 29);
            this.btn_s_zero.TabIndex = 12;
            this.btn_s_zero.Text = "Set 0";
            this.btn_s_zero.UseVisualStyleBackColor = false;
            this.btn_s_zero.Click += new System.EventHandler(this.btn_s_zero_Click);
            // 
            // Insert_Class_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 541);
            this.Controls.Add(this.btn_s_zero);
            this.Controls.Add(this.Data_View);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_marks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_std_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_Subject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insert_Class_One";
            this.Text = "Insert_Class_One";
            this.Load += new System.EventHandler(this.Insert_Class_One_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_std_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_marks;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.DataGridView Data_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.Button btn_s_zero;
    }
}