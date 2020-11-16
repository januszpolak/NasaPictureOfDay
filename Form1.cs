using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace NasaPhotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string results;
            using (WebClient client = new WebClient())
            results = client.DownloadString("https://api.nasa.gov/planetary/apod?api_key=D5eW7d8pzrELRM0UxNJl8diqhHYVkc98YoMalk6M");
            dynamic nasaResults = JObject.Parse(results);

            string title = nasaResults.title;
            label1.Text = title;

            var picture = nasaResults.url;
            pictureBox1.ImageLocation = picture;


            var desc = nasaResults.explanation;
            textBox1.Text = desc;


        }
    }
}
