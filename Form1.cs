namespace bilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogruNo = 0, yanlýsNo = 0;
        string cevap, sonuc;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            soruNo++;
            labelSoru.Text = soruNo.ToString();

            if(soruNo == 1 )
            {
                richTextBox1.Text = "Ahtapotlarýn kaç kalbi vardýr ? ";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "3";
                btnD.Text = "4";
                cevap = "3";
            }
            if(soruNo == 2 )
            {
                richTextBox1.Text = "Türkiye kaç yýlýnda NATO'ya girmiþtir ? ";
                btnA.Text = "1962";
                btnB.Text = "1949";
                btnC.Text = "1965";
                btnD.Text = "1952";
                cevap = "1952";
            }
            if(soruNo == 3)
            {
                richTextBox1.Text = "Dünya haritasýný çizen ilk Türk kimdir ?";
                btnA.Text = "Piri Reis";
                btnB.Text = "Barbaros Hayrettin";
                btnC.Text = "Mimar Sinan";
                btnD.Text = "Turgut Reis";
                cevap = "Piri Reis";
            }
            if(soruNo == 4) 
            {
                richTextBox1.Text = "Sevgilime bir kefen hangi þairimize aittir";
                btnA.Text = "Atilla Ýlhan";
                btnB.Text = "Ýsmet Özel";
                btnC.Text = "Can Yücel";
                btnD.Text = "Cemal Süreya";
                cevap = "Ýsmet Özel";
                btnSonraki.Text = "Sonuçlar";
            }
            if(soruNo == 5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doðru : " + dogruNo + "\n" + "Yanlýþ : "+ yanlýsNo);
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;  
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            sonuc = btnA.Text;
            if(sonuc == cevap)
            {
                dogruNo++;
                labelDogru.Text =dogruNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýsNo++;
                labelyanlýs.Text = yanlýsNo.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled=false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonraki.Enabled = true;

            sonuc = btnB.Text;
            if(sonuc == cevap)
            {
                dogruNo++;
                labelDogru.Text=dogruNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýsNo++;
                labelyanlýs.Text = yanlýsNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled=false;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnSonraki.Enabled = true;

            sonuc = btnC.Text;
            if(sonuc == cevap)
            {
                dogruNo++;
                labelDogru.Text = dogruNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýsNo++;
                labelyanlýs.Text = yanlýsNo.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            sonuc = btnD.Text;
            if (sonuc == cevap)
            {
                dogruNo++;
                labelDogru.Text = dogruNo.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlýsNo++;
                labelyanlýs.Text = yanlýsNo.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
