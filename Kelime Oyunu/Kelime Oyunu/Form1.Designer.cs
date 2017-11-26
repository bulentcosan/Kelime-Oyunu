namespace Kelime_Oyunu
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
            this.components = new System.ComponentModel.Container();
            this.txt_tahmin = new System.Windows.Forms.TextBox();
            this.lbl_soru = new System.Windows.Forms.Label();
            this.lbl_harf0 = new System.Windows.Forms.Label();
            this.lbl_harf1 = new System.Windows.Forms.Label();
            this.lbl_harf2 = new System.Windows.Forms.Label();
            this.lbl_harf3 = new System.Windows.Forms.Label();
            this.lbl_toplam_süre = new System.Windows.Forms.Label();
            this.btn_cevap = new System.Windows.Forms.Button();
            this.btn_harf_iste = new System.Windows.Forms.Button();
            this.btn_tahmin = new System.Windows.Forms.Button();
            this.toplamsuresi = new System.Windows.Forms.Timer(this.components);
            this.cevapsuresi = new System.Windows.Forms.Timer(this.components);
            this.lbl_puan_number = new System.Windows.Forms.Label();
            this.pb_cevapsuresi = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_soru_degeri = new System.Windows.Forms.Label();
            this.picbox_harf3 = new System.Windows.Forms.PictureBox();
            this.picbox_harf2 = new System.Windows.Forms.PictureBox();
            this.picbox_harf1 = new System.Windows.Forms.PictureBox();
            this.picbox_harf0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf0)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tahmin
            // 
            this.txt_tahmin.Location = new System.Drawing.Point(149, 379);
            this.txt_tahmin.Name = "txt_tahmin";
            this.txt_tahmin.Size = new System.Drawing.Size(400, 20);
            this.txt_tahmin.TabIndex = 0;
            // 
            // lbl_soru
            // 
            this.lbl_soru.AutoSize = true;
            this.lbl_soru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soru.Location = new System.Drawing.Point(149, 262);
            this.lbl_soru.MinimumSize = new System.Drawing.Size(400, 50);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(400, 50);
            this.lbl_soru.TabIndex = 1;
            this.lbl_soru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_harf0
            // 
            this.lbl_harf0.AutoSize = true;
            this.lbl_harf0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harf0.Location = new System.Drawing.Point(81, 177);
            this.lbl_harf0.MinimumSize = new System.Drawing.Size(50, 50);
            this.lbl_harf0.Name = "lbl_harf0";
            this.lbl_harf0.Size = new System.Drawing.Size(50, 50);
            this.lbl_harf0.TabIndex = 2;
            this.lbl_harf0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_harf1
            // 
            this.lbl_harf1.AutoSize = true;
            this.lbl_harf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harf1.Location = new System.Drawing.Point(137, 177);
            this.lbl_harf1.MinimumSize = new System.Drawing.Size(50, 50);
            this.lbl_harf1.Name = "lbl_harf1";
            this.lbl_harf1.Size = new System.Drawing.Size(50, 50);
            this.lbl_harf1.TabIndex = 2;
            this.lbl_harf1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_harf2
            // 
            this.lbl_harf2.AutoSize = true;
            this.lbl_harf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harf2.Location = new System.Drawing.Point(193, 177);
            this.lbl_harf2.MinimumSize = new System.Drawing.Size(50, 50);
            this.lbl_harf2.Name = "lbl_harf2";
            this.lbl_harf2.Size = new System.Drawing.Size(50, 50);
            this.lbl_harf2.TabIndex = 2;
            this.lbl_harf2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_harf3
            // 
            this.lbl_harf3.AutoSize = true;
            this.lbl_harf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harf3.Location = new System.Drawing.Point(249, 177);
            this.lbl_harf3.MinimumSize = new System.Drawing.Size(50, 50);
            this.lbl_harf3.Name = "lbl_harf3";
            this.lbl_harf3.Size = new System.Drawing.Size(50, 50);
            this.lbl_harf3.TabIndex = 2;
            this.lbl_harf3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_toplam_süre
            // 
            this.lbl_toplam_süre.AutoSize = true;
            this.lbl_toplam_süre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_toplam_süre.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toplam_süre.Location = new System.Drawing.Point(520, 32);
            this.lbl_toplam_süre.Name = "lbl_toplam_süre";
            this.lbl_toplam_süre.Size = new System.Drawing.Size(131, 71);
            this.lbl_toplam_süre.TabIndex = 3;
            this.lbl_toplam_süre.Text = "180";
            // 
            // btn_cevap
            // 
            this.btn_cevap.Location = new System.Drawing.Point(560, 379);
            this.btn_cevap.Name = "btn_cevap";
            this.btn_cevap.Size = new System.Drawing.Size(75, 20);
            this.btn_cevap.TabIndex = 5;
            this.btn_cevap.Text = "Cevapla";
            this.btn_cevap.UseVisualStyleBackColor = true;
            this.btn_cevap.Click += new System.EventHandler(this.btn_cevap_Click);
            // 
            // btn_harf_iste
            // 
            this.btn_harf_iste.Location = new System.Drawing.Point(560, 262);
            this.btn_harf_iste.Name = "btn_harf_iste";
            this.btn_harf_iste.Size = new System.Drawing.Size(75, 50);
            this.btn_harf_iste.TabIndex = 6;
            this.btn_harf_iste.Text = "Harf Lütfen";
            this.btn_harf_iste.UseVisualStyleBackColor = true;
            this.btn_harf_iste.Click += new System.EventHandler(this.btn_harf_iste_Click);
            // 
            // btn_tahmin
            // 
            this.btn_tahmin.Location = new System.Drawing.Point(80, 262);
            this.btn_tahmin.Name = "btn_tahmin";
            this.btn_tahmin.Size = new System.Drawing.Size(63, 50);
            this.btn_tahmin.TabIndex = 7;
            this.btn_tahmin.Text = "Tahmin Et";
            this.btn_tahmin.UseVisualStyleBackColor = true;
            this.btn_tahmin.Click += new System.EventHandler(this.btn_tahmin_Click);
            // 
            // toplamsuresi
            // 
            this.toplamsuresi.Interval = 1000;
            this.toplamsuresi.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cevapsuresi
            // 
            this.cevapsuresi.Interval = 1000;
            this.cevapsuresi.Tick += new System.EventHandler(this.cevapsuresi_Tick);
            // 
            // lbl_puan_number
            // 
            this.lbl_puan_number.AutoSize = true;
            this.lbl_puan_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puan_number.Location = new System.Drawing.Point(49, 18);
            this.lbl_puan_number.Name = "lbl_puan_number";
            this.lbl_puan_number.Size = new System.Drawing.Size(51, 55);
            this.lbl_puan_number.TabIndex = 9;
            this.lbl_puan_number.Text = "0";
            // 
            // pb_cevapsuresi
            // 
            this.pb_cevapsuresi.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pb_cevapsuresi.AnimationSpeed = 500;
            this.pb_cevapsuresi.BackColor = System.Drawing.Color.Transparent;
            this.pb_cevapsuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.pb_cevapsuresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_cevapsuresi.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_cevapsuresi.InnerMargin = 2;
            this.pb_cevapsuresi.InnerWidth = -1;
            this.pb_cevapsuresi.Location = new System.Drawing.Point(292, 32);
            this.pb_cevapsuresi.MarqueeAnimationSpeed = 2000;
            this.pb_cevapsuresi.Maximum = 15;
            this.pb_cevapsuresi.Name = "pb_cevapsuresi";
            this.pb_cevapsuresi.OuterColor = System.Drawing.Color.Gray;
            this.pb_cevapsuresi.OuterMargin = -25;
            this.pb_cevapsuresi.OuterWidth = 26;
            this.pb_cevapsuresi.ProgressColor = System.Drawing.Color.Red;
            this.pb_cevapsuresi.ProgressWidth = 25;
            this.pb_cevapsuresi.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pb_cevapsuresi.Size = new System.Drawing.Size(116, 116);
            this.pb_cevapsuresi.StartAngle = 270;
            this.pb_cevapsuresi.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_cevapsuresi.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pb_cevapsuresi.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pb_cevapsuresi.SubscriptText = "";
            this.pb_cevapsuresi.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pb_cevapsuresi.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pb_cevapsuresi.SuperscriptText = "";
            this.pb_cevapsuresi.TabIndex = 11;
            this.pb_cevapsuresi.TextMargin = new System.Windows.Forms.Padding(0);
            this.pb_cevapsuresi.Value = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 177);
            this.label2.MinimumSize = new System.Drawing.Size(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 177);
            this.label3.MinimumSize = new System.Drawing.Size(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 177);
            this.label4.MinimumSize = new System.Drawing.Size(50, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 50);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 177);
            this.label5.MinimumSize = new System.Drawing.Size(50, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 50);
            this.label5.TabIndex = 2;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 177);
            this.label6.MinimumSize = new System.Drawing.Size(50, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 50);
            this.label6.TabIndex = 2;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 177);
            this.label1.MinimumSize = new System.Drawing.Size(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 50);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_soru_degeri
            // 
            this.lbl_soru_degeri.AutoSize = true;
            this.lbl_soru_degeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soru_degeri.Location = new System.Drawing.Point(49, 73);
            this.lbl_soru_degeri.Name = "lbl_soru_degeri";
            this.lbl_soru_degeri.Size = new System.Drawing.Size(51, 55);
            this.lbl_soru_degeri.TabIndex = 9;
            this.lbl_soru_degeri.Text = "0";
            // 
            // picbox_harf3
            // 
            this.picbox_harf3.Image = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf3.InitialImage = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf3.Location = new System.Drawing.Point(246, 177);
            this.picbox_harf3.Name = "picbox_harf3";
            this.picbox_harf3.Size = new System.Drawing.Size(49, 50);
            this.picbox_harf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_harf3.TabIndex = 13;
            this.picbox_harf3.TabStop = false;
            // 
            // picbox_harf2
            // 
            this.picbox_harf2.Image = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf2.InitialImage = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf2.Location = new System.Drawing.Point(191, 177);
            this.picbox_harf2.Name = "picbox_harf2";
            this.picbox_harf2.Size = new System.Drawing.Size(49, 50);
            this.picbox_harf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_harf2.TabIndex = 13;
            this.picbox_harf2.TabStop = false;
            // 
            // picbox_harf1
            // 
            this.picbox_harf1.Image = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf1.InitialImage = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf1.Location = new System.Drawing.Point(136, 177);
            this.picbox_harf1.Name = "picbox_harf1";
            this.picbox_harf1.Size = new System.Drawing.Size(49, 50);
            this.picbox_harf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_harf1.TabIndex = 13;
            this.picbox_harf1.TabStop = false;
            // 
            // picbox_harf0
            // 
            this.picbox_harf0.Image = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf0.InitialImage = global::Kelime_Oyunu.Properties.Resources._13;
            this.picbox_harf0.Location = new System.Drawing.Point(81, 177);
            this.picbox_harf0.Name = "picbox_harf0";
            this.picbox_harf0.Size = new System.Drawing.Size(49, 50);
            this.picbox_harf0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_harf0.TabIndex = 13;
            this.picbox_harf0.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.picbox_harf3);
            this.Controls.Add(this.picbox_harf2);
            this.Controls.Add(this.picbox_harf1);
            this.Controls.Add(this.picbox_harf0);
            this.Controls.Add(this.pb_cevapsuresi);
            this.Controls.Add(this.lbl_soru_degeri);
            this.Controls.Add(this.lbl_puan_number);
            this.Controls.Add(this.btn_tahmin);
            this.Controls.Add(this.btn_harf_iste);
            this.Controls.Add(this.btn_cevap);
            this.Controls.Add(this.lbl_toplam_süre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_harf3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_harf2);
            this.Controls.Add(this.lbl_harf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_harf0);
            this.Controls.Add(this.lbl_soru);
            this.Controls.Add(this.txt_tahmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_harf0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tahmin;
        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.Label lbl_harf0;
        private System.Windows.Forms.Label lbl_harf1;
        private System.Windows.Forms.Label lbl_harf2;
        private System.Windows.Forms.Label lbl_harf3;
        private System.Windows.Forms.Label lbl_toplam_süre;
        private System.Windows.Forms.Button btn_cevap;
        private System.Windows.Forms.Button btn_harf_iste;
        private System.Windows.Forms.Button btn_tahmin;
        private System.Windows.Forms.Timer toplamsuresi;
        private System.Windows.Forms.Timer cevapsuresi;
        private System.Windows.Forms.Label lbl_puan_number;
        private CircularProgressBar.CircularProgressBar pb_cevapsuresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_soru_degeri;
        private System.Windows.Forms.PictureBox picbox_harf0;
        private System.Windows.Forms.PictureBox picbox_harf1;
        private System.Windows.Forms.PictureBox picbox_harf2;
        private System.Windows.Forms.PictureBox picbox_harf3;
    }
}

