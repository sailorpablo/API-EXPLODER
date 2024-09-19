using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Reflection;

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

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var url = textUrl.Text;
            var body = textBody.Text;

            string options = "";

            if (radioBtnSingle.Checked)
            {
                options = "single";
            }
            else if (radioBtnMultiple.Checked)
            {
                options = "multiple";
            }
            else if (radioBtnExploder.Checked)
            {
                options = "exploder";
            }


            using HttpClient client = new HttpClient();


            if (checkBox1.Checked == true)
            {
                EnviromentVariables variables = new EnviromentVariables(); //pega classe das variaves

                string patternVariable = @"\{\{\$([^}]+)\}\}"; //padrao comeca {{$ e termina }}
                
                MatchCollection matches = Regex.Matches(body, patternVariable); //palavras com esse padrao do Body

                List <string> enviromentVariablesBody = new List<string>(); //lista para jogar as strings

                foreach (Match match in matches) {

                    enviromentVariablesBody.Add(match.Groups[1].Value); //loop que adiciona na lista, as palavras encontradas

                }

                //PropertyInfo[] properties = typeof(EnviromentVariables).GetProperties(); //pega as propriedades da classe

                var properties = variables.variables.Keys;

                foreach (string enviromentVariableBody in enviromentVariablesBody) {

                    foreach (var property in properties) {

                        if (property.Equals(enviromentVariableBody, StringComparison.OrdinalIgnoreCase)) {

                            string replacer = variables.variables[property];

                            body = body.Replace(enviromentVariableBody, replacer);

                        }
                        
                    }

                }
            }

            var content = new StringContent(body, Encoding.UTF8, "application/json");


            try
            {

                HttpResponseMessage response = await client.PostAsync(url, content);

                string messageFind = "Msg";
                string resultFind = "Result";


                string responseBody = await response.Content.ReadAsStringAsync();

                int messageIndex = responseBody.IndexOf(messageFind) + 5;
                int resultIndex = responseBody.IndexOf(resultFind) - 2;









                // Reposta
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    textStatus.Text = response.StatusCode.ToString() + ", " + responseBody.Substring(messageIndex, resultIndex - messageIndex);

                }
                else
                {

                    textStatus.Text = response.StatusCode.ToString();

                }
            }

            catch
            {

                textStatus.Text = "FAIL, ERROR IN URL!";
            }




        }

        private void radioBtnMultiple_Click(object sender, EventArgs e)
        {

            textBoxMultiple.Visible = true;


        }

        private void radioBtnSingle_Click(object sender, EventArgs e)
        {

            textBoxMultiple.Visible = false;

        }

        private void radioBtnExploder_Click(object sender, EventArgs e)
        {

            textBoxMultiple.Visible = false;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
