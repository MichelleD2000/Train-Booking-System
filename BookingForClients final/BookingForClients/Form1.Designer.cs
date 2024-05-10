namespace BookingForClients
{
    partial class Form2
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.Button();
            this.textfromstation = new System.Windows.Forms.TextBox();
            this.textendstation = new System.Windows.Forms.TextBox();
            this.dgvSeatBooking = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yournic = new System.Windows.Forms.TextBox();
            this.entername = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.trainname = new System.Windows.Forms.TextBox();
            this.traindate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.triantime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.seatnumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatBooking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Your Train ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 48);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "From Station:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "To Station:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Search.Location = new System.Drawing.Point(126, 150);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 34);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textfromstation
            // 
            this.textfromstation.Location = new System.Drawing.Point(114, 82);
            this.textfromstation.Name = "textfromstation";
            this.textfromstation.Size = new System.Drawing.Size(147, 20);
            this.textfromstation.TabIndex = 8;
            // 
            // textendstation
            // 
            this.textendstation.Location = new System.Drawing.Point(114, 118);
            this.textendstation.Name = "textendstation";
            this.textendstation.Size = new System.Drawing.Size(147, 20);
            this.textendstation.TabIndex = 9;
            // 
            // dgvSeatBooking
            // 
            this.dgvSeatBooking.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvSeatBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeatBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSeatBooking.Location = new System.Drawing.Point(292, 53);
            this.dgvSeatBooking.Name = "dgvSeatBooking";
            this.dgvSeatBooking.Size = new System.Drawing.Size(481, 131);
            this.dgvSeatBooking.TabIndex = 35;
            this.dgvSeatBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeatBooking_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-4, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(812, 35);
            this.label7.TabIndex = 36;
            this.label7.Text = "Seat Selection";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Enter Your Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Your NIC:";
            // 
            // yournic
            // 
            this.yournic.Location = new System.Drawing.Point(109, 417);
            this.yournic.Name = "yournic";
            this.yournic.Size = new System.Drawing.Size(152, 20);
            this.yournic.TabIndex = 39;
            // 
            // entername
            // 
            this.entername.Location = new System.Drawing.Point(109, 391);
            this.entername.Name = "entername";
            this.entername.Size = new System.Drawing.Size(152, 20);
            this.entername.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 282);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "Train Name:";
            // 
            // trainname
            // 
            this.trainname.Location = new System.Drawing.Point(109, 279);
            this.trainname.Name = "trainname";
            this.trainname.Size = new System.Drawing.Size(152, 20);
            this.trainname.TabIndex = 62;
            // 
            // traindate
            // 
            this.traindate.Location = new System.Drawing.Point(109, 305);
            this.traindate.Name = "traindate";
            this.traindate.Size = new System.Drawing.Size(152, 20);
            this.traindate.TabIndex = 63;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 308);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "Train Date:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 337);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 65;
            this.label21.Text = "Train Time:";
            // 
            // triantime
            // 
            this.triantime.Location = new System.Drawing.Point(109, 334);
            this.triantime.Name = "triantime";
            this.triantime.Size = new System.Drawing.Size(152, 20);
            this.triantime.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(126, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 67;
            this.button1.Text = "BOOK NOW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seatnumber
            // 
            this.seatnumber.Location = new System.Drawing.Point(109, 360);
            this.seatnumber.Name = "seatnumber";
            this.seatnumber.Size = new System.Drawing.Size(152, 20);
            this.seatnumber.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Seat Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(292, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 200);
            this.panel1.TabIndex = 95;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.MidnightBlue;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = new System.Drawing.Point(373, 156);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 27);
            this.label29.TabIndex = 15;
            this.label29.Text = "16";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.MidnightBlue;
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = new System.Drawing.Point(258, 156);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 27);
            this.label28.TabIndex = 14;
            this.label28.Text = "15";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.MidnightBlue;
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(150, 156);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 27);
            this.label27.TabIndex = 13;
            this.label27.Text = "14";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.MidnightBlue;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(40, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 27);
            this.label26.TabIndex = 12;
            this.label26.Text = "13";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.MidnightBlue;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(373, 111);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 27);
            this.label25.TabIndex = 11;
            this.label25.Text = "12";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.MidnightBlue;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(258, 111);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 27);
            this.label24.TabIndex = 10;
            this.label24.Text = "11";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.MidnightBlue;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(150, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 27);
            this.label23.TabIndex = 9;
            this.label23.Text = "10";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.MidnightBlue;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(40, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 27);
            this.label22.TabIndex = 8;
            this.label22.Text = "09";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.MidnightBlue;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(373, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 27);
            this.label18.TabIndex = 7;
            this.label18.Text = "08";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.MidnightBlue;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(258, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 27);
            this.label17.TabIndex = 6;
            this.label17.Text = "07";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.MidnightBlue;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(150, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 27);
            this.label16.TabIndex = 5;
            this.label16.Text = "06";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.MidnightBlue;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(40, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "05";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.MidnightBlue;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(373, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 27);
            this.label14.TabIndex = 3;
            this.label14.Text = "04";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.MidnightBlue;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(258, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 27);
            this.label13.TabIndex = 2;
            this.label13.Text = "03";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.MidnightBlue;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(150, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "02";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.MidnightBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(40, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "01";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.seatnumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.triantime);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.traindate);
            this.Controls.Add(this.trainname);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.entername);
            this.Controls.Add(this.yournic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSeatBooking);
            this.Controls.Add(this.textendstation);
            this.Controls.Add(this.textfromstation);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatBooking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textfromstation;
        private System.Windows.Forms.TextBox textendstation;
        private System.Windows.Forms.DataGridView dgvSeatBooking;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yournic;
        private System.Windows.Forms.TextBox entername;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox trainname;
        private System.Windows.Forms.TextBox traindate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox triantime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox seatnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}

