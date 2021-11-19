using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Threading;

namespace CreateAccountMiddleAges
{
    public partial class MainRegisterWindow : Form
    {
        public MainRegisterWindow()
        {
            InitializeComponent();
            DownloadNewtonsoftJsonDLL();
            DownloadSystemRuntimeInteropServicesRuntimeInformationDLL();
        }


        private void DownloadDotNetZipDLL()
        {
            string BouncyCastleCryptoDLL = @".\DotNetZip.dll";

            string[] files = Directory.GetFiles(@".\"); // получаем файлы
            if (Array.IndexOf(files, BouncyCastleCryptoDLL) < 0) // если индекс меньше нуля, значит совпадений не найдено
            {
                WebClient webClient = new WebClient(); //грузим вебклиент
                {
                    webClient.DownloadFile("https://drive.google.com/u/0/uc?id=102sOeb5rmBWL9aswOyETUO3eM30a-Fo_&export=download", @".\DotNetZip.dll"); //грузим компоненту
                }
            }
        }

        private void DownloadNewtonsoftJsonDLL()
        {
            string BouncyCastleCryptoDLL = @".\Newtonsoft.Json.dll";   //проверка наличия файла в папке

            string[] files = Directory.GetFiles(@".\"); // получаем файлы
            if (Array.IndexOf(files, BouncyCastleCryptoDLL) < 0) // если индекс меньше нуля, значит совпадений не найдено
            {
                WebClient webClient = new WebClient(); //грузим вебклиент
                {
                    webClient.DownloadFile("https://drive.google.com/u/2/uc?id=1XftAF9KMuH5X5O8mqgfofemaXcUv7GU6&export=download", @".\Newtonsoft.Json.dll"); //грузим компоненту
                }
            }
        }

        private void DownloadSystemRuntimeInteropServicesRuntimeInformationDLL()
        {
            string BouncyCastleCryptoDLL = @".\System.Runtime.InteropServices.RuntimeInformation.dll";   //проверка наличия файла в папке

            string[] files = Directory.GetFiles(@".\"); // получаем файлы
            if (Array.IndexOf(files, BouncyCastleCryptoDLL) < 0) // если индекс меньше нуля, значит совпадений не найдено
            {
                WebClient webClient = new WebClient(); //грузим вебклиент
                {
                    webClient.DownloadFile("https://drive.google.com/u/2/uc?id=1sufyWG9ExoXT17tR55CP1nOtZSzpuUnR&export=download", @".\System.Runtime.InteropServices.RuntimeInformation.dll"); //грузим компоненту
                }
            }
        }


        private void pictureVK_Click(object sender, EventArgs e)
        {
            string url = "https://vk.com/vintageages";
            try
            {
                Process.Start("https://vk.com/vintageages");
            }
            catch
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void pictureDiscord_Click(object sender, EventArgs e)
        {
            string url = "https://discord.com/invite/gWpmkateWU";
            try
            {
                Process.Start("https://discord.com/invite/gWpmkateWU");
            }
            catch
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void pictureBoxOffPage_Click(object sender, EventArgs e)
        {
            string url = "https://www.vintagestory.at/";
            try
            {
                Process.Start("https://www.vintagestory.at/");
            }
            catch
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void pictureBoxYouTube_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=k1qcSDTfaS8";
            try
            {
                Process.Start("https://www.youtube.com/watch?v=k1qcSDTfaS8");
            }
            catch
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            bool dir = CheckDataDir();
            if (dir) {
                bool file = CheckSettingsFile();
                if (file)
                {
                    CreateAccount();
                    labelLogin.Visible = false;
                    labelPassword.Visible = false;
                    login.Visible = false;
                    password.Visible = false;
                    CreateAccountBtn.Visible = false;
                    CreateSuccess.Visible = true;
                    CreateSuccess.Text = "Аккаунт успешно создан!";
                    CreateSuccessGif.Visible = true;
                }
                else
                {
                    ShowDownloadWindow();
                }

            }
            if (!dir)
            {
                string VSDataPath = Environment.ExpandEnvironmentVariables(@"%appdata%\VintagestoryData");
                Directory.CreateDirectory(VSDataPath);
                ShowDownloadWindow();
            }

        }


        private void ShowDownloadWindow()
        {
            DownloadWindow settingsForm = new DownloadWindow();
            settingsForm.Show();
        }

        private bool CheckDataDir()
        {
            string VSDataPath = Environment.ExpandEnvironmentVariables(@"%appdata%\VintagestoryData");
            if (!Directory.Exists(VSDataPath))
            {
                try
                {
                    Directory.CreateDirectory(VSDataPath);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
            if (Directory.Exists(VSDataPath))
            {
                return true;
            }
            return true;
            
        }

        private bool CheckSettingsFile()
        {
            string VSDataClientSettings = Environment.ExpandEnvironmentVariables(@"%appdata%\VintagestoryData\clientsettings.json");
            if (File.Exists(VSDataClientSettings))
            {
                return true;
            }
            if(!File.Exists(VSDataClientSettings))
            {
                try
                {
                    return false;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }

            }
            return true;
        }

        // 1  проверить наличие директории
        // 2  проверить наличие файла который будет модифицирован 
        //      если нет файла вставить из хардкода
        //      ксли есть отредачить

        private void CreateAccount()
        {
            string VSDataClientSettings = Environment.ExpandEnvironmentVariables(@"%appdata%\VintagestoryData\clientsettings.json");
            string json = File.ReadAllText(VSDataClientSettings);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            string login = this.login.Text;
            string passw = this.password.Text;
            jsonObj["stringSettings"]["playeruid"] = passw;
            jsonObj["stringSettings"]["playername"] = login;
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(VSDataClientSettings, output);
        }


    }
}
