using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FGlobus.Componentes.WinForms;

namespace WFA_Exemplos.GroupControlBGM
{
    public partial class GroupControlBGMDemoX : GroupControl
    {
        public GroupControlBGMDemoX()
        {
            InitializeComponent();
            this.CriarControles();
        }

        public GroupControlBGMDemoX(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.CriarControles();
        }

        private PanelControl _pnlCtrlTitulo;
        private LabelControlBGM _lblCtrlBGM;
        private ButtonEdit _btnEdt;
        private const string TITULO = "[Informe o título]";
        private eOcultar _ocultarControle = eOcultar.None;
        private Image _image;

        private void GroupControlBGMDemoX_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (_pnlCtrlTitulo == null)
                return;

            Action<Color, int, int, int, int> actionGraphics =
                (cor, x1, y1, x2, y2) => e.Graphics.DrawLine(new Pen(cor), x1, y1, x2, y2);

            actionGraphics(SystemColors.ButtonShadow, 1, _pnlCtrlTitulo.Height + 2, Width - 2, _pnlCtrlTitulo.Height + 2);
            actionGraphics(SystemColors.ButtonHighlight, 1, _pnlCtrlTitulo.Height + 3, Width - 2, _pnlCtrlTitulo.Height + 3);
        }

        [Description("Informa ou retorna os botõe do controle.\nName: Botoes")]
        [DisplayName("2) Botões")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RefreshProperties(RefreshProperties.All)]
        public EditorButtonCollection Botoes
        {
            get
            {
                this.DefinirTamanho();
                return this.ButtonOpcoes.Properties.Buttons;
            }
        }

        [Description("Informa ou retorna os botõe do controle.\nName: Botoes")]
        [DisplayName("1) Titulo")]
        [DefaultValue(GroupControlBGMDemoX.TITULO)]
        public string Titulo
        {
            get
            {
                return this.LabelTitulo.Text;
            }
            set { _lblCtrlBGM.Text = value; }
        }
        

        [DisplayName("3) OcultarControle")]
        [RefreshProperties(RefreshProperties.Repaint)]
        [DefaultValue(eOcultar.None)]
        [EditorAttribute(typeof(UITypeEditorBGMRodotec), typeof(UITypeEditor))]
        public eOcultar OcultarControle
        {
            get { return _ocultarControle; }
            set { _ocultarControle = value; }
        }        

        private void GroupControlBGMDemoX_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control.Top <= 50)
                e.Control.Top = 55;
        }

        private void DefinirTamanho()
        {
            if (_btnEdt == null)
                return;

            int tama = this.ButtonOpcoes.Properties.Buttons
                .OfType<EditorButton>()
                .Where(w => w.Visible)
                .Count(w => w.Visible) * 20;

            this.ButtonOpcoes.Width = tama;
        }

        private void CriarControles()
        {
            if (_pnlCtrlTitulo != null)
                return;

            _pnlCtrlTitulo = new PanelControl()
            {
                Dock = System.Windows.Forms.DockStyle.Top,
                BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder,
                Size = new Size(0, 25),
                Padding = new Padding(3, 0, 3, 1),
                BackColor = Color.Gainsboro
            };

            _pnlCtrlTitulo.Controls.Add(this.ButtonOpcoes);
            _pnlCtrlTitulo.Controls.Add(this.LabelTitulo);
            this.Controls.Add(_pnlCtrlTitulo);
        }

        private ButtonEdit ButtonOpcoes
        {
            get
            {
                if (_btnEdt == null)
                {
                    _btnEdt = new ButtonEdit()
                    {
                        Dock = DockStyle.Right,
                        BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
                    };
                    _btnEdt.Properties.AutoHeight = false;
                    _btnEdt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                    _btnEdt.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
                    _btnEdt.Properties.Appearance.Options.UseBackColor = true;
                    _btnEdt.Properties.Buttons.Clear();
                }
                return _btnEdt;
            }
        }

        private LabelControlBGM LabelTitulo
        {
            get
            {
                if (_lblCtrlBGM == null)
                    _lblCtrlBGM = new LabelControlBGM()
                    {
                        AutoSizeMode = LabelAutoSizeMode.None,
                        Dock = System.Windows.Forms.DockStyle.Left,
                        Text = "aaaaaa1"
                    };

                return _lblCtrlBGM;
            }
        }

        protected override void CreateHandle()
        {
            this.DefinirTamanho();
            base.CreateHandle();
        }

        internal Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public enum eOcultar
        {
            None = 0,
            Top = 1,
            Bottom = 2,
            Left = 3,
            Right = 4
        }

    }
}