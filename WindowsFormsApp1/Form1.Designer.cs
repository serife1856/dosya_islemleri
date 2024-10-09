namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonKonumSec = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.buttonOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonYazdir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(759, 24);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(161, 58);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "openFile dialog";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Location = new System.Drawing.Point(759, 88);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(161, 58);
            this.buttonFolderBrowser.TabIndex = 1;
            this.buttonFolderBrowser.Text = "Folder Browser Dialogg";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(759, 152);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(161, 58);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.Text = "Save Fİle Dialog";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonKonumSec
            // 
            this.buttonKonumSec.Location = new System.Drawing.Point(759, 216);
            this.buttonKonumSec.Name = "buttonKonumSec";
            this.buttonKonumSec.Size = new System.Drawing.Size(161, 58);
            this.buttonKonumSec.TabIndex = 3;
            this.buttonKonumSec.Text = "Konum Seç";
            this.buttonKonumSec.UseVisualStyleBackColor = true;
            this.buttonKonumSec.Click += new System.EventHandler(this.buttonKonumSec_Click);
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.Location = new System.Drawing.Point(759, 280);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(161, 58);
            this.buttonOlustur.TabIndex = 4;
            this.buttonOlustur.Text = "Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = true;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Belge Yolu";
            // 
            // textBoxYol
            // 
            this.textBoxYol.Location = new System.Drawing.Point(128, 39);
            this.textBoxYol.Name = "textBoxYol";
            this.textBoxYol.Size = new System.Drawing.Size(218, 28);
            this.textBoxYol.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Belge Adı";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(128, 106);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(218, 28);
            this.textBoxAd.TabIndex = 8;
            this.textBoxAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonOku
            // 
            this.buttonOku.Location = new System.Drawing.Point(759, 344);
            this.buttonOku.Name = "buttonOku";
            this.buttonOku.Size = new System.Drawing.Size(161, 58);
            this.buttonOku.TabIndex = 9;
            this.buttonOku.Text = "Oku";
            this.buttonOku.UseVisualStyleBackColor = true;
            this.buttonOku.Click += new System.EventHandler(this.buttonOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(29, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 136);
            this.listBox1.TabIndex = 10;
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.Location = new System.Drawing.Point(759, 417);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(161, 58);
            this.buttonYazdir.TabIndex = 11;
            this.buttonYazdir.Text = "Yazdır";
            this.buttonYazdir.UseVisualStyleBackColor = true;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 321);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(317, 141);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOku);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOlustur);
            this.Controls.Add(this.buttonKonumSec);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonFolderBrowser);
            this.Controls.Add(this.buttonOpenFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonKonumSec;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button buttonOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonYazdir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

