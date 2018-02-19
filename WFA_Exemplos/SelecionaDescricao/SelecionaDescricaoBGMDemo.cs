using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using FGlobus.Componentes.WinForms;
using FGlobus.Util;
using FGlobus.Util.ExtensaoObject;
using WFA_Workflow.SelecionaDescricao;

namespace WFA_Workflow
{
    public partial class SelecionaDescricaoBGMDemo : UserControl
    {
        public SelecionaDescricaoBGMDemo()
        {
            InitializeComponent();
        }

        private ButtonEditBGM _buttonEditBGM;
        private string _colunaDefault = null;
        private GridView gridView;

        internal GridView GridView
        {
            get
            {
                if (gridView == null)
                    gridView = this.RetornarGridViewDoBrowseDePesquisa();

                return gridView;
            }
        }

        [DefaultValue(null)]
        public ButtonEditBGM ButtonEditBGM
        {
            get { return _buttonEditBGM; }
            set
            {
                _buttonEditBGM = value;
            }
        }

        [EditorAttribute(typeof(UITypeEditorBGMRodotecSelecionaColunaBGM), typeof(UITypeEditor))]
        [DefaultValue(null)]
        public string ColunaDefault
        {
            get
            {
                return _colunaDefault;
            }
            set
            {
                _colunaDefault = value;
            }
        }

        internal void AtualizarDadosComAColuna()
        {
            string[] valores = _colunaDefault.Split(';');
            if (valores.NuloOuVazio())
            {
                if (!DesignMode && this.GridView != null)
                {
                    GridColumn gridColumn = this.GridView.Columns
                        .OfType<GridColumn>()
                        .FirstOrDefault();
                    _colunaDefault = String.Concat(gridColumn.Caption, ';', gridColumn.FieldName);
                }
            }

            if (!valores.NuloOuVazio())
                this.lblCtrlColunaDefault.Text = valores[0];

            this.HabilitarControle();
        }

        private GridView RetornarGridViewDoBrowseDePesquisa()
        {
            GridView retorno = null;

            if (_buttonEditBGM != null &&
                _buttonEditBGM.ExecutarPesquisa &&
                !_buttonEditBGM.BrowseDePesquisa.NuloOuVazio())
            {
                String diretorioDoWPF = Util.RetornarDiretorioDoWPF(eTipoArquivoWPF.DLL, "Pesquisa");

                object masterPanelBrowseDePesquisa = Util.RetornarClasseDoAssemblyName<object>(
                        _buttonEditBGM.BrowseDePesquisa,
                        diretorioBase: diretorioDoWPF);

                retorno = masterPanelBrowseDePesquisa
                    .RetornarValorPropriedade("BrowseDePesquisa")
                    .RetornarValorPropriedade("Grid") as GridView;
            }

            return retorno;
        }

        private void SelecionaColunaBGM_Load(object sender, EventArgs e)
        {
            this.AtualizarDadosComAColuna();

            _buttonEditBGM.Confirmar += new EventHandler(buttonEditBGM_Confirmar);
            _buttonEditBGM.Validated += new EventHandler(buttonEditBGM_Validated);
            _buttonEditBGM.EditValueChanged += new EventHandler(buttonEditBGM_EditValueChanged);
        }

        private void buttonEditBGM_Validated(object sender, EventArgs e)
        {
            this.Atualizar(_buttonEditBGM.LinhaSelecionada);
        }

        private void buttonEditBGM_EditValueChanged(object sender, EventArgs e)
        {
            if (_buttonEditBGM != null && _buttonEditBGM.Text.NuloOuVazio())
                this.Limpar();
        }

        private void buttonEditBGM_Confirmar(object sender, EventArgs e)
        {
            this.Atualizar(_buttonEditBGM.LinhaSelecionada);
        }

        private void grdLkUpEdtColunaDefault_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = this.grdLkUpEdtColunaDefault.Properties.View.GetFocusedRow() as DataRowView;
            if (dataRowView != null)
                this.lblCtrlColunaDefault.Text = dataRowView.Row[this.grdLkUpEdtColunaDefault.Properties.ValueMember].ToString();
        }

        private void Atualizar(object valor)
        {
            if (this.GridView != null)
            {
                this.Limpar();

                object primeiraDataRow = null;
                this.GridView.Columns
                    .OfType<GridColumn>()
                    .Where(w => w.Visible && w.OptionsColumn.ShowInCustomizationForm)
                    .Aggregate(this.dtTblSelecionaColuna, (retorno, item) =>
                    {
                        DataRow dataRow = retorno.NewRow();
                        string colCaption = item.RetornarName(p => p.Caption);
                        string colFieldName = item.RetornarName(p => p.FieldName);

                        dataRow[colCaption] = item.Caption.NuloOuVazio()
                            ? item.FieldName
                            : item.Caption;
                        dataRow[colFieldName] = valor.RetornarValorPropriedade(item.FieldName);

                        primeiraDataRow = dataRow[colFieldName];

                        retorno.Rows.Add(dataRow);
                        return retorno;
                    });

                this.grdLkUpEdtColunaDefault.Properties.DataSource = this.dtTblSelecionaColuna;

                string[] valores = _colunaDefault.Split(';');
                this.grdLkUpEdtColunaDefault.EditValue = valores.NuloOuVazio()
                    ? primeiraDataRow
                    : valores[1];
            }

            this.HabilitarControle();
        }

        private void HabilitarControle()
        {
            this.grdLkUpEdtColunaDefault.Enabled = this.dtTblSelecionaColuna.Rows.Count > 0;
        }

        public void Limpar()
        {
            this.dtTblSelecionaColuna.Rows.Clear();
            this.HabilitarControle();
        }
    }

    internal class UITypeEditorBGMRodotecSelecionaColunaBGM : UITypeEditor
    {
        private IWindowsFormsEditorService _windowsFormsEditorService;

        /// <summary>
        /// Retorna o tipo de execução do evento
        /// </summary>
        /// <param name="controle">Controle que chamou o editor</param>
        /// <returns>UITypeEditorEditStyle</returns>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext controle)
        {
            if (controle != null)
                return UITypeEditorEditStyle.DropDown;

            return base.GetEditStyle(controle);
        }

        public override object EditValue(ITypeDescriptorContext contexto, IServiceProvider provider, object valor)
        {
            if (contexto != null && provider != null)
                _windowsFormsEditorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

            if (_windowsFormsEditorService != null)
            {
                return EditValueMascaras(contexto, valor);
            }

            return valor;
        }

        private object EditValueMascaras(ITypeDescriptorContext contexto, object valor)
        {
            ColunasSelecionaDescricaoDemo selecionaDescricao = new ColunasSelecionaDescricaoDemo(contexto.Instance as SelecionaDescricaoBGMDemo, _windowsFormsEditorService);
            _windowsFormsEditorService.DropDownControl(selecionaDescricao);

            return selecionaDescricao.ColunaSelecionada;
        }

        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            if (context.Instance is SelecionaDescricaoBGMDemo)
                (context.Instance as SelecionaDescricaoBGMDemo).AtualizarDadosComAColuna();

            return base.GetPaintValueSupported(context);
        }
    }
}
