namespace team18New
{
    partial class findRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findRoom));
            this.back = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.nameRoom = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.finlePrice = new System.Windows.Forms.TextBox();
            this.labelBikoret = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.review = new System.Windows.Forms.TextBox();
            this.sendOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(75, 369);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(81, 33);
            this.back.TabIndex = 0;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(320, 52);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(267, 32);
            this.text.TabIndex = 1;
            this.text.Text = "החלל שמצאנו עבורך";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(657, 124);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 22);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "שם החלל";
            // 
            // nameRoom
            // 
            this.nameRoom.Location = new System.Drawing.Point(391, 124);
            this.nameRoom.Name = "nameRoom";
            this.nameRoom.Size = new System.Drawing.Size(216, 22);
            this.nameRoom.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(657, 168);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 22);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "מחיר סופי";
            // 
            // finlePrice
            // 
            this.finlePrice.Location = new System.Drawing.Point(391, 168);
            this.finlePrice.Name = "finlePrice";
            this.finlePrice.Size = new System.Drawing.Size(216, 22);
            this.finlePrice.TabIndex = 5;
            // 
            // labelBikoret
            // 
            this.labelBikoret.AutoSize = true;
            this.labelBikoret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBikoret.Location = new System.Drawing.Point(665, 227);
            this.labelBikoret.Name = "labelBikoret";
            this.labelBikoret.Size = new System.Drawing.Size(70, 22);
            this.labelBikoret.TabIndex = 6;
            this.labelBikoret.Text = "ביקורות";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(391, 227);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(219, 22);
            this.review.TabIndex = 8;
            // 
            // sendOrder
            // 
            this.sendOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendOrder.Location = new System.Drawing.Point(432, 290);
            this.sendOrder.Name = "sendOrder";
            this.sendOrder.Size = new System.Drawing.Size(114, 48);
            this.sendOrder.TabIndex = 9;
            this.sendOrder.Text = "הזמן";
            this.sendOrder.UseVisualStyleBackColor = true;
            // 
            // findRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendOrder);
            this.Controls.Add(this.review);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBikoret);
            this.Controls.Add(this.finlePrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.nameRoom);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.text);
            this.Controls.Add(this.back);
            this.Name = "findRoom";
            this.Text = "findRoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameRoom;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox finlePrice;
        private System.Windows.Forms.Label labelBikoret;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.Button sendOrder;
    }
}