using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Constantes = FGlobus.Util.Constantes;

namespace WFA_Exemplos.ButtonEditBGM
{
    [ToolboxItem(true)]
    public class TextButtonBGM : BaseEdit
    {
        private ButtonEdit _buttonEdit;
        private bool _segBotaoProximo;


        private ButtonEdit ButtonEdit
        {
            get
            {
                if (_buttonEdit == null)
                {
                    _buttonEdit = new ButtonEdit()
                    {
                        Dock = System.Windows.Forms.DockStyle.Fill
                    };

                    _buttonEdit.Properties.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
                    _buttonEdit.Properties.Buttons[0].Image = WFA_Exemplos.Properties.Resources.ButtonEditBGMLupa;

                    this.Controls.Add(_buttonEdit);
                }
                return _buttonEdit;
            }
        }


        protected override void OnEnter(EventArgs e)
        {
            _buttonEdit.Focus();
            base.OnEnter(e);
        }

        /// <summary>
        /// Construtor default.
        /// </summary>
        public TextButtonBGM()
        {


            //_comboBoxEdit.KeyDown += new KeyEventHandler(this.OnPedeEmpresaKeyDown);

            //this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Properties.AutoHeight = false;
            this.Width = 50;
            this.Height = 20;
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, System.Windows.Forms.BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, ButtonEdit.Height, specified);
        }


        /// <summary>
        /// (Set/Get) Informa ou retorna se adiciona botão para calcula o próximo.
        /// </summary>
        [Category(Constantes.CATEGORIA)]
        [DisplayName("7) Botão calcular próximo")]
        [Description("Informa ou retorna se adiciona botão para calcular o próximo.\nName: SegBotaoProximo")]
        [DefaultValue(false)]
        [RefreshProperties(RefreshProperties.All)]
        public bool SegBotaoProximo
        {
            get
            {
                return _segBotaoProximo;
            }
            set
            {
                _segBotaoProximo = value;

                EditorButton editorButton = _buttonEdit.Properties.Buttons
                    .OfType<EditorButton>()
                    .FirstOrDefault(w => w.Kind == ButtonPredefines.Plus);

                if (_segBotaoProximo)
                {
                    if (editorButton == null)
                    {
                        editorButton = new EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus);

                        _buttonEdit.Properties.BeginUpdate();
                        _buttonEdit.Properties.Buttons.Add(editorButton);
                        _buttonEdit.Properties.EndUpdate();
                    }

                    //if (!UtilComponentes.Designer)
                    //{
                    //    editorButton.Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Add);
                    //    editorButton.SuperTip = UtilComponentes.CriarSuperToolTip(FGlobus.Mensagens.Frameworks.ButtonEditBGM_ProximoCodigo);
                    //    editorButton.Tag = FGlobus.Util.Constantes.COMPONENTE_DE_CONTROLE_INTERNO;
                    //}
                }
                else if (editorButton != null)
                    _buttonEdit.Properties.Buttons.RemoveAt(editorButton.Index);
            }
        }
    }
}
