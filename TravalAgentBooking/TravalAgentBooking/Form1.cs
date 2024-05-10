using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Net.Http;

namespace TravalAgentBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void LoadUser()
        {
            string url = "https://localhost:7021/api/Train";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.DownloadString(url);

            List<Trains> trains = (new JavaScriptSerializer()).Deserialize<List<Trains>>(json);

            string startFilter = textfromstation.Text.Trim();
            string endFilter = textendstation.Text.Trim();
            DateTime dateFilter = dateTimePicker1.Value.Date;

            List<Trains> filteredTrains = trains.Where(train =>
                (string.IsNullOrEmpty(startFilter) || train.Start == startFilter) &&
                (string.IsNullOrEmpty(endFilter) || train.End == endFilter) &&
                (train.Date == dateFilter.ToShortDateString())
            ).ToList();
            dgvSeatBooking.DataSource = null;
            dgvSeatBooking.DataSource = filteredTrains;
            dgvSeatBooking.Columns["Id"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvSeatBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                trainname.Text = dgvSeatBooking.Rows[e.RowIndex].Cells[1].Value.ToString();
                traindate.Text = dgvSeatBooking.Rows[e.RowIndex].Cells[2].Value.ToString();
                triantime.Text = dgvSeatBooking.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7021/api/SeatBooking";
            HttpClient client = new HttpClient();
            SeatBooking seatBooking = new SeatBooking();
            seatBooking.TrainName = trainname.Text;
            seatBooking.TrainDate = traindate.Text;
            seatBooking.TrainTime = triantime.Text;
            seatBooking.FromStation = textfromstation.Text;
            seatBooking.ToStation = textendstation.Text;
            seatBooking.NIC = yournic.Text;
            seatBooking.PassengerName = entername.Text;
            seatBooking.Numberofseats = seatnumber.Text;

            string data = (new JavaScriptSerializer()).Serialize(seatBooking);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var res = client.PostAsync(url, content).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Your Seat is Booked");
            }
            else
            {
                MessageBox.Show("Failed to Book Seat. Try Again");
            }

            string[] seats = seatBooking.Numberofseats.Split(',');
            if (seats.Length > 5)
            {
                MessageBox.Show("One person can book only five seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!AreSeatsAvailable(seatBooking.TrainName, seats))
            {
                MessageBox.Show("One or more seats are already booked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool AreSeatsAvailable(string trainName, string[] seats)
        {

            return true;
        }
        public class SeatBooking
        {
            public int Id { get; set; }

            public string TrainName { get; set; }

            public string TrainDate { get; set; }

            public string TrainTime { get; set; }

            public string FromStation { get; set; }

            public string ToStation { get; set; }

            public string NIC { get; set; }

            public string PassengerName { get; set; }

            public string Numberofseats { get; set; }
        }

        public class Trains
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Date { get; set; }

            public string Time { get; set; }

            public string Start { get; set; }

            public string End { get; set; }

            public int TrainBox { get; set; }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
