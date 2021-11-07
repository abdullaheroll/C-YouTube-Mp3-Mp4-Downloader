using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit;
using VideoLibrary;

namespace Youtube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean format = true;

        private async void button1_Click(object sender, EventArgs e)
        {
            //YouTube MP3/MP4 İndirici
            //github.com/abdullaheroll
            using (FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Lütfen Klasör Seçiniz" })
            {
                if (dialog.ShowDialog()==DialogResult.OK)
                {
                    GetTitle();
                    MessageBox.Show("İndirme İşlemi Başladı Lütfen Bekleyiniz...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    var yt = YouTube.Default;
                    var video = await yt.GetVideoAsync(textBox1.Text);
                    File.WriteAllBytes(dialog.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var girisdosyasi = new MediaToolkit.Model.MediaFile { Filename = dialog.SelectedPath + @"\" + video.FullName };
                    var cikisdosyasi = new MediaToolkit.Model.MediaFile { Filename = $"{dialog.SelectedPath + @"\" + video.FullName }.mp3" };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(girisdosyasi);
                        enging.Convert(girisdosyasi, cikisdosyasi);

                    }
                    if (format == true)
                    {
                        File.Delete(dialog.SelectedPath + @"\" + video.FullName);
                    }
                    if (format == false)
                    {
                        File.Delete($"{dialog.SelectedPath + @"\" + video.FullName}.mp3");
                    }


                    progressBar1.Value = 100;
                    MessageBox.Show("İndirme İşlemi Tamamlandı <3", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Dosya Yolu Seçiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var yt = YouTube.Default;
                }
            }
        }




        void GetTitle()
        {
            WebRequest istek = HttpWebRequest.Create(textBox1.Text);
            WebResponse yanit = istek.GetResponse();
            StreamReader sr = new StreamReader(yanit.GetResponseStream());
            string gelen = sr.ReadToEnd();
            int baslangic = gelen.IndexOf("<title>") + 7;
            int bitis = gelen.Substring(baslangic).IndexOf("</title>");
            string gelenbilgi = gelen.Substring(baslangic, bitis);
            baslik.Text = (gelenbilgi);
        }

        private void radioButtonMP3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonMP4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonMP3_CheckedChanged(object sender, EventArgs e)
        {
            format = true;
        }

        private void radioButtonMP4_CheckedChanged(object sender, EventArgs e)
        {
            format = false;
        }
    }
}
