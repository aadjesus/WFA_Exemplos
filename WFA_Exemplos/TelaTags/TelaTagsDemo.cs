using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    /// <summary>
    /// Panel flutuante para a classe MasterPanel1.
    /// <remarks>
    /// Arquivo criado : 10/9/2012 11:07:27 AM. 
    /// Criado por     : alessandro.augusto.
    /// </remarks>
    /// </summary>
    [ToolboxItem(true)]
    public partial class CmpTelaTags : FGlobus.Componentes.WinForms.MasterPanel
    {
        #region Construtor

        /// <summary>
        /// Inicializador da classe.
        /// </summary>
        public CmpTelaTags()
        {
            InitializeComponent();
        }

        #endregion


        public string Texto
        {
            get
            {
                return this.popupContainerEdit1.Text;
            }
            set { this.popupContainerEdit1.Text = value; }
        }

        private void popupContainerEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            TelaInteira(e.Button.Shortcut.Key);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            TelaInteira(keyData);

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void TelaInteira(Keys keys)
        {
            if (keys.Equals(Keys.F11))
            {
                Control control = new Control();
                DockStyle dockStyle = this.Dock;

                EditorButton editorButton = popupContainerEdit1.Properties.Buttons
                    .OfType<EditorButton>()
                    .Where(w => w.Shortcut.Key.Equals(Keys.F11))
                    .FirstOrDefault();

                control = this.Parent;                

                MasterForm masterForm = new MasterForm();
                masterForm.FormClosing += delegate(object sender, FormClosingEventArgs e)
                {
                    CmpTelaTags masterPanel1 = masterForm.Controls
                        .OfType<CmpTelaTags>()
                        .FirstOrDefault();

                    masterPanel1.Dock = dockStyle;
                    editorButton.Visible = true;
                    masterForm.Controls.Remove(masterPanel1);                   
                    
                    control.Controls.Add(masterPanel1);
                };

                masterForm.Shown += delegate(object sender, EventArgs e)
                {
                    editorButton.Visible = false;
                    this.Dock = DockStyle.Fill;
                };

                masterForm.Controls.Add(this);
                masterForm.ShowDialog();
            }

        }


    }
}