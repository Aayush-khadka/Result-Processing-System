namespace Project_v2
{
    partial class class1_delete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete_data = new System.Windows.Forms.Button();
            this.txt_roll = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.btn_Delete_data);
            this.groupBox1.Controls.Add(this.txt_roll);
            this.groupBox1.Controls.Add(this.lbl_fname);
            this.groupBox1.Location = new System.Drawing.Point(22, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // btn_Delete_data
            // 
            this.btn_Delete_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Delete_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_Delete_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_data.Font = new System.Drawing.Font("Mosk Bold 700", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.btn_Delete_data.Location = new System.Drawing.Point(90, 101);
            this.btn_Delete_data.Name = "btn_Delete_data";
            this.btn_Delete_data.Size = new System.Drawing.Size(90, 29);
            this.btn_Delete_data.TabIndex = 15;
            this.btn_Delete_data.Text = "Delete";
            this.btn_Delete_data.UseVisualStyleBackColor = false;
            // 
            // txt_roll
            // 
            this.txt_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_roll.Location = new System.Drawing.Point(147, 51);
            this.txt_roll.MaxLength = 3;
            this.txt_roll.Name = "txt_roll";
            this.txt_roll.Size = new System.Drawing.Size(33, 20);
            this.txt_roll.TabIndex = 128;
            // 
            // lbl_fname
            // 
            this.lbl_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(87, 53);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(54, 15);
            this.lbl_fname.TabIndex = 16;
            this.lbl_fname.Text = "Roll no:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.txt_num);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(324, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Marks";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Mosk Bold 700", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.btn_delete.Location = new System.Drawing.Point(88, 101);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 29);
            this.btn_delete.TabIndex = 129;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_num
            // 
            this.txt_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_num.Location = new System.Drawing.Point(145, 41);
            this.txt_num.MaxLength = 3;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(33, 20);
            this.txt_num.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 130;
            this.label1.Text = "Roll no:";
            // 
            // class1_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 226);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "class1_delete";
            this.Text = "class1_delete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_roll;
        private System.Windows.Forms.Button btn_Delete_data;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label1;


    }
}