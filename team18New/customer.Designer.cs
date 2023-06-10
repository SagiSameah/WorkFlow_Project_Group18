namespace team18New
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.text = new System.Windows.Forms.Label();
            this.newCus = new System.Windows.Forms.Button();
            this.existCust = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.text.Location = new System.Drawing.Point(304, 79);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(198, 36);
            this.text.TabIndex = 0;
            this.text.Text = "מערכת לקוחות";
            // 
            // newCus
            // 
            this.newCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newCus.Location = new System.Drawing.Point(438, 210);
            this.newCus.Name = "newCus";
            this.newCus.Size = new System.Drawing.Size(286, 71);
            this.newCus.TabIndex = 1;
            this.newCus.Text = "יצירת פרופיל לקוח חדש";
            this.newCus.UseVisualStyleBackColor = true;
            this.newCus.Click += new System.EventHandler(this.newCus_Click);
            // 
            // existCust
            // 
            this.existCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existCust.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.existCust.Location = new System.Drawing.Point(438, 321);
            this.existCust.Name = "existCust";
            this.existCust.Size = new System.Drawing.Size(286, 65);
            this.existCust.TabIndex = 2;
            this.existCust.Text = "כניסה לפרופיל לקוח קיים";
            this.existCust.UseVisualStyleBackColor = true;
            this.existCust.Click += new System.EventHandler(this.existCust_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(59, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(111, 36);
            this.back.TabIndex = 3;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-365, -392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.existCust);
            this.Controls.Add(this.newCus);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pictureBox1);
            this.Name = "customer";
            this.Text = "customer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button newCus;
        private System.Windows.Forms.Button existCust;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}