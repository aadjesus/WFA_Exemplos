using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTab.Buttons;
using FGlobus.Util;
using FGlobus.Util.ExtensaoObject;
using FGlobus.Util.ExtensaoString;

namespace ClassLibrary1
{
    /// <summary>
    /// Componente para controlar lista de itens disponíveis e autorizados.
    /// </summary>
    //[ToolboxItem(true)]
    //[Description("Componente para controlar lista de itens disponíveis e associados.")]
    //[ToolboxBitmap(typeof(AutorizaGridBGM), "AutorizaGrids.AutorizaGridBGM.ico")]
    //[Docking(DockingBehavior.Ask)]
    //[Designer(typeof(ControlaComponenteDesigner))]
    //[PropertyTab(typeof(BotaoBrowserPropriedades), PropertyTabScope.Document)]
    //[DefaultProperty("LayOut")]
    ////[DefaultEvent("Click")]
    //[InformacoesComponente("Alessandro Augusto", "1.0.0")]
    public partial class AssociacaoBGMDemo : UserControl
    {
        #region Construtor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public AssociacaoBGMDemo()
        {
            InitializeComponent();

            //MessageBox.Show(this.RunTime().ToString());
        }

        #endregion

        #region Atributos

        /// <summary>
        /// Enum para controlar layout
        /// </summary>
        public enum eLayOut
        {
            /// <summary>
            /// Vertical
            /// </summary>
            Vertical,
            /// <summary>
            /// Horizontal
            /// </summary>
            Horizontal,
            /// <summary>
            /// Abas
            /// </summary>
            Abas
        }

        private eLayOut _layOut;
        private ColunaAutorizaBGMCollection _colunas = new ColunaAutorizaBGMCollection();
        private string _titulo;
        private bool _ordenacaoAutomatica = true;
        private GridControl _gridControlDisponiveis;
        private GridControl _gridControlAssociados;
        private List<object> _dataTableDisponiveis = new List<object>();
        private List<object> _dataTableAssociados = new List<object>();
        private IEnumerable<object> _dataTableDisponiveisAtual;
        private IEnumerable<object> _dataTableAssociadosAtual;
        private bool _habilitaOuDesabilitarBotoes = true;
        private int _qtdeMaxPermitido = -1;
        private GridHitInfo _gridHitInfo = null;

        private const string TODOS = "TODOS";

        #endregion

        #region Propriedades

        /// <summary>
        /// (Set/Get) Informa ou retorna o layout.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna o layout.\nNome: LayOut")]
        [DisplayName("1) LayOut")]
        [DefaultValue(eLayOut.Vertical)]
        [RefreshProperties(RefreshProperties.All)]
        public eLayOut LayOut
        {
            get
            {
                this.pnlCtrlDisponiveis.Dock = DockStyle.Fill;
                this.pnlCtrlAssociados.Dock = DockStyle.Fill;

                return _layOut;
            }
            set
            {
                _layOut = value;
                this.AtualizarLayOut();
            }
        }

        /// <summary>
        /// (Set/Get) Informa ou retorna o titulo.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna o titulo.\nNome: titulo")]
        [DisplayName("2) Titulo")]
        [DefaultValue(null)]
        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;
                this.grpCtrlAutorizaGrid.Text = _titulo;
            }
        }

        /// <summary>
        /// (Get) Retorna as colunas.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Retorna as colunas.\nNome: Colunas")]
        [DisplayName("3) Colunas")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorAttribute(typeof(CustomCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [RefreshProperties(RefreshProperties.All)]
        public ColunaAutorizaBGMCollection Colunas
        {
            get
            {
                return _colunas;
            }
        }

        /// <summary>
        /// (Set/Get) Informa ou retorna a ordenação automática.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna a ordenação automática.\nNome: OrdenacaoAutomatica")]
        [DisplayName("4) Ordenação automática")]
        [DefaultValue(true)]
        public bool OrdenacaoAutomatica
        {
            get { return _ordenacaoAutomatica; }
            set
            {
                if (_ordenacaoAutomatica != value)
                {
                    _ordenacaoAutomatica = value;
                    this.MostrarBotoesOrdenacao();
                }
            }
        }

        /// <summary>
        /// (Set/Get) Informa ou retorna a quantidade máxima permitida para associação.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna a quantidade máxima permitida para associação.\nNome: QtdeMaxPermitido")]
        [DisplayName("5) Quantidade máxima permitida para associação")]
        [DefaultValue(-1)]
        public int QtdeMaxPermitido
        {
            get { return _qtdeMaxPermitido; }
            set { _qtdeMaxPermitido = value; }
        }

        #endregion

        #region Override

        /// <summary>
        /// Sobreposição do método para identificar quando for precionado as teclas
        /// <para> Ctrl + A = Adiciona um.</para>
        /// <para> Ctrl + T = Adiciona todos.</para>
        /// <para> Ctrl + R = Revoga um.</para>
        /// <para> Ctrl + V = Revoga todos.</para>
        /// </summary>
        /// <param name="msg">Mensagem do S.O.</param>
        /// <param name="keyData">Tecla</param>
        /// <returns>bool</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            ButtonEdit buttonEdit = null;
            bool todos = false;
            switch (keyData)
            {
                case Keys.Control | Keys.A:
                case Keys.Control | Keys.T:
                    buttonEdit = this.btnEdtDisponiveis;
                    todos = keyData == (Keys.Control | Keys.T);
                    break;
                case Keys.Control | Keys.R:
                case Keys.Control | Keys.V:
                    buttonEdit = this.btnEdtAssociados;
                    todos = keyData == (Keys.Control | Keys.V);
                    break;
            }

            if (buttonEdit != null)
            {
                EditorButton editorButton = buttonEdit.Properties.Buttons
                    .OfType<EditorButton>()
                    .Where(w => w.Enabled &&
                                w.Kind == ButtonPredefines.Glyph &&
                                (todos
                                    ? w.Tag.Contido(AssociacaoBGMDemo.TODOS)
                                    : !w.Tag.Contido(AssociacaoBGMDemo.TODOS)))
                    .FirstOrDefault();

                if (editorButton != null)
                    buttonEdit.PerformClick(editorButton);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Metodos controle

        private void xtrTbCtrlAutorizaGrid_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            IEnumerable<EditorButton> listaBotoes = (this.xtrTbCtrlAbas.SelectedTabPage == this.xtrTbPgDisponiveis
                    ? this.btnEdtDisponiveis
                    : this.btnEdtAssociados).Properties.Buttons
                .OfType<EditorButton>();

            this.xtrTbCtrlAbas.CustomHeaderButtons.Clear();
            this.xtrTbCtrlAbas.CustomHeaderButtons.AddRange(listaBotoes
                .Select(s => new CustomHeaderButton()
                {
                    Kind = ButtonPredefines.Glyph,
                    Tag = s.Tag,
                    SuperTip = s.SuperTip,
                    Enabled = s.Enabled,
                    Image = s.Image,
                    Shortcut = s.Shortcut
                })
                .ToArray());

        }

        private void AutorizaGridBGM_Load(object sender, EventArgs e)
        {
            this.AtualizarLayOut();

            if (DesignMode)
                this.AdicionarButtonColuna();
            else
                this.CriarGridControl();

            this.HabilitarBotoes();
        }

        private void botoesAssociaERevoga_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridControl gridControlOrigem = this.RetornarGridDoButtonEdit(sender as ButtonEdit);
            GridView gridView = this.RetornarGridView(gridControlOrigem);

            if (gridView.RowCount > 0)
            {
                GridControl gridControlDestino = gridControlOrigem == _gridControlDisponiveis
                    ? _gridControlAssociados
                    : _gridControlDisponiveis;

                if (!gridControlOrigem.Focused)
                {
                    gridView.Focus();
                    if (gridView.GetSelectedRows().NuloOuVazio())
                        gridView.MoveFirst();
                }

                if (e != null && e.Button.Tag.Contido(AssociacaoBGMDemo.TODOS))
                    gridView.SelectAll();

                //  _dataTableDisponiveisAtual = (gridControlOrigem.DataSource as DataTable).Copy();
                //  _dataTableAssociadosAtual = (gridControlDestino.DataSource as DataTable).Copy();

                if (_dataTableAssociados == null)
                    _dataTableAssociados = new List<object>();

                if (_dataTableDisponiveis == null)
                    _dataTableDisponiveis = new List<object>();

                List<object> listaOrigem = gridControlOrigem == _gridControlDisponiveis
                    ? _dataTableDisponiveis
                    : _dataTableAssociados;
                List<object> listaDestino = gridControlOrigem == _gridControlDisponiveis
                    ? _dataTableAssociados
                    : _dataTableDisponiveis;

                List<object> listaAtual = new List<object>();
                gridView.GetSelectedRows()
                    .ToList()
                    .ForEach(f =>
                    {
                        object dataRow = gridView.GetRow(f);
                        listaDestino.Add(dataRow);
                        listaAtual.Add(dataRow);
                    });

                listaAtual
                    .ForEach(f => listaOrigem.Remove(f));

                _gridControlDisponiveis.DataSource = _dataTableDisponiveis;
                _gridControlAssociados.DataSource = _dataTableAssociados;
                _gridControlDisponiveis.RefreshDataSource();
                _gridControlAssociados.RefreshDataSource();

                gridView.Focus();
                if (gridView.RowCount > 1)
                {
                    gridView.MoveNext();
                }
                else
                    gridView.MoveFirst();
            }

            this.HabilitarBotoes();
        }

        private void btnEdtOpcoes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Undo)
            {
                _dataTableDisponiveis = _dataTableDisponiveisAtual.ToList();
                _dataTableAssociados = _dataTableAssociadosAtual.ToList();

                _gridControlDisponiveis.DataSource = _dataTableDisponiveis;
                _gridControlAssociados.DataSource = _dataTableAssociados;

                _dataTableDisponiveisAtual = null;
                _dataTableAssociadosAtual = null;

                this.HabilitarBotoes();
            }
            else
            {
                Enum.TryParse(e.Button.Tag.ToString(), out _layOut);
                this.HabilitarBotoes();
                this.AtualizarLayOut();
            }
        }

        private void btnEdtMover_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.MoverLinha(e.Button.Kind);
        }

        #endregion

        #region Metodos

        private GridControl RetornarGridDoButtonEdit(ButtonEdit buttonEdit)
        {
            GridControl gridControlOrigem = buttonEdit.Parent.Parent.Controls
                .OfType<GridControl>()
                .FirstOrDefault();

            return gridControlOrigem;
        }

        private void MostrarBotoesOrdenacao()
        {
            this.btnEdtMover.Visible = !_ordenacaoAutomatica;
            this.HabilitarBotoesMover();
        }

        private void AtualizarLayOut()
        {
            this.xtrTbCtrlAbas.Dock = DockStyle.Fill;
            this.spltCtnrCtrlAutorizaGrid.Dock = DockStyle.Fill;

            this.xtrTbCtrlAbas.Visible = _layOut.Equals(eLayOut.Abas);
            this.spltCtnrCtrlAutorizaGrid.Visible = !this.xtrTbCtrlAbas.Visible;

            this.btnEdtDisponiveis.Visible = this.spltCtnrCtrlAutorizaGrid.Visible;
            this.btnEdtAssociados.Visible = this.spltCtnrCtrlAutorizaGrid.Visible;
            int paddingRightBottom = 3;
            if (_layOut.Equals(eLayOut.Abas))
            {
                this.xtrTbCtrlAbas.SelectedTabPage = this.xtrTbPgAssociados;
                this.xtrTbCtrlAbas.SelectedTabPage = this.xtrTbPgDisponiveis;

                this.spltCtnrCtrlAutorizaGrid.Panel1.Controls.Remove(this.pnlCtrlDisponiveis);
                this.spltCtnrCtrlAutorizaGrid.Panel2.Controls.Remove(this.pnlCtrlAssociados);
                this.xtrTbPgDisponiveis.Controls.Add(this.pnlCtrlDisponiveis);
                this.xtrTbPgAssociados.Controls.Add(this.pnlCtrlAssociados);
                paddingRightBottom = 1;
            }
            else
            {
                this.xtrTbPgDisponiveis.Controls.Remove(this.pnlCtrlDisponiveis);
                this.xtrTbPgDisponiveis.Controls.Remove(this.pnlCtrlAssociados);

                this.spltCtnrCtrlAutorizaGrid.Panel1.Controls.Add(this.pnlCtrlDisponiveis);
                this.spltCtnrCtrlAutorizaGrid.Panel2.Controls.Add(this.pnlCtrlAssociados);
                this.spltCtnrCtrlAutorizaGrid.Visible = true;

                this.spltCtnrCtrlAutorizaGrid.Horizontal = _layOut.Equals(eLayOut.Vertical);
            }

            if (String.IsNullOrWhiteSpace(_titulo))
                this.Titulo = String.Concat("[", this.Name, "]");

            this.grpCtrlAutorizaGrid.Padding = new Padding(3, 3, paddingRightBottom, paddingRightBottom);
            this.pnlCtrlDisponiveis.Dock = DockStyle.Fill;
            this.pnlCtrlAssociados.Dock = DockStyle.Fill;

            this.PosicionarSplitterPosition();
            this.HabilitarBotoesLayout();
            this.MostrarBotoesOrdenacao();
        }

        private void PosicionarSplitterPosition()
        {
            if (this.spltCtnrCtrlAutorizaGrid.Visible)
                this.spltCtnrCtrlAutorizaGrid.SplitterPosition = (_layOut.Equals(eLayOut.Vertical)
                    ? this.spltCtnrCtrlAutorizaGrid.Width
                    : this.spltCtnrCtrlAutorizaGrid.Height) / 2;
        }

        private void CriarColunas(PanelControl panelControl, GridControl gridControl, GridView gridView)
        {
            if (_colunas != null && _colunas.Count > 0)
            {
                gridView.Columns.AddRange(_colunas
                    .OfType<ColunaAutorizaBGM>()
                    .Aggregate(new List<GridColumn>(), (retorno, item) =>
                    {
                        GridColumn gridColumnItem = new GridColumn()
                        {
                            Caption = item.Caption,
                            FieldName = item.FieldName,
                            Visible = true,
                            VisibleIndex = retorno.Count,
                            Name = String.Concat(panelControl.Name, '_', item.FieldName)
                        };

                        if (panelControl == this.pnlCtrlAssociados)
                        {
                            gridColumnItem.OptionsColumn.AllowSort = _ordenacaoAutomatica
                                ? DevExpress.Utils.DefaultBoolean.Default
                                : DevExpress.Utils.DefaultBoolean.False;

                            gridView.OptionsView.ShowGroupPanel = _ordenacaoAutomatica;
                        }
                        retorno.Add(gridColumnItem);
                        return retorno;
                    })
                    .ToArray());

                GridColumn gridColumnPrimeira = gridView.Columns
                    .OfType<GridColumn>()
                    .FirstOrDefault();
                gridColumnPrimeira.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;

                gridView.GroupSummary.Add(new GridGroupSummaryItem(
                    DevExpress.Data.SummaryItemType.Count,
                    gridColumnPrimeira.FieldName,
                    null, // gridColumnPrimeira // Sem esse parametro mostra o total na linha do grupo
                    String.Empty));

                if (gridColumnPrimeira.OptionsColumn.AllowSort == DevExpress.Utils.DefaultBoolean.Default)
                    gridColumnPrimeira.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

                gridControl.MainView = gridView;
                gridControl.ViewCollection.Add(gridView);

                //gridView.DefinirCaracteristicas();
            }
        }

        private GridView RetornarGridView(object sender)
        {
            GridControl gridControl = sender as GridControl;

            return gridControl == null
                ? null
                : gridControl.MainView as GridView;
        }

        private void CriarGridControl()
        {
            if (_gridControlDisponiveis == null)
            {
                this.pnlColunasDesignAsso.Dispose();
                this.pnlColunasDesignDisp.Dispose();
                this.lblVisualizacaoDispo.Dispose();
                this.lblVisualizacaoAsso.Dispose();
                Func<PanelControl, GridControl> deleGridControl = delegate(PanelControl panelControl)
                {
                    GridControl gridControl = new GridControl();
                    gridControl.Dock = DockStyle.Fill;
                    gridControl.AllowDrop = true;
                    gridControl.Name = String.Concat("Grid", '_', panelControl.Name);

                    GridView gridView = new GridView(gridControl);
                    gridView.OptionsBehavior.Editable = false;
                    gridView.OptionsSelection.MultiSelect = true;

                    gridControl.MouseDown += new MouseEventHandler(gridControl_MouseDown);
                    gridControl.MouseMove += new MouseEventHandler(gridControl_MouseMove);
                    gridControl.DragEnter += new DragEventHandler(gridControl_DragEnter);
                    gridControl.DragDrop += new DragEventHandler(gridControl_DragDrop);

                    gridView.KeyDown += new KeyEventHandler(gridView_KeyDown);
                    gridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(gridView_SelectionChanged);

                    this.CriarColunas(panelControl, gridControl, gridView);

                    panelControl.Controls.Add(gridControl);
                    gridControl.BringToFront();

                    return gridControl;
                };

                _gridControlDisponiveis = deleGridControl(this.pnlCtrlDisponiveis);
                _gridControlAssociados = deleGridControl(this.pnlCtrlAssociados);

            }
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
                e.Handled = true;
        }

        private void gridControl_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gridView = this.RetornarGridView(sender);
            if (gridView != null)
            {
                _gridHitInfo = gridView.CalcHitInfo(e.Location);
                gridView.SelectRow(gridView.FocusedRowHandle);
            }
        }

        private void gridControl_MouseMove(object sender, MouseEventArgs e)
        {
            GridView gridView = this.RetornarGridView(sender);
            if (gridView != null)
            {
                if (_gridHitInfo != null &&
                    _gridHitInfo.InRow &&
                    e.Button == MouseButtons.Left)
                {
                    Rectangle rectangle = new Rectangle(new Point(
                        _gridHitInfo.HitPoint.X - SystemInformation.DragSize.Width / 2,
                        _gridHitInfo.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);

                    if (!rectangle.Contains(new Point(e.X, e.Y)))
                    {
                        object dragDrop = gridView.GetRow(_gridHitInfo.RowHandle);
                        gridView.GridControl.DoDragDrop(dragDrop, DragDropEffects.Move);
                        _gridHitInfo = null;
                    }
                }
            }
        }

        private void gridControl_DragEnter(object sender, DragEventArgs e)
        {
            GridView gridView = this.RetornarGridView(sender);

            e.Effect = _gridHitInfo == null ||
                _gridHitInfo == null ||
                _gridHitInfo.Column == null ||
                _gridHitInfo.Column.View == gridView ||
                (!this.QuantidadeMenorQueOPermitido(_qtdeMaxPermitido)) ||
                sender == xtrTbPgAssociados ||
                sender == xtrTbPgDisponiveis

                ? DragDropEffects.None
                : DragDropEffects.Move;
        }

        private void gridControl_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (sender is DevExpress.XtraTab.XtraTabControl ||
                    sender is DevExpress.XtraTab.XtraTabPage
                    )
                {
                    this.FindForm().Text = this.FindForm().Text + "1, " + (sender as Control).Name;
                }

            }
            catch
            {
            }

            GridView gridView = this.RetornarGridView(sender);
            if (gridView != null)
            {
                botoesAssociaERevoga_ButtonClick((gridView.GridControl.Parent == this.pnlCtrlAssociados
                    ? this.btnEdtDisponiveis
                    : this.btnEdtAssociados), null);
            }
        }

        private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            this.HabilitarBotoes();
        }

        internal void AtualizarButtonColuna(ColunaAutorizaBGM colunaAutorizaBGM)
        {
            this.AtualizarButtonColuna(this.pnlColunasDesignDisp, colunaAutorizaBGM);
            this.AtualizarButtonColuna(this.pnlColunasDesignAsso, colunaAutorizaBGM);
        }

        private void AtualizarButtonColuna(Panel panel, ColunaAutorizaBGM colunaAutorizaBGM)
        {
            Button button = panel.Controls
                .OfType<Button>()
                .Where(w => (int)w.Tag == colunaAutorizaBGM.GetHashCode())
                .FirstOrDefault();

            if (button != null)
            {
                button.Text = colunaAutorizaBGM.Caption;
                button.Width = colunaAutorizaBGM.Tamanho;
            }
        }

        internal void AdicionarButtonColuna()
        {
            if (_colunas.Count > 0)
            {
                this.AdicionarButtonColuna(this.pnlColunasDesignDisp);
                this.AdicionarButtonColuna(this.pnlColunasDesignAsso);
            }
        }

        /// <summary>
        /// Limpa as listas do controle
        /// </summary>
        public void LimparListas()
        {
            if (_dataTableDisponiveis != null)
                _dataTableDisponiveis = null;
            if (_dataTableAssociados != null)
                _dataTableAssociados = null;

            _gridControlAssociados.RefreshDataSource();
            _gridControlDisponiveis.RefreshDataSource();
        }

        private void AdicionarButtonColuna(Panel panel)
        {
            panel.Controls.Clear();
            panel.Controls.AddRange(_colunas
                .OfType<ColunaAutorizaBGM>()
                .Reverse()
                .Select(s => new Button()
                {
                    Text = s.Caption.NuloOuVazio()
                        ? s.FieldName
                        : s.Caption,
                    Tag = s.GetHashCode(),
                    Dock = DockStyle.Left,
                    Width = s.Tamanho,
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat
                })
                .ToArray());
        }

        private DataTable ConverteListParaDataTable<T>(IEnumerable<T> lista)
        {
            return FGlobus.Util.Util.ConverteListParaDataTable(lista
                .OfType<T>()
                .ToList());
        }

        private void Popular<T1, T2>(
            bool disponiveis,
            IEnumerable<T1> listaOrigem,
            IEnumerable<T2> listaDestino)
        {

            Func<object, string, string> funcCamposAssociados =
                (dataRow, campo) => String.Join("_", _colunas
                    .OfType<ColunaAutorizaBGM>()
                    .Where(w => !w.FieldNameAssociado.NuloOuVazio())
                    .Aggregate(new List<object>(), (retorno, item) =>
                    {
                        var valor = dataRow
                            .GetType()
                            .GetProperty(item.RetornarValorPropriedade<string>(campo))
                            .GetValue(dataRow, null);

                        retorno.Add(valor);

                        return retorno;
                    })
                    .ToArray());

            ColunaAutorizaBGM colunaAutorizaBGM = new ColunaAutorizaBGM();

            Func<T1, bool> funcCondicaoContido = dataRow =>
                listaDestino
                    .OfType<T2>()
                    .Select(s => funcCamposAssociados(s, colunaAutorizaBGM.RetornarName(c => c.FieldNameAssociado)))
                    .Contains(funcCamposAssociados(dataRow, colunaAutorizaBGM.RetornarName(c => c.FieldName)));

            IEnumerable<T1> novaListaOrigem = listaOrigem
                .OfType<T1>()
                .Where(w => !funcCondicaoContido(w));

            IEnumerable<T1> novaListaDestino = listaOrigem
                .OfType<T1>()
                .Where(funcCondicaoContido);

            IEnumerable<T1> dataTableOrigem = novaListaOrigem;
            IEnumerable<T1> dataTableDestino = novaListaDestino;

            this.PopularDataTable(disponiveis, dataTableOrigem, dataTableDestino);
        }

        private void PopularDataTable<T>(bool disponiveis, IEnumerable<T> dataTableOrigem, IEnumerable<T> dataTableDestino)
        {
            if (disponiveis)
            {
                if (!dataTableOrigem.NuloOuVazio())
                    _dataTableDisponiveis = dataTableOrigem
                        .Select(s => (object)s)
                        .ToList();

                if (!dataTableDestino.NuloOuVazio())
                    _dataTableAssociados = dataTableDestino
                        .Select(s => (object)s)
                        .ToList();
            }
            else
            {
                if (!dataTableOrigem.NuloOuVazio())
                    _dataTableAssociados = dataTableOrigem
                        .Select(s => (object)s)
                        .ToList();

                if (!dataTableDestino.NuloOuVazio())
                    _dataTableDisponiveis = dataTableDestino
                        .Select(s => (object)s)
                        .ToList();
            }

            if (!_dataTableDisponiveis.NuloOuVazio())
                _gridControlDisponiveis.DataSource = _dataTableDisponiveis.ToArray();

            if (!_dataTableAssociados.NuloOuVazio())
                _gridControlAssociados.DataSource = _dataTableAssociados.ToArray();

            this.HabilitarBotoes();
        }

        private void PopularGrid<T>(bool disponiveis, IEnumerable<T> lista)
        {
            IEnumerable<T> dataTableOrigem = lista;
            IEnumerable<T> dataTableDestino = default(IEnumerable<T>);

            this.PopularDataTable(disponiveis, dataTableOrigem, dataTableDestino);
        }

        private IEnumerable<T> RetornarDadosDoGrid<T>(IEnumerable<object> dataTable)
        {
            return dataTable
                .Select(s => (T)s);
        }

        private void MoverLinha(ButtonPredefines buttonPredefines)
        {
            //GridView gridView = this.RetornarGridView(_gridControlAssociados);
            //if (gridView != null)
            //{
            //    DataRow dataRowAtual = (gridView.GetRow(gridView.GetSelectedRows().FirstOrDefault()) as DataRowView).Row;
            //    DataRow dataRowNova = _dataTableAssociados.NewRow();

            //    dataRowNova.ItemArray = dataRowAtual.ItemArray;

            //    int indexAtual = _dataTableAssociados.Rows.IndexOf(dataRowAtual);
            //    int indexNovo = buttonPredefines == ButtonPredefines.Down
            //        ? indexAtual + 1
            //        : indexAtual - 1;

            //    _dataTableAssociados.Rows.Remove(dataRowAtual);
            //    _dataTableAssociados.Rows.InsertAt(dataRowNova, indexNovo);

            //    gridView.SelectRow(_dataTableAssociados.Rows.IndexOf(dataRowNova));
            //}
        }

        private void HabilitarBotoes()
        {
            this.HabilitarBotoesAssociaOuRevoga();
            this.HabilitarBotoesMover();
        }

        private void HabilitarBotoesMover()
        {
            bool setaParaBaixo = false;
            bool setaParaCima = false;

            if (!_ordenacaoAutomatica &&
                !_dataTableAssociados.NuloOuVazio())
            {
                GridView gridView = this.RetornarGridView(_gridControlAssociados);
                if (gridView != null)
                {
                    int[] listaInt = gridView.GetSelectedRows();
                    if (listaInt.Count() == 1)
                    {
                        DataRowView dataRowView = gridView.GetRow(listaInt.FirstOrDefault()) as DataRowView;
                        if (dataRowView != null)
                        {
                            DataRow dataRowAtual = dataRowView.Row;

                            setaParaBaixo = dataRowAtual != _dataTableAssociados
                                .LastOrDefault();

                            setaParaCima = dataRowAtual != _dataTableAssociados
                                .FirstOrDefault();
                        }
                    }
                }
            }
            this.btnEdtMover.Properties.Buttons
                .OfType<EditorButton>()
                .Update(u => u.Enabled = u.Kind == ButtonPredefines.Down
                                ? setaParaBaixo
                                : setaParaCima);
        }

        private void HabilitarBotoesLayout()
        {
            eLayOut layOut = eLayOut.Vertical;
            this.btnEdtOpcoes.Properties.Buttons
                .OfType<EditorButton>()
                .Update(u =>
                {
                    Enum.TryParse(u.Tag.ToString(), out layOut);
                    u.Enabled = (u.Kind == ButtonPredefines.Undo && _dataTableDisponiveisAtual != null) ||
                        _layOut != layOut;
                });
        }

        private void HabilitarBotoesAssociaOuRevoga()
        {
            Action<ButtonEdit, int> actionHabilitarBotoes = (buttonEdit, qtdeMaxPermitido) =>
            {
                GridView gridView = this.RetornarGridView(this.RetornarGridDoButtonEdit(buttonEdit));

                bool habilita = gridView != null &&
                    gridView.GetSelectedRows().FirstOrDefault() >= 0 &&
                    this.QuantidadeMenorQueOPermitido(qtdeMaxPermitido);

                buttonEdit.Properties.Buttons
                    .OfType<EditorButton>()
                    .Update(u =>
                    {
                        u.Enabled = _habilitaOuDesabilitarBotoes && habilita &&
                            gridView.RowCount > (u.Tag.Contido(AssociacaoBGMDemo.TODOS) ? 1 : 0);

                        this.xtrTbCtrlAbas.CustomHeaderButtons
                            .OfType<CustomHeaderButton>()
                            .Where(w => w.SuperTip == u.SuperTip)
                            .Update(u2 => u2.Enabled = u.Enabled);
                    });
            };

            actionHabilitarBotoes(this.btnEdtDisponiveis, _qtdeMaxPermitido);
            actionHabilitarBotoes(this.btnEdtAssociados, -1);
        }

        private bool QuantidadeMenorQueOPermitido(int qtdeMaxPermitido)
        {
            bool qtdePermitido = qtdeMaxPermitido == -1;

            GridView gridView = this.RetornarGridView(_gridControlDisponiveis);

            if (gridView != null && !qtdePermitido)
            {
                int qtdeSelecionado = gridView.GetSelectedRows().Count();

                qtdePermitido = _dataTableAssociados != null &&
                    (_dataTableAssociados.Count() + qtdeSelecionado) <= qtdeMaxPermitido;
            }
            return qtdePermitido;
        }

        /// <summary>
        /// Popula a lista de disponiveis
        /// </summary>
        /// <typeparam name="T">Tipo de objeto da lista</typeparam>
        /// <param name="listaDisponiveis">Lista de objetos do tipo informado</param>
        public void PopularDisponiveis<T>(IEnumerable<T> listaDisponiveis)
        {
            this.PopularGrid<T>(true, listaDisponiveis);
        }

        /// <summary>
        /// Popula a lista de associados
        /// </summary>
        /// <typeparam name="T">Tipo de objeto da lista</typeparam>
        /// <param name="listaDisponiveis">Lista de objetos do tipo informado</param>
        public void PopularAssociados<T>(IEnumerable<T> listaAssociados)
        {
            this.PopularGrid<T>(false, listaAssociados);
        }

        /// <summary>
        /// Popula a lista de disponiveis e associados conforme a lista de associados
        /// </summary>
        /// <typeparam name="T1">Tipo de objeto da lista de disponiveis</typeparam>
        /// <typeparam name="T2">Tipo de objeto da lista de associados</typeparam>
        /// <param name="listaDisponiveis">Lista de objetos do tipo informado no disponiveis</param>
        /// <param name="listaAssociados">Lista de objetos do tipo informado no associados</param>
        public void PopularDisponiveis<T1, T2>(
            IEnumerable<T1> listaDisponiveis,
            IEnumerable<T2> listaAssociados)
        {
            this.Popular<T1, T2>(true, listaDisponiveis, listaAssociados);
        }

        /// <summary>
        /// Popula a lista de associados e disponiveis conforme a lista de disponiveis
        /// </summary>
        /// <typeparam name="T1">Tipo de objeto da lista de associados</typeparam>
        /// <typeparam name="T2">Tipo de objeto da lista de disponiveis</typeparam>
        /// <param name="listaAssociados">Lista de objetos do tipo informado no associados</param>
        /// <param name="listaDisponiveis">Lista de objetos do tipo informado no disponiveis</param>
        public void PopularAssociados<T1, T2>(
            IEnumerable<T1> listaAssociados,
            IEnumerable<T2> listaDisponiveis)
        {
            this.Popular<T1, T2>(false, listaAssociados, listaDisponiveis);
        }

        /// <summary>
        /// Retorna os lista com os itens disponiveis
        /// </summary>
        /// <typeparam name="T">Tipo de objeto da lista</typeparam>
        /// <returns>Lista de objetos do tipo informado</returns>
        public IEnumerable<T> RetornarDisponiveis<T>()
        {
            return this.RetornarDadosDoGrid<T>(_dataTableDisponiveis);
        }

        /// <summary>
        /// Retorna os lista com os itens associados
        /// </summary>
        /// <typeparam name="T">Tipo de objeto da lista</typeparam>
        /// <returns>Lista de objetos do tipo informado</returns>
        public IEnumerable<T> RetornarAssociados<T>()
        {
            return this.RetornarDadosDoGrid<T>(_dataTableAssociados);
        }

        #endregion

        #region Classes auxiliares

        /// <summary>
        /// Classe para controlar a lista de colunas
        /// </summary>
        public class ColunaAutorizaBGMCollection : CollectionBase
        {
            #region Construtor

            /// <summary>
            /// Construtor padrao
            /// </summary>
            public ColunaAutorizaBGMCollection()
            {
            }

            #endregion

            #region Metodos

            /// <summary>
            /// Adiciona a lista de objetos na coleção
            /// </summary>
            /// <param name="colunaAutorizaBGM">Lista de objetos do tipo ColunaAutorizaBGM</param>
            public void AddRange(ColunaAutorizaBGM[] colunaAutorizaBGM)
            {
                this.InnerList.AddRange(colunaAutorizaBGM);
            }

            //public ColunaAutorizaBGM Add(ColunaAutorizaBGM colunaAutorizaBGM)
            //{
            //    this.InnerList.Add(colunaAutorizaBGM);
            //    return colunaAutorizaBGM;
            //}

            //public void Remove(ColunaAutorizaBGM colunaAutorizaBGM)
            //{
            //    this.InnerList.Remove(colunaAutorizaBGM);
            //}

            //public bool Contains(ColunaAutorizaBGM colunaAutorizaBGM)
            //{
            //    return this.InnerList.Contains(colunaAutorizaBGM);
            //}

            //public ColunaAutorizaBGM[] GetValues()
            //{
            //    ColunaAutorizaBGM[] colunaAutorizaBGM = new ColunaAutorizaBGM[this.InnerList.Count];

            //    this.InnerList.CopyTo(0, colunaAutorizaBGM, 0, this.InnerList.Count);

            //    return colunaAutorizaBGM;
            //}

            #endregion

            #region Propriedades

            /// <summary>
            /// (Set/Get) Informa ou retorna o objeto ColunaAutorizaBGM conforme o index .
            /// </summary>
            /// <param name="index">Index</param>
            /// <returns>Objeto do tipo ColunaAutorizaBGM</returns>
            public ColunaAutorizaBGM this[int index]
            {
                get
                {
                    return this.InnerList[index] as ColunaAutorizaBGM;
                }
                set
                {
                    this.InnerList[index] = value;
                }
            }
            #endregion
        }

        /// <summary>
        /// Classe da colunas dos grids
        /// </summary>
        [TypeConverter(typeof(FilterConverter))]
        public class ColunaAutorizaBGM
        {
            #region Construtor

            /// <summary>
            /// Construtor padrao
            /// </summary>
            public ColunaAutorizaBGM() { }

            public ColunaAutorizaBGM(
            string Caption,
            string FieldName,
            int Tamanho,
            string FieldNameAssociado
                )
            {
                _caption = Caption;
                _fieldName = FieldName;
                _tamanho = Tamanho;
                _fieldNameAssociado = FieldNameAssociado;
            }
            #endregion

            #region Atributos

            private string _caption;
            private string _fieldName;
            private string _fieldNameAssociado;
            private int _tamanho = 100;
            private AssociacaoBGMDemo _autorizaGridBGM;

            #endregion

            #region Propriedades

            /// <summary>
            /// (Set/Get) Informa ou retorna o titulo da coluna.
            /// </summary>
            [DefaultValue(null)]
            [Description("Informa ou retorna o titulo da coluna.")]
            public string Caption
            {
                get { return _caption; }
                set
                {
                    if (value.NuloOuVazio())
                        MessageBox.Show("FieldName invalido.", "Informação");
                    else
                    {
                        if (_caption != value)
                        {
                            _caption = value;
                            if (_autorizaGridBGM != null)
                                _autorizaGridBGM.AtualizarButtonColuna(this);
                        }
                    }
                }
            }

            /// <summary>
            /// (Set/Get) Informa ou retorna o nome do campo da coluna.
            /// </summary>
            [DefaultValue(null)]
            [Description("Informa ou retorna o nome do campo da coluna.")]
            public string FieldName
            {
                get { return _fieldName; }
                set
                {
                    if (value.RemoverCaracterEspecial() != value)
                        MessageBox.Show("FieldName invalido.", "Informação");
                    else
                    {
                        _fieldName = value;
                    }
                }
            }

            /// <summary>
            /// (Set/Get) Informa ou retorna o tamanho da coluna.
            /// </summary>
            [DefaultValue(100)]
            [Description("Informa ou retorna o tamanho da coluna.")]
            public int Tamanho
            {
                get { return _tamanho; }
                set
                {
                    if (_tamanho != value)
                    {
                        _tamanho = value;
                        if (_autorizaGridBGM != null)
                            _autorizaGridBGM.AtualizarButtonColuna(this);
                    }
                }
            }

            /// <summary>
            /// (Set/Get) Informa ou retorna o objeto AutorizaGridBGMx2
            /// </summary>
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            [Browsable(false)]
            public AssociacaoBGMDemo AutorizaGridBGM
            {
                get { return _autorizaGridBGM; }
                set { _autorizaGridBGM = value; }
            }

            /// <summary>
            /// (Set/Get) Informa ou retorna o nome do campo associado a essa coluna.
            /// </summary>
            [DefaultValue(null)]
            [Description("Informa ou retorna o nome do campo associado a essa coluna.")]
            public string FieldNameAssociado
            {
                get { return _fieldNameAssociado; }
                set { _fieldNameAssociado = value; }
            }

            #endregion
        }

        /// <summary>
        /// Classe para controlar a edição das colunas
        /// </summary>
        private class CustomCollectionEditor : CollectionEditor
        {
            #region Construtor

            /// <summary>
            /// Construtor padrao
            /// </summary>
            public CustomCollectionEditor()
                : base(typeof(List<ColunaAutorizaBGM>))
            {
            }

            #endregion

            #region Atributos

            private AssociacaoBGMDemo _autorizaGridBGM;

            #endregion

            #region Metodos

            /// <summary>
            /// Sobreposição do método para criar a coluna
            /// </summary>
            /// <param name="itemType">Type</param>
            /// <returns>object</returns>
            protected override object CreateInstance(Type itemType)
            {
                ColunaAutorizaBGM colunaAutorizaBGM = base.CreateInstance(itemType) as ColunaAutorizaBGM;

                colunaAutorizaBGM.AutorizaGridBGM = _autorizaGridBGM;
                colunaAutorizaBGM.FieldName = String.Concat("ColunaAutorizaBGM", _autorizaGridBGM.Colunas.Count + 1);
                colunaAutorizaBGM.Caption = colunaAutorizaBGM.FieldName;

                return colunaAutorizaBGM;
            }

            /// <summary>
            /// Sobreposição do método criar as colunas no componente
            /// </summary>
            /// <param name="context">Componente que cionnou o método</param>
            /// <returns>bool</returns>
            public override bool GetPaintValueSupported(ITypeDescriptorContext context)
            {
                if (_autorizaGridBGM == null)
                    _autorizaGridBGM = context.Instance as AssociacaoBGMDemo;
                else
                    _autorizaGridBGM.AdicionarButtonColuna();

                return base.GetPaintValueSupported(context);
            }

            /// <summary>
            /// Sobreposição do método atualizar a valores do coluna na lista
            /// </summary>
            /// <param name="coluna">Coluna</param>
            /// <returns>string</returns>
            protected override string GetDisplayText(object coluna)
            {
                ColunaAutorizaBGM colunaAutorizaBGM = coluna as ColunaAutorizaBGM;

                StringBuilder retorno = new StringBuilder();

                retorno.Append(String.Concat(colunaAutorizaBGM.RetornarName(c => c.Caption), "= ", colunaAutorizaBGM.Caption));

                if (colunaAutorizaBGM.FieldName != colunaAutorizaBGM.Caption)
                    retorno.Append(String.Concat(", ", colunaAutorizaBGM.RetornarName(c => c.FieldName), "= ", colunaAutorizaBGM.FieldName));

                if (retorno.Length == 0)
                    retorno.Append(colunaAutorizaBGM.ToString());

                return retorno.ToString();
            }

            protected override CollectionForm CreateCollectionForm()
            {
                CollectionForm collectionForm = base.CreateCollectionForm();

                Form form = collectionForm as Form;
                form.HelpButtonClicked += new CancelEventHandler(form_HelpButtonClicked);

                FieldInfo fieldInfo = form.GetType().GetField("propertyBrowser", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    PropertyGrid propertyGrid = fieldInfo.GetValue(form) as PropertyGrid;
                    if (propertyGrid != null)
                    {
                        propertyGrid.ToolbarVisible = false;
                        propertyGrid.HelpVisible = true;
                        propertyGrid.PropertySort = PropertySort.NoSort;
                    }
                }

                return collectionForm;
            }

            private void form_HelpButtonClicked(object sender, CancelEventArgs e)
            {
                try
                {
                    System.Diagnostics.Process.Start("mhtml:http://tfsserver/sites/BGMRodotec/Globus/Desenvolvimento/Manuais/IdentidadeVisualGlb_Htm.mht#_Toc325727334");
                }
                catch { }
            }

            #endregion
        }

        #endregion

        private void xtrTbCtrlAbas_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            botoesAssociaERevoga_ButtonClick((this.xtrTbCtrlAbas.SelectedTabPage == this.xtrTbPgDisponiveis
                ? this.btnEdtDisponiveis
                : this.btnEdtAssociados), null);

        }

        internal class FilterConverter : TypeConverter
        {
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
            }

            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor) && value is ColunaAutorizaBGM)
                {
                    ColunaAutorizaBGM colunaAutoriza = value as ColunaAutorizaBGM;
                    object[] propriedades = new object[]
                    {
                        colunaAutoriza.Caption, 
                        colunaAutoriza.FieldName, 
                        colunaAutoriza.Tamanho,
                        colunaAutoriza.FieldNameAssociado 
                     };

                    object[] propriedades1 = colunaAutoriza.GetType()
                        .GetProperties()
                        .Where(w => w.GetCustomAttributes(true) == null)
                        .Select(s => s.GetValue(colunaAutoriza, null))
                        .ToArray();

                    ConstructorInfo constructor = typeof(ColunaAutorizaBGM)
                        .GetConstructor(propriedades
                            .Select(s => s.GetType())
                            .ToArray());

                    return new InstanceDescriptor(
                        constructor,
                        propriedades,
                        true);
                }

                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        private void Teste_NomeMetodo()
        {
            ColunaAutorizaBGM colunaAutoriza = new ColunaAutorizaBGM();

            object[] propriedades1 = colunaAutoriza.GetType()
                .GetProperties()
                .Where(w => w.GetCustomAttributes(typeof(BrowsableAttribute), true).NuloOuVazio())
                .Select(s => s.GetValue(colunaAutoriza, null))
                .ToArray();



            Console.WriteLine(propriedades1.Count());
            foreach (var item in propriedades1)
            {

            }

        }      
    }
}



//string Caption
//string FieldName
//int Tamanho
//string FieldNameAssociado


