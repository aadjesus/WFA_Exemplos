using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FGlobus.Componentes.WinForms;

namespace WFA_Workflow.AutorizaGridsBGMx
{
    public partial class FrmAssociacaoBGMDemo1 : MasterFormCadastro
    {
        public FrmAssociacaoBGMDemo1()
        {
            InitializeComponent();
        }

        private void FrmAssociacaoBGMDemo1_HabilitarBotoes(object sender)
        {
            smpBtnBGMExcluirMFCadastro.Habilita = associacaoBGM1.QtdeAssociado != 0;
        }

        public class Cadastro
        {
            public int ID { get; set; }
            public int Cod { get; set; }
            public string Desc { get; set; }
            public string Ape { get; set; }
        }
        
        public class Associativa
        {
            public int IDCadastro { get; set; }
            public int ID { get; set; }
        }

        private void FrmAssociacaoBGMDemo1_Shown(object sender, EventArgs e)
        {
            List<Cadastro> listaCadastro = new List<Cadastro>();
            listaCadastro.Add(new Cadastro() { ID = 1, Cod = 1, Desc = "Descição", Ape = "Apedlido" });
            listaCadastro.Add(new Cadastro() { ID = 2, Cod = 2, Desc = "Descição", Ape = "Apedlido" });
            listaCadastro.Add(new Cadastro() { ID = 3, Cod = 1, Desc = "Descição", Ape = "Apedlido" });
            listaCadastro.Add(new Cadastro() { ID = 4, Cod = 1, Desc = "Descição", Ape = "Apedlido" });

            List<Associativa> listaAssociativa = new List<Associativa>();
            listaAssociativa.Add(new Associativa() { IDCadastro = 1, ID = 1 });
            listaAssociativa.Add(new Associativa() { IDCadastro = 2, ID = 2 });

            associacaoBGM1.PopularDisponiveis<Cadastro, Associativa>(listaCadastro, listaAssociativa);
        }
      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Type type = this.FindForm().GetType();
            Form form = (Form)Activator.CreateInstance(type);
            form.ShowDialog();
        }

        private void associacaoBGM1_ClickBotaoConsultar(object sender)
        {
            MessageBox.Show("");
        }
    }
}
