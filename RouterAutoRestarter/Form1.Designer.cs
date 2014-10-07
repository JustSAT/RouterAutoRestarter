namespace RouterAutoRestarter
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.routerIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.hoursLeft = new System.Windows.Forms.Label();
            this.minutesLeft = new System.Windows.Forms.Label();
            this.secondsLeft = new System.Windows.Forms.Label();
            this.currentSeconds = new System.Windows.Forms.Label();
            this.currentMinutes = new System.Windows.Forms.Label();
            this.currentHours = new System.Windows.Forms.Label();
            this.everyHours = new System.Windows.Forms.MaskedTextBox();
            this.everyMinutes = new System.Windows.Forms.MaskedTextBox();
            this.everySeconds = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // routerIp
            // 
            this.routerIp.Location = new System.Drawing.Point(81, 12);
            this.routerIp.Name = "routerIp";
            this.routerIp.Size = new System.Drawing.Size(100, 20);
            this.routerIp.TabIndex = 0;
            this.routerIp.Text = "192.168.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP роутера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логін:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(81, 40);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 4;
            this.login.Text = "admin";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(81, 66);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 5;
            this.password.Text = "admin";
            this.password.UseSystemPasswordChar = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 332);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(410, 38);
            this.start.TabIndex = 7;
            this.start.Text = "Розпочати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // hoursLeft
            // 
            this.hoursLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.hoursLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hoursLeft.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.hoursLeft.Font = new System.Drawing.Font("Segoe WP Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursLeft.Location = new System.Drawing.Point(12, 242);
            this.hoursLeft.Name = "hoursLeft";
            this.hoursLeft.Size = new System.Drawing.Size(132, 87);
            this.hoursLeft.TabIndex = 8;
            this.hoursLeft.Text = "0";
            this.hoursLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesLeft
            // 
            this.minutesLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.minutesLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minutesLeft.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.minutesLeft.Font = new System.Drawing.Font("Segoe WP Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutesLeft.Location = new System.Drawing.Point(149, 242);
            this.minutesLeft.Name = "minutesLeft";
            this.minutesLeft.Size = new System.Drawing.Size(132, 87);
            this.minutesLeft.TabIndex = 9;
            this.minutesLeft.Text = "0";
            this.minutesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondsLeft
            // 
            this.secondsLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.secondsLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondsLeft.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.secondsLeft.Font = new System.Drawing.Font("Segoe WP Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondsLeft.Location = new System.Drawing.Point(287, 242);
            this.secondsLeft.Name = "secondsLeft";
            this.secondsLeft.Size = new System.Drawing.Size(135, 87);
            this.secondsLeft.TabIndex = 10;
            this.secondsLeft.Text = "0";
            this.secondsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentSeconds
            // 
            this.currentSeconds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currentSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentSeconds.Cursor = System.Windows.Forms.Cursors.Help;
            this.currentSeconds.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSeconds.Location = new System.Drawing.Point(287, 185);
            this.currentSeconds.Name = "currentSeconds";
            this.currentSeconds.Size = new System.Drawing.Size(135, 50);
            this.currentSeconds.TabIndex = 13;
            this.currentSeconds.Text = "60";
            this.currentSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentMinutes
            // 
            this.currentMinutes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currentMinutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentMinutes.Cursor = System.Windows.Forms.Cursors.Help;
            this.currentMinutes.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentMinutes.Location = new System.Drawing.Point(149, 185);
            this.currentMinutes.Name = "currentMinutes";
            this.currentMinutes.Size = new System.Drawing.Size(132, 50);
            this.currentMinutes.TabIndex = 12;
            this.currentMinutes.Text = "60";
            this.currentMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentHours
            // 
            this.currentHours.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currentHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentHours.Cursor = System.Windows.Forms.Cursors.Help;
            this.currentHours.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentHours.Location = new System.Drawing.Point(12, 185);
            this.currentHours.Name = "currentHours";
            this.currentHours.Size = new System.Drawing.Size(132, 50);
            this.currentHours.TabIndex = 11;
            this.currentHours.Text = "24";
            this.currentHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // everyHours
            // 
            this.everyHours.Location = new System.Drawing.Point(12, 162);
            this.everyHours.Mask = "00";
            this.everyHours.Name = "everyHours";
            this.everyHours.Size = new System.Drawing.Size(132, 20);
            this.everyHours.TabIndex = 14;
            this.everyHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // everyMinutes
            // 
            this.everyMinutes.Location = new System.Drawing.Point(149, 162);
            this.everyMinutes.Mask = "00";
            this.everyMinutes.Name = "everyMinutes";
            this.everyMinutes.Size = new System.Drawing.Size(132, 20);
            this.everyMinutes.TabIndex = 15;
            this.everyMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // everySeconds
            // 
            this.everySeconds.Location = new System.Drawing.Point(287, 162);
            this.everySeconds.Mask = "00";
            this.everySeconds.Name = "everySeconds";
            this.everySeconds.Size = new System.Drawing.Size(135, 20);
            this.everySeconds.TabIndex = 16;
            this.everySeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Години:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Хвилини:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(283, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Секунди:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Рестарт роутера буде відбуватися кожного разу коли закінчиться час.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.everySeconds);
            this.Controls.Add(this.everyMinutes);
            this.Controls.Add(this.everyHours);
            this.Controls.Add(this.currentSeconds);
            this.Controls.Add(this.currentMinutes);
            this.Controls.Add(this.currentHours);
            this.Controls.Add(this.secondsLeft);
            this.Controls.Add(this.minutesLeft);
            this.Controls.Add(this.hoursLeft);
            this.Controls.Add(this.start);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.routerIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Router Auto Restarter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox routerIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label hoursLeft;
        private System.Windows.Forms.Label minutesLeft;
        private System.Windows.Forms.Label secondsLeft;
        private System.Windows.Forms.Label currentSeconds;
        private System.Windows.Forms.Label currentMinutes;
        private System.Windows.Forms.Label currentHours;
        private System.Windows.Forms.MaskedTextBox everyHours;
        private System.Windows.Forms.MaskedTextBox everyMinutes;
        private System.Windows.Forms.MaskedTextBox everySeconds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

