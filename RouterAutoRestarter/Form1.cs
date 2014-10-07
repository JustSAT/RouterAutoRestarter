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
            //Адресс отвечающий за перезагрузку роутера
            string adress = @"http://" + login.Text + ":" + password.Text + "@" + routerIp.Text + "/userRpm/SysRebootRpm.htm?Reboot=Перезагрузка";

            Uri uri = new Uri(adress);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri) as HttpWebRequest;
            request.Accept = "application/xml";

            // authentication
            var cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(login.Text, password.Text));
            request.Credentials = cache;

            


            // If required by the server, set the credentials.
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
        }

    }
}
