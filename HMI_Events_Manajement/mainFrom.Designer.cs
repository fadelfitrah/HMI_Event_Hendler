using System.Windows.Forms;
using System;

namespace HMI_Events_Manajement
{
    partial class mainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent2()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Events1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addTrue = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.addTrue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Events1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(139, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // listView1
            // 
            this.Events1.HideSelection = false;
            this.Events1.Location = new System.Drawing.Point(22, 109);
            this.Events1.Name = "Events1";
            this.Events1.Size = new System.Drawing.Size(200, 185);
            this.Events1.TabIndex = 1;
            this.Events1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pelantikan Pengurus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(70, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "05 Februari 2024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(54, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gedung Kebudayaan";
            // 
            // addTrue
            // 
            this.addTrue.BackColor = System.Drawing.Color.Chartreuse;
            this.addTrue.Location = new System.Drawing.Point(70, 253);
            this.addTrue.Name = "addTrue";
            this.addTrue.Size = new System.Drawing.Size(99, 35);
            this.addTrue.TabIndex = 6;
            this.addTrue.Text = "Absen";
            this.addTrue.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(311, 109);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(200, 185);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 673);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button addTrue;
        private System.Windows.Forms.ListView Events1;
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logOut = new System.Windows.Forms.Button();
            this.kalenderEvents = new System.Windows.Forms.Button();
            this.daftarEvents = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.extraNavbar = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cekEvents = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.notifications = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.halaman = new System.Windows.Forms.FlowLayoutPanel();
            this.pelantikanGroup = new System.Windows.Forms.GroupBox();
            this.detail1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pelatihan = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detail2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.detail3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.detail4 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.detailShow = new System.Windows.Forms.GroupBox();
            this.Usermessage = new System.Windows.Forms.Panel();
            this.sendBtn = new System.Windows.Forms.Button();
            this.userMessageText = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.event1Desc = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.extraNavbar.SuspendLayout();
            this.halaman.SuspendLayout();
            this.pelantikanGroup.SuspendLayout();
            this.pelatihan.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.detailShow.SuspendLayout();
            this.Usermessage.SuspendLayout();
            this.event1Desc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.logOut);
            this.groupBox1.Controls.Add(this.kalenderEvents);
            this.groupBox1.Controls.Add(this.daftarEvents);
            this.groupBox1.Controls.Add(this.home);
            this.groupBox1.Location = new System.Drawing.Point(4, 71);
            this.groupBox1.MaximumSize = new System.Drawing.Size(95, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.White;
            this.logOut.BackgroundImage = global::HMI_Events_Manajement.Properties.Resources.home_icon_silhouette_69524;
            this.logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logOut.Image = global::HMI_Events_Manajement.Properties.Resources.logout_1828479__1_;
            this.logOut.Location = new System.Drawing.Point(13, 367);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(67, 65);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Log Out";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // kalenderEvents
            // 
            this.kalenderEvents.BackColor = System.Drawing.Color.White;
            this.kalenderEvents.BackgroundImage = global::HMI_Events_Manajement.Properties.Resources.home_icon_silhouette_69524;
            this.kalenderEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kalenderEvents.Image = global::HMI_Events_Manajement.Properties.Resources.calendar_2886665__1_;
            this.kalenderEvents.Location = new System.Drawing.Point(13, 247);
            this.kalenderEvents.Name = "kalenderEvents";
            this.kalenderEvents.Size = new System.Drawing.Size(67, 70);
            this.kalenderEvents.TabIndex = 2;
            this.kalenderEvents.Text = "Date";
            this.kalenderEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kalenderEvents.UseVisualStyleBackColor = false;
            this.kalenderEvents.Click += new System.EventHandler(this.kalenderEvents_Click);
            // 
            // daftarEvents
            // 
            this.daftarEvents.BackColor = System.Drawing.Color.White;
            this.daftarEvents.BackgroundImage = global::HMI_Events_Manajement.Properties.Resources.home_icon_silhouette_69524;
            this.daftarEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.daftarEvents.Image = global::HMI_Events_Manajement.Properties.Resources.list_1950630__1_;
            this.daftarEvents.Location = new System.Drawing.Point(13, 130);
            this.daftarEvents.Name = "daftarEvents";
            this.daftarEvents.Size = new System.Drawing.Size(67, 63);
            this.daftarEvents.TabIndex = 1;
            this.daftarEvents.Text = "Events";
            this.daftarEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.daftarEvents.UseVisualStyleBackColor = false;
            this.daftarEvents.Click += new System.EventHandler(this.daftarEvents_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.BackgroundImage = global::HMI_Events_Manajement.Properties.Resources.home_icon_silhouette_69524;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home.Image = global::HMI_Events_Manajement.Properties.Resources.home_icon_silhouette_69524__2_;
            this.home.Location = new System.Drawing.Point(13, 21);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(67, 62);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // extraNavbar
            // 
            this.extraNavbar.AutoSize = true;
            this.extraNavbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extraNavbar.Controls.Add(this.dateTimePicker1);
            this.extraNavbar.Controls.Add(this.cekEvents);
            this.extraNavbar.Location = new System.Drawing.Point(103, -3);
            this.extraNavbar.Name = "extraNavbar";
            this.extraNavbar.Size = new System.Drawing.Size(1008, 82);
            this.extraNavbar.TabIndex = 2;
            this.extraNavbar.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // cekEvents
            // 
            this.cekEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cekEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cekEvents.Location = new System.Drawing.Point(604, 21);
            this.cekEvents.Multiline = true;
            this.cekEvents.Name = "cekEvents";
            this.cekEvents.Size = new System.Drawing.Size(398, 40);
            this.cekEvents.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1066, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 110);
            this.button2.TabIndex = 4;
            this.button2.Text = "Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifications
            // 
            this.notifications.Location = new System.Drawing.Point(1066, 280);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(124, 110);
            this.notifications.TabIndex = 5;
            this.notifications.Text = "Notification";
            this.notifications.UseVisualStyleBackColor = true;
            this.notifications.Click += new System.EventHandler(this.notifications_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1066, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 110);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reminder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // halaman
            // 
            this.halaman.AutoScroll = true;
            this.halaman.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.halaman.Controls.Add(this.pelantikanGroup);
            this.halaman.Controls.Add(this.pelatihan);
            this.halaman.Controls.Add(this.groupBox5);
            this.halaman.Controls.Add(this.groupBox7);
            this.halaman.Controls.Add(this.detailShow);
            this.halaman.Location = new System.Drawing.Point(172, 92);
            this.halaman.Name = "halaman";
            this.halaman.Size = new System.Drawing.Size(826, 506);
            this.halaman.TabIndex = 7;
            // 
            // pelantikanGroup
            // 
            this.pelantikanGroup.BackColor = System.Drawing.Color.White;
            this.pelantikanGroup.Controls.Add(this.detail1);
            this.pelantikanGroup.Controls.Add(this.label2);
            this.pelantikanGroup.Controls.Add(this.label1);
            this.pelantikanGroup.Location = new System.Drawing.Point(3, 3);
            this.pelantikanGroup.Name = "pelantikanGroup";
            this.pelantikanGroup.Size = new System.Drawing.Size(200, 155);
            this.pelantikanGroup.TabIndex = 0;
            this.pelantikanGroup.TabStop = false;
            // 
            // detail1
            // 
            this.detail1.BackColor = System.Drawing.Color.DarkGreen;
            this.detail1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detail1.Location = new System.Drawing.Point(35, 109);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(122, 40);
            this.detail1.TabIndex = 2;
            this.detail1.Text = "Detail";
            this.detail1.UseVisualStyleBackColor = false;
            this.detail1.Click += new System.EventHandler(this.detail1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Februari 2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelantikan Pengurus";
            // 
            // pelatihan
            // 
            this.pelatihan.BackColor = System.Drawing.Color.White;
            this.pelatihan.Controls.Add(this.groupBox4);
            this.pelatihan.Controls.Add(this.label5);
            this.pelatihan.Controls.Add(this.detail2);
            this.pelatihan.Controls.Add(this.label3);
            this.pelatihan.Controls.Add(this.label4);
            this.pelatihan.Location = new System.Drawing.Point(209, 3);
            this.pelatihan.Name = "pelatihan";
            this.pelatihan.Size = new System.Drawing.Size(200, 155);
            this.pelatihan.TabIndex = 3;
            this.pelatihan.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(209, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 155);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pemrogramman";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGreen;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(35, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Detail";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Februari 2024";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pelatihan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pemrogramman";
            // 
            // detail2
            // 
            this.detail2.BackColor = System.Drawing.Color.DarkGreen;
            this.detail2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detail2.Location = new System.Drawing.Point(35, 109);
            this.detail2.Name = "detail2";
            this.detail2.Size = new System.Drawing.Size(122, 40);
            this.detail2.TabIndex = 2;
            this.detail2.Text = "Detail";
            this.detail2.UseVisualStyleBackColor = false;
            this.detail2.Click += new System.EventHandler(this.detail2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Februari 2024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pelatihan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.detail3);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(415, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 155);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(209, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 155);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Pemrogramman";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGreen;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(35, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "Detail";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Februari 2024";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pelatihan";
            // 
            // detail3
            // 
            this.detail3.BackColor = System.Drawing.Color.DarkGreen;
            this.detail3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detail3.Location = new System.Drawing.Point(35, 109);
            this.detail3.Name = "detail3";
            this.detail3.Size = new System.Drawing.Size(122, 40);
            this.detail3.TabIndex = 2;
            this.detail3.Text = "Detail";
            this.detail3.UseVisualStyleBackColor = false;
            this.detail3.Click += new System.EventHandler(this.detail3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Februari 2024";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Seminar Sains";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.detail4);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Location = new System.Drawing.Point(621, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 155);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.button9);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Location = new System.Drawing.Point(209, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 155);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(27, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Pemrogramman";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGreen;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(35, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 40);
            this.button9.TabIndex = 2;
            this.button9.Text = "Detail";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Februari 2024";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Pelatihan";
            // 
            // detail4
            // 
            this.detail4.BackColor = System.Drawing.Color.DarkGreen;
            this.detail4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detail4.Location = new System.Drawing.Point(35, 109);
            this.detail4.Name = "detail4";
            this.detail4.Size = new System.Drawing.Size(122, 40);
            this.detail4.TabIndex = 2;
            this.detail4.Text = "Detail";
            this.detail4.UseVisualStyleBackColor = false;
            this.detail4.Click += new System.EventHandler(this.detail4_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(48, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Februari 2024";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(43, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "LK 1 part 1";
            // 
            // detailShow
            // 
            this.detailShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detailShow.Controls.Add(this.Usermessage);
            this.detailShow.Controls.Add(this.event1Desc);
            this.detailShow.Location = new System.Drawing.Point(3, 164);
            this.detailShow.Name = "detailShow";
            this.detailShow.Size = new System.Drawing.Size(818, 332);
            this.detailShow.TabIndex = 7;
            this.detailShow.TabStop = false;
            this.detailShow.Text = "Detail";
            // 
            // Usermessage
            // 
            this.Usermessage.AutoSize = true;
            this.Usermessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Usermessage.Controls.Add(this.sendBtn);
            this.Usermessage.Controls.Add(this.userMessageText);
            this.Usermessage.Controls.Add(this.button5);
            this.Usermessage.Controls.Add(this.button3);
            this.Usermessage.Controls.Add(this.button1);
            this.Usermessage.Location = new System.Drawing.Point(358, 34);
            this.Usermessage.MaximumSize = new System.Drawing.Size(800, 325);
            this.Usermessage.Name = "Usermessage";
            this.Usermessage.Size = new System.Drawing.Size(434, 271);
            this.Usermessage.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(300, 236);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(124, 32);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Kirim";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // userMessageText
            // 
            this.userMessageText.Location = new System.Drawing.Point(12, 44);
            this.userMessageText.Multiline = true;
            this.userMessageText.Name = "userMessageText";
            this.userMessageText.Size = new System.Drawing.Size(412, 184);
            this.userMessageText.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // event1Desc
            // 
            this.event1Desc.AutoSize = true;
            this.event1Desc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.event1Desc.Controls.Add(this.label26);
            this.event1Desc.Controls.Add(this.label25);
            this.event1Desc.Controls.Add(this.label24);
            this.event1Desc.Controls.Add(this.label23);
            this.event1Desc.Controls.Add(this.label22);
            this.event1Desc.Controls.Add(this.label21);
            this.event1Desc.Controls.Add(this.label18);
            this.event1Desc.Controls.Add(this.label12);
            this.event1Desc.Location = new System.Drawing.Point(22, 34);
            this.event1Desc.Name = "event1Desc";
            this.event1Desc.Size = new System.Drawing.Size(330, 228);
            this.event1Desc.TabIndex = 0;
            this.event1Desc.TabStop = false;
            this.event1Desc.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(182, 193);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Gedung kebudayaan";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(181, 139);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 17);
            this.label25.TabIndex = 6;
            this.label25.Text = "Semua anggota";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(181, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 17);
            this.label24.TabIndex = 5;
            this.label24.Text = "12 Februari 2024";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(181, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(143, 17);
            this.label23.TabIndex = 4;
            this.label23.Text = "Pelantikan Pengurus";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 16);
            this.label22.TabIndex = 3;
            this.label22.Text = "Lokasi :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "Peserta :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Tanggal kegiatan :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nama kegiatan : ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Green;
            this.label27.Location = new System.Drawing.Point(1137, 285);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 20);
            this.label27.TabIndex = 8;
            this.label27.Text = "New";
            // 
            // mainFrom
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1227, 670);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.halaman);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.notifications);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.extraNavbar);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainFrom";
            this.Load += new System.EventHandler(this.mainFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.extraNavbar.ResumeLayout(false);
            this.extraNavbar.PerformLayout();
            this.halaman.ResumeLayout(false);
            this.pelantikanGroup.ResumeLayout(false);
            this.pelantikanGroup.PerformLayout();
            this.pelatihan.ResumeLayout(false);
            this.pelatihan.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.detailShow.ResumeLayout(false);
            this.detailShow.PerformLayout();
            this.Usermessage.ResumeLayout(false);
            this.Usermessage.PerformLayout();
            this.event1Desc.ResumeLayout(false);
            this.event1Desc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button kalenderEvents;
        private System.Windows.Forms.Button daftarEvents;
        private System.Windows.Forms.GroupBox extraNavbar;
        private System.Windows.Forms.TextBox cekEvents;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button notifications;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel halaman;
        private GroupBox pelantikanGroup;
        private Label label1;
        private Button detail1;
        private Label label2;
        private GroupBox pelatihan;
        private Button detail2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox4;
        private Label label6;
        private Button button6;
        private Label label7;
        private Label label8;
        private Label label5;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label9;
        private Button button7;
        private Label label10;
        private Label label11;
        private Button detail3;
        private Label label13;
        private Label label14;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Label label15;
        private Button button9;
        private Label label16;
        private Label label17;
        private Button detail4;
        private Label label19;
        private Label label20;
        private GroupBox detailShow;
        private GroupBox event1Desc;
        private Label label12;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label18;
        private DateTimePicker dateTimePicker1;
        private Label label27;
        private Panel Usermessage;
        private TextBox userMessageText;
        private Button button5;
        private Button button3;
        private Button button1;
        private Button sendBtn;
    }
}