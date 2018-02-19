using System.ComponentModel;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmSimpleButtonBGM : Form
    {
        public FrmSimpleButtonBGM()
        {
            InitializeComponent();
            simpleButtonBGM13.Validating += new CancelEventHandler(simpleButtonBGM13_Validating);
            
            simpleButtonBGM13.CausesValidationChanged += new System.EventHandler(simpleButtonBGM13_CausesValidationChanged);
            simpleButtonBGM13.Validated += new System.EventHandler(simpleButtonBGM13_Validated);            
        }

        void simpleButtonBGM13_CausesValidationChanged(object sender, System.EventArgs e)
        {
            //C:\Users\alessandro.augusto\Documents\Visual Studio\Exemplos_Meus\WFA_Exemplos\WFA_Workflow\FrmBarManager.cs
        }

        void simpleButtonBGM13_Validated(object sender, System.EventArgs e)
        {
            simpleButtonBGM13.DialogResult = checkEdit1.Checked
                ? System.Windows.Forms.DialogResult.OK
                : System.Windows.Forms.DialogResult.No;
        }

        private void simpleButtonBGM13_Click(object sender, System.EventArgs e)
        {
            if (simpleButtonBGM13.DialogResult == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("ok");
        }

        void simpleButtonBGM13_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = checkEdit1.Checked;
        }
    }
}
