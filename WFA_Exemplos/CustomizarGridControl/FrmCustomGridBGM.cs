using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using FGlobus.Componentes.WinForms;

namespace WFA_Exemplos.CustomizarGridControl
{
    public partial class FrmCustomGridBGM : Form
    {
        public FrmCustomGridBGM()
        {
            InitializeComponent();

            gridControl1.DataSource = Enumerable.Range(1, 20)
                .Select(s => new
                {
                    Codigo = s,
                    Descricao = s.ToString(),
                    Grupo = s / 5,
                    Valor = s <= 2
                        ? 1.1234m
                        : s % 3
                })
                .ToArray();





            //Inicializacao.Usuario = "MANAGER";
            //Inicializacao.Sistema = "CTR";
            //gridControl1.DataSource = Inicializacao.GaragensSistema
            //    .Select(s => new
            //    {
            //        s.CodigoEmpresa,
            //        s.CodigoFl,
            //        s.Garagem.BairroGa,
            //        s.Garagem.CepGa,
            //        s.Garagem.CidadeGa,
            //        s.Garagem.CodigoGa,
            //        s.Garagem.CodigoUf,
            //        s.Garagem.CodMunic,
            //        s.Garagem.ComplendGa,
            //        s.Garagem.EnderecoGa,
            //        s.Garagem.MicroRegiao_1,
            //        s.Garagem.MicroRegiao_2,
            //        s.Garagem.MicroRegiao_3,
            //        s.Garagem.MicroRegiao_4,
            //        s.Garagem.NomeGa,
            //        s.Garagem.NumeroEndGa,
            //    })
            //    .ToArray();

            this.gridView1.DefinirCaracteristicas();

        }

        private void FrmCustomGridBGM_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCustomGridBGM_Leave(object sender, EventArgs e)
        {

        }

        private void FrmCustomGridBGM_Load(object sender, EventArgs e)
        {

        }

        private void FrmCustomGridBGM_Shown(object sender, EventArgs e)
        {

        }

        private void spinEdit1_EditValueChanging(object sender, ChangingEventArgs e)
        {
            panelControl1.Height = (int)spinEdit1.Value;
            panelControl1.Refresh();
        }

    }
}
