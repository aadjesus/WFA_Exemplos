using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;


namespace WFA_Workflow.GroupControlBGM
{
    /// <summary>
    /// Controle do tipo GroupControl com implementações exclusívas BGM.
    /// </summary>
    [ToolboxItem(true)]
    [Description("Controle do tipo GroupControl com implementações exclusívas BGM.")]
    //[ToolboxBitmap(typeof(GroupControlBGM), "Destaque.DestaqueBGM.ico")]
    [ToolboxBitmap( typeof(DevExpress.XtraEditors.GroupControl))]
    [Docking(DockingBehavior.Ask)]
    //[Designer(typeof(ControlaComponenteDesigner))]
    //[PropertyTab(typeof(BotaoBrowserPropriedades), PropertyTabScope.Document)]
    [DefaultProperty("Tipo")]
    //[InformacoesComponente("Alessandro Augusto", "1.0.0", "mhtml:http://tfsserver/sites/BGMRodotec/Globus/Desenvolvimento/Manuais/IdentidadeVisualGlb_Htm.mht#_Toc325727343")]
    public partial class GroupControlBGMDemo : UserControl
    {
        #region Construtor

        public GroupControlBGMDemo()
        {
            InitializeComponent();
        }

        #endregion

        #region Propriedades

        ///// <summary>
        ///// (Set/Get) Informa ou retorna o titulo.
        ///// </summary>
        ////[Category(Util.Constantes.CATEGORIA)]
        //[Description("Informa ou retorna o titulo.")]
        //[DisplayName("1) Titulo")]
        //[DefaultValue(null)]
        //public string Titulo
        //{
        //    get
        //    {
        //        return this.groupControl1.Text;
        //    }
        //    set
        //    {
        //        this.groupControl1.Text = value;
        //    }
        //}

        /// <summary>
        /// (Set/Get) Informa ou retorna os botõe do controle.
        /// </summary>
        //[Category(Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna os botõe do controle.\nName: Botoes")]
        [DisplayName("2) Botões")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RefreshProperties(RefreshProperties.All)]
        //public EditorButtonCollection Botoes
        //{
        //    get
        //    {
        //        //if (!DesignMode && this.btnEdtBotoes.Properties.Buttons.Count == 1)
        //        //    this.btnEdtBotoes.Properties.Buttons.Clear();

        //        this.DefinirTamanho();
        //       // return this.btnEdtBotoes.Properties.Buttons;
        //    }
        //}

        #endregion

        #region Metodos controle

        private void btnEdtBotoes_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (this.ClickBotao != null)
                this.ClickBotao(sender, e);
        }

        #endregion

        #region Metodos

        private void DefinirTamanho()
        {
            //if (btnEdtBotoes != null)
            //{
            //    int tama = btnEdtBotoes.Properties.Buttons
            //        .OfType<EditorButton>()
            //        .Where(w => w.Visible)
            //        .Count() * 20;
            //    btnEdtBotoes.Width = tama;
            //    btnEdtBotoes.Left = this.Width - tama - 2;
            //}
        }

        #endregion

        #region Override

        /// <summary>
        /// Sobreposição do método para executar o metodo <see cref="DefinirTamanho"/> na construção do componente.
        /// </summary>
        protected override void InitLayout()
        {
            base.InitLayout();
            //if (this.btnEdtBotoes.Properties.Buttons.Count > 1)
            //{
            //    IEnumerable<EditorButton> listaEditorButton = this.btnEdtBotoes.Properties.Buttons
            //        .OfType<EditorButton>()
            //        .Where((w, index) => w.Tag != null &&
            //                             w.Tag.ToString() == Constantes.COMPONENTE_DE_CONTROLE_INTERNO);

            //    if (!listaEditorButton.NuloOuVazio())
            //        listaEditorButton.FirstOrDefault().Visible = false;
            //}

            this.DefinirTamanho();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Evento para executar o click do botão.
        /// </summary>
        [Category(FGlobus.Util.Constantes.CATEGORIA)]
        [Description("Evento para executar o click do botão.")]
        [DisplayName("Click do botão")]
        public event ButtonPressedEventHandler ClickBotao;

        #endregion

    }


}
