using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraGrid.Columns;
using FGlobus.Util;
using FGlobus.Util.ExtensaoObject;

namespace WFA_Workflow.SelecionaDescricao
{
    [ToolboxItem(false)]
    public partial class ColunasSelecionaDescricaoDemo : UserControl
    {
        public ColunasSelecionaDescricaoDemo()
        {
            InitializeComponent();
        }

        public ColunasSelecionaDescricaoDemo(SelecionaDescricaoBGMDemo selecionaDescricao, IWindowsFormsEditorService iWindowsFormsEditorService)
        {
            InitializeComponent();

            _selecionaDescricao = selecionaDescricao;
            _windowsFormsEditorService = iWindowsFormsEditorService;
        }

        #region Atributos

        private SelecionaDescricaoBGMDemo _selecionaDescricao;
        private IWindowsFormsEditorService _windowsFormsEditorService;
        private string _colunaSelecionada;

        #endregion

        #region Propriedades

        /// <summary>
        /// (Set/Get) Informa ou retorna a coluna selecionada
        /// </summary>
        public string ColunaSelecionada
        {
            get
            {
                return _colunaSelecionada;
            }
            set
            {
                _colunaSelecionada = value;
            }
        }

        #endregion

        private void ColunasSelecionaDescricao_Load(object sender, EventArgs e)
        {
            if (_selecionaDescricao != null && _selecionaDescricao.GridView != null)
            {
                _colunaSelecionada = _selecionaDescricao.ColunaDefault;

                // Cria lista com os itens do enum
                var listaTipoMascara = _selecionaDescricao.GridView.Columns
                    .OfType<GridColumn>()
                    .Where(w => w.Visible && w.OptionsColumn.ShowInCustomizationForm)
                    .Select((s, index) => new
                    {
                        Index = index,
                        Caption = s.Caption.NuloOuVazio()
                            ? s.FieldName
                            : s.Caption,
                        FieldName = s.FieldName
                    })
                    .ToArray();

                this.grdCtrlColunas.DataSource = listaTipoMascara;

                // Procura a coluna selecionada e posiciona na mesma
                int handle = listaTipoMascara
                    .Where(w => String.Concat(w.Caption, ';', w.FieldName) == _colunaSelecionada)
                    .FirstOrDefault()
                    .Index;

                this.grdCtrlColunas.ForceInitialize();
                this.grdVwColunas.FocusedRowHandle = handle;
            }
        }

        private void grdVwColunas_DoubleClick(object sender, EventArgs e)
        {
            object focusedRow = this.grdVwColunas.GetFocusedRow();

            _colunaSelecionada = String.Concat(
                focusedRow.RetornarValorPropriedade("Caption"), ';',
                focusedRow.RetornarValorPropriedade("FieldName"));

            _windowsFormsEditorService.CloseDropDown();
        }
    }
}
