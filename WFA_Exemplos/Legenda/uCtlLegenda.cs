using System.Drawing;
using System.Windows.Forms;

namespace WFA_Workflow.Legenda
{
    public partial class uCtlLegenda : UserControl
    {
        public uCtlLegenda()
        {
            InitializeComponent();
        }

        public uCtlLegenda(string titulo)
        {
            InitializeComponent();

            labelControl1.Text = titulo;
        }

        public uCtlLegenda(string titulo, Color cor)
        {
            InitializeComponent();

            labelControl1.Text = titulo;
            panelControl2.BackColor = cor;
        }

        public uCtlLegenda(string titulo, Color cor, string toolTip)
        {
            InitializeComponent();

            labelControl1.Text = titulo;
            panelControl2.BackColor = cor;

            //this.toolTip = toolTip;
        }
    }
}
