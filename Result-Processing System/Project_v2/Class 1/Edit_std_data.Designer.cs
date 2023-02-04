namespace Project_v2
{
    partial class Edit_std_data
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_retrive = new System.Windows.Forms.Button();
            this.txt_rollno = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Mosk Bold 700", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.btn_Update.Location = new System.Drawing.Point(516, 249);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(116, 38);
            this.btn_Update.TabIndex = 45;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_age
            // 
            this.txt_age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_age.Location = new System.Drawing.Point(516, 155);
            this.txt_age.MaxLength = 20;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(33, 20);
            this.txt_age.TabIndex = 44;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // txt_dob
            // 
            this.txt_dob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dob.Location = new System.Drawing.Point(156, 208);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(112, 20);
            this.txt_dob.TabIndex = 43;
            this.txt_dob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dob_KeyPress);
            // 
            // lbl_dob
            // 
            this.lbl_dob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(109, 213);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(36, 15);
            this.lbl_dob.TabIndex = 42;
            this.lbl_dob.Text = "DOB:";
            // 
            // lbl_age
            // 
            this.lbl_age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(474, 160);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(36, 15);
            this.lbl_age.TabIndex = 41;
            this.lbl_age.Text = "Age:";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_phone.Location = new System.Drawing.Point(155, 155);
            this.txt_phone.MaxLength = 10;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(112, 20);
            this.txt_phone.TabIndex = 40;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(45, 157);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(104, 15);
            this.lbl_phone.TabIndex = 39;
            this.lbl_phone.Text = "Phone Number:";
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lname.Location = new System.Drawing.Point(516, 103);
            this.txt_lname.MaxLength = 20;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(112, 20);
            this.txt_lname.TabIndex = 38;
            this.txt_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lname_KeyPress);
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fname.Location = new System.Drawing.Point(155, 103);
            this.txt_fname.MaxLength = 20;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(112, 20);
            this.txt_fname.TabIndex = 37;
            this.txt_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fname_KeyPress);
            // 
            // lbl_lname
            // 
            this.lbl_lname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(429, 108);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(81, 15);
            this.lbl_lname.TabIndex = 36;
            this.lbl_lname.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name:";
            // 
            // btn_retrive
            // 
            this.btn_retrive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_retrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.btn_retrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retrive.Font = new System.Drawing.Font("Mosk Bold 700", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retrive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.btn_retrive.Location = new System.Drawing.Point(400, 23);
            this.btn_retrive.Name = "btn_retrive";
            this.btn_retrive.Size = new System.Drawing.Size(99, 30);
            this.btn_retrive.TabIndex = 34;
            this.btn_retrive.Text = "Retrive";
            this.btn_retrive.UseVisualStyleBackColor = false;
            this.btn_retrive.Click += new System.EventHandler(this.btn_retrive_Click);
            // 
            // txt_rollno
            // 
            this.txt_rollno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_rollno.Location = new System.Drawing.Point(332, 29);
            this.txt_rollno.MaxLength = 20;
            this.txt_rollno.Name = "txt_rollno";
            this.txt_rollno.Size = new System.Drawing.Size(33, 20);
            this.txt_rollno.TabIndex = 33;
            this.txt_rollno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rollno_KeyPress);
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(272, 31);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(54, 15);
            this.lbl_fname.TabIndex = 32;
            this.lbl_fname.Text = "Roll no:";
            // 
            // Edit_std_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 361);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_retrive);
            this.Controls.Add(this.txt_rollno);
            this.Controls.Add(this.lbl_fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_std_data";
            this.Text = "Edit_std_data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_retrive;
        private System.Windows.Forms.TextBox txt_rollno;
        private System.Windows.Forms.Label lbl_fname;
    }
}