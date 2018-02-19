using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using FGlobus.Componentes.WinForms;
using FGlobus.Util;

namespace WFA_Workflow
{
    public partial class FrmGridConstrol : Form
    {
        public FrmGridConstrol()
        {
            InitializeComponent();
            //this.Load += (o, e1) => 
            //{ 
            //    MessageBox.Show("2");
            //};
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);

        //    MessageBox.Show("3");
        //}

        private void FrmGridConstrol_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("1");
        }

        private void FrmGridConstrol_Shown(object sender, EventArgs e)
        {
            xtraTabControl1_Selected(sender,
                new DevExpress.XtraTab.TabPageEventArgs(xtraTabPage9, 0, TabControlAction.Selected));
        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            if (e.Page.Tag == null)
            {
                MethodInfo methodInfo = this.GetType().GetMethod(e.Page.Name.ToUpper(), BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (methodInfo == null)
                    FGlobus.Componentes.WinForms.Mensagem.Informacao(e.Page.Name);
                else
                {
                    methodInfo.Invoke(this, null);
                    e.Page.Tag = true;
                }
            }

        }

        class ItensMovimentacao
        {
            public int ID { get; set; }
            public int Codigo { get; set; }
        }
        class MyClassx
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public decimal Valor1 { get; set; }
            public decimal Valor2 { get; set; }
            public int Tipo1 { get; set; }
            public int Tipo2 { get; set; }

            public int ID { get; set; }
            public DateTime Data { get; set; }
            public List<ItensMovimentacao> Itens { get; set; }
        }

        private List<MyClassx> PopularLista()
        {
            return Enumerable.Range(1, 10)
                .Aggregate(new List<MyClassx>(), (retornoMovto, itemMovto) =>
                {
                    List<ItensMovimentacao> listaItensMovimentacao = new List<ItensMovimentacao>();


                    if ((itemMovto % 2) == 0)
                        Enumerable.Range(1, itemMovto)
                            .Aggregate(listaItensMovimentacao, (retornoItemMovto, itemItemMovto) =>
                            {
                                retornoItemMovto.Add(new ItensMovimentacao() { Codigo = itemItemMovto, ID = itemMovto });
                                return retornoItemMovto;
                            });


                    MyClassx movimentacao = new MyClassx()
                    {
                        Itens = listaItensMovimentacao.ToList(),
                        Codigo = itemMovto,
                        Descricao = String.Concat((itemMovto / 3), " - Descricao", itemMovto),

                        Valor1 = itemMovto * 10,
                        //Valor2 = itemMovto * 5.2M,
                        Valor2 = 5555123M,
                        Tipo1 = (itemMovto % 10),
                        Tipo2 = (itemMovto % 4),

                        ID = itemMovto.GetHashCode(),
                        Data = DateTime.Now.AddDays(itemMovto),
                    };
                    retornoMovto.Add(movimentacao);
                    return retornoMovto;
                })
                .ToList();
        }


        #region Ex1

        private void button1_Click(object sender, EventArgs e)
        {
            GridView baseView = gridViewEx1.GetDetailView(gridViewEx1.FocusedRowHandle, 0) as GridView;
            DataRow dataRow = baseView.GetFocusedDataRow();

            if (baseView.GetFocusedDataRow() == null)
            {
            }
        }

        private void XTRATABPAGEEX1()
        {
            Random random = new Random(1000);
            for (int i = 21; i < 51; i++)
            {
                try
                {
                    bool ok = false;

                    DataRow dataRow1 = dataTable1.NewRow();
                    //dataRow1["Descrição"] = String.Concat(i.ToString("0000"), " - ", dataRow1.GetHashCode());
                    dataRow1["Descrição"] = "SP";// String.Concat(i.ToString("0000"), " - ", dataRow1.GetHashCode());
                    dataRow1["SimOuNao"] = (dataRow1.GetHashCode() % 2) == 0;
                    dataTable1.Rows.Add(dataRow1);

                    for (int j = 5; j < random.Next(10, i); j++)
                    {
                        DataRow dataRow2 = dataTable2.NewRow();
                        dataRow2["ID1"] = dataRow1["ID"];

                        dataRow2["Descrição"] = String.Concat(i.ToString("0000"), " - ", j.ToString("0000"), " - ", dataRow2.GetHashCode());

                        DateTime aaa = DateTime.Now.AddDays(random.Next(j + i));
                        dataRow2["Data1"] = aaa.Date;
                        dataRow2["Data2"] = DateTime.Now.AddDays(random.Next(j + i));
                        dataRow2["Qtde"] = Math.Abs(Convert.ToDateTime(aaa).Subtract(Convert.ToDateTime(dataRow2["Data2"])).TotalDays);

                        dataTable2.Rows.Add(dataRow2);
                        dataRow2["ID1ID2"] = String.Concat(dataRow1["ID"], '_', dataRow2["ID"]);


                        for (int l = 16; l < random.Next(21, i); l++)
                        {
                            DataRow dataRow4 = dataTable4.NewRow();
                            dataRow4["ID1ID2"] = dataRow2["ID1ID2"];
                            dataRow4["Descrição"] = String.Concat(i.ToString("0000"), " - ", j.ToString("0000"), " - ", l.ToString("0000"), " - ", dataRow4.GetHashCode());

                            dataTable4.Rows.Add(dataRow4);
                        }
                    }



                    for (int j = 15; j < random.Next(20, i); j++)
                    {
                        DataRow dataRow3 = dataTable3.NewRow();
                        dataRow3["ID1"] = dataRow1["ID"];
                        dataRow3["Descrição"] = String.Concat(i.ToString("0000"), " - ", j.ToString("0000"), " - ", dataRow3.GetHashCode());

                        dataTable3.Rows.Add(dataRow3);
                    }

                    dataRow1["MaxQtde"] = dataTable2.Rows.OfType<DataRow>()
                        .Where(w => Convert.ToInt32(w["ID1"]) == Convert.ToInt32(dataRow1["ID"]))
                        .Max(m => Convert.ToInt32(m["Qtde"]));

                }
                catch (Exception)
                {
                }

            }

            repositoryQtdeMax.Maximum = repositoryQtde.Maximum;
        }

        #endregion

        #region Ex2

        private void XTRATABPAGE2()
        {
            gridView1.DefinirCaracteristicas();
            gridControl1.DataSource = this.PopularLista();
            gridControl1.ShowPrintPreview();
        }

        #endregion

        #region Ex3

        private void XTRATABPAGE1()
        {
            grdVwEx3.CustomSummaryCalculate += new CustomSummaryEventHandler(grdVwEx1_CustomSummaryCalculate);
            grdVwEx3.CustomSummaryExists += new CustomSummaryExistEventHandler(grdVwEx1_CustomSummaryExists);

            grdVwEx3.DefinirCaracteristicas();
            grdCtrlEx3.DataSource = this.PopularLista();
        }

        private void grdVwEx1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                List<MyClassx> lista = grdVwEx3.GridControl.DataSource as List<MyClassx>;

                if (e.IsGroupSummary)
                    e.TotalValue = lista
                        .Where(w => w.Tipo1 == (int)e.FieldValue)
                        .Sum(s => s.Valor1);

                if (e.IsTotalSummary)
                    e.TotalValue = lista.Sum(s => s.Valor2 / 3);
            }
        }

        private void grdVwEx1_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {

        }

        #endregion

        #region Ex4

        private void XTRATABPAGE3()
        {
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Codigo", typeof(int));
            dataTable1.Columns.Add("Descricao", typeof(string));
            dataTable1.Columns.Add("Data", typeof(DateTime));
            dataTable1.Columns.Add("OK", typeof(bool));
            dataTable1.Columns.Add("Valor", typeof(bool));

            for (int i = 0; i < 10; i++)
            {
                DataRow dataRow1 = dataTable1.NewRow();
                dataRow1["Codigo"] = i;
                dataRow1["Descricao"] = String.Concat(i, "sssssssss");
                dataRow1["Data"] = DateTime.MinValue.Add(DateTime.Now.AddMinutes(i).TimeOfDay);
                dataRow1["OK"] = (i % 2) == 0;
                dataRow1["Valor"] = 10 * i;

                dataTable1.Rows.Add(dataRow1);
            }
            grdCtrlEx4.DataSource = dataTable1;

            this.grdVwEx4.CustomDrawRowFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.grdVwEx2_CustomDrawRowFooterCell);
            this.grdVwEx4.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.grdVwEx2_CustomDrawFooterCell);

            this.grdVwEx4.CustomDrawRowFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(grdVwEx2_CustomDrawRowFooter);
            this.grdVwEx4.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(grdVwEx2_CustomDrawFooter);
            this.grdVwEx4.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(grdVwEx2_CustomSummaryCalculate);

            grdCtrlEx4.RefreshDataSource();
        }

        private int totalCount;
        private TimeSpan totalTimeSpan = new TimeSpan();
        private TimeSpan subTotalTimeSpan = new TimeSpan();

        private void grdVwEx2_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                subTotalTimeSpan = new TimeSpan();
                totalTimeSpan = new TimeSpan();
            }
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                if (e.FieldValue != null && e.FieldValue != DBNull.Value)
                {
                    TimeSpan timeSpan = ((DateTime)e.FieldValue).TimeOfDay;
                    if (e.IsGroupSummary)
                    {
                        if (timeSpan < subTotalTimeSpan)
                            subTotalTimeSpan = subTotalTimeSpan.Subtract(timeSpan);
                        else
                            subTotalTimeSpan = timeSpan.Subtract(subTotalTimeSpan);
                    }

                    if (e.IsTotalSummary)
                    {
                        if (timeSpan < totalTimeSpan)
                            totalTimeSpan = totalTimeSpan.Subtract(timeSpan);
                        else
                            totalTimeSpan = timeSpan.Subtract(totalTimeSpan);
                    }
                }

                if (e.IsGroupSummary)
                    e.TotalValue = subTotalTimeSpan;
                if (e.IsTotalSummary)
                    e.TotalValue = totalTimeSpan;
            }
        }

        private void grdVwEx2_CustomDrawRowFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            //LinearGradientBrush backBrush = new LinearGradientBrush(e.Bounds, Color.Orange, Color.PeachPuff, LinearGradientMode.Vertical);
            //e.Graphics.FillRectangle(backBrush, e.Bounds);
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.SunkenInner);

            //e.Graphics.DrawString("xxxxxx", e.Appearance.Font, new SolidBrush(Color.Blue), e.Bounds, e.Appearance.GetStringFormat());
            //e.Handled = true;

        }

        private void grdVwEx2_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            //LinearGradientBrush backBrush = new LinearGradientBrush(e.Bounds, Color.Orange, Color.PeachPuff, LinearGradientMode.Vertical);
            //e.Graphics.FillRectangle(backBrush, e.Bounds);
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.SunkenInner);

            //e.Graphics.DrawString("aaaaaaa", e.Appearance.Font, new SolidBrush(Color.Blue), e.Bounds, e.Appearance.GetStringFormat());
            //e.Handled = true;

        }

        private void grdVwEx2_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "OK")
            //{
            //    LinearGradientBrush backBrush = new LinearGradientBrush(e.Bounds, Color.Orange, Color.PeachPuff, LinearGradientMode.Vertical);
            //    e.Graphics.FillRectangle(backBrush, e.Bounds);
            //    ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.SunkenInner);

            //    e.Graphics.DrawString("tttt", e.Appearance.Font, new SolidBrush(Color.Blue), e.Bounds, e.Appearance.GetStringFormat());
            //    e.Handled = true;
            //}
        }

        private void grdVwEx2_CustomDrawRowFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            //if (e.Column.FieldName == "OK")
            //{
            //    LinearGradientBrush backBrush = new LinearGradientBrush(e.Bounds, Color.Orange, Color.PeachPuff, LinearGradientMode.Vertical);
            //    e.Graphics.FillRectangle(backBrush, e.Bounds);
            //    ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.SunkenInner);

            //    e.Graphics.DrawString("bbbbbb", e.Appearance.Font, new SolidBrush(Color.Blue), e.Bounds, e.Appearance.GetStringFormat());
            //    e.Handled = true;
            //}
        }
        #endregion

        #region xtraTabPage4

        private void XTRATABPAGE4()
        {
            Dictionary<string, string> dictionary = new ComponentResourceManager(typeof(FGlobus.Mensagens.Informacoes)).GetResourceSet(System.Globalization.CultureInfo.InvariantCulture, true, true)
               .OfType<System.Collections.DictionaryEntry>()
               .ToDictionary(d => d.Key.ToString(), d => d.Value.ToString());

            gridControl2.DataSource = dictionary
                .Select(s => new
                {
                    Name = s.Key,
                    s.Value
                })
                .ToArray();
        }

        #endregion

        #region xtraTabPage5

        DataTable DataTablextraTabPage5 = new DataTable();

        private void XTRATABPAGE5()
        {
            Enumerable.Range(0, 3)
                .Aggregate(DataTablextraTabPage5.Columns, (a, b) =>
                {
                    a.Add(new DataColumn(b.ToString()));
                    return a;
                });

            //Enumerable.Range(0, 10)
            //    .Aggregate(DataTablextraTabPage5, (a, b) =>
            //    {
            //        DataRow dataRow = a.NewRow();
            //        Enumerable.Range(0, 3)
            //            .Aggregate(dataRow, (a1, b1) =>
            //            {
            //                a1[b1] = a.Rows.Count;
            //                return a1;
            //            });
            //        a.Rows.Add(dataRow);
            //        return a;
            //    });

            gridControl3.DataSource = DataTablextraTabPage5;
            gridView7.DefinirCaracteristicas();
        }

        private void gridView7_RowCountChanged(object sender, EventArgs e)
        {
            //gridView7.OptionsView.ShowFooter = gridView7.RowCount > 1;
            //gridView7.OptionsView.ShowAutoFilterRow = gridView7.OptionsView.ShowFooter;
            //gridView7.OptionsView.ShowGroupPanel = gridView7.OptionsView.ShowFooter;
        }

        private void gridView7_DataSourceChanged(object sender, EventArgs e)
        {
            //gridView7.OptionsView.ShowFooter = gridView7.RowCount > 1;
            //gridView7.OptionsView.ShowAutoFilterRow = gridView7.OptionsView.ShowFooter;
            //gridView7.OptionsView.ShowGroupPanel = gridView7.OptionsView.ShowFooter;
        }

        private void smplBtnRemoverLinhaFocada_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = ((System.Data.DataRowView)(gridView7.GetFocusedRow())).Row;
                DataTablextraTabPage5.Rows.Remove(dataRow);
            }
            catch { }
        }

        private void smplBtnLimparTabela_Click(object sender, EventArgs e)
        {
            DataTablextraTabPage5.Rows.Clear();
        }

        private void smplBtnAdicionar_Click(object sender, EventArgs e)
        {
            DataRow dataRow = DataTablextraTabPage5.NewRow();
            Enumerable.Range(0, 3)
                .Aggregate(dataRow, (a1, b1) =>
                {
                    a1[b1] = DataTablextraTabPage5.Rows.Count;
                    return a1;
                });
            DataTablextraTabPage5.Rows.Add(dataRow);
        }

        #endregion

        LayoutControleDevExpress layoutControleDevExpress = new LayoutControleDevExpress();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            layoutControleDevExpress.Restaurar(gridControl4);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            layoutControleDevExpress.Salvar();
        }

        #region xtraTabPage6

        #endregion

        #region xtraTabPage7

        private void XTRATABPAGE7()
        {
            //dataSet1
            Enumerable.Range(0, 10)
                .ToList()
                .ForEach(f1 =>
                {
                    DataRow dataRowF1 = dataSet2.Tables["Table1"].NewRow();
                    dataRowF1["Chave"] = f1.ToString();
                    dataRowF1["OK"] = true;
                    dataRowF1["Column2"] = String.Concat("aaaaac", f1);
                    dataRowF1["Column3"] = String.Concat("bbbbbx", f1.GetHashCode());
                    dataSet2.Tables["Table1"].Rows.Add(dataRowF1);

                    if (f1 == 1)
                        Enumerable.Range(1, 5)
                            .ToList()
                            .ForEach(f2 =>
                            {
                                DataRow dataRowF2 = dataSet2.Tables["Table2"].NewRow();
                                dataRowF2["Chave"] = dataRowF1["Chave"];
                                dataRowF2["Column2"] = String.Concat("aaaaa", f2);
                                dataRowF2["Column3"] = String.Concat("bbbbb", f2.GetHashCode());
                                dataSet2.Tables["Table2"].Rows.Add(dataRowF2);
                            });

                    if (f1 == 2)
                        Enumerable.Range(1, 4)
                            .ToList()
                            .ForEach(f3 =>
                            {
                                DataRow dataRowF3 = dataSet2.Tables["Table3"].NewRow();
                                dataRowF3["Chave"] = dataRowF1["Chave"];
                                dataRowF3["Column2"] = String.Concat("aaaaa", f3);
                                dataRowF3["Column3"] = String.Concat("bbbbb", f3.GetHashCode());
                                dataSet2.Tables["Table3"].Rows.Add(dataRowF3);
                            });
                });



            repositoryItemCheckedComboBoxEdit1.Items.AddRange(
                dataSet2.Tables["Table1"].Rows
                    .OfType<DataRow>()
                    .Select(s => new CheckedListBoxItem()
                    {
                        Value = s["Chave"],
                        Description = String.Concat(s["Chave"], '-', s["Chave"])
                    })
                    .ToArray());

            colChave.ColumnEdit = repositoryItemCheckedComboBoxEdit1;

            repositoryItemComboBox1.Items.AddRange(
                dataSet2.Tables["Table1"].Rows
                    .OfType<DataRow>()
                    .Select(s => new CheckedListBoxItem()
                    {
                        Value = s["Chave"],
                        Description = String.Concat(s["Chave"], '-', s["Chave"])
                    })
                    .ToArray());

            gridLookUpEdit1.Properties.DataSource = dataSet2;



            gridViewEx1.DefinirCaracteristicas();
        }

        #endregion


        #region XTRATABPAGE9

        private void XTRATABPAGE9()
        {
            gridControl7.DataSource = Enumerable.Range(0, 10)
                .Select(s => new
                {
                    Codigo = s,
                    Descricao = "aaaaaaaaaaaa"
                })
                .ToArray();


            gridControl8.DataSource = Enumerable.Range(0, 100)
                .Select(s => new
                {
                    Codigo = s,
                    Codigo2 = s,
                    Codigo3 = s,
                })
                .ToArray();
        }

        #endregion
        private void btnListaSomentoOsVisiveis_Click(object sender, EventArgs e)
        {
            ////GridView

            //Action<int> actionItensGrid = null;
            //actionItensGrid = 
            //    item =>
            //    {
            //        FrmGridConstrol.MyClassx valor = (FrmGridConstrol.MyClassx)this.grdVwEx3.GetRow(item);
            //        if (valor != null)
            //        {
            //            valor.Descricao = "xxxxxxx" + item.ToString();
            //            this.grdVwEx3.RefreshRow(item);

            //            actionItensGrid(this.grdVwEx3.GetNextVisibleRow(item));
            //        }
            //    };

            //actionItensGrid(this.grdVwEx3.GetVisibleRowHandle(0));    
            var xxx = this.grdVwEx3.RetornarItensVisiveis<FrmGridConstrol.MyClassx>();
            xxx.Update(u =>
            {
                u.Descricao = "xxxxxxx" + u.Descricao.ToString();
            });
            this.grdVwEx3.RefreshData();
        }

        private void gridControl5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                DataRow dataRow = gridView8.GetDataRow(gridView8.FocusedRowHandle);
                dataRow["OK"] = false;// !((bool)dataRow["OK"]);                
            }

        }

        private void repositoryItemCheckEdit2_Click(object sender, EventArgs e)
        {
            gridControl5_KeyDown(sender, new KeyEventArgs(Keys.Space));
        }

        class XTRATABPAGE8xx
        {
            public int Codigo { get; set; }
            public string Descricao { get; set; }
            public string Codigo2 { get; set; }

        }
        private void XTRATABPAGE8()
        {

            gridControl6.DataSource = Enumerable.Range(0, 10)
                .Select(s => new XTRATABPAGE8xx()
                {
                    Codigo = s,
                    Descricao = s.ToString(),
                    //Codigo2 = (s % 2) == 0
                    //            ? String.Concat(s, ';', s + 3, ';', s + 4)
                    //            : "0"

                    Codigo2 =
                                String.Concat(((s * 5 / 3 * s)).GetHashCode(), ';', s + 3, ';', s + 4)


                                ,
                })
                .ToArray();
        }

        private void bandedGridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //bandedGridView2.RowCellClick
            if (e.Column == bandedGridColumn5)
            {
                MessageBox.Show(String.Concat(e.CellValue));
            }
        }

        IndicatorObjectInfoArgs graphics = null;
        private void bandedGridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                //view.GetRow(e.RowHandle)
                e.Info.DisplayText = "xxxxxxxxxxxxxxxxxxxx " + e.RowHandle.ToString();
                graphics = e.Info;
            }
            else
            {

                e.Info.DisplayText = "asdasad";
                graphics = null;
            }
        }

        private void bandedGridView2_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column == Codigo2 && e.RowHandle > 0)
            {
                paintRaisedBackground(e.Graphics, e.Bounds);
                //paintSunkenBackground(e.Graphics, e.Bounds);


            }
            //if (e.Column == bandedGridColumn7)
            //{
            //    string[] x1 = e.CellValue.ToString().Split(';');
            //    if (!x1.NuloOuVazio())

            //        e.DisplayText = String.Join(";", x1.Select(s => s.PadLeft(5, '0')));
            //}
        }

        private void paintRaisedBackground(Graphics g, Rectangle bounds)
        {

            LinearGradientBrush brush = new LinearGradientBrush(bounds,

                graphics.Appearance.BackColor,
                graphics.Appearance.BackColor2,
                LinearGradientMode.Vertical);
            g.FillRectangle(brush, bounds);
            //ControlPaint.DrawBorder3D(g, bounds, Border3DStyle.RaisedInner);
        }

        // paints the background of sunken elements
        private void paintSunkenBackground(Graphics g, Rectangle bounds)
        {
            LinearGradientBrush brush = new LinearGradientBrush(bounds, Color.CornflowerBlue, Color.LightGray, LinearGradientMode.Vertical);
            g.FillRectangle(brush, bounds);
            ControlPaint.DrawBorder3D(g, bounds, Border3DStyle.SunkenOuter);

        }

        private void bandedGridView2_CustomColumnSort(object sender, CustomColumnSortEventArgs e)
        {
            try
            {
                if (e.Column == Codigo2)
                {
                    XTRATABPAGE8xx dr1 = bandedGridView2.GetRow(e.ListSourceRowIndex1) as XTRATABPAGE8xx;
                    XTRATABPAGE8xx dr2 = bandedGridView2.GetRow(e.ListSourceRowIndex2) as XTRATABPAGE8xx;
                    e.Handled = true;
                    e.Result = System.Collections.Comparer.Default.Compare(
                        String.Concat(dr1.Codigo2.Split(';').Select(s => s.PadLeft(5, '0'))),
                        String.Concat(dr2.Codigo2.Split(';').Select(s => s.PadLeft(5, '0')))
                        );
                }
            }
            catch { }

        }




        private void cardViewEx1_DoubleClick(object sender, EventArgs e)
        {
            var x1 = cardViewEx1.RetornarLinhaSelecionadaDoDetalhe<object>();
            if (x1 == null)
            {
                
            }
        }

        private void gridView1Ex1_DoubleClick(object sender, EventArgs e)
        {
            var x1 = gridView1Ex1.RetornarLinhaSelecionadaDoDetalhe<object>();
            if (x1 == null)
            {

            }
        }
    }
}
