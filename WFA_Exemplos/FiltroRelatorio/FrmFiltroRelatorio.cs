using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using FGlobus.Componentes.WinForms;
using eSentidoNavegacao = FGlobus.Componentes.WinForms.MasterFormGlobus.eSentidoNavegacao;

namespace WFA_Exemplos.FiltroRelatorio
{
    public partial class FrmFiltroRelatorio : Form
    {
        public FrmFiltroRelatorio()
        {
            InitializeComponent();
        }

        private void filtroRelatorioBGM1_Load(object sender, EventArgs e) 
        {
        }

        //List<MyClass> listaMyClass = new List<MyClass>();

        //private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        //{
        //    if (e == null)
        //    {

        //    }

        //}

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{

        //    //listaMyClass.Remove(gridView1.GetFocusedRow() as MyClass);
        //    //gridView1.RefreshData();
        //    //dataTable1.Rows.Remove(gridView1.GetDataRow(gridView1.FocusedRowHandle));
        //}



        //private void gridView1_RowCountChanged(object sender, EventArgs e)
        //{

        //    if (e == null)
        //    {

        //    }
        //}


        //private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        //{
        //    if (e==null)
        //    {

        //    }
        //}

        //private void dataTable1_RowDeleting(object sender, DataRowChangeEventArgs e)
        //{
        //    MessageBox.Show("dataTable1_RowDeleting");
        //}

        //private void dataTable1_TableNewRow(object sender, DataTableNewRowEventArgs e)
        //{
        //    MessageBox.Show("dataTable1_TableNewRow");
        //}

        //private void simpleButton2_Click(object sender, EventArgs e)
        //{
        //    DataRow rataRow = dataTable1.NewRow();
        //    rataRow["Column1"] = 1;
        //    rataRow["Column2"] = "aaaaaaaaaaaaaaaaaa";

        //    dataTable1.Rows.Add(rataRow);
        //}

        //private void dataTable1_RowChanging(object sender, DataRowChangeEventArgs e)
        //{
        //    MessageBox.Show("dataTable1_RowChanging");
        //}

        private eSentidoNavegacao _sentidoNavegacao = eSentidoNavegacao.None;
        private Control _primeiroControle;
        private bool _workflow = false;
        private bool _habilitarKeyPress = true;
        private bool _sentidoNavegacaoIgualNone = false;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (this._habilitarKeyPress)
            {
                bool enter = ((int)e.KeyChar).Equals((int)Keys.Enter);
                bool esc = ((int)e.KeyChar).Equals((int)Keys.Escape);

                if (enter || esc)
                    this.ProcessTabKey(enter);
            }
        }

        /// <summary>
        /// Sobreposição do método para redefinir a variavel "_sentidoNavegacao".
        /// </summary>
        /// <param name="e">Objeto do tipo KeyEventArgs.</param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            _sentidoNavegacao = eSentidoNavegacao.None;
            base.OnKeyDown(e);
        }

        /// <summary>
        /// Sobreposição do método para redefinir a variavel "_sentidoNavegacao".
        /// </summary>
        /// <param name="e">Objeto do tipo KeyEventArgs.</param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            _sentidoNavegacao = eSentidoNavegacao.None;
            base.OnKeyUp(e);
        }

        /// <summary>
        /// Sobreposição do método para redefinir a variavel "_sentidoNavegacao".
        /// </summary>
        /// <param name="forward">Bool.</param>
        protected override bool ProcessTabKey(bool forward)
        {
            _sentidoNavegacao = _sentidoNavegacaoIgualNone
                ? eSentidoNavegacao.None
                : forward
                    ? eSentidoNavegacao.Fore
                    : eSentidoNavegacao.Back;

            return base.ProcessTabKey(forward);
        }

    }

    //class MyClass
    //{
    //    public int cod { get; set; }
    //    public string desc { get; set; }
    //}

    //public partial class ListaFiltrosBGM : Component
    //{

    //    private FiltroBGMCollection _colunas;


    //    public FiltroBGMCollection Colunas
    //    {
    //        get
    //        {
    //            if (_colunas == null)
    //                _colunas = new FiltroBGMCollection();

    //            return _colunas;
    //        }
    //    }

    //    public class FiltroBGMCollection : CollectionBase
    //    {
    //        public FiltroBGMCollection() { }

    //        //public FiltroBGMCollection(AssociacaoBGM owner)
    //        //{
    //        //}

    //        public void AddRange(FiltroBGM[] colunaAutorizaBGM)
    //        {
    //            this.InnerList.AddRange(colunaAutorizaBGM);
    //        }

    //        public FiltroBGM this[int index]
    //        {
    //            get
    //            {
    //                return this.InnerList[index] as FiltroBGM;
    //            }
    //            set
    //            {
    //                this.InnerList[index] = value;
    //            }
    //        }

    //    }

    //    public class FiltroBGM
    //    {
    //        public FiltroBGM() { }

    //        private Control _componenteInicial;
    //        private Control _componenteFinal;
    //        private Control _componente;
    //        private string _nomePropriedade;

    //        private string[] _listaAleatoria;

    //        public Control ComponenteInicial
    //        {
    //            get { return _componenteInicial; }
    //            set { _componenteInicial = value; }
    //        }

    //        public Control ComponenteFinal
    //        {
    //            get { return _componenteFinal; }
    //            set { _componenteFinal = value; }
    //        }

    //        public Control Componente
    //        {
    //            get { return _componente; }
    //            set { _componente = value; }
    //        }

    //        public string[] ListaAleatoria
    //        {
    //            get { return _listaAleatoria; }
    //            set { _listaAleatoria = value; }
    //        }

    //        public string NomePropriedade
    //        {
    //            get { return _nomePropriedade; }
    //            set { _nomePropriedade = value; }
    //        }
    //    }
    //}

}
