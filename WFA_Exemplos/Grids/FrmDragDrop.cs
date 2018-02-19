using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WFA_Workflow
{
    public partial class FrmDragDrop : Form
    {
        public FrmDragDrop()
        { 

            InitializeComponent();
        }

        List<cFrmDragDrop> lista1 = new List<cFrmDragDrop>();
        List<cFrmDragDrop> lista2 = new List<cFrmDragDrop>();

        private void FrmDragDrop_Shown(object sender, EventArgs e)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<cFrmDragDrop>));
            ////StringWriter stringWriter = new StringWriter();
            //TextWriter textWriter = new StreamWriter();
            ////xmlSerializer.Serialize(textWriter, this.usrCtrlRelatorioGerencial1.usrCtrlGraficoRelatorioGerencial.ListaGrafico);


            lista1 = Enumerable.Range(0, 10)
                .Select((s, index) => new cFrmDragDrop()
                {
                    ID = index,
                    Codigo = index,
                    Descricao = String.Concat("Descrição - ", index),
                    Data = new DateTime().AddDays(index),
                    Itens = Enumerable.Range(0, 5)
                        .Select(s1 => new cFrmDragDrop2()
                        {
                            ID = index,
                            Codigo = index + s1,
                            Descricao = String.Concat("Descrição - ", index, s1),
                            Data = new DateTime().AddDays(s1),
                        }).ToList(),

                    ItensXX = Enumerable.Range(0, 2)
                        .Select(s1 => new cFrmDragDrop2XXXXXX()
                        {
                            ID2 = index,
                            Descricao1xxx = String.Concat("Descrição - ", index, s1),
                            Descricao2 = new DateTime().AddDays(s1).ToString(),
                        }).ToArray()

                })
                .ToList();

            gridControl1.DataSource = lista1.RetornarDataSet(
                //c => c.Codigo,
                //c => c.Codigo)

                c => new
                {
                    c.Codigo,
                    c.Descricao
                },
                c => new
                {
                    c.Codigo,
                    c.Descricao
                })

                .Tables["cFrmDragDrop"];


            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(cFrmDragDrop[]));
            //StringWriter stringWriter = new StringWriter();
            //xmlSerializer.Serialize(stringWriter, lista1.ToArray());

            //TextReader txtReader = new StringReader(stringWriter.ToString());
            //XmlReader reader = new XmlTextReader(txtReader);
            //DataSet ds = new DataSet();
            //ds.ReadXml(reader);

            //ds.Relations.Clear();

            //DataRelation CustOrderRel = new DataRelation("Tabela1", ds.Tables["cFrmDragDrop"].Columns["ID"], ds.Tables["cFrmDragDrop2"].Columns["ID"]);

            //DataColumn[] parentCols1 = new DataColumn[] { ds.Tables["cFrmDragDrop"].Columns["ID"] };
            //DataColumn[] childCols1 = new DataColumn[] { ds.Tables["cFrmDragDrop2XXXXXX"].Columns["ID2"] };
            //DataRelation CustOrderRel1 = new DataRelation("Tabela2", parentCols1, childCols1);

            //ds.Relations.Add(CustOrderRel);
            //ds.Relations.Add(CustOrderRel1);

            //gridControl1.DataSource = ds.Tables["cFrmDragDrop"];

        }


        public class cFrmDragDrop
        {
            public int ID { get; set; }
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public string Descricao2 { get; set; }
            public DateTime Data { get; set; }
            public List<cFrmDragDrop2> Itens { get; set; }
            public cFrmDragDrop2XXXXXX[] ItensXX { get; set; }
        }

        public class cFrmDragDrop2
        {
            public int ID { get; set; }
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public DateTime Data { get; set; }
        }


        public class cFrmDragDrop2XXXXXX
        {
            public int ID2 { get; set; }
            public string Descricao1xxx { get; set; }
            public string Descricao2 { get; set; }

            //ID Descricao1xxx Descricao2
        }



        private GridHitInfo _gridHitInfo = null;
        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            _gridHitInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
        }

        private void gridControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_gridHitInfo != null &&
                e.Button == MouseButtons.Left)
                gridControl1.DoDragDrop(gridView1.GetRow(_gridHitInfo.RowHandle) as cFrmDragDrop, DragDropEffects.Copy);
        }

        private void gridControl2_DragDrop(object sender, DragEventArgs e)
        {
            //cFrmDragDrop drmDragDrop = e.Data.GetData(typeof(cFrmDragDrop)) as cFrmDragDrop;

            //lista2.Add(drmDragDrop);
            //gridControl2.RefreshDataSource();

            //lista1.Remove(drmDragDrop);
            //gridControl1.RefreshDataSource();
            ////gridView1.MoveFirst();
        }

        private void gridControl2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }

    public static class XXXX
    {
        public static DataSet RetornarDataSet<TSource, TKey>(
            this IEnumerable<TSource> source,
            Expression<Func<TSource, TKey>> keySelectorPai,
            Expression<Func<TSource, TKey>> keySelectorFilho)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            Func<int, Expression, MemberExpression> funcMemberExpression =
                (tipo, propriedade) =>
                {
                    MemberExpression memberExpression = null;
                    UnaryExpression unaryExpression = propriedade as UnaryExpression;

                    if (unaryExpression == null)
                        memberExpression = propriedade as MemberExpression;
                    else
                        memberExpression = unaryExpression.Operand as MemberExpression;

                    dictionary.Add(String.Concat(tipo, '_', memberExpression.Member.Name), memberExpression.Member.Name);
                    return memberExpression;
                };

            NewExpression newExpressionPai = keySelectorPai.Body as NewExpression;
            NewExpression newExpressionFilho = keySelectorFilho.Body as NewExpression;

            if (newExpressionPai == null)
            {
                funcMemberExpression(1, keySelectorPai);
                funcMemberExpression(2, keySelectorFilho);
            }
            else
            {
                newExpressionPai.Arguments
                    .ToList()
                    .ForEach(f => funcMemberExpression(1, f));

                newExpressionFilho.Arguments
                    .ToList()
                    .ForEach(f => funcMemberExpression(2, f));
            }

            Func<int, Dictionary<string, string>> FuncFiltro = p => dictionary
                    .Where(s => Convert.ToInt32(s.Key.Split('_').FirstOrDefault()) == p)
                    .ToDictionary(d => d.Key, d => d.Value);

            var x2 = FuncFiltro(1).Intersect(FuncFiltro(2));

            Console.WriteLine(x2.Count());


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TSource[]));
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, source.ToArray());

            TextReader txtReader = new StringReader(stringWriter.ToString());
            XmlReader xmlReader = new XmlTextReader(txtReader);
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlReader);

            dataSet.Relations.Clear();

            DataRelation CustOrderRel = new DataRelation("Tabela1", dataSet.Tables["cFrmDragDrop"].Columns["ID"], dataSet.Tables["cFrmDragDrop2"].Columns["ID"]);

            DataColumn[] parentCols1 = new DataColumn[] { dataSet.Tables["cFrmDragDrop"].Columns["ID"] };
            DataColumn[] childCols1 = new DataColumn[] { dataSet.Tables["cFrmDragDrop2XXXXXX"].Columns["ID2"] };
            DataRelation CustOrderRel1 = new DataRelation("Tabela2", parentCols1, childCols1);

            dataSet.Relations.Add(CustOrderRel);
            dataSet.Relations.Add(CustOrderRel1);

            return dataSet;
        }
    }


}



