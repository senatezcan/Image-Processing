using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Goruntu_Isleme_Editoru
{
    public partial class olcekGirisEkrani : Form
    {
        public olcekGirisEkrani()
        {
            InitializeComponent();

            button2.DialogResult = DialogResult.OK;
            button1.DialogResult = DialogResult.Cancel;
        }

        public int yeniYuksekik
        {
            get
            {
                return Convert.ToInt32(textBox1.Text);
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }

        public int yeniGenislik
        {
            get
            {
                return Convert.ToInt32(textBox2.Text);
            }
            set
            {
                textBox2.Text = value.ToString();
            }
        }


        private void olcekGirisEkrani_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
