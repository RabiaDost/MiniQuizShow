namespace bilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogruNo = 0, yanl�sNo = 0;
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
                richTextBox1.Text = "Ahtapotlar�n ka� kalbi vard�r ? ";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "3";
                btnD.Text = "4";
                cevap = "3";
            }
            if(soruNo == 2 )
            {
                richTextBox1.Text = "T�rkiye ka� y�l�nda NATO'ya girmi�tir ? ";
                btnA.Text = "1962";
                btnB.Text = "1949";
                btnC.Text = "1965";
                btnD.Text = "1952";
                cevap = "1952";
            }
            if(soruNo == 3)
            {
                richTextBox1.Text = "D�nya haritas�n� �izen ilk T�rk kimdir ?";
                btnA.Text = "Piri Reis";
                btnB.Text = "Barbaros Hayrettin";
                btnC.Text = "Mimar Sinan";
                btnD.Text = "Turgut Reis";
                cevap = "Piri Reis";
            }
            if(soruNo == 4) 
            {
                richTextBox1.Text = "Sevgilime bir kefen hangi �airimize aittir";
                btnA.Text = "Atilla �lhan";
                btnB.Text = "�smet �zel";
                btnC.Text = "Can Y�cel";
                btnD.Text = "Cemal S�reya";
                cevap = "�smet �zel";
                btnSonraki.Text = "Sonu�lar";
            }
            if(soruNo == 5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Do�ru : " + dogruNo + "\n" + "Yanl�� : "+ yanl�sNo);
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
                yanl�sNo++;
                labelyanl�s.Text = yanl�sNo.ToString();
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
                yanl�sNo++;
                labelyanl�s.Text = yanl�sNo.ToString();
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
                yanl�sNo++;
                labelyanl�s.Text = yanl�sNo.ToString();
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
                yanl�sNo++;
                labelyanl�s.Text = yanl�sNo.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
