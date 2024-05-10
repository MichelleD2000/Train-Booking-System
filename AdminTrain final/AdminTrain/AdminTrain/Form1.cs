using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;
using System.Net.Http;

namespace Admin
{
    public partial class Form1 : Form
    {
        int id;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnUpddate_Click(object sender, EventArgs e)
        {
           


        }



        private void btnADD_Click(object sender, EventArgs e)
        {



        }

        public void LoadTrain()
        {
            string url = "https://localhost:7021/api/Train";
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
              string json = client.DownloadString(url);
            dgvAdmin.DataSource = null;
            dgvAdmin.DataSource = (new JavaScriptSerializer()).Deserialize<List<Train>>(json);
            dgvAdmin.Columns["Id"].Visible = false;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTrain();
        }




        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {

            string url = "https://localhost:7021/api/Train";
            HttpClient client = new HttpClient();
            Train train = new Train();
            train.Name = textname.Text;
            train.Date = textdate.Text;
            train.Time = texttime.Text;
            train.Start = textstart.Text;
            train.End = textend.Text;
            train.TrainBox = Convert.ToInt32(textBox.Text);
            string data = (new JavaScriptSerializer()).Serialize(train);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var res = client.PostAsync(url, content).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Added Successfuly");
                LoadTrain();
            }
            else
            {
                MessageBox.Show("Adding Failed");
            }

        }

        private void btnUpddate_Click_1(object sender, EventArgs e)
        {
            string url = "https://localhost:7021/api/Train/" + id;
            HttpClient client = new HttpClient();
            Train train = new Train();
            train.Id = id;
            train.Name = textname.Text;
            train.Date = textdate.Text;
            train.Time = texttime.Text;
            train.Start = textstart.Text;
            train.End = textend.Text;
            train.TrainBox = Convert.ToInt32(textBox.Text);
            string data = (new JavaScriptSerializer()).Serialize(train);
            var content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            var res = client.PutAsync(url, content).Result;
            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Update Successfuly");
                LoadTrain();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }


        }

        private void dgvAdmin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                textname.Text = dgvAdmin.Rows[e.RowIndex].Cells[3].Value.ToString();
                textdate.Text = dgvAdmin.Rows[e.RowIndex].Cells[4].Value.ToString();
                texttime.Text = dgvAdmin.Rows[e.RowIndex].Cells[5].Value.ToString();
                textstart.Text = dgvAdmin.Rows[e.RowIndex].Cells[6].Value.ToString();
                textend.Text = dgvAdmin.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox.Text = dgvAdmin.Rows[e.RowIndex].Cells[8].Value.ToString();
                id = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells[2].Value.ToString());

            }
            else if (e.ColumnIndex == 1)
            {
                id = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells[2].Value.ToString());
                string url = "https://localhost:7021/api/Train/" + id;
                HttpClient client = new HttpClient();
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var res = client.DeleteAsync(url).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        LoadTrain();
                    }
                }
            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

    }

    public class Train
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public int TrainBox { get; set; }

    }
}
