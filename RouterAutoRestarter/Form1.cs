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
        Timer myTimer = new Timer();
        int alarmCounter = 1;

        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        bool timerStarted = false;
        bool timerEnded = false;

        public Form1()
        {
            InitializeComponent();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
            myTimer.Start();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (everyHours.Text.Length > 0 || everyMinutes.Text.Length > 0 || everySeconds.Text.Length > 0)
            {
                timerStarted = true;
                hoursLeft.BackColor = Color.ForestGreen;
                minutesLeft.BackColor = Color.ForestGreen;
                secondsLeft.BackColor = Color.ForestGreen;
                if (everyHours.Text == "")
                {
                    hours = 0;
                }
                else
                {
                    hours = Int32.Parse(everyHours.Text);
                }
                if (everyMinutes.Text == "")
                {
                    minutes = 0;
                }
                else
                {
                    minutes = Int32.Parse(everyMinutes.Text);
                    if (minutes > 60)
                        minutes = 60;
                }
                if (everySeconds.Text == "")
                {
                    seconds = 0;
                }
                else
                {
                    seconds = Int32.Parse(everySeconds.Text);
                    if (seconds > 60)
                        seconds = 60;
                }
                hoursLeft.Text = hours.ToString();
                minutesLeft.Text = minutes.ToString();
                secondsLeft.Text = seconds.ToString();

                everyHours.Enabled = false;
                everyMinutes.Enabled = false;
                everySeconds.Enabled = false;
            }
            else
            {
                everyHours.BackColor = Color.DarkRed;
                everyMinutes.BackColor = Color.DarkRed;
                everySeconds.BackColor = Color.DarkRed;
                if (MessageBox.Show("Введіть через скільки часу робити рестарт роутера") == DialogResult.OK)
                {
                    everyHours.BackColor = Color.White;
                    everyMinutes.BackColor = Color.White;
                    everySeconds.BackColor = Color.White;
                }
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;
            currentHours.Text = curTime.Hour.ToString();
            currentMinutes.Text = curTime.Minute.ToString();
            currentSeconds.Text = curTime.Second.ToString();
            hoursLeft.BackColor = Color.WhiteSmoke;
            minutesLeft.BackColor = Color.WhiteSmoke;
            secondsLeft.BackColor = Color.WhiteSmoke;

            
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            DateTime curTime = DateTime.Now;
            currentHours.Text = curTime.Hour.ToString();
            currentMinutes.Text = curTime.Minute.ToString();
            currentSeconds.Text = curTime.Second.ToString();
            if (timerStarted && !timerEnded)
            {
                if (seconds > 0)
                {
                    seconds--;
                }
                else
                {
                    if (minutes > 0)
                    {
                        minutes--;
                        seconds = 59;
                    }
                    else
                    {
                        if (hours > 0)
                        {
                            hours--;
                            minutes = 59;
                        }
                        else
                        {
                            timerEnded = true;
                            RestartRouter();
                        }
                    }
                }
                hoursLeft.Text = hours.ToString();
                minutesLeft.Text = minutes.ToString();
                secondsLeft.Text = seconds.ToString();
            }
            else if (timerEnded)
            {
                if (everyHours.Text.Length > 0 || everyMinutes.Text.Length > 0 || everySeconds.Text.Length > 0)
                {
                    if (everyHours.Text == "")
                    {
                        hours = 0;
                    }
                    else
                    {
                        hours = Int32.Parse(everyHours.Text);
                    }
                    if (everyMinutes.Text == "")
                    {
                        minutes = 0;
                    }
                    else
                    {
                        minutes = Int32.Parse(everyMinutes.Text);
                        if (minutes > 60)
                            minutes = 60;
                    }
                    if (everySeconds.Text == "")
                    {
                        seconds = 0;
                    }
                    else
                    {
                        seconds = Int32.Parse(everySeconds.Text);
                        if (seconds > 60)
                            seconds = 60;
                    }
                    hoursLeft.Text = hours.ToString();
                    minutesLeft.Text = minutes.ToString();
                    secondsLeft.Text = seconds.ToString();
                }
                timerEnded = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoursLeft.BackColor = Color.WhiteSmoke;
            minutesLeft.BackColor = Color.WhiteSmoke;
            secondsLeft.BackColor = Color.WhiteSmoke;
            timerStarted = false;

            everyHours.Enabled = true;
            everyMinutes.Enabled = true;
            everySeconds.Enabled = true;
        }

    }
}
