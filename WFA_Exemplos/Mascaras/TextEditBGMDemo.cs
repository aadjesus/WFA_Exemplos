using System;
using System.ComponentModel;
using System.Drawing.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using FGlobus.Util;

namespace WFA_Workflow.Mascaras
{
    public partial class TextEditBGMDemo : TextEdit
    {
        public TextEditBGMDemo()
        {
            InitializeComponent();
        }

        public TextEditBGMDemo(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private eMascara _mascara = eMascara.Default;


        [Category(Constantes.CATEGORIA)]
        [DefaultValue(eMascara.Default)]
        [EditorAttribute(typeof(UITypeEditorBGMRodotecX), typeof(UITypeEditor))]
        public eMascara Mascara
        {
            get { return _mascara; }
            set { _mascara = value; }
        }

        [Category(Constantes.CATEGORIA)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DisplayName("Tamanho campo")]
        [Description("Informa ou retorna o tamanho do campo.\nNome: TamanhoCampo")]
        [DefaultValue(0)]
        public int TamanhoCampo
        {
            get
            {
                return this.Properties.MaxLength;
            }
            set
            {
                this.Properties.MaxLength = value;
            }
        }

        //[Category(Constantes.CATEGORIA)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[DisplayName("Salvar mascara")]
        //[Description("Informa ou retorna se salvar a mascara.\nNome: TamanhoCampo")]
        //[DefaultValue(true)]
        //public bool SalvarMascara
        //{
        //    get
        //    {
        //        return this.Properties.Mask.SaveLiteral;
        //    }
        //    set
        //    {
        //        this.Properties.Mask.SaveLiteral = value;
        //    }
        //}

        protected override void InitLayout()
        {
            base.InitLayout();

            Mascaras.DefinirMascara(this);
        }
        protected override void OnValidating(CancelEventArgs e)
        {
            if (Mascaras.ValidarMascara(this, _dXErrorProvider))
                base.OnValidating(e);
            //ValidarValorConformeMascara(e);
        }

        private DXErrorProvider _dXErrorProvider = new DXErrorProvider();

        private string ValidarValorConformeMascara(CancelEventArgs e = null)
        {
            this._dXErrorProvider.ClearErrors();

            if (_mascara == eMascara.Email && !String.IsNullOrEmpty(base.Text))  // E-mail
            {
                if (this.Text.IndexOf("@").Equals(-1))
                {
                    this._dXErrorProvider.SetError(this, "Entre com um e-mail válido", ErrorType.Critical);
                    this.Focus();
                }
            }
            else if (e != null)
                base.OnValidating(e);

            return _dXErrorProvider.GetError(this);
        }

    }


}
