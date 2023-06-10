namespace team18New
{
    partial class orders
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
            System.Windows.Forms.ComboBox cotgory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orders));
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.size = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateRoom = new System.Windows.Forms.DateTimePicker();
            this.findRoom = new System.Windows.Forms.Button();
            this.amountOfRooms = new System.Windows.Forms.TextBox();
            cotgory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cotgory
            // 
            cotgory.FormattingEnabled = true;
            cotgory.Items.AddRange(new object[] {
            "Meeting room",
            "Presentation room",
            "Assembly Hall",
            "Working Room",
            "Shared Space"});
            cotgory.Location = new System.Drawing.Point(448, 195);
            cotgory.Name = "cotgory";
            cotgory.Size = new System.Drawing.Size(121, 24);
            cotgory.TabIndex = 9;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(36, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(142, 25);
            this.back.TabIndex = 0;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "אנחנו כאן, לכל דרך בה תבחרו לעבוד";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "חפשו מיקום עבודה ליחידים או לחברות בכל הגדלים\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "גודל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "עיר";
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "Brazil",
            "Chile",
            "Israel",
            "Greece",
            "Israel",
            "Serbia",
            "Germany",
            "France",
            "Israel",
            "Thailand"});
            this.city.Location = new System.Drawing.Point(448, 111);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 24);
            this.city.TabIndex = 5;
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "One",
            "Small",
            "Medium",
            "Big"});
            this.size.Location = new System.Drawing.Point(448, 151);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(121, 24);
            this.size.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "קטגוריית חדר";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "כמות - עד 10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "תאריך השכרה";
            // 
            // dateRoom
            // 
            this.dateRoom.Location = new System.Drawing.Point(402, 282);
            this.dateRoom.Name = "dateRoom";
            this.dateRoom.Size = new System.Drawing.Size(200, 22);
            this.dateRoom.TabIndex = 13;
            // 
            // findRoom
            // 
            this.findRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findRoom.Location = new System.Drawing.Point(318, 336);
            this.findRoom.Name = "findRoom";
            this.findRoom.Size = new System.Drawing.Size(160, 34);
            this.findRoom.TabIndex = 14;
            this.findRoom.Text = "חפש לי חלל";
            this.findRoom.UseVisualStyleBackColor = true;
            this.findRoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // amountOfRooms
            // 
            this.amountOfRooms.Location = new System.Drawing.Point(448, 233);
            this.amountOfRooms.Name = "amountOfRooms";
            this.amountOfRooms.Size = new System.Drawing.Size(121, 22);
            this.amountOfRooms.TabIndex = 15;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.amountOfRooms);
            this.Controls.Add(this.findRoom);
            this.Controls.Add(this.dateRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(cotgory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.size);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "orders";
            this.Text = "orders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateRoom;
        private System.Windows.Forms.Button findRoom;
        private System.Windows.Forms.TextBox amountOfRooms;
    }
}