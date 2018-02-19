using System;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow
{
    public partial class FrmSelecionaDescricao : MasterForm
    {
        public FrmSelecionaDescricao()
        {
            InitializeComponent(); 



        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionaDescricaoBGM1.Limpar();
        } 
    }
}
