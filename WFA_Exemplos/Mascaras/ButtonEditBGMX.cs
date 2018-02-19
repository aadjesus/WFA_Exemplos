using System.ComponentModel;
using System.Drawing.Design;
using DevExpress.XtraEditors;
using FGlobus.Util;

namespace WFA_Workflow.Mascaras
{
    public partial class ButtonEditBGMX : ButtonEdit
    {
        public ButtonEditBGMX()
        {
            InitializeComponent();
        }

        public ButtonEditBGMX(IContainer container)
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

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Mascaras.DefinirMascara(this);
        }
    }
}
