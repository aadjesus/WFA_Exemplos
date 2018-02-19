using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Exemplos.ConectaNoBanco
{
    public partial class FrmConectaNoBanco : Form
    {
        public FrmConectaNoBanco()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Select * from GFO_CONTROLEOPERACIONAL ");
            stringBuilder.Append("WHERE DATA_OCORRENCIA between :Ini and :Fin");
            stringBuilder.Append("  AND CODINTLINHA IN (:CODINTLINHA )");

            //OleDbConnection conexao = new OleDbConnection(
            //    String.Concat("Provider=OraOLEDB.Oracle.1;Data Source=", textBox1.Text, ";Persist Security Info=True;User ID=", textBox2.Text, ";Password=", textBox3.Text, ";Unicode=True"));

            using (OleDbConnection connection = new OleDbConnection(
                String.Concat("Provider=OraOLEDB.Oracle;Data Source=", textBox1.Text, ";User ID=", textBox2.Text, ";Password=", textBox3.Text, "")))
            {
                OleDbCommand command = new OleDbCommand(textBox4.Text, connection);
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
            }

        }
    }
}
