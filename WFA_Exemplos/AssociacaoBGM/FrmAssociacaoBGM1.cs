using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using FGlobus.Componentes.WinForms;


namespace WFA_Workflow.AssociacaoBGM
{

    //  Desenvolvido novo componente para associar e desassociar item
    //  20073;20058;20052;20000;19857;19855;19623;19539;19151;19147;19046;18960;18936;18931;18922;18915;18735;18686;
    public partial class FrmAssociacaoBGM1 : XtraForm
    {
        public FrmAssociacaoBGM1()
        {
            InitializeComponent();

        }

        public enum MyEnum
        {
            aaaaa = 1, 
            bbbbb = 2,
            condicao
        }
        public class Demo
        {
            public int ID { get; set; }
            public int Cod { get; set; }
            public int? Cod2 { get; set; }
            public string Desc { get; set; }
            public string Ape { get; set; }
            public MyEnum MyEnumX { get; set; }
            public Cadastro Cadastro1 { get; set; }
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

        private void Teste_NomeMetodo()
        {
            //BGMRodotec YYYY/MM/DD: 01-01-2008
        
        

            List<Cadastro> listaCadastro = new List<Cadastro>();
            listaCadastro.Add(new Cadastro() { ID = 1, Cod = 1, Desc = "Descição", Ape = "Apedlido"  });
            listaCadastro.Add(new Cadastro() { ID = 2, Cod = 2, Desc = "Descição", Ape = "Apedlido" });
            listaCadastro.Add(new Cadastro() { ID = 3, Cod = 1, Desc = "Descição", Ape = "Apedlido" });
            listaCadastro.Add(new Cadastro() { ID = 4, Cod = 1, Desc = "Descição", Ape = "Apedlido" });

            List<Associativa> listaAssociativa = new List<Associativa>();
            listaAssociativa.Add(new Associativa() { IDCadastro = 1, ID = 1 });
            listaAssociativa.Add(new Associativa() { IDCadastro = 2, ID = 2 });

            associacaoBGM5.PopularDisponiveis(listaCadastro, listaAssociativa);
             
        }

        List<Demo> listaPneuDTO = null;
        private void FrmTeste_Shown(object sender, EventArgs e)
        {
            listaPneuDTO = new List<Demo>();
            listaPneuDTO.Add(new Demo() { MyEnumX = MyEnum.aaaaa, ID = 1, Cod = 1, Desc = "Descição", Ape = "Apedlido", Cadastro1 = new Cadastro() { Ape = "1", Cod = 1 } });
            listaPneuDTO.Add(new Demo() { MyEnumX = MyEnum.aaaaa, ID = 2, Cod = 2, Cod2 = 2, Desc = "Descição", Ape = "Apedlido" });
            listaPneuDTO.Add(new Demo() { MyEnumX = MyEnum.condicao, ID = 3, Cod = 3, Cod2 = 3, Desc = "Descição", Ape = "Apedlido" });
            listaPneuDTO.Add(new Demo() { MyEnumX = MyEnum.aaaaa, ID = 4, Cod = 4, Cod2 = 4, Desc = "Descição", Ape = "Apedlido" });

            associacaoBGM5.PopularDisponiveis(listaPneuDTO
                .Select(s => new
                {
                    ID = s.ID,
                    Cod = s.Cod,
                    Cod2 = s.Cod2,
                    MyEnumX = (s.MyEnumX == MyEnum.condicao
                        ? "Condição"
                        : s.MyEnumX.ToString()),

                    objeto = s

                    //Desc = s.Desc,
                    //ApeXXXX = s.Ape,
                    //OK = true,
                    //Data = DateTime.Now
                })
                );
            
            Random aaa = new Random(5000);
            gridControl1.DataSource = Enumerable
                .Range(0, 5000)
                .Select((s, index) => new Demo()
                {
                    ID = s,
                    Desc = aaa.NextDouble().ToString()
                })
                .ToArray();

            //ID Cod Cod2 Desc ApeXXXX OK Data


            //BandedGridColumn

            //(((GridControl)(((SplitContainerControl)(associacaoBGM5.Controls[0].Controls[2])).Panel1.Controls[0].Controls[0])).MainView as AdvBandedGridView).Columns[0].Visible = false;
            //(((GridControl)(((SplitContainerControl)(associacaoBGM5.Controls[0].Controls[2])).Panel1.Controls[0].Controls[0])).MainView as AdvBandedGridView).Columns[0].OptionsColumn.ShowInCustomizationForm = false;

            //StyleFormatCondition aa = new StyleFormatCondition();
            //aa.Condition = FormatConditionEnum.Expression

            //advBandedGridView1.OptionsColumn.AllowEdit = coluna.ColunaEditavel;
            //advBandedGridView1.DisplayFormat.FormatString = coluna.FormatString;
            //advBandedGridView1.DisplayFormat.FormatType = coluna.FormatType;

        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            //xtraTabControl1.Selected
            MessageBox.Show("a");
        }

        private void xtraTabControl1_Selecting(object sender, DevExpress.XtraTab.TabPageCancelEventArgs e)
        {
            MessageBox.Show("b");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panelControl2.Parent
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
             
            if (associacaoBGM5.ExisteAssociacao)
                associacaoBGM5.RetornarAssociados<Demo>()
                    .Aggregate(listBoxControl1.Items, (a, b) =>
                    {
                        a.Add(String.Concat(b.ID, "->", b.Cod, "->", b.Cod2, "->", b.Desc, "->", b.Ape));
                        return a;
                    });

            MessageBox.Show(String.Join(
                Environment.NewLine,
                    associacaoBGM5.RetornarAssociados<Demo, int>(p => p.ID)
                        .ToArray()));
        }

        private void propertyGrid1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.DisplayFormat.FormatType == DevExpress.Utils.FormatType.Custom)
                e.Column.DisplayFormat.Format = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void associacaoBGM1_ClickBotaoConsultar(object sender)
        {

            var xx =  associacaoBGM5.RetornarAssociados<Demo>("objeto");
            if (xx == null)
            {
                
            }

            var xx1 = associacaoBGM5.RetornarAssociados<Demo, int>(p => p.ID);
            if (xx1 == null)
            {

            }

            associacaoBGM1.PopularDisponiveis(

                

            listaPneuDTO
                .Where(w => associacaoBGM5.RetornarAssociados<Demo, int>(p => p.ID).Contains(w.ID))
                );
        }

        private void associacaoBGM5_ClicouEmMover(object sender, bool associando, System.Data.DataRow[] dataRow)
        {
            foreach (var item in dataRow)
            {
                MessageBox.Show(String.Concat(associando," : ", item[1]));
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewInfo info = new GridViewInfo(advBandedGridView1);

                //info.View.RowCount
                //info.View
                    //info.View.GetVisibleIndex 
                //info.View.SourceRow

                if (info.RowsInfo == null)
                {
                    
                }

                var x1 = advBandedGridView1.RetornarItensVisiveis<Demo>();
                
                MessageBox.Show(x1.Count().ToString());

                //MessageBox.Show(String.Join(
                //        Environment.NewLine,
                //        x1
                //            .Select(s => s.ID)
                //            .ToArray()));
            }
            catch (Exception ex)
            {
                Mensagem.Erro(ex);
            }
        }

    
       
    }


}

//ID Cod Cod2 Desc  Ape Cadastro1


