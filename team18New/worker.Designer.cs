namespace team18New
{
    partial class worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(worker));
            this.label1 = new System.Windows.Forms.Label();
            this.newWorker = new System.Windows.Forms.Button();
            this.exsitWorker = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(306, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "מערכת עובדים";
            // 
            // newWorker
            // 
            this.newWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorker.ForeColor = System.Drawing.SystemColors.GrayText;
            this.newWorker.Location = new System.Drawing.Point(462, 175);
            this.newWorker.Name = "newWorker";
            this.newWorker.Size = new System.Drawing.Size(236, 63);
            this.newWorker.TabIndex = 1;
            this.newWorker.Text = "יצירת פרופיל עובד חדש";
            this.newWorker.UseVisualStyleBackColor = true;
            this.newWorker.Click += new System.EventHandler(this.newWorker_Click);
            // 
            // exsitWorker
            // 
            this.exsitWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exsitWorker.ForeColor = System.Drawing.SystemColors.GrayText;
            this.exsitWorker.Location = new System.Drawing.Point(462, 272);
            this.exsitWorker.Name = "exsitWorker";
            this.exsitWorker.Size = new System.Drawing.Size(236, 61);
            this.exsitWorker.TabIndex = 2;
            this.exsitWorker.Text = "כניסה לפרופיל עובד קיים";
            this.exsitWorker.UseVisualStyleBackColor = true;
            this.exsitWorker.Click += new System.EventHandler(this.exsitWorker_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(104, 378);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(107, 27);
            this.back.TabIndex = 3;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-177, -125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 1000);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exsitWorker);
            this.Controls.Add(this.newWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "worker";
            this.Text = "worker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newWorker;
        private System.Windows.Forms.Button exsitWorker;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}