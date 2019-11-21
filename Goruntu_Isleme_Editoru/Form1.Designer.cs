namespace Goruntu_Isleme_Editoru
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaAc = new System.Windows.Forms.ToolStripMenuItem();
            this.tekrarAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değişiklikleriKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rgbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griGörüntüHistogramıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tersleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiAynalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagaAynalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağaDöndür90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solaDöndür90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiÖlçekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiGriSeviyeDönüştToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resminRGBRenkKanallarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıRenkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilRenkKanalıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviRenkKanalıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|BMP|*.bmp|GIF|*.gif|TIF|*.tif";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Dosya Seçiniz";
            this.openFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|BMP|*.bmp|GIF|*.gif|TIF|*.tif";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dosya,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Dosya
            // 
            this.Dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAc,
            this.tekrarAçToolStripMenuItem,
            this.değişiklikleriKaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.Dosya.Name = "Dosya";
            this.Dosya.Size = new System.Drawing.Size(51, 20);
            this.Dosya.Text = "Dosya";
            this.Dosya.Click += new System.EventHandler(this.Dosya_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.Name = "dosyaAc";
            this.dosyaAc.Size = new System.Drawing.Size(179, 22);
            this.dosyaAc.Text = "Dosya Aç";
            this.dosyaAc.Click += new System.EventHandler(this.dosyaAc_Click);
            // 
            // tekrarAçToolStripMenuItem
            // 
            this.tekrarAçToolStripMenuItem.Name = "tekrarAçToolStripMenuItem";
            this.tekrarAçToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.tekrarAçToolStripMenuItem.Text = "Tekrar Aç";
            this.tekrarAçToolStripMenuItem.Click += new System.EventHandler(this.tekrarAcToolStripMenuItem_Click);
            // 
            // değişiklikleriKaydetToolStripMenuItem
            // 
            this.değişiklikleriKaydetToolStripMenuItem.Enabled = false;
            this.değişiklikleriKaydetToolStripMenuItem.Name = "değişiklikleriKaydetToolStripMenuItem";
            this.değişiklikleriKaydetToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.değişiklikleriKaydetToolStripMenuItem.Text = "Değişiklikleri Kaydet";
            this.değişiklikleriKaydetToolStripMenuItem.Click += new System.EventHandler(this.degisiklikleriKaydetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.programdanCıkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rgbToolStripMenuItem,
            this.griGörüntüHistogramıToolStripMenuItem,
            this.tersleToolStripMenuItem,
            this.resmiAynalaToolStripMenuItem,
            this.resmiDöndürToolStripMenuItem,
            this.resmiÖlçekleToolStripMenuItem,
            this.resmiGriSeviyeDönüştToolStripMenuItem,
            this.resminRGBRenkKanallarıToolStripMenuItem});
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "İşlemler";
            // 
            // rgbToolStripMenuItem
            // 
            this.rgbToolStripMenuItem.Name = "rgbToolStripMenuItem";
            this.rgbToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.rgbToolStripMenuItem.Text = "Renkli Görüntü Historamı";
            this.rgbToolStripMenuItem.Click += new System.EventHandler(this.renkliGoruntuHistogramiToolStripMenuItem_Click);
            // 
            // griGörüntüHistogramıToolStripMenuItem
            // 
            this.griGörüntüHistogramıToolStripMenuItem.Name = "griGörüntüHistogramıToolStripMenuItem";
            this.griGörüntüHistogramıToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.griGörüntüHistogramıToolStripMenuItem.Text = "Gri Görüntü Histogramı";
            this.griGörüntüHistogramıToolStripMenuItem.Click += new System.EventHandler(this.griGoruntuHistogramiToolStripMenuItem_Click);
            // 
            // tersleToolStripMenuItem
            // 
            this.tersleToolStripMenuItem.Name = "tersleToolStripMenuItem";
            this.tersleToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.tersleToolStripMenuItem.Text = "Resmi Tersle (Negatifini Al)";
            this.tersleToolStripMenuItem.Click += new System.EventHandler(this.tersleToolStripMenuItem_Click);
            // 
            // resmiAynalaToolStripMenuItem
            // 
            this.resmiAynalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sagaAynalaToolStripMenuItem});
            this.resmiAynalaToolStripMenuItem.Name = "resmiAynalaToolStripMenuItem";
            this.resmiAynalaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.resmiAynalaToolStripMenuItem.Text = "Resmi Aynala";
            // 
            // sagaAynalaToolStripMenuItem
            // 
            this.sagaAynalaToolStripMenuItem.Name = "sagaAynalaToolStripMenuItem";
            this.sagaAynalaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sagaAynalaToolStripMenuItem.Text = "Sağa / Sola Aynala";
            this.sagaAynalaToolStripMenuItem.Click += new System.EventHandler(this.sagaSolaAynalaToolStripMenuItem_Click);
            // 
            // resmiDöndürToolStripMenuItem
            // 
            this.resmiDöndürToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağaDöndür90ToolStripMenuItem,
            this.solaDöndür90ToolStripMenuItem});
            this.resmiDöndürToolStripMenuItem.Name = "resmiDöndürToolStripMenuItem";
            this.resmiDöndürToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.resmiDöndürToolStripMenuItem.Text = "Resmi Döndür";
            // 
            // sağaDöndür90ToolStripMenuItem
            // 
            this.sağaDöndür90ToolStripMenuItem.Name = "sağaDöndür90ToolStripMenuItem";
            this.sağaDöndür90ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sağaDöndür90ToolStripMenuItem.Text = "Sağa Döndür (90)";
            this.sağaDöndür90ToolStripMenuItem.Click += new System.EventHandler(this.sagaDondur90ToolStripMenuItem_Click);
            // 
            // solaDöndür90ToolStripMenuItem
            // 
            this.solaDöndür90ToolStripMenuItem.Name = "solaDöndür90ToolStripMenuItem";
            this.solaDöndür90ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.solaDöndür90ToolStripMenuItem.Text = "Sola Döndür (90)";
            this.solaDöndür90ToolStripMenuItem.Click += new System.EventHandler(this.solaDondur90ToolStripMenuItem_Click);
            // 
            // resmiÖlçekleToolStripMenuItem
            // 
            this.resmiÖlçekleToolStripMenuItem.Name = "resmiÖlçekleToolStripMenuItem";
            this.resmiÖlçekleToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.resmiÖlçekleToolStripMenuItem.Text = "Resmi Ölçekle";
            this.resmiÖlçekleToolStripMenuItem.Click += new System.EventHandler(this.OlcekleToolStripMenuItem_Click);
            // 
            // resmiGriSeviyeDönüştToolStripMenuItem
            // 
            this.resmiGriSeviyeDönüştToolStripMenuItem.Name = "resmiGriSeviyeDönüştToolStripMenuItem";
            this.resmiGriSeviyeDönüştToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.resmiGriSeviyeDönüştToolStripMenuItem.Text = "Resmi Gri Tonla";
            this.resmiGriSeviyeDönüştToolStripMenuItem.Click += new System.EventHandler(this.griSeviyeDonusturToolStripMenuItem_Click);
            // 
            // resminRGBRenkKanallarıToolStripMenuItem
            // 
            this.resminRGBRenkKanallarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kırmızıRenkToolStripMenuItem,
            this.yeşilRenkKanalıToolStripMenuItem,
            this.maviRenkKanalıToolStripMenuItem});
            this.resminRGBRenkKanallarıToolStripMenuItem.Name = "resminRGBRenkKanallarıToolStripMenuItem";
            this.resminRGBRenkKanallarıToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.resminRGBRenkKanallarıToolStripMenuItem.Text = "Resmin RGB Renk Kanalları";
            // 
            // kırmızıRenkToolStripMenuItem
            // 
            this.kırmızıRenkToolStripMenuItem.Name = "kırmızıRenkToolStripMenuItem";
            this.kırmızıRenkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kırmızıRenkToolStripMenuItem.Text = "Kırmızı Renk Kanalı";
            this.kırmızıRenkToolStripMenuItem.Click += new System.EventHandler(this.kirmiziRenkKanaliToolStripMenuItem_Click);
            // 
            // yeşilRenkKanalıToolStripMenuItem
            // 
            this.yeşilRenkKanalıToolStripMenuItem.Name = "yeşilRenkKanalıToolStripMenuItem";
            this.yeşilRenkKanalıToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.yeşilRenkKanalıToolStripMenuItem.Text = "Yeşil Renk Kanalı";
            this.yeşilRenkKanalıToolStripMenuItem.Click += new System.EventHandler(this.yesilRenkKanaliToolStripMenuItem_Click);
            // 
            // maviRenkKanalıToolStripMenuItem
            // 
            this.maviRenkKanalıToolStripMenuItem.Name = "maviRenkKanalıToolStripMenuItem";
            this.maviRenkKanalıToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.maviRenkKanalıToolStripMenuItem.Text = "Mavi Renk Kanalı";
            this.maviRenkKanalıToolStripMenuItem.Click += new System.EventHandler(this.maviRenkKanaliToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Piksel Yoğunluğu";
            chartArea1.AxisY.Title = "Frekans";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(693, 129);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Lime;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Yesil";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Kirmizi";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Mavi";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Gray;
            series4.Legend = "Legend1";
            series4.Name = "Gri";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(391, 249);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Name = "histogram";
            title1.Text = "Renkli Görüntü Histogramı";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1124, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Görüntü İşleme Editörü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Dosya;
        private System.Windows.Forms.ToolStripMenuItem dosyaAc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem rgbToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tersleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiAynalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagaAynalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiDöndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağaDöndür90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solaDöndür90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiÖlçekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiGriSeviyeDönüştToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resminRGBRenkKanallarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıRenkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilRenkKanalıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviRenkKanalıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değişiklikleriKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griGörüntüHistogramıToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tekrarAçToolStripMenuItem;
    }
}

