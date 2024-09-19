using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_Exploder.Forms
{
    public partial class EnvVarForm : Form
    {
        public EnvVarForm()
        {
            InitializeComponent();
            EnvVarFormLoad();


        }
        private void EnvVarFormLoad()
        {
            EnviromentVariables variables = new EnviromentVariables();

            var properties = variables.variables.Keys;

            foreach (var property in properties)
            {

                listBoxVariable.Items.Add("{{$" + property + "}}");   

            }



        }
    }
}
