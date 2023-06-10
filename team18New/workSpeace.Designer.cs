namespace team18New
{
    partial class workSpeace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workSpeace));
            this.back = new System.Windows.Forms.Button();
            this.newWorkSpece = new System.Windows.Forms.Button();
            this.exsitWorkSpeace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(22, 397);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 32);
            this.back.TabIndex = 0;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // newWorkSpece
            // 
            this.newWorkSpece.BackColor = System.Drawing.Color.Peru;
            this.newWorkSpece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorkSpece.ForeColor = System.Drawing.SystemColors.Info;
            this.newWorkSpece.Location = new System.Drawing.Point(477, 163);
            this.newWorkSpece.Name = "newWorkSpece";
            this.newWorkSpece.Size = new System.Drawing.Size(221, 60);
            this.newWorkSpece.TabIndex = 1;
            this.newWorkSpece.Text = "יצירת חלל עבודה חדש";
            this.newWorkSpece.UseVisualStyleBackColor = false;
            this.newWorkSpece.Click += new System.EventHandler(this.newWorkSpece_Click);
            // 
            // exsitWorkSpeace
            // 
            this.exsitWorkSpeace.BackColor = System.Drawing.Color.Peru;
            this.exsitWorkSpeace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exsitWorkSpeace.ForeColor = System.Drawing.SystemColors.Info;
            this.exsitWorkSpeace.Location = new System.Drawing.Point(137, 161);
            this.exsitWorkSpeace.Name = "exsitWorkSpeace";
            this.exsitWorkSpeace.Size = new System.Drawing.Size(238, 62);
            this.exsitWorkSpeace.TabIndex = 2;
            this.exsitWorkSpeace.Text = "כניסה לחלל עבודה קיים";
            this.exsitWorkSpeace.UseVisualStyleBackColor = false;
            this.exsitWorkSpeace.Click += new System.EventHandler(this.exsitWorkSpeace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(291, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "מערכת ניהול חלל עבודה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1923);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // workSpeace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exsitWorkSpeace);
            this.Controls.Add(this.newWorkSpece);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "workSpeace";
            this.Text = "workSpeace";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button newWorkSpece;
        private System.Windows.Forms.Button exsitWorkSpeace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}