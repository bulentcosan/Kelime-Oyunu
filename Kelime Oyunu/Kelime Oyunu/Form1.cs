using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zaman;
        int cevapzaman;
        int anlikpuan;
        int toplampuan = 0;
        int harfsayisi = 4;
        string soru = "DÖrt ayaklı yemek yerken kullanılan alet.";
        string kelime = "MASA";
        char[] harf;
        List<int> cıkan = new List<int>();
        positive_feedback posfed = new positive_feedback();
       

        public object positive_feedback { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txt_tahmin.Visible = false;
            btn_cevap.Visible = false;
            toplamsuresi.Enabled = true;
            zaman = 180;
            cevapzaman = 15;
            anlikpuan = harfsayisi * 100;
            lbl_soru.Text = soru;
            harf = kelime.ToCharArray();
            lbl_harf0.Text = harf[0].ToString();
            lbl_harf1.Text = harf[1].ToString();
            lbl_harf2.Text = harf[2].ToString();
            lbl_harf3.Text = harf[3].ToString();
            lbl_soru_degeri.Text = anlikpuan.ToString();
            pb_cevapsuresi.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            lbl_toplam_süre.Text = zaman.ToString();
            
        }

        private void btn_tahmin_Click(object sender, EventArgs e)
        {

            pb_cevapsuresi.Enabled = true;

            cevapsuresi.Enabled = true;
            toplamsuresi.Stop();
            txt_tahmin.Visible = true;
            btn_cevap.Visible = true;
            btn_harf_iste.Visible = false;
            btn_tahmin.Visible = false;
            pb_cevapsuresi.Visible = true;

        }

        private void cevapsuresi_Tick(object sender, EventArgs e)
        {
            pb_cevapsuresi.Text = cevapzaman.ToString();
            pb_cevapsuresi.Value = cevapzaman;
            cevapzaman--;
        }

        private void btn_cevap_Click(object sender, EventArgs e)
        {
            if (kelime == txt_tahmin.Text)
            {
                toplampuan += anlikpuan;
                lbl_puan_number.Text = toplampuan.ToString();
                cevapzaman = 15;
                pb_cevapsuresi.Visible = false;
                picbox_harf0.Visible = false;
                picbox_harf1.Visible = false;
                picbox_harf2.Visible = false;
                picbox_harf3.Visible = false;
                posfed.Show();
                //this.Hide();


            }
            else
            {
            }
        }

        private void btn_harf_iste_Click(object sender, EventArgs e)
        {
            anlikpuan -= 100;
            lbl_soru_degeri.Text = anlikpuan.ToString();
            Random ran = new Random();
            int randomnumber;
            randomnumber = ran.Next(0, harfsayisi);
            
            while (cıkan.IndexOf(randomnumber) != -1)
                {
                    randomnumber = ran.Next(0, harfsayisi);
                }
            cıkan.Add(randomnumber);

            if (randomnumber == 0 )
            {
                picbox_harf0.Visible = false;
                lbl_harf0.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (randomnumber == 1 )
            {
                picbox_harf1.Visible = false;
                lbl_harf0.BorderStyle = BorderStyle.Fixed3D;

            }
            else if (randomnumber == 2 )
            {
                picbox_harf2.Visible = false;
                lbl_harf0.BorderStyle = BorderStyle.Fixed3D;

            }
            else if (randomnumber == 3 )
            {
                picbox_harf3.Visible = false;
                lbl_harf0.BorderStyle = BorderStyle.Fixed3D;

            }

        }

        private void btn_sonraki_soru_Click(object sender, EventArgs e)
        {
            pb_cevapsuresi.Visible = false;
            cevapzaman = 15;
            txt_tahmin.Clear();
            toplamsuresi.Start();
            txt_tahmin.Visible = false;
            btn_cevap.Visible = false;
            btn_tahmin.Visible = true;
            btn_harf_iste.Visible = true;
            picbox_harf0.Visible = true;
            picbox_harf1.Visible = true;
            picbox_harf2.Visible = true;
            picbox_harf3.Visible = true;

        }
    }
}
