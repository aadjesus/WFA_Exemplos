using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WFA_Workflow
{
    public partial class FrmTamanhoMemoEdit : XtraForm
    {
        public FrmTamanhoMemoEdit()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Size sizeTextoMensagem = TextRenderer.MeasureText(this.memoEdit1.Text, this.memoEdit1.Font);
            this.memoEdit2.Text = this.memoEdit1.Text;
            this.memoEdit2.Size = sizeTextoMensagem;

            
            this.ActiveControl = this.simpleButton1;
            
            
        }
    }
}
