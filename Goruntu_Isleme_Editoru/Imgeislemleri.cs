using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;


namespace Goruntu_Isleme_Editoru
{

    class Imgeislemleri
    {
        private Bitmap imgeSuanki;

        public Bitmap ImgeSuanki
        {
            get
            {
                return imgeSuanki;
            }
            set
            {
                imgeSuanki = value;
            }

        }


        public void histogramHesapla(Form1 form)
        {

            BitmapData bmpVeri = null;

            bmpVeri = imgeSuanki.LockBits(new Rectangle(0, 0, imgeSuanki.Width, imgeSuanki.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int rgbNoktaSayisi = imgeSuanki.Width * imgeSuanki.Height * 3;


            byte[] rgbDegerleri = new byte[rgbNoktaSayisi];


            int[] histogramKirmizi = new int[256];
            int[] histogramYesil = new int[256];
            int[] histogramMavi = new int[256];

            int[] histogramGriseviye = new int[256];


            System.IntPtr ptrScan0 = bmpVeri.Scan0;
            Marshal.Copy(ptrScan0, rgbDegerleri, 0, rgbNoktaSayisi);


            for (int i = 0; i < rgbNoktaSayisi; i++)
            {
                // BGR olarak okunduğu için önce Mavi, sonra yeşil (i+1. indeks) en son kırmızı (i+2. indeks)
                histogramMavi[rgbDegerleri[i]]++;
                histogramYesil[rgbDegerleri[i + 1]]++;
                histogramKirmizi[rgbDegerleri[i + 2]]++;

                histogramGriseviye[(byte)(rgbDegerleri[i] * 0.11 + rgbDegerleri[i + 1] * 0.58 + rgbDegerleri[i + 2] * 0.29)]++;


                i += 2;
            }

            form.chart1.Series["Mavi"].Points.DataBindY(histogramMavi);
            form.chart1.Series["Yesil"].Points.DataBindY(histogramYesil);
            form.chart1.Series["Kirmizi"].Points.DataBindY(histogramKirmizi);
            form.chart1.Series["Gri"].Points.DataBindY(histogramGriseviye);

            imgeSuanki.UnlockBits(bmpVeri);
            bmpVeri = null;                 
            rgbDegerleri = null;            
            System.GC.Collect();

        }


        public void tersle(Form1 form)
        {

            Bitmap terslenmisImge = imgeSuanki;
            Color renkDegeri;
            int xEksen = terslenmisImge.Width;
            int yEksen = terslenmisImge.Height;

            for (int x = 0; x < xEksen; x++)
            {
                for (int y = 0; y < yEksen; y++)
                {
                    renkDegeri = terslenmisImge.GetPixel(x, y);
                    terslenmisImge.SetPixel(x, y, Color.FromArgb(255 - renkDegeri.R, 255 - renkDegeri.G, 255 - renkDegeri.B));
                }
            }

            form.pictureBox1.Image = terslenmisImge; 

            imgeSuanki = terslenmisImge;             


        }


        public void aynala(Form1 form)
        {
            Bitmap aynalanmisImge = new Bitmap(imgeSuanki.Width, imgeSuanki.Height);

            int sonSatir = aynalanmisImge.Width - 1;
            int xEksen = aynalanmisImge.Width;
            int yEksen = aynalanmisImge.Height;

            for (int x = 0; x < xEksen; x++)
            {
                for (int y = 0; y < yEksen; y++)
                {
                    aynalanmisImge.SetPixel(sonSatir, y, imgeSuanki.GetPixel(x, y));
                }
                sonSatir--;
            }

            form.pictureBox1.Image = aynalanmisImge; 

            imgeSuanki = aynalanmisImge;             

        }

        public void sagsolDondur(Form1 form, char yon)
        {
            // Orjinal resmin sutun boyunu sag donmus resmin satır boyu, satır boylarını ise sutun boyu yaptık
            Bitmap dondurulmusImge = new Bitmap(imgeSuanki.Height, imgeSuanki.Width, PixelFormat.Format24bppRgb);

            if (yon == '+')
            {
                int OrjResSutunlariSonu = imgeSuanki.Height - 1;

                for (int y = 0; y < imgeSuanki.Height; y++)
                {
                    for (int x = 0; x < imgeSuanki.Width; x++)
                    {
                        dondurulmusImge.SetPixel(OrjResSutunlariSonu - y, x, imgeSuanki.GetPixel(x, y));
                    }
                }
            }

            else
            {
                int OrjResSatirlariSonu = imgeSuanki.Width - 1;

                for (int y = 0; y < imgeSuanki.Height; y++)
                {
                    for (int x = 0; x < imgeSuanki.Width; x++)
                    {
                        dondurulmusImge.SetPixel(y, OrjResSatirlariSonu - x, imgeSuanki.GetPixel(x, y));

                    }
                }

            }

            form.pictureBox1.Image = dondurulmusImge;

            imgeSuanki = dondurulmusImge;

        }

        public void olcekle(Form1 form, int yeniYukseklik, int yeniGenislik)
        {

            Bitmap olceklenmisImge = new Bitmap(yeniGenislik, yeniYukseklik, PixelFormat.Format24bppRgb);


            double olcekX = (double)ImgeSuanki.Width / yeniGenislik;
            double olcekY = (double)ImgeSuanki.Height / yeniYukseklik;


            for (int x = 0; x < yeniGenislik; x++)
            {
                for (int y = 0; y < yeniYukseklik; y++)
                {
                    olceklenmisImge.SetPixel(x, y, ImgeSuanki.GetPixel((int)(Math.Floor(x * olcekX)), (int)(Math.Floor(y * olcekY))));
                }
            }

            form.pictureBox1.Image = olceklenmisImge;

            imgeSuanki = olceklenmisImge;

        }

        public void griYap(Form1 form)
        {
            Bitmap griseviyeImge = new Bitmap(imgeSuanki.Width, imgeSuanki.Height);

            Color renkDegeri;
            byte griSeviyeDegeri;
            int xEksen = griseviyeImge.Width;
            int yEksen = griseviyeImge.Height;

            for (int x = 0; x < xEksen; x++)
            {
                for (int y = 0; y < yEksen; y++)
                {
                    renkDegeri = imgeSuanki.GetPixel(x, y);
                    griSeviyeDegeri = (byte)((renkDegeri.R * 0.29) + (renkDegeri.G * 0.58) + (renkDegeri.B * 0.11));
                    griseviyeImge.SetPixel(x, y, Color.FromArgb(griSeviyeDegeri, griSeviyeDegeri, griSeviyeDegeri));
                }
            }

            form.pictureBox1.Image = griseviyeImge;

            imgeSuanki = griseviyeImge;

        }

        public void renkKanallari(Form1 form, char kanal)
        {
            Bitmap tekkanalImge = new Bitmap(imgeSuanki.Width, imgeSuanki.Height, PixelFormat.Format24bppRgb);


            Color renkDegeri;
            byte kirmizi, yesil, mavi;
            int xEksen = tekkanalImge.Width;
            int yEksen = tekkanalImge.Height;

            for (int x = 0; x < xEksen; x++)
            {
                for (int y = 0; y < yEksen; y++)
                {

                    renkDegeri = imgeSuanki.GetPixel(x, y);

                    kirmizi = renkDegeri.R;
                    yesil = renkDegeri.G;
                    mavi = renkDegeri.B;
                    
                    if (kanal == 'r') tekkanalImge.SetPixel(x, y, Color.FromArgb(kirmizi, 0, 0));
                    if (kanal == 'g') tekkanalImge.SetPixel(x, y, Color.FromArgb(0, yesil, 0));
                    if (kanal == 'b') tekkanalImge.SetPixel(x, y, Color.FromArgb(0, 0, mavi));
                }
            }


            form.pictureBox1.Image = tekkanalImge;

            imgeSuanki = tekkanalImge;

        }
    }
}
