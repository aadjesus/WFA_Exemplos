using System.ComponentModel;
using System.Drawing.Design;
using DevExpress.XtraEditors;
using FGlobus.Util;

namespace WFA_Workflow.Mascaras
{
    public partial class CalcEditBGMX : CalcEdit
    {
        public CalcEditBGMX()
        {
            InitializeComponent();
        }

        public CalcEditBGMX(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private eMascara _mascara = eMascara.Default;
        private int _casasDecimais;
        private decimal _valorMinimo;
        private decimal _valorMaximo;

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

        [Category(Constantes.CATEGORIA)]
        [DisplayName("Casas decimais")]
        [Description("Informa ou retorna a quantidade de casas decimais.\nNome: CasasDecimais")]
        [DefaultValue(2)]
        public int CasasDecimais
        {
            get
            {
                return _casasDecimais;
            }
            set
            {
                _casasDecimais = value;
            }
        }


        /// <summary>
        /// (Set\Get) Informa ou retorna o ValorMinimo.
        /// </summary>
        [Category(Constantes.CATEGORIA)]
        [DisplayName("Valor mínimo")]
        [Description("Informa ou retorna o valor mínimo.\nNome: ValorMinimo")]
        public decimal ValorMinimo
        {
            get
            {
                return _valorMinimo;
            }
            set
            {
                _valorMinimo = value;
            }
        }

        /// <summary>
        /// (Set\Get) Informa ou retorna o ValorMaximo.
        /// </summary>
        [Category(Constantes.CATEGORIA)]
        [DisplayName("Valor máximo")]
        [Description("Informa ou retorna o valor máximo.\nNome: ValorMaximo")]
        public decimal ValorMaximo
        {
            get
            {
                return _valorMaximo;
            }
            set
            {
                _valorMaximo = value;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Mascaras.DefinirMascara(this);
        }

    }
}
