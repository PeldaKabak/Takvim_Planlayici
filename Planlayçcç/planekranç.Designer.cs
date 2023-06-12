namespace Planlayıcı
{
    partial class planekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planekranı));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickergün = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickersaat = new System.Windows.Forms.DateTimePicker();
            this.rchtxtNot = new System.Windows.Forms.RichTextBox();
            this.cmbplan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnhatırlat = new System.Windows.Forms.Button();
            this.btnplanla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(278, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Başlangıç Zamanı";
            // 
            // dateTimePickergün
            // 
            this.dateTimePickergün.CalendarFont = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickergün.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickergün.Location = new System.Drawing.Point(56, 113);
            this.dateTimePickergün.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dateTimePickergün.Name = "dateTimePickergün";
            this.dateTimePickergün.Size = new System.Drawing.Size(317, 27);
            this.dateTimePickergün.TabIndex = 23;
            // 
            // dateTimePickersaat
            // 
            this.dateTimePickersaat.CalendarFont = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickersaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickersaat.Location = new System.Drawing.Point(426, 113);
            this.dateTimePickersaat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dateTimePickersaat.Name = "dateTimePickersaat";
            this.dateTimePickersaat.Size = new System.Drawing.Size(233, 27);
            this.dateTimePickersaat.TabIndex = 24;
            // 
            // rchtxtNot
            // 
            this.rchtxtNot.Location = new System.Drawing.Point(80, 194);
            this.rchtxtNot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchtxtNot.Name = "rchtxtNot";
            this.rchtxtNot.Size = new System.Drawing.Size(302, 208);
            this.rchtxtNot.TabIndex = 25;
            this.rchtxtNot.Text = "";
            // 
            // cmbplan
            // 
            this.cmbplan.FormattingEnabled = true;
            this.cmbplan.Items.AddRange(new object[] {
            "Toplantı",
            "Okul",
            "İş",
            "Randevu",
            "Seyahat"});
            this.cmbplan.Location = new System.Drawing.Point(480, 208);
            this.cmbplan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbplan.Name = "cmbplan";
            this.cmbplan.Size = new System.Drawing.Size(191, 27);
            this.cmbplan.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Not";
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(522, 369);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(113, 42);
            this.btngüncelle.TabIndex = 31;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            // 
            // btnhatırlat
            // 
            this.btnhatırlat.Location = new System.Drawing.Point(522, 319);
            this.btnhatırlat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnhatırlat.Name = "btnhatırlat";
            this.btnhatırlat.Size = new System.Drawing.Size(113, 42);
            this.btnhatırlat.TabIndex = 30;
            this.btnhatırlat.Text = "Hatırlat";
            this.btnhatırlat.UseVisualStyleBackColor = true;
            // 
            // btnplanla
            // 
            this.btnplanla.Location = new System.Drawing.Point(522, 260);
            this.btnplanla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnplanla.Name = "btnplanla";
            this.btnplanla.Size = new System.Drawing.Size(113, 42);
            this.btnplanla.TabIndex = 29;
            this.btnplanla.Text = "Planla";
            this.btnplanla.UseVisualStyleBackColor = true;
            this.btnplanla.Click += new System.EventHandler(this.btnplanla_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // planekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(760, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnhatırlat);
            this.Controls.Add(this.btnplanla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbplan);
            this.Controls.Add(this.rchtxtNot);
            this.Controls.Add(this.dateTimePickersaat);
            this.Controls.Add(this.dateTimePickergün);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "planekranı";
            this.Text = "planekranı";
  //          this.Load += new System.EventHandler(this.planekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickergün;
        private System.Windows.Forms.DateTimePicker dateTimePickersaat;
        private System.Windows.Forms.RichTextBox rchtxtNot;
        private System.Windows.Forms.ComboBox cmbplan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnhatırlat;
        private System.Windows.Forms.Button btnplanla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}