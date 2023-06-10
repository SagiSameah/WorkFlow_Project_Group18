namespace team18New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.customerEnter = new System.Windows.Forms.Button();
            this.workerEnter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.White;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.text.Location = new System.Drawing.Point(351, 34);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(167, 32);
            this.text.TabIndex = 0;
            this.text.Text = "welcome to";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.White;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.text2.Location = new System.Drawing.Point(135, 66);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(599, 135);
            this.text2.TabIndex = 1;
            this.text2.Text = "WorkFlow";
            // 
            // customerEnter
            // 
            this.customerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEnter.Location = new System.Drawing.Point(432, 331);
            this.customerEnter.Name = "customerEnter";
            this.customerEnter.Size = new System.Drawing.Size(226, 53);
            this.customerEnter.TabIndex = 2;
            this.customerEnter.Text = "כניסת לקוח";
            this.customerEnter.UseVisualStyleBackColor = true;
            this.customerEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // workerEnter
            // 
            this.workerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerEnter.Location = new System.Drawing.Point(106, 331);
            this.workerEnter.Name = "workerEnter";
            this.workerEnter.Size = new System.Drawing.Size(238, 53);
            this.workerEnter.TabIndex = 3;
            this.workerEnter.Text = "כניסות עובד";
            this.workerEnter.UseVisualStyleBackColor = true;
            this.workerEnter.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-176, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1140, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerEnter);
            this.Controls.Add(this.customerEnter);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button customerEnter;
        private System.Windows.Forms.Button workerEnter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

