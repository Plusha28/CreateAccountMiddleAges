using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateAccountMiddleAges
{
    public partial class DownloadWindow : Form
    {
        public DownloadWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            downloadBtn.Visible = false;
            labelAlert.Text = "Загрузка файлов...";
            pictureDownloadGif.Visible = true;
            this.backgroundWorker1.RunWorkerAsync();
            labelAlert.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureDownloadGif.Visible = false;
            pictureSuccess.Visible = true;
        }


        private void DownloadFile()
        {
            string VSDataClientSettings = Environment.ExpandEnvironmentVariables(@"%appdata%\VintagestoryData\clientsettings.json");

            WebClient webClient = new WebClient(); //грузим вебклиент
            {
                webClient.DownloadFile("https://drive.google.com/u/2/uc?id=10e_TCn-S7ELD-pcmoYJFsR6rkc59h_uj&export=download", VSDataClientSettings); //грузим компоненту
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadFile();
        }
    }
}
