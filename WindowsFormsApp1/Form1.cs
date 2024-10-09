using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void buttonFolderBrowser_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        string belgeyolu, belgeadi;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(belgeyolu+"\\"+belgeadi+".txt");
            MessageBox.Show("Belgeniz Başarıyla Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader oku= new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while( satir !=null)
                {
                    listBox1.Items.Add( satir );
                    satir = oku.ReadLine();
                }
            }
        }

        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter= "Metin Belgesi |*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kayde= new StreamWriter(saveFileDialog1.FileName);
            kayde.WriteLine(richTextBox1.Text);
            kayde.Close();
            MessageBox.Show("Kayııt Yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void buttonKonumSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                textBoxYol.Text = belgeyolu;
            }
        }
    }
}
