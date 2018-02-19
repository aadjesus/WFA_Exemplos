using System;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmDateEditBGM : MasterForm
    {
        public FrmDateEditBGM()
        {
            InitializeComponent();
        }

        private void FrmDiversos_Shown(object sender, EventArgs e)
        {
            Inicializacao.Sistema = "GFO";
            Inicializacao.Usuario = "Manager";
        }

        public enum eSentidoNavegacao
        {
            /// <summary>
            /// Estado normal
            /// </summary>
            None = 0,
            /// <summary>
            /// Pressionou ENTER
            /// </summary>
            Fore = 1,
            /// <summary>
            /// Pressionou ESC
            /// </summary>
            Back = 2
        }

        //private eSentidoNavegacao _sentidoNavegacao = eSentidoNavegacao.None;
        //private bool _sentidoNavegacaoIgualNone = false;

        //protected override bool ProcessTabKey(bool forward)
        //{
        //    _sentidoNavegacao = _sentidoNavegacaoIgualNone
        //        ? eSentidoNavegacao.None
        //        : forward
        //            ? eSentidoNavegacao.Fore
        //            : eSentidoNavegacao.Back;

        //    return base.ProcessTabKey(forward);
        //}

        //private void FrmDateEditBGM_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    bool enter = ((int)e.KeyChar).Equals((int)Keys.Enter);
        //    bool esc = ((int)e.KeyChar).Equals((int)Keys.Escape);

        //    if (enter || esc)
        //        this.ProcessTabKey(enter);

        //}

        //private void FrmDateEditBGM_KeyDown(object sender, KeyEventArgs e)
        //{
        //    _sentidoNavegacao = eSentidoNavegacao.None;
        //    base.OnKeyDown(e);
        //}

        //private void FrmDateEditBGM_KeyUp(object sender, KeyEventArgs e)
        //{
        //    _sentidoNavegacao = eSentidoNavegacao.None;
        //    base.OnKeyUp(e);
        //}

    }
}

