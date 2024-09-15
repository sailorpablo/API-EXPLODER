using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System;

namespace Api_Exploder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // label1.Text = "teste";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var url = textUrl.Text;
            var body = textBody.Text;

            textStatus.Text = url + body;

            using HttpClient client = new HttpClient();

            var content = new StringContent(body, Encoding.UTF8, "application/json");

            try {

                HttpResponseMessage response = await client.PostAsync(url, content);

      


                if (response.StatusCode == HttpStatusCode.OK)
                {

                    textStatus.Text = "ok";

                }
                else 
                {

                    textStatus.Text = "fail!";

                }
            }

            catch { 
            
            }
            



        }
    }
}
