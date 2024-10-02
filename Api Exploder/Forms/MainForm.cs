using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Reflection;
using Api_Exploder.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Policy;
using System.Linq;

namespace Api_Exploder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private async void SendRequestApi(string body, string url)
        {

            using HttpClient client = new HttpClient();


            if (checkBox1.Checked == true)
            {
                EnviromentVariables variables = new EnviromentVariables(); //pega classe das variaves

                string patternVariable = @"\{\{\$([^}]+)\}\}"; //padrao comeca {{$ e termina }}

                MatchCollection matches = Regex.Matches(body, patternVariable); //palavras com esse padrao do Body

                List<string> enviromentVariablesBody = new List<string>(); //lista para jogar as strings

                foreach (Match match in matches)
                {

                    enviromentVariablesBody.Add(match.Groups[1].Value); //loop que adiciona na lista, as palavras encontradas

                }

                //PropertyInfo[] properties = typeof(EnviromentVariables).GetProperties(); //pega as propriedades da classe

                var properties = variables.variables.Keys;

                foreach (string enviromentVariableBody in enviromentVariablesBody)
                {

                    foreach (var property in properties)
                    {

                        if (property.Equals(enviromentVariableBody, StringComparison.OrdinalIgnoreCase))
                        {

                            string replacer = variables.variables[property];
                            string replaced = "{{$" + enviromentVariableBody + "}}";

                            body = body.Replace(replaced, replacer);
                        }
                    }

                }
            }

            var content = new StringContent(body, Encoding.UTF8, "application/json");


            try
            {

                HttpResponseMessage response = await client.PostAsync(url, content);

                string messageFind = "{";
                string resultFind = "}";


                string responseBody = await response.Content.ReadAsStringAsync();

                int messageIndex = responseBody.IndexOf(messageFind);
                int resultIndex = responseBody.IndexOf(resultFind);


                // Reposta
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    textStatus.Text = response.StatusCode.ToString() + ",  " + responseBody.Substring(messageIndex, resultIndex - messageIndex);

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

        private async void button1_Click(object sender, EventArgs e)
        {
            var url = textUrl.Text;
            var body = textBody.Text;

            string options = "";

            if (radioBtnSingle.Checked)
            {
                options = "single";

                SendRequestApi(body, url);
            }
            else if (radioBtnMultiple.Checked)
            {
                options = "multiple";

                int multipleCount = Convert.ToInt32(textBoxMultiple.Text);

                for (int i = 0; i < multipleCount; i++)
                {
                    SendRequestApi(body, url);
                }




            }
            else if (radioBtnExploder.Checked)
            {
                options = "exploder";
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

        private void button2_Click(object sender, EventArgs e)
        {
            EnvVarForm envVarForm = new EnvVarForm();

            envVarForm.Show();
        }

        private void textBoxMultiple_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string patternVariable = @"\{\{\$([^}]+)\}\}";

            MatchCollection matches = Regex.Matches(textBody.Text, patternVariable);

            if (checkBox1.Checked == true)
            {
                foreach (Match match in matches)
                {


                    int replacerLength = match.Length;
                    int replacerIndex = match.Index;

                    textBody.Select(replacerIndex, replacerLength);
                    textBody.SelectionFont = new Font(textBody.Font, FontStyle.Bold | FontStyle.Italic);

                    textBody.Select(replacerIndex + replacerLength, 0);
                    textBody.SelectionFont = new Font(textBody.Font, FontStyle.Regular);

                    /*Verifcar, nao esta 100 por cento ainda, depois da variavel o prox caracter fica em italico*/

                }
            }

            if (checkBox1.Checked == false)
            {
                textBody.SelectAll();
                textBody.SelectionFont = new Font(textBody.Font, FontStyle.Regular);
            }



        }

        private void textBody_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // Salva a posição atual do cursor 
                int cursorPositionInit = textBody.SelectionStart;

                // Desabilita temporariamente o evento TextChanged para evitar loops infinitos
                textBody.TextChanged -= textBody_TextChanged;

                // Define um padrão de regex para encontrar a delcaracao de variaveis {{$ e }}
                string patternOpen = @"\{\{\$";
                string patternClose = @"\}\}";
                var matchesPatterOpen = Regex.Matches(textBody.Text, patternOpen);
                var matchesPatterClose = Regex.Matches(textBody.Text, patternClose);

                // Limpa toda a formatação pre-existente
                textBody.SelectAll();
                textBody.Font = new Font(textBody.Font, FontStyle.Regular);

                // Se tem declaracao aberta {{$ sem }} transforma a partir do cursor, tudo em italico + bold
                if (matchesPatterOpen.Count > matchesPatterClose.Count)
                {
                    int lengthTextRemaining = textBody.Text.Length - cursorPositionInit;

                    textBody.Select(cursorPositionInit - 3, cursorPositionInit);
                    textBody.SelectionFont = new Font(textBody.Font, FontStyle.Bold | FontStyle.Italic);

                    textBody.Select(cursorPositionInit, lengthTextRemaining);
                    textBody.SelectionFont = new Font(textBody.Font, FontStyle.Bold | FontStyle.Italic);
                }
                // Se todas as declaracoes tem abertura e fechamento, formata tudo a partir do cursor 
                else if (matchesPatterOpen.Count == matchesPatterClose.Count)

                {

                    int lengthTextRemaining = textBody.Text.Length - cursorPositionInit;

                    textBody.Select(cursorPositionInit, lengthTextRemaining);
                    textBody.SelectionFont = new Font(textBody.Font, FontStyle.Regular);
                };



                // Restaura a posição do cursor
                textBody.SelectionStart = cursorPositionInit;
                textBody.SelectionLength = 0;

                // Reanexa o evento TextChanged
                textBody.TextChanged += textBody_TextChanged;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogsForm logsForm = new LogsForm();

            logsForm.Show();
        }
    }
}
