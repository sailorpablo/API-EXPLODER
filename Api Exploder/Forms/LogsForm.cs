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
            
            DataTable tb_log = new DataTable();

            tb_log = DALapi_exploder.GetLogs();

            foreach (DataRow row in tb_log.Rows)
            {
                richTextBoxCentral.Text = richTextBoxCentral.Text + row["request"].ToString();
            }

       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBoxCentral_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
