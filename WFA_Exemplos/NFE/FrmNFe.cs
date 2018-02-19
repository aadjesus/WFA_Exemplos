using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WFA_Workflow.NFE
{
    public partial class FrmNFe : Form
    {
        public FrmNFe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //    //XmlDocument document = new XmlDocument();
                //    //document.Load(@"c:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Exemplos\NFE\leiauteNFe_v2.00.xsd");

                //    DataSet aa = new DataSet();
                //    aa.ReadXmlSchema(@"c:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Exemplos\NFE\leiauteNFe_v2.00.xsd");

                //    //aa.ReadXml(new XmlNodeReader(document));
                //    gridControl1.DataSource = aa;
                //    aa.WriteXml(@"c:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Exemplos\NFE\leiauteNFe_v2.00.xsd");

                //    XmlDataDocument xml = new XmlDataDocument();


                //    //gridControl1.DataMember ="TNFe"

                //    //aa.Tables
                //    //    .OfType<DataTable>()
                //    //    .FirstOrDefault()
                //    //    .TableName
                //    ;
                //
                //XmlDataDocument xmlData = new XmlDataDocument();
                //XmlWriterSettings writerSett = new XmlWriterSettings();
                //writerSett.Indent = true;
                //writerSett.CheckCharacters = true;
                //writerSett.Encoding = Encoding.UTF8;
                //writerSett.ConformanceLevel = ConformanceLevel.Auto;
                ////XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Exemplos\NFE\XMLFile1.xml", writerSett);

                //xmlData.DataSet.ReadXmlSchema(@"C:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Exemplos\NFE\leiauteNFe_v2.00.xsd");

                //DataSet aa = new DataSet();
                //aa.ReadXml(new XmlNodeReader(xmlData));

                //gridControl1.DataSource = aa;
                //gridControl1.DataMember = "ide";
                SalvarNFE();



            }
            catch (Exception ex)
            {
                FGlobus.Componentes.WinForms.Mensagem.Erro(ex);
            }
        }

        public void SalvarNFE()
        {
           

        }

        private void Teste_NomeMetodo()
        {
            Dictionary<string, bool> teste = new Dictionary<string, bool>();

            teste.Add("1", false);
            teste.Add("1", false);
            teste.Add("1", false);

            if (teste["1"] )
            {
                
            }
        }

        class NotafiscalEletronica
        {
            //private int ID_NFE { get; set; }
            private int Empresa { get; set; }
            private int Filial { get; set; }
            private int Fase { get; set; }
            private int Numero { get; set; }
            private int Serie { get; set; }
            private string ChaveDeAcesso { get; set; }//VARCHAR2(44)      
            private DateTime DataEmissao { get; set; }//DATE              
            private string Sistema { get; set; }//VARCHAR2(3)       
            private string Usuario { get; set; }//VARCHAR2(15)      
            //private DateTime DATAGEROU { get; set; }//DATE              
            //private LONG CONTEUDONF { get; set; }//LONG              
            private string Protocolo { get; set; }//VARCHAR2(50)      
            private int DataProtocolo { get; set; }//VARCHAR2(20)      

            private string Status { get; set; }//VARCHAR2(1)       
            private int Recibo { get; set; }//VARCHAR2(20)      
            private string MensagemRecibo { get; set; }//VARCHAR2(500)     

            //private int CODINTNF_BGMNF { get; set; }
            //private int CODINTNF_TRR { get; set; }
            //private int CODINTNFAVUL { get; set; }
            //private int NUMERONF_MANNF { get; set; }
            //private int CODINTNF_ESFNF { get; set; }
            //private int CODINTNF_TTM { get; set; }
            private int InformacoesAdicionaisFisco { get; set; }//VARCHAR2(2000)    
        }

        class NotafiscalEletronicaConteudo
        {

        }

    }
}
