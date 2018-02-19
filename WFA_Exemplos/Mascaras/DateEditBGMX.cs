using System.ComponentModel;
using System.Drawing.Design;
using DevExpress.XtraEditors;
using FGlobus.Util;

namespace WFA_Workflow.Mascaras
{
    public partial class DateEditBGMX : DateEdit
    {
        public DateEditBGMX()
        {
            InitializeComponent();
        }

        public DateEditBGMX(IContainer container)
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

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Mascaras.DefinirMascara(this);
        }

    }
}
