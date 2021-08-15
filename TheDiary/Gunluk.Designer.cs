
namespace TheDiary
{
    partial class Gunluk
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tarihegitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gunusilBtn = new System.Windows.Forms.Button();
            this.gunukaydetBtn = new System.Windows.Forms.Button();
            this.diarytitleLabel = new System.Windows.Forms.Label();
            this.kapatBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.tarihegitBtn);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 506);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheDiary.Properties.Resources.notebook_3_;
            this.pictureBox1.Location = new System.Drawing.Point(89, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 104);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tarihegitBtn
            // 
            this.tarihegitBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihegitBtn.Location = new System.Drawing.Point(107, 282);
            this.tarihegitBtn.Name = "tarihegitBtn";
            this.tarihegitBtn.Size = new System.Drawing.Size(149, 42);
            this.tarihegitBtn.TabIndex = 4;
            this.tarihegitBtn.Text = "Seçili Tarihe Git";
            this.tarihegitBtn.UseVisualStyleBackColor = true;
            this.tarihegitBtn.Click += new System.EventHandler(this.tarihegitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(336, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 455);
            this.textBox1.TabIndex = 3;
            // 
            // gunusilBtn
            // 
            this.gunusilBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunusilBtn.Location = new System.Drawing.Point(549, 576);
            this.gunusilBtn.Name = "gunusilBtn";
            this.gunusilBtn.Size = new System.Drawing.Size(103, 45);
            this.gunusilBtn.TabIndex = 5;
            this.gunusilBtn.Text = "Günü Sil";
            this.gunusilBtn.UseVisualStyleBackColor = true;
            this.gunusilBtn.Click += new System.EventHandler(this.gunusilBtn_Click);
            // 
            // gunukaydetBtn
            // 
            this.gunukaydetBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunukaydetBtn.Location = new System.Drawing.Point(696, 576);
            this.gunukaydetBtn.Name = "gunukaydetBtn";
            this.gunukaydetBtn.Size = new System.Drawing.Size(103, 45);
            this.gunukaydetBtn.TabIndex = 7;
            this.gunukaydetBtn.Text = "Günü Kaydet";
            this.gunukaydetBtn.UseVisualStyleBackColor = true;
            this.gunukaydetBtn.Click += new System.EventHandler(this.gunukaydetBtn_Click);
            // 
            // diarytitleLabel
            // 
            this.diarytitleLabel.AutoSize = true;
            this.diarytitleLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diarytitleLabel.Location = new System.Drawing.Point(320, 45);
            this.diarytitleLabel.Name = "diarytitleLabel";
            this.diarytitleLabel.Size = new System.Drawing.Size(184, 30);
            this.diarytitleLabel.TabIndex = 8;
            this.diarytitleLabel.Text = "Günlük Başlığı:";
            // 
            // kapatBtn
            // 
            this.kapatBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapatBtn.Location = new System.Drawing.Point(845, 576);
            this.kapatBtn.Name = "kapatBtn";
            this.kapatBtn.Size = new System.Drawing.Size(103, 45);
            this.kapatBtn.TabIndex = 9;
            this.kapatBtn.Text = "Çıkış";
            this.kapatBtn.UseVisualStyleBackColor = true;
            this.kapatBtn.Click += new System.EventHandler(this.kapatBtn_Click);
            // 
            // Gunluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(972, 645);
            this.Controls.Add(this.kapatBtn);
            this.Controls.Add(this.diarytitleLabel);
            this.Controls.Add(this.gunukaydetBtn);
            this.Controls.Add(this.gunusilBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Gunluk";
            this.Text = "Gunluk";
            this.Load += new System.EventHandler(this.Gunluk_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tarihegitBtn;
        private System.Windows.Forms.Button gunusilBtn;
        private System.Windows.Forms.Button gunukaydetBtn;
        private System.Windows.Forms.Label diarytitleLabel;
        private System.Windows.Forms.Button kapatBtn;
    }
}