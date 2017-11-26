namespace Kelime_Oyunu
{
    partial class positive_feedback
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
            this.lbl_tebrikler = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sonraki_soru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tebrikler
            // 
            this.lbl_tebrikler.AutoSize = true;
            this.lbl_tebrikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tebrikler.Location = new System.Drawing.Point(224, 101);
            this.lbl_tebrikler.Name = "lbl_tebrikler";
            this.lbl_tebrikler.Size = new System.Drawing.Size(370, 91);
            this.lbl_tebrikler.TabIndex = 0;
            this.lbl_tebrikler.Text = "Tebrikler!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kelime_Oyunu.Properties.Resources.TİK_344x330;
            this.pictureBox1.Location = new System.Drawing.Point(257, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sonraki_soru
            // 
            this.btn_sonraki_soru.Location = new System.Drawing.Point(345, 384);
            this.btn_sonraki_soru.Name = "btn_sonraki_soru";
            this.btn_sonraki_soru.Size = new System.Drawing.Size(132, 23);
            this.btn_sonraki_soru.TabIndex = 2;
            this.btn_sonraki_soru.Text = "Sonraki Soru";
            this.btn_sonraki_soru.UseVisualStyleBackColor = true;
            this.btn_sonraki_soru.Click += new System.EventHandler(this.btn_sonraki_soru_Click);
            // 
            // positive_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 493);
            this.Controls.Add(this.btn_sonraki_soru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tebrikler);
            this.Name = "positive_feedback";
            this.Text = "positive_feedback";
            this.Load += new System.EventHandler(this.positive_feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tebrikler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sonraki_soru;
    }
}