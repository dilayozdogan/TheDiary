
namespace TheDiary
{
    partial class GunlukBaslik
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
            this.label1 = new System.Windows.Forms.Label();
            this.diarytitleBtn = new System.Windows.Forms.TextBox();
            this.baslikcikisBtn = new System.Windows.Forms.Button();
            this.baslikkaydetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(113, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlüğünü Adlandır";
            // 
            // diarytitleBtn
            // 
            this.diarytitleBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diarytitleBtn.Location = new System.Drawing.Point(136, 92);
            this.diarytitleBtn.Name = "diarytitleBtn";
            this.diarytitleBtn.Size = new System.Drawing.Size(232, 44);
            this.diarytitleBtn.TabIndex = 1;
            // 
            // baslikcikisBtn
            // 
            this.baslikcikisBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikcikisBtn.Location = new System.Drawing.Point(136, 174);
            this.baslikcikisBtn.Name = "baslikcikisBtn";
            this.baslikcikisBtn.Size = new System.Drawing.Size(109, 44);
            this.baslikcikisBtn.TabIndex = 3;
            this.baslikcikisBtn.Text = "Çıkış";
            this.baslikcikisBtn.UseVisualStyleBackColor = true;
            this.baslikcikisBtn.Click += new System.EventHandler(this.baslikcikisBtn_Click);
            // 
            // baslikkaydetBtn
            // 
            this.baslikkaydetBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslikkaydetBtn.Location = new System.Drawing.Point(259, 174);
            this.baslikkaydetBtn.Name = "baslikkaydetBtn";
            this.baslikkaydetBtn.Size = new System.Drawing.Size(109, 44);
            this.baslikkaydetBtn.TabIndex = 4;
            this.baslikkaydetBtn.Text = "Kaydet";
            this.baslikkaydetBtn.UseVisualStyleBackColor = true;
            this.baslikkaydetBtn.Click += new System.EventHandler(this.baslikkaydetBtn_Click);
            // 
            // GunlukBaslik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(499, 274);
            this.Controls.Add(this.baslikkaydetBtn);
            this.Controls.Add(this.baslikcikisBtn);
            this.Controls.Add(this.diarytitleBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "GunlukBaslik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GunlukBaslik";
            this.Load += new System.EventHandler(this.GunlukBaslik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diarytitleBtn;
        private System.Windows.Forms.Button baslikcikisBtn;
        private System.Windows.Forms.Button baslikkaydetBtn;
    }
}