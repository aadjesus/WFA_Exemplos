using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Controls;

namespace WFA_Workflow
{
    public partial class FrmGridConstrolRepository : Form
    {
        public FrmGridConstrolRepository()
        {
            InitializeComponent();
        }

        private void FrmGridConstrolRepository_Shown(object sender, EventArgs e)
        {

            List<MyClass> lista = new List<MyClass>();
            lista.Add(new MyClass() { Codigo1 = 1, Codigo2 = 1, Data = DateTime.Now });
            lista.Add(new MyClass() { Codigo1 = 1, Codigo2 = 2 });
            lista.Add(new MyClass() { Codigo1 = 2, Codigo2 = 1 });
            lista.Add(new MyClass() { Codigo1 = 3, Codigo2 = 1 });
            lista.Add(new MyClass() { Codigo1 = 3, Codigo2 = 2 });
            lista.Add(new MyClass() { Codigo1 = 3, Codigo2 = 3 });
            lista.Add(new MyClass() { Codigo1 = 3, Codigo2 = 1 });
            lista.Add(new MyClass() { Codigo1 = 3, Codigo2 = 2 });
            lista.Add(new MyClass() { Codigo1 = 3, Codigo2 = 3 });

            repositoryItemCheckedComboBoxEdit1.Items
                .AddRange(Enumerable
                            .Range(1, 10)
                            .Select(s => new CheckedListBoxItem()
                            {
                                Value = String.Concat(s, "_", 1),
                                Description = String.Concat(s, "xxxxxx")
                            })
                            .ToArray());


            gridControl1.DataSource = lista;
            pivotGridControl1.DataSource = lista;
        }

        private void chartControl1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ChartHitInfo hi = chartControl1.CalcHitInfo(e.X, e.Y);
            SeriesPoint point = hi.SeriesPoint;

            if (point != null)
            {
                string argument = point.Argument.ToString();

                if (chartControl1.Series[0].Visible == true)
                {
                    chartControl1.Series[0].Visible = false;

                    chartControl1.Series[1].Name = argument;
                    chartControl1.Series[1].Visible = true;

                    XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
                    diagram.AxisX.Label.Angle = -25;
                    diagram.AxisY.NumericOptions.Format = NumericFormat.Currency;
                    diagram.AxisY.NumericOptions.Precision = 0;
                    
                    //chartControl1.Series[1].DataFilters.Clear();
                    //chartControl1.Series[1].DataFilters.Add(
                    //    new DevExpress.XtraCharts.DataFilter(
                    //        "Codigo1",
                    //        "System.Int32", 
                    //        DevExpress.XtraCharts.DataFilterCondition.Equal,
                    //        argument));
                        
                    //    new DataFilter()
                    //{
                    //    ColumnName = "Codigo1",
                    //    Value = argument, 
                    //    DataType = 
                    //});

                    chartControl1.Titles[0].Visible = true;
                    chartControl1.Titles[1].Text = argument.ToString();
                }
            }

            ChartTitle link = hi.ChartTitle;
            if (link != null && link.Text.StartsWith("Back"))
            {
                chartControl1.Series[0].Visible = true;
                chartControl1.Series[1].Visible = false;

                link.Visible = false;
                chartControl1.Titles[1].Text = "Sales by Person";
            }

        }

        private void itemBarraItensBGM1_ClickBotao(object sender)
        {

        }

        //private void FrmGridConstrolRepository_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    //ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
        //    //                             Color.Black, 5, ButtonBorderStyle.Inset,
        //    //                             Color.Black, 5, ButtonBorderStyle.Inset,
        //    //                             Color.Black, 5, ButtonBorderStyle.Inset,
        //    //                             Color.Black, 5, ButtonBorderStyle.Inset);
        //}
    }

    public class MyClass
    {
        public int Codigo1 { get; set; }
        public int Codigo2 { get; set; }
        public DateTime Data { get; set; }
    }


}