using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Configuration;
namespace RouterAutoRestarter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            RestartRouter();
        }
        public void RestartRouter()
        {
            //Адресс отвечающий за перезагрузку роутера
            string adress = @"http://" + login.Text + ":" + password.Text + "@" + routerIp.Text + "/userRpm/SysRebootRpm.htm?Reboot=Перезагрузка";

            Uri uri = new Uri(adress);

            //Инициализируем запрос
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri) as HttpWebRequest;
            request.Accept = "application/xml";

            //Т.к. при попытке подключиться к роутеру требует логин и пароль, 
            //это надо учесть при написании кода. Следующие строчки этим и занимаются
            var cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(login.Text, password.Text));
            request.Credentials = cache;


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
