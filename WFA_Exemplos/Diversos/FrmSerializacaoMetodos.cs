using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmSerializacaoMetodos : Form
    {
        public FrmSerializacaoMetodos()
        {
            InitializeComponent();
        }

        private DateTime dataInicial = new DateTime(2012, 05, 01, 0, 0, 0);
        private DateTime dataFinal = new DateTime(2012, 05, 10, 0, 0, 0);

        private void btnConsultarNormal_Click(object sender, EventArgs e)
        {
            //(sender as Button).Enabled = false;
            //DateTime dateTime1 = DateTime.Now;
            //DateTime dateTime2 = DateTime.Now;

            //GFO.GestaoDeFrotaOnLineWS gestaoDeFrotaOnLineWS = new GFO.GestaoDeFrotaOnLineWS();

            //gestaoDeFrotaOnLineWS.SerializacaoNormalAsync();
            //gestaoDeFrotaOnLineWS.SerializacaoNormalCompleted += delegate(object sender1, SerializacaoNormalCompletedEventArgs e1)
            //{
            //    try
            //    {
            //        MyClass myClass = e1.Result as MyClass;
            //        if (myClass != null)
            //        {
            //            dateTime2 = DateTime.Now;

            //            dataGridViewNormal.DataSource = myClass.ListaControleOperacionalDTO.ToArray();

            //            lbl_Ini_click_n.Text = dateTime1.ToString();
            //            lbl_fin_click_n.Text = dateTime2.ToString();
            //            lbl_tot_click_n.Text = dateTime2.Subtract(dateTime1).ToString();

            //            lbl_Ini_consulta_n.Text = myClass.DataIni.ToString();
            //            lbl_fin_consulta_n.Text = myClass.DataFin.ToString();
            //            lbl_tot_consulta_n.Text = myClass.DataFin.Subtract(myClass.DataIni).ToString();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(string.Concat(ex));
            //    }
            //    finally
            //    {
            //        (sender as Button).Enabled = true;
            //    }
            //};


        }

        private void btnConsultarBinaria_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = DateTime.Now;
            DateTime dateTime3 = DateTime.Now;
            DateTime dateTime4 = DateTime.Now;         
         


        }

        public T DeserializeFromBytes<T>(byte[] binData)
        {
            T retorno = default(T);
            if (binData != null || binData.Length != 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream ms = new MemoryStream(binData);
                retorno = (T)formatter.Deserialize(ms);
            }
            return retorno;
        }

        private void btnConsultarDataTable_Click(object sender, EventArgs e)
        {
            //(sender as Button).Enabled = false;

            //DateTime dateTime1 = DateTime.Now;
            //DateTime dateTime2 = DateTime.Now;

            //GFO.GestaoDeFrotaOnLineWS gestaoDeFrotaOnLineWS = new GFO.GestaoDeFrotaOnLineWS();

            //gestaoDeFrotaOnLineWS.SerializacaoNormalADOAsync();
            //gestaoDeFrotaOnLineWS.SerializacaoNormalADOCompleted += delegate(object sender1, SerializacaoNormalADOCompletedEventArgs e1)
            //{
            //    try
            //    {
            //        MyClass myClass = e1.Result as MyClass;
            //        if (myClass != null)
            //        {
            //            dateTime2 = DateTime.Now;

            //            dataGridViewDataTable.DataSource = myClass.DataTableC;

            //            lbl_Ini_click_D.Text = dateTime1.ToString();
            //            lbl_fin_click_D.Text = dateTime2.ToString();
            //            lbl_tot_click_D.Text = dateTime2.Subtract(dateTime1).ToString();

            //            lbl_Ini_consulta_D.Text = myClass.DataIni.ToString();
            //            lbl_fin_consulta_D.Text = myClass.DataFin.ToString();
            //            lbl_tot_consulta_D.Text = myClass.DataFin.Subtract(myClass.DataIni).ToString();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(string.Concat(ex));
            //    }
            //    finally
            //    {
            //        (sender as Button).Enabled = true;
            //    }
            //};
        }

        private void btnConsultarDataTableCliente_Click(object sender, EventArgs e)
        {
            //(sender as Button).Enabled = false;
            //BackgroundWorker backgroundWorker = new BackgroundWorker();

            //DateTime dateTime1 = DateTime.Now;
            //DateTime dateTime2 = DateTime.Now;

            //backgroundWorker.DoWork += delegate(object sender1, DoWorkEventArgs e1)
            //{
            //    MyClass myClass = new MyClass();

            //    StringBuilder stringBuilder = new StringBuilder();
            //    stringBuilder.Append("Select * from GFO_CONTROLEOPERACIONAL ");
            //    stringBuilder.Append("WHERE DATA_OCORRENCIA between :Ini and :Fin");
            //    stringBuilder.Append("  AND CODINTLINHA IN (:CODINTLINHA )");

            //    //OleDbConnection conexao = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=ORA11g64;User ID=COMPORTE120629;Password=COMPORTE120629;Persist Security Info=True;Unicode=True;FetchSize=500;CacheType=Memory;OSAuthent=0;PLSQLRSet=1;StmtCacheSize=10;");                                
            //    //OleDbConnection conexao = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=ORA11g64;User ID=COMPORTE120629;Password=COMPORTE120629;FetchSize=2000");
            //    //OleDbConnection conexao = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=ORA11g64;User ID=COMPORTE120629;Password=COMPORTE120629");
            //    //OleDbConnection conexao = new OleDbConnection("Provider=OraOLEDB.Oracle.1;Data Source=ORA11g64;Persist Security Info=False;User ID=COMPORTE120629;Password=COMPORTE120629;Unicode=False");
            //    //OleDbConnection conexao = new OleDbConnection("Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=COMPORTE120629;Password=COMPORTE120629;Data Source=ora11g64");

            //    myClass.DataIni = DateTime.Now;

            //    using (OleDbConnection connection = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=ORA11g64;User ID=COMPORTE120629;Password=COMPORTE120629"))
            //    {
            //        OleDbCommand command = new OleDbCommand(stringBuilder.ToString(), connection);

            //        command.Parameters.Add("Ini", OleDbType.DBDate).Value = dataInicial;
            //        command.Parameters.Add("Fin", OleDbType.DBDate).Value = dataFinal;
            //        command.Parameters.Add("CODINTLINHA", OleDbType.Integer).Value = 1102;
            //        connection.Open();

            //        OleDbDataReader reader = command.ExecuteReader();
            //        myClass.DataTableC = new DataTable();
            //        myClass.DataTableC.Columns.AddRange(
            //            reader.GetSchemaTable().Rows
            //                .OfType<DataRow>()
            //                .Select(s => new DataColumn(s["ColumnName"].ToString()))
            //                .ToArray()
            //            );

            //        //s[s.Table.Columns[0].Caption]

            //        //                    		Caption	"DataType"	string

            //        //int columnCount = reader.GetSchemaTable() FieldCount;

            //        //for (int i = 0; i < columnCount; i++)
            //        //{
            //        //    myClass.DataTableC.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
            //        //}

            //        //

            //        object[] rowData = new object[reader.FieldCount];

            //        while (reader.Read())
            //        {
            //            for (int k = 0; k < reader.FieldCount; k++)
            //                rowData[k] = reader.GetValue(k);

            //            myClass.DataTableC.Rows.Add(rowData);
            //        }


            //        //myClass.DataTableC.Load(reader);
            //        myClass.DataFin = DateTime.Now;
            //        reader.Close();


            //        e1.Result = myClass;
            //    }
            //};
            //backgroundWorker.RunWorkerCompleted += delegate(object sender1, RunWorkerCompletedEventArgs e1)
            //{
            //    MyClass myClass = e1.Result as MyClass;
            //    if (myClass != null)
            //    {
            //        dataGridView1.DataSource = myClass.DataTableC;
            //        lbl_Ini_click_D2.Text = myClass.DataIni.ToString();
            //        lbl_fin_click_D2.Text = myClass.DataFin.ToString();
            //        lbl_tot_click_D2.Text = myClass.DataFin.Subtract(myClass.DataIni).ToString();
            //    }
            //    (sender as Button).Enabled = true;

            //};
            //backgroundWorker.RunWorkerAsync();


        }

        private void FrmSerializacaoMetodos_Shown(object sender, EventArgs e)
        {
            XXX2 xxx = new XXX2();
            if (xxx == null)
            {

            }

        }

    }

    public static class ExtensionMethods
    {
        public static bool CompararOr(this System.Enum valor, params System.Enum[] valores)
        {
            return valores.Contains(valor);
        }
    }

    public abstract class XXX1
    {
        public XXX1(int teste)
        {
        }

        protected string teste { get; set; }
    }

    public partial class XXX2 : XXX1
    {
        public XXX2()
            : base(5)
        {
            base.teste = "aaaa";
        }
    }



}
