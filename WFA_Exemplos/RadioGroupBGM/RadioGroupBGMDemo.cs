using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace WFA_Workflow.RadioGroupBGM
{
    public partial class RadioGroupBGMDemo : GroupControl
    {
        public RadioGroupBGMDemo()
        {
            InitializeComponent();
        }

        public RadioGroupBGMDemo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();


        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        private void CriarRadioGroup()
        {
            if (_radioGroup1 == null)
            {
                _radioGroup1 = new RadioGroup()
                {
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    BorderStyle = BorderStyles.NoBorder,

                };
                _radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
                _radioGroup1.Properties.Appearance.Options.UseBackColor = true;

                this.Controls.Add(_radioGroup1);
            }
        }



        RadioGroup _radioGroup1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.ComponentModel.Design.CollectionEditor, System.Design", typeof(UITypeEditor))]
        public RadioGroupItemCollection Items
        {
            get
            {
                if (_radioGroupItemCollection == null)
                    _radioGroupItemCollection = new RadioGroupItemCollection();

                if (_radioGroup1 == null)
                    CriarRadioGroup();

                _radioGroup1.Properties.Items.AddRange(_radioGroupItemCollection
                    .OfType<RadioGroupItem>()
                    .Except(_radioGroup1.Properties.Items
                                .OfType<RadioGroupItem>())
                    .ToArray());

                base.Invalidate();

                return _radioGroupItemCollection;
            }
        }


        public int QtdeColunas
        {
            get
            {
                return _radioGroup1.Properties.Columns;
            }
            set
            {
                _radioGroup1.Properties.Columns = value;
            }
        }

        private RadioGroupItemCollection _radioGroupItemCollection;

    }
}
