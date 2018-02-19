using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WFA_Workflow.AutorizaGridsBGMx
{
    public partial class FrmAssociacaoBGMDemo2 : Form
    {
        public FrmAssociacaoBGMDemo2()
        {
            InitializeComponent(); 
        }

        public class CadastroDTO
        {
            public int Cod { get; set; }
            public string Desc { get; set; }
            public bool Cond { get; set; }
        }

        public class AssociacaoDTO
        {
            public int Cod { get; set; }
            public int CodMyClass { get; set; }
            public bool CondMyClass { get; set; }
        }

        List<CadastroDTO> listaCadastro = new List<CadastroDTO>();
        List<AssociacaoDTO> listaAssociacao = new List<AssociacaoDTO>();

        private void FrmAutorizaGridsBGMx_Shown(object sender, EventArgs e)
        {

            listaCadastro.Add(new CadastroDTO() { Cod = 1, Desc = "aaaaa", Cond = true });
            listaCadastro.Add(new CadastroDTO() { Cod = 2, Desc = "bbbbb", Cond = true });
            listaCadastro.Add(new CadastroDTO() { Cod = 3, Desc = "ccccc", Cond = true });
            listaCadastro.Add(new CadastroDTO() { Cod = 4, Desc = "ddddd", Cond = true });
            listaCadastro.Add(new CadastroDTO() { Cod = 5, Desc = "eeeee", Cond = false });
            listaCadastro.Add(new CadastroDTO() { Cod = 6, Desc = "fffff", Cond = false });
            listaCadastro.Add(new CadastroDTO() { Cod = 7, Desc = "ggggg", Cond = false });
            gridControllistaCadastrados.DataSource = listaCadastro;

            listaAssociacao.Add(new AssociacaoDTO() { Cod = 1, CodMyClass = 1, CondMyClass = true });
            listaAssociacao.Add(new AssociacaoDTO() { Cod = 1, CodMyClass = 2, CondMyClass = true });
            listaAssociacao.Add(new AssociacaoDTO() { Cod = 1, CodMyClass = 3 });

            gridControllistaAssociacao.DataSource = listaAssociacao;

            radioGroup1.SelectedIndex = 0;
            radioGroup1_SelectedIndexChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            autorizaGridBGMx21.LimparListas();
            switch (radioGroup1.SelectedIndex)
            {
                case 0: autorizaGridBGMx21.PopularDisponiveis<CadastroDTO>(listaCadastro);
                    break;
                //case 1: autorizaGridBGMx21.PopularAssociados<CadastroDTO>(listaCadastro);
                //    break;
                //case 2: autorizaGridBGMx21.PopularDisponiveis<CadastroDTO, AssociacaoDTO>(listaCadastro, listaAssociacao);
                //    break;
                //case 3: autorizaGridBGMx21.PopularAssociados<CadastroDTO, AssociacaoDTO>(listaCadastro, listaAssociacao);
                //    break;
            }

            //gridControl3.DataSource = autorizaGridBGMx21.RetornarAssociados<CadastroDTO>().ToArray();
        }
    }
}
