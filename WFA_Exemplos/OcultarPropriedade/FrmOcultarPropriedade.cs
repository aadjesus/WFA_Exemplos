using System;
using System.Windows.Forms;

namespace WFA_Workflow
{
    public partial class FrmOcultarPropriedade : Form
    {
        public FrmOcultarPropriedade()
        {
            InitializeComponent();
        }

        private void cmpOcultarPropriedade1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = null;// Refresh();
            propertyGrid1.SelectedObject = cmpOcultarPropriedade1;
        }
    }
}

