namespace team18New
{
    partial class loginManeger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginManeger));
            this.back = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.workSpeace = new System.Windows.Forms.Button();
            this.salery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 412);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 26);
            this.back.TabIndex = 0;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.SaddleBrown;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.report.Location = new System.Drawing.Point(597, 209);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(169, 86);
            this.report.TabIndex = 1;
            this.report.Text = "להנפיק דוח עובדים שבועי";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // workSpeace
            // 
            this.workSpeace.BackColor = System.Drawing.Color.SaddleBrown;
            this.workSpeace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSpeace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.workSpeace.Location = new System.Drawing.Point(361, 209);
            this.workSpeace.Name = "workSpeace";
            this.workSpeace.Size = new System.Drawing.Size(161, 85);
            this.workSpeace.TabIndex = 2;
            this.workSpeace.Text = "ניהול חללי עבודה";
            this.workSpeace.UseVisualStyleBackColor = false;
            this.workSpeace.Click += new System.EventHandler(this.workSpeace_Click);
            // 
            // salery
            // 
            this.salery.BackColor = System.Drawing.Color.SaddleBrown;
            this.salery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salery.ForeColor = System.Drawing.SystemColors.Control;
            this.salery.Location = new System.Drawing.Point(84, 205);
            this.salery.Name = "salery";
            this.salery.Size = new System.Drawing.Size(198, 89);
            this.salery.TabIndex = 3;
            this.salery.Text = "חישוב שכר עובד חודשי";
            this.salery.UseVisualStyleBackColor = false;
            this.salery.Click += new System.EventHandler(this.salery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(610, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "יום נעים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(355, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "מה תרצה לעשות היום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(331, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // loginManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salery);
            this.Controls.Add(this.workSpeace);
            this.Controls.Add(this.report);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginManeger";
            this.Text = "loginManeger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button workSpeace;
        private System.Windows.Forms.Button salery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}