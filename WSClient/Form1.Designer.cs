namespace WSClient
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
            this.btnDsSvNC = new System.Windows.Forms.Button();
            this.btnDsSvMonHoc = new System.Windows.Forms.Button();
            this.btnTop5sv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDsSvNC
            // 
            this.btnDsSvNC.Location = new System.Drawing.Point(25, 48);
            this.btnDsSvNC.Name = "btnDsSvNC";
            this.btnDsSvNC.Size = new System.Drawing.Size(176, 50);
            this.btnDsSvNC.TabIndex = 0;
            this.btnDsSvNC.Text = "Danh sách sinh viên lớp niên chế";
            this.btnDsSvNC.UseVisualStyleBackColor = true;
            this.btnDsSvNC.Click += new System.EventHandler(this.btnDsSvNC_Click);
            // 
            // btnDsSvMonHoc
            // 
            this.btnDsSvMonHoc.Location = new System.Drawing.Point(25, 132);
            this.btnDsSvMonHoc.Name = "btnDsSvMonHoc";
            this.btnDsSvMonHoc.Size = new System.Drawing.Size(176, 50);
            this.btnDsSvMonHoc.TabIndex = 0;
            this.btnDsSvMonHoc.Text = "Danh sách sinh viên lớp môn học";
            this.btnDsSvMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnTop5sv
            // 
            this.btnTop5sv.Location = new System.Drawing.Point(25, 209);
            this.btnTop5sv.Name = "btnTop5sv";
            this.btnTop5sv.Size = new System.Drawing.Size(176, 50);
            this.btnTop5sv.TabIndex = 0;
            this.btnTop5sv.Text = "Top 5 sinh viên điểm cao nhất";
            this.btnTop5sv.UseVisualStyleBackColor = true;
            this.btnTop5sv.Click += new System.EventHandler(this.btnTop5sv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Lấy danh sách các sinh viên của lớp niên chế theo tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Lấy danh sách các sinh viên của lớp môn học và danh sách điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "- Lấy top 5 sinh viên cao điểm nhất theo học kỳ/năm học";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTop5sv);
            this.Controls.Add(this.btnDsSvMonHoc);
            this.Controls.Add(this.btnDsSvNC);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WS Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDsSvNC;
        private System.Windows.Forms.Button btnDsSvMonHoc;
        private System.Windows.Forms.Button btnTop5sv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

