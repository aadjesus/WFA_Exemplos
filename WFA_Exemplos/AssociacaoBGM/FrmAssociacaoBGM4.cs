using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGlobus.Util.ExtensaoLinq;
using FGlobus.Util.ExtensaoEnum;
using FGlobus.Util;
using DevExpress.XtraEditors.Repository;
using System.Xml.Serialization;
using DevExpress.XtraEditors.Controls;
using FGlobus.Componentes.WinForms;
using DevExpress.XtraGrid.Views.Base;

namespace WFA_Exemplos.AssociacaoBGM
{
    public partial class FrmAssociacaoBGM4 : Form
    {
        public FrmAssociacaoBGM4()
        {
            InitializeComponent();

        }

        IEnumerable<Cadastro> listaCadastro = null;
        List<Associacao> listaAssociacao = new List<Associacao>();
        List<Movimentacao> listaMovimentacao = new List<Movimentacao>();

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Movimentacao linhaAnterior = gridView1.GetRow(e.PrevFocusedRowHandle) as Movimentacao;

            listaAssociacao.AddRange(associacaoBGM1.RetornarAssociados<Cadastro>()
                .Select(s => new Associacao()
                {
                    CodigoCadastro = s.Codigo,
                    CodigoMovimentacao = linhaAnterior.CodigoMovimentacao
                })
                .ToArray());

            Movimentacao linhaAtual = gridView1.GetRow(e.FocusedRowHandle) as Movimentacao;

            IEnumerable<Associacao> listaAssociacao1 = listaAssociacao
                    .Where(w => w.CodigoMovimentacao == linhaAtual.CodigoMovimentacao);

            //associacaoBGM1.GridViewAssociados.FilteredColumnsCount


            associacaoBGM1.PopularDisponiveis(
                listaCadastro,
                listaAssociacao1);
        }

        private void FrmAssociacaoBGM4_Shown(object sender, EventArgs e)
        {
            listaCadastro = Enumerable.Range(0, 10)
                .Select(s => new Cadastro()
                {
                    Codigo = s,
                    Descricao = s.GetHashCode().ToString(),
                });


            listaMovimentacao = Enumerable.Range(0, 5)
               .Select(s => new Movimentacao()
               {
                   CodigoMovimentacao = s,
                   CodigoCadastro = s,
                   Data = DateTime.Now.AddDays(s),
                   myEnum = s == 1
                        ? MyEnum.aaaa
                        : s == 3
                            ? MyEnum.bbbb
                            : MyEnum.cccc
               })
               .ToList();

            listaAssociacao.Add(new Associacao() { CodigoCadastro = 1, CodigoMovimentacao = 1 });

            //var listaX = Enum.GetValues(typeof(MyEnum))
            //    .OfType<MyEnum>()
            //    .Select(s => new ComboBoxItem() { Value = })
            //    .ToArray();

            //repositoryItemImageComboBox1.PopularRepository<MyEnum>();
            //gridView1.Columns["myEnum"].ColumnEdit = repositoryItemImageComboBox1;

            //(gridControl1.MainView as ColumnView)
            //    .Columns["myEnum"].AdicionarRepositoryNaColuna<MyEnum>();

            // gridView1.Columns["myEnum"].Tag = "ENUMERADOR-MyEnum";
            //gridView1.DefinirCaracteristicas();

            gridControl1.DataSource = listaMovimentacao;

            //CheckedListBoxItem a1; //repositoryItemCheckedComboBoxEdit1.Items.AddRange(listaX);
            //ComboBoxItem       a2; //repositoryItemComboBox1.Items.AddRange(listaX);
            //ImageComboBoxItem  a3; //repositoryItemImageComboBox1.Items.AddRange(listaX);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridView1.Columns["myEnum"].Tag = "ENUMERADOR-MyEnum";

            listaMovimentacao.Add(new Movimentacao()
            {
                CodigoCadastro = listaMovimentacao.Count + 10,
                CodigoMovimentacao = listaMovimentacao.Count + 20,
                myEnum = MyEnum.cccc
            });

            gridControl1.DataSource = listaMovimentacao
                .ToList();
        }

        private void associacaoBGM1_ClickBotaoConsultar(object sender)
        {
            //associacaoBGM1.GridViewDisponiveis.ActiveFilter

        }

    }

    class Movimentacao
    {
        public int CodigoMovimentacao { get; set; }
        public int CodigoCadastro { get; set; }

        public DateTime Data { get; set; }

        public MyEnum myEnum { get; set; }

    }

    class Cadastro
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

    }


    enum MyEnum
    {
        [XmlEnum("1=aaaa")]
        aaaa,
        [XmlEnum("2=bbbb")]
        bbbb,
        [XmlEnum("3=cccc")]
        cccc
    }


    class Associacao
    {
        public int CodigoMovimentacao { get; set; }
        public int CodigoCadastro { get; set; }
    }


}
