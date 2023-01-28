namespace Project_v2
{
    partial class Print
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
            this.btn_res_Print = new System.Windows.Forms.Button();
            this.txt_no_std = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_res_Print
            // 
            this.btn_res_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_res_Print.FlatAppearance.BorderSize = 3;
            this.btn_res_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res_Print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_res_Print.Location = new System.Drawing.Point(290, 207);
            this.btn_res_Print.Name = "btn_res_Print";
            this.btn_res_Print.Size = new System.Drawing.Size(225, 48);
            this.btn_res_Print.TabIndex = 0;
            this.btn_res_Print.Text = "Print the Results";
            this.btn_res_Print.UseVisualStyleBackColor = false;
            this.btn_res_Print.Click += new System.EventHandler(this.btn_res_Print_Click);
            // 
            // txt_no_std
            // 
            this.txt_no_std.Location = new System.Drawing.Point(432, 142);
            this.txt_no_std.Name = "txt_no_std";
            this.txt_no_std.Size = new System.Drawing.Size(38, 20);
            this.txt_no_std.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(302, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "No of Student :";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_no_std);
            this.Controls.Add(this.btn_res_Print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Result";
            this.Load += new System.EventHandler(this.Print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_res_Print;
        private System.Windows.Forms.TextBox txt_no_std;
        private System.Windows.Forms.Label label3;
    }
}