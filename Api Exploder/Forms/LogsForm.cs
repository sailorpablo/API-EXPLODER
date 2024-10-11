using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_Exploder.Forms
{
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();




        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRecentReq_Click(object sender, EventArgs e)

        {
            DataTable tb_log = new DataTable(); //cria uma instancia do objeto DataTable

            tb_log = DALapi_exploder.GetLogs(); //instancia criada recebe select com todas as requisições


            foreach (DataRow row in tb_log.Rows) // pra cada linha do select, insere no texto princial os valores daquela linha
            {
                richTextBoxCentral.Text = richTextBoxCentral.Text + row["id"].ToString() + row["request"].ToString() + row["dt_request"].ToString() ;
            }
        }
    }
}
