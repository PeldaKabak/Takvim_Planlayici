namespace Planlayıcı
{
    partial class Secimekranı
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
            this.btnplanlama = new System.Windows.Forms.Button();
            this.btnlisteleme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnplanlama
            // 
            this.btnplanlama.BackColor = System.Drawing.Color.Moccasin;
            this.btnplanlama.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnplanlama.Location = new System.Drawing.Point(164, 128);
            this.btnplanlama.Name = "btnplanlama";
            this.btnplanlama.Size = new System.Drawing.Size(212, 149);
            this.btnplanlama.TabIndex = 0;
            this.btnplanlama.Text = "Plan Oluştur";
            this.btnplanlama.UseVisualStyleBackColor = false;
            this.btnplanlama.Click += new System.EventHandler(this.btnplanlama_Click);
            // 
            // btnlisteleme
            // 
            this.btnlisteleme.BackColor = System.Drawing.Color.Tomato;
            this.btnlisteleme.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlisteleme.Location = new System.Drawing.Point(416, 128);
            this.btnlisteleme.Name = "btnlisteleme";
            this.btnlisteleme.Size = new System.Drawing.Size(212, 149);
            this.btnlisteleme.TabIndex = 1;
            this.btnlisteleme.Text = "Planlarımı Görüntüle";
            this.btnlisteleme.UseVisualStyleBackColor = false;
            this.btnlisteleme.Click += new System.EventHandler(this.btnlisteleme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(301, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "MY PLANNER";
            // 
            // Secimekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlisteleme);
            this.Controls.Add(this.btnplanlama);
            this.Name = "Secimekranı";
            this.Text = "Secimekranı";
            this.Load += new System.EventHandler(this.Secimekranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplanlama;
        private System.Windows.Forms.Button btnlisteleme;
        private System.Windows.Forms.Label label3;
    }
}