using System;
using System.Windows.Forms;

namespace WFA_Workflow.Shortcut
{
    public partial class FrmSimpleButtonComShortcut : Form
    {
        public FrmSimpleButtonComShortcut()
        {
            InitializeComponent();
        }

        private void simpleButtonComShortcut1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Concat((sender as SimpleButtonComShortcut).Shortcut));
        }
    }
}
