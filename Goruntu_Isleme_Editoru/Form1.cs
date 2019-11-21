using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goruntu_Isleme_Editoru
{
    public partial class Form1 : Form
    {

        Imgeislemleri islem = new Imgeislemleri();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
        }


        private void dosyaAc_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                islem.ImgeSuanki = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = islem.ImgeSuanki;

            }

            if (islem.ImgeSuanki != null)
            {
                label1.Text = "Açılan Resim " + "(" + System.IO.Path.GetFileName(openFileDialog1.FileName) + ")";
                label3.Text = "Yapılan işlem : ";
                label2.Text = "Yeni bir dosyanın açılması";
                toolStripMenuItem1.Enabled = true; 

            }

        }

        private void tekrarAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (islem.ImgeSuanki == null)
            {
                MessageBox.Show("Önce bir dosya açınız.", MessageBoxIcon.Warning.ToString());
            }
            else
            {
                islem.ImgeSuanki = (Bitmap)Image.FromFile(openFileDialog1.FileName);

                pictureBox1.Image = islem.ImgeSuanki;
                label2.Text = "Başlangıçta seçilen görüntünün tekrar açılması";
                chart1.Enabled = false;
                chart1.Visible = false;
            }

        }

        private void renkliGoruntuHistogramiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            chart1.Enabled = true;
            chart1.Visible = true;

            chart1.Titles["histogram"].Text = "Renkli Görüntü Histogramı";
            chart1.Series["Mavi"].Enabled = true;
            chart1.Series["Yesil"].Enabled = true;
            chart1.Series["Kirmizi"].Enabled = true;

            chart1.Series["Gri"].Enabled = false;

            islem.histogramHesapla(this);  
            label2.Text = "Resmin renkli görüntü histogramı";
        }

        private void griGoruntuHistogramiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            chart1.Enabled = true;
            chart1.Visible = true;

            chart1.Titles["histogram"].Text = "Gri Görüntü Histogramı";
            chart1.Series["Gri"].Enabled = true;

            chart1.Series["Mavi"].Enabled = false;
            chart1.Series["Yesil"].Enabled = false;
            chart1.Series["Kirmizi"].Enabled = false;

            islem.histogramHesapla(this);
            label2.Text = "Resmin gri görüntü histogramı";

        }

        private void tersleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.tersle(this);                       
            label2.Text = "Resmin Tersi / Negatifi";  


        }

        private void sagaSolaAynalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;

            islem.aynala(this);

            label2.Text = "Resmin Sağa Aynalanması";

        }

        private void sagaDondur90ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.sagsolDondur(this, '+');

            label2.Text = "Resmin Sağa 90 Derece Döndürülmesi"; 


        }

        private void solaDondur90ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.sagsolDondur(this, '-');
            label2.Text = "Resmin Sola 90 Derece Döndürülmesi";

        }

        private void OlcekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            olcekGirisEkrani olcekAl = new olcekGirisEkrani();

            olcekAl.yeniYuksekik = islem.ImgeSuanki.Height;
            olcekAl.yeniGenislik = islem.ImgeSuanki.Width;

            if (olcekAl.ShowDialog() == DialogResult.OK)
            {
                label2.Text = "Ölçeklenmiş Resim";
            }

            islem.olcekle(this, olcekAl.yeniYuksekik, olcekAl.yeniGenislik);
        }

        private void griSeviyeDonusturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.griYap(this);

            label2.Text = "Resmin Gri Tona Dönüştürülmesi";

        }

        private void kirmiziRenkKanaliToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.renkKanallari(this, 'r');
            label2.Text = "Resmin Kırmızı Renk Kanalı";


        }

        private void yesilRenkKanaliToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.renkKanallari(this, 'g');
            label2.Text = "Resmin Yeşil Renk Kanalı";

        }

        private void maviRenkKanaliToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.Visible = false;

            islem.renkKanallari(this, 'b');
            label2.Text = "Resmin Mavi Renk Kanalı";
        }

        private void programdanCıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void degisiklikleriKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydetDialog = new SaveFileDialog();

            kaydetDialog.FileName = "islenmis_" + System.IO.Path.GetFileName(openFileDialog1.FileName);
            kaydetDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;  *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (kaydetDialog.ShowDialog(this) == DialogResult.OK)
            {

                pictureBox1.Image.Save(kaydetDialog.FileName, pictureBox1.Image.RawFormat);

                MessageBox.Show("İşlenmiş resim başarıyla kaydedildi.");

            }

        }

        private void Dosya_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) değişiklikleriKaydetToolStripMenuItem.Enabled = true;
        }

    }

}
