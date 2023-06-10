namespace team18New
{
    partial class custServiRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(custServiRating));
            this.back = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.numberReqest = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.sendRating = new System.Windows.Forms.Button();
            this.rating = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(38, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.SeaShell;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(245, 34);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(308, 25);
            this.text.TabIndex = 1;
            this.text.Text = "דירוג שירות לקוחות לאחר סגירת פנייה";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.BackColor = System.Drawing.Color.Sienna;
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text3.Location = new System.Drawing.Point(443, 96);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(313, 29);
            this.text3.TabIndex = 2;
            this.text3.Text = "הכנס בבקשה את מספר הפנייה";
            // 
            // numberReqest
            // 
            this.numberReqest.Location = new System.Drawing.Point(167, 96);
            this.numberReqest.Name = "numberReqest";
            this.numberReqest.Size = new System.Drawing.Size(270, 22);
            this.numberReqest.TabIndex = 3;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Maroon;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(70, 97);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "חיפוש";
            this.search.UseVisualStyleBackColor = false;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.BackColor = System.Drawing.Color.Sienna;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text2.Location = new System.Drawing.Point(258, 171);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(353, 25);
            this.text2.TabIndex = 5;
            this.text2.Text = "דרג כאשר 10 מרוצה בהחלט ו1 לא מרוצה כלל";
            // 
            // sendRating
            // 
            this.sendRating.BackColor = System.Drawing.Color.Maroon;
            this.sendRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRating.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendRating.Location = new System.Drawing.Point(368, 298);
            this.sendRating.Name = "sendRating";
            this.sendRating.Size = new System.Drawing.Size(121, 34);
            this.sendRating.TabIndex = 7;
            this.sendRating.Text = "שלח דירוג";
            this.sendRating.UseVisualStyleBackColor = false;
            // 
            // rating
            // 
            this.rating.FormattingEnabled = true;
            this.rating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rating.Location = new System.Drawing.Point(368, 251);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(121, 24);
            this.rating.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // custServiRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.sendRating);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.numberReqest);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "custServiRating";
            this.Text = "custServiRating";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.TextBox numberReqest;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button sendRating;
        private System.Windows.Forms.ComboBox rating;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}