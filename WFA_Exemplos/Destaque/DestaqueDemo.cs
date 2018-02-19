using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using DevExpress.Utils.Editors;
using DevExpress.XtraEditors;

namespace FGlobus.Componentes.WinForms
{
    /// <summary>
    /// Componente para destacar um determinado valor no formulário
    /// </summary>
    [ToolboxItem(true)]
    [Description("Componente para destacar um determinado valor no formulário")]    
    //[Docking(DockingBehavior.Ask)]
    //[Designer(typeof(ControlaComponenteDesigner))]
    //[PropertyTab(typeof(BotaoBrowserPropriedades), PropertyTabScope.Document)]
    [DefaultProperty("Tipo")]
    //[InformacoesComponente("Alessandro Augusto", "1.0.0")]
    public partial class DestaqueDemo : UserControl
    {
        #region Construtor

        /// <summary>
        /// Construtor default
        /// </summary>
        public DestaqueDemo()
        {
            InitializeComponent();
            //MessageBox.Show(Constantes.EM_DESENVOLVIMENTO);
        }

        #endregion

        #region Atributos

        /// <summary>
        /// enum para controlar o tamanho do controle no formulário
        /// </summary>
        public enum eTamanho
        {
            /// <summary>
            /// Pequeno
            /// </summary>
            Pequeno = 1,
            /// <summary>
            /// Médio 30% a mais que o pequeno
            /// </summary>
            Medio = 70,
            /// <summary>
            /// Grande 50% a mais que o pequeno
            /// </summary>
            Grande = 120
        }

        /// <summary>
        /// Enum para controlar qual o tipo de informação que será destaque
        /// </summary>
        public enum eTipo
        {
            /// <summary>
            /// Moeda
            /// </summary>
            Moeda = 0,
            /// <summary>
            /// Data
            /// </summary>
            Data = 1,
            /// <summary>
            /// Texto
            /// </summary>
            Texto = -1
        }

        private const float TAMANHO_DEFAULT_FONT_TITULO = 9F;
        private const float TAMANHO_DEFAULT_FONT_VALOR = 15F;
        private const string VALOR_DEFAULT = "Valor";
        private const string TITULO_DEFAULT = "Titulo";
        private const int HEIGHT_DEFAULT = 40;

        private eTamanho _tamanho = eTamanho.Grande;
        private eTipo _eTipo = eTipo.Moeda;
        private bool _atencao;
        private object _valor = DestaqueDemo.VALOR_DEFAULT;
        private string _titulo = DestaqueDemo.TITULO_DEFAULT;

        #endregion

        #region Propriedades

        /// <summary>
        /// (Set/Get) Informa ou retorna o tipo.
        /// </summary>
        [Category(Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna o tipo.")]
        [DisplayName("1) Tipo")]
        [DefaultValue(eTipo.Moeda)]
        public eTipo Tipo
        {
            get { return _eTipo; }
            set
            {
                _eTipo = value;
                //this.lblCtrlValor.Appearance.ImageIndex =
                //    imageCollection1.Images.IndexOf(imageCollection1.Images[String.Concat(this.GetType().Name, "_", _eTipo, ".png")])

                //    //(int)(char)_eTipo
                //        ;
                this.pictureEdit1.Image = imageCollection1.Images[String.Concat(this.GetType().Name, "_", _eTipo, ".png")];
            }
        }

        /// <summary>
        /// (Set/Get) Informa ou retorna o Tamanho.
        /// </summary>
        [Category(Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna o tamanho.")]
        [DisplayName("2) Tamanho")]
        [DefaultValue(eTamanho.Grande)]
        [RefreshProperties(RefreshProperties.All)]
        public eTamanho Tamanho
        {
            get
            {
                return _tamanho;
            }
            set
            {
                _tamanho = value;
                this.DefinirTamanhos();
            }
        }

        /// <summary>
        /// (Set/Get) Informa ou retorna se o destaque é uma atenção, se verdadeiro muda a cor do valor para vermelho.
        /// </summary>
        [Category(Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna se o destaque é uma atenção, se verdadeiro muda a cor do valor para vermelho.")]
        [DisplayName("3) Atenção")]
        [DefaultValue(false)]
        public bool Atencao
        {
            get { return _atencao; }
            set
            {
                _atencao = value;

                this.lblCtrlValor.ForeColor = _atencao
                    ? Color.Red
                    : this.lblCtrlTitulo.ForeColor;
            }
        }

        /// <summary>
        /// (Set/Get) Informa ou retorna o titulo.
        /// </summary>
        [Category(Util.Constantes.CATEGORIA)]
        [Description("Informa ou retorna o titulo.")]
        [DisplayName("4) Titulo")]
        [DefaultValue(DestaqueDemo.TITULO_DEFAULT)]
        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;
                this.lblCtrlTitulo.Text = value;
            }
        }

        [Editor(typeof(UIObjectEditor), typeof(UITypeEditor))]
        [Localizable(true)]
        [Category(Util.Constantes.CATEGORIA)]
        [RefreshProperties(RefreshProperties.All)]
        [Bindable(true)]
        [TypeConverter(typeof(ObjectEditorTypeConverter))]
        [DefaultValue(DestaqueDemo.VALOR_DEFAULT)]
        [DisplayName("5) Valor")]
        [Description("Gets or sets the editor's value.")]
        public object Valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
                this.lblCtrlValor.Text = _valor.ToString();
            }
        }

        #endregion

        #region Override

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.DefinirTamanhos();
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, (int)this.RetornarTamanho(HEIGHT_DEFAULT), specified);
        }

        #endregion

        #region Metodos

        private float RetornarTamanho(float valor)
        {
            return (valor + (valor * ((int)(char)_tamanho) / 100));
        }


        //private const float TAMANHO_DEFAULT_FONT_TITULO = 9.75F;
        //private const float TAMANHO_DEFAULT_FONT_VALOR = 17.25F;

        private void DefinirTamanhos()
        {
            Action<LabelControl, float> actionLabelControl = (a, b) =>
                    a.Font = new System.Drawing.Font(
                        a.Font.FontFamily,
                        this.RetornarTamanho(b),
                        a.Font.Style);

            actionLabelControl(this.lblCtrlTitulo, DestaqueDemo.TAMANHO_DEFAULT_FONT_TITULO);
            actionLabelControl(this.lblCtrlValor, DestaqueDemo.TAMANHO_DEFAULT_FONT_VALOR);

            this.Height = (int)this.RetornarTamanho(DestaqueDemo.HEIGHT_DEFAULT);
            this.pictureEdit1.Width = this.pictureEdit1.Height;

            //this.MinimumSize = new Size(this.Height, this.Height);
        }

        #endregion


        bool _visibel;

        [Category(Util.Constantes.CATEGORIA)]
        public bool Visibel
        {
            get 
            {
                return lblCtrlTitulo.Visible; 
            }
            set 
            {
                lblCtrlTitulo.Visible = value;
            }
        } 
    }
}
