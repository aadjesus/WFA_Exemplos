using System;
using System.Windows.Forms;

namespace WFA_Workflow.InscricaoEstadual
{
    public partial class FrmInscricaoEstadual : Form
    {
        public FrmInscricaoEstadual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Concat(ex));
            }

        }
    }
}
