using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnSonraki.Text = "Başla";
        }

        int sayac = 0;
        int soruno = 0, dogru = 0, yanlis = 0;
        bool yarismabasladi = false;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            LblCevap.Text = BtnB.Text;

            if (LblDogruCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                PBoxDogru.Visible = true;
                BtnA.BackColor = Color.Red;
                BtnB.BackColor = Color.Green;
                BtnC.BackColor = Color.Red;
                BtnD.BackColor = Color.Red;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                PBoxYanlis.Visible = true;
                BtnB.BackColor = Color.Red;

                if (LblDogruCevap.Text == BtnA.Text)
                {
                    BtnA.BackColor = Color.Green;
                    BtnC.BackColor= Color.Red;
                    BtnD.BackColor = Color.Red;
                    BtnB.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnC.Text)
                {
                    BtnC.BackColor = Color.Green;
                    BtnD.BackColor = Color.Red;
                    BtnB.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnD.Text)
                {
                    BtnD.BackColor = Color.Green;
                    BtnB.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                    BtnC.BackColor = Color.Red;
                }
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            LblCevap.Text = BtnC.Text;

            if (LblDogruCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                PBoxDogru.Visible = true;
                BtnA.BackColor = Color.Red;
                BtnB.BackColor = Color.Red;
                BtnC.BackColor = Color.Green;
                BtnD.BackColor = Color.Red;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                PBoxYanlis.Visible = true;

                if (LblDogruCevap.Text == BtnA.Text)
                {
                    BtnA.BackColor = Color.Green;
                    BtnC.BackColor = Color.Red;
                    BtnD.BackColor = Color.Red;
                    BtnB.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnB.Text)
                {
                    BtnB.BackColor = Color.Green;
                    BtnD.BackColor = Color.Red;
                    BtnC.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnD.Text)
                {
                    BtnD.BackColor = Color.Green;
                    BtnB.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                    BtnC.BackColor = Color.Red;
                }
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            LblCevap.Text = BtnD.Text;

            if (LblDogruCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                PBoxDogru.Visible = true;
                BtnA.BackColor = Color.Red;
                BtnB.BackColor = Color.Red;
                BtnC.BackColor = Color.Red;
                BtnD.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                PBoxYanlis.Visible = true;

                if (LblDogruCevap.Text == BtnA.Text)
                {
                    BtnA.BackColor = Color.Green;
                    BtnC.BackColor = Color.Red;
                    BtnD.BackColor = Color.Red;
                    BtnB.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnB.Text)
                {
                    BtnB.BackColor = Color.Green;
                    BtnD.BackColor = Color.Red;
                    BtnC.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnC.Text)
                {
                    BtnC.BackColor = Color.Green;
                    BtnB.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                    BtnD.BackColor = Color.Red;
                }
            }
        }
     

        private void sure_Tick(object sender, EventArgs e)
        {
            sayac++;
            LblSureDegeri.Text = sayac.ToString();

            if (sayac == 60000)
            {
                sure.Stop();
                MessageBox.Show("Süreniz doldu!");
                Application.Exit();
            }
        }


        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            LblCevap.Text = BtnA.Text;

            if (LblDogruCevap.Text == LblCevap.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                PBoxDogru.Visible = true;
                BtnA.BackColor = Color.Green;
                BtnB.BackColor = Color.Red;
                BtnC.BackColor = Color.Red;
                BtnD.BackColor = Color.Red;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                PBoxYanlis.Visible = true;

                if (LblDogruCevap.Text == BtnD.Text)
                {
                    BtnD.BackColor = Color.Green;
                    BtnC.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                    BtnB.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnB.Text)
                {
                    BtnB.BackColor = Color.Green;
                    BtnD.BackColor = Color.Red;
                    BtnC.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                }
                else if (LblDogruCevap.Text == BtnC.Text)
                {
                    BtnC.BackColor = Color.Green;
                    BtnB.BackColor = Color.Red;
                    BtnA.BackColor = Color.Red;
                    BtnD.BackColor = Color.Red;
                }

            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            PBIlerleme.Value += 11;

            BtnA.BackColor = SystemColors.Control;
            BtnB.BackColor = SystemColors.Control;
            BtnC.BackColor = SystemColors.Control;
            BtnD.BackColor = SystemColors.Control;
            sure.Start();

            if (!yarismabasladi)
            {
                yarismabasladi = true;
                BtnSonraki.Text = "Sonraki soru";
            }
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            PBoxYanlis.Visible = false;
            PBoxDogru.Visible=false;

            soruno++;
            LblSoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                RTBoxSoru.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";

                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                LblDogruCevap.Text = "1923";
            }
            if (soruno == 2)
            {
                RTBoxSoru.Text = "Hangi il Ege Bölgesinde bulunmaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                LblDogruCevap.Text = "Balıkesir";
            }

            if (soruno == 3)
            {
                RTBoxSoru.Text = "'Son Kuşlar' adlı eser hangi yazara aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Reşat Nuri";
                BtnC.Text = "Cemal Süreya";
                BtnD.Text = "Atilla İlhan";
                LblDogruCevap.Text = "Sait Faik";
            }

            if (soruno == 4)
            {
                RTBoxSoru.Text = "'Leon:The Professional' adlı filmde 'Mathilda' karakterini canlandıran oyuncu kimdir?";
                BtnA.Text = "Scarlett Johanson";
                BtnB.Text = "Bella Thorne";
                BtnC.Text = "Natalie Portman";
                BtnD.Text = "Blake Lively";
                LblDogruCevap.Text = "Natalie Portman";
            }

            if (soruno == 5)
            {
                RTBoxSoru.Text = "Mimar Sinan'ın Ustalık Dönemi eseri sayılan Edirne'deki eserinin adı nedir?";
                BtnA.Text = "Süleymaniye Camii";
                BtnB.Text = "Şehzade Cami";
                BtnC.Text = "Topkapı Sarayı";
                BtnD.Text = "Selimiye Camii";
                LblDogruCevap.Text = "Selimiye Camii";
            }

            if (soruno == 6)
            {
                RTBoxSoru.Text = "2024 yılında Olimpiyat oyunları nerede gerçekleşmiştir?";
                BtnA.Text = "İngiltere";
                BtnB.Text = "Brüksel";
                BtnC.Text = "Berlin";
                BtnD.Text = "Paris";
                LblDogruCevap.Text = "Paris";
            }

            if (soruno == 7)
            {
                RTBoxSoru.Text = "Nobel ödülleri hangi ülkede verilmektedir? ";
                BtnA.Text = "Fransa";
                BtnB.Text = "İsviçre";
                BtnC.Text = "İsveç";
                BtnD.Text = "İngiltere";
                LblDogruCevap.Text = "İsveç";
            }

            if (soruno == 8)
            {
                RTBoxSoru.Text = "Türkiye’de Erozyonla mücadele amacıyla kurulan vakfın kısa adı nedir?";
                BtnA.Text = "TEMA";
                BtnB.Text = "AKUT";
                BtnC.Text = "KIZILAY";
                BtnD.Text = "Çevre Vakfı";
                LblDogruCevap.Text = "TEMA";
            }

            if (soruno == 9)
            {
                RTBoxSoru.Text = "Gece gündüz eşitliği (ekinoks) bir yılda kaç kez gerçekleşir?";
                BtnA.Text = "1";
                BtnB.Text = "2";
                BtnC.Text = "0";
                BtnD.Text = "4";
                LblDogruCevap.Text = "2";
            }

            if (soruno == 10)
            {
                RTBoxSoru.Text = "Dünyanın ilk haritasını çizen ünlü Türk denizcisi kimdir?";
                BtnA.Text = "Barbaros Hayreddin Paşa";
                BtnB.Text = "Çaka Bey";
                BtnC.Text = "Piri Reis";
                BtnD.Text = "Oruç Reis";
                LblDogruCevap.Text = "Piri Reis";
                BtnSonraki.Text = "Sonuçları al";
            }

            if (soruno == 11)
            {
                sure.Stop();
                RTBoxSoru.Text = "YARIŞMA BİTTİ";
                BtnA.Text = "";
                BtnB.Text = "";
                BtnC.Text = "";
                BtnD.Text = "";
                LblDogruCevap.Text = "";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                if (dogru < 5)
                {
                    MessageBox.Show("Pek iyi sayılmaz.");
                    Application.Exit();
                }
                else if (dogru > 5 && dogru < 10)
                {
                    MessageBox.Show("İyi iş çıkardınız.");
                    Application.Exit();
                }
                else if (dogru == 10)
                {
                    MessageBox.Show("Mükemmel bir performans!");
                    Application.Exit();
                }

            }
        }
    }
}
