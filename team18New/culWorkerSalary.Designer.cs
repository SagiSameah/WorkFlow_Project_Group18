namespace team18New
{
    partial class culWorkerSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(culWorkerSalary));
            this.back = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.labelBounos = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.TextBox();
            this.culculet = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.totalSalery = new System.Windows.Forms.TextBox();
            this.updateSalery = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(42, 403);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(106, 26);
            this.back.TabIndex = 0;
            this.back.Text = "חזרה";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(341, 41);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(172, 25);
            this.text.TabIndex = 1;
            this.text.Text = "חישוב שכר עובדים";
            this.text.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnter.Location = new System.Drawing.Point(561, 117);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(135, 25);
            this.labelEnter.TabIndex = 2;
            this.labelEnter.Text = "הכנס ת\"ז עובד";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(54, 119);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(130, 26);
            this.search.TabIndex = 3;
            this.search.Text = "חיפוש";
            this.search.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(237, 116);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(262, 22);
            this.id.TabIndex = 4;
            // 
            // labelBounos
            // 
            this.labelBounos.AutoSize = true;
            this.labelBounos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBounos.Location = new System.Drawing.Point(561, 177);
            this.labelBounos.Name = "labelBounos";
            this.labelBounos.Size = new System.Drawing.Size(183, 25);
            this.labelBounos.TabIndex = 5;
            this.labelBounos.Text = "הכנס בונוס באחוזים";
            // 
            // bonus
            // 
            this.bonus.Location = new System.Drawing.Point(237, 180);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(262, 22);
            this.bonus.TabIndex = 6;
            // 
            // culculet
            // 
            this.culculet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culculet.Location = new System.Drawing.Point(54, 180);
            this.culculet.Name = "culculet";
            this.culculet.Size = new System.Drawing.Size(130, 26);
            this.culculet.TabIndex = 7;
            this.culculet.Text = "בצע חישוב";
            this.culculet.UseVisualStyleBackColor = true;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(210, 215);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(303, 16);
            this.text2.TabIndex = 8;
            this.text2.Text = "במידה ואינך רוצה להזין בונוס לעובד יש להזין ערך 0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(451, 277);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(258, 25);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "משכורת חודשית לאחר חישוב";
            // 
            // totalSalery
            // 
            this.totalSalery.Location = new System.Drawing.Point(151, 277);
            this.totalSalery.Name = "totalSalery";
            this.totalSalery.Size = new System.Drawing.Size(262, 22);
            this.totalSalery.TabIndex = 10;
            // 
            // updateSalery
            // 
            this.updateSalery.BackColor = System.Drawing.Color.Tan;
            this.updateSalery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSalery.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.updateSalery.Location = new System.Drawing.Point(241, 330);
            this.updateSalery.Name = "updateSalery";
            this.updateSalery.Size = new System.Drawing.Size(258, 78);
            this.updateSalery.TabIndex = 11;
            this.updateSalery.Text = "לחץ על מנת לעדכן את שכר העובד במערכת";
            this.updateSalery.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // culWorkerSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateSalery);
            this.Controls.Add(this.totalSalery);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.culculet);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.labelBounos);
            this.Controls.Add(this.id);
            this.Controls.Add(this.search);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.text);
            this.Controls.Add(this.back);
            this.Name = "culWorkerSalary";
            this.Text = "culWorkerSalary";
            this.Load += new System.EventHandler(this.culWorkerSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label labelBounos;
        private System.Windows.Forms.TextBox bonus;
        private System.Windows.Forms.Button culculet;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox totalSalery;
        private System.Windows.Forms.Button updateSalery;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}