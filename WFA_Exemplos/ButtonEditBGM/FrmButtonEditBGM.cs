using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGlobus.Componentes.WinForms;

namespace WFA_Exemplos.ButtonEditBGM
{
    public partial class FrmButtonEditBGM : Form
    {
        public FrmButtonEditBGM()
        {
            InitializeComponent();
        }

        private eSentidoNavegacao _sentidoNavegacao = eSentidoNavegacao.None;
        private Control _primeiroControle;
        private bool _workflow = false;
        private bool _habilitarKeyPress = true;
        private bool _sentidoNavegacaoIgualNone = false;

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


        #region Override

        /// <summary>
        /// Sobreposição do método para controlar o ENTER e o ESC.
        /// </summary>
        /// <param name="e">Objeto do tipo KeyPressEventArgs.</param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (this._habilitarKeyPress)
            {
                bool enter = ((int)e.KeyChar).Equals((int)Keys.Enter);
                bool esc = ((int)e.KeyChar).Equals((int)Keys.Escape);

                if (enter || esc)
                    this.ProcessTabKey(enter);
            }
        }

        /// <summary>
        /// Sobreposição do método para redefinir a variavel "_sentidoNavegacao".
        /// </summary>
        /// <param name="e">Objeto do tipo KeyEventArgs.</param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            _sentidoNavegacao = eSentidoNavegacao.None;
            base.OnKeyDown(e);
        }

        /// <summary>
        /// Sobreposição do método para redefinir a variavel "_sentidoNavegacao".
        /// </summary>
        /// <param name="e">Objeto do tipo KeyEventArgs.</param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            _sentidoNavegacao = eSentidoNavegacao.None;
            base.OnKeyUp(e);
        }

        /// <summary>
        /// Sobreposição do método para redefinir a variavel "_sentidoNavegacao".
        /// </summary>
        /// <param name="forward">Bool.</param>
        protected override bool ProcessTabKey(bool forward)
        {
            _sentidoNavegacao = _sentidoNavegacaoIgualNone
                ? eSentidoNavegacao.None
                : forward
                    ? eSentidoNavegacao.Fore
                    : eSentidoNavegacao.Back;

            return base.ProcessTabKey(forward);
        }

        /// <summary>
        /// Simula ENTER alterando o sentido da navegação para None.
        /// </summary>
        /// <param name="sentidoNavegacao">SentidoNavegacao</param>
        public void SimulaEnter(eSentidoNavegacao sentidoNavegacao = eSentidoNavegacao.None)
        {
            _sentidoNavegacao = sentidoNavegacao;
            base.ProcessTabKey(true);
        }

        /// <summary>
        /// Sobreposição do método para focar o primeiro controle quando informado.
        /// </summary>
        /// <param name="e">Objeto do tipo EventArgs.</param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_workflow)
                this.TopLevel = false;

            if (_primeiroControle != null)
                this.FocaNoControle(_primeiroControle);
        }

        #endregion


        /// <summary>
        /// Trabalha o tipo do componente antes de focar no mesmo
        /// </summary>
        /// <param name="controle">BaseControl, componente que recebe o foco</param>
        internal void FocaNoControle(Control controle)
        {
            if (controle is PedeEmpresaBGM)
                (controle as PedeEmpresaBGM).Focus();
            else if (controle is PedeFilialBGM)
                (controle as PedeFilialBGM).Focus();
            else if (controle is PedeGaragemBGM)
                (controle as PedeGaragemBGM).Focus();
            else if (controle is AutorizaBGM)
                (controle as AutorizaBGM).FocarOrigemOuDestino();
            else
                controle.Focus();
        }
    }
}
