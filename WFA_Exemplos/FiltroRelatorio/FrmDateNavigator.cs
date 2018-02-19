using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraScheduler;
using FGlobus.Util;

namespace WFA_Workflow.WPFDateNavigator
{
    public partial class FrmDateNavigator : Form
    {
        public FrmDateNavigator()
        {
            InitializeComponent();

            //dateNavigator1.HighlightHolidays = true; 
            //dateNavigator1.HighlightSpecialDates


            // dateNavigator1.DataBindings
            //dateNavigator1.nu
        }

        private void FrmDateNavigator_Shown(object sender, EventArgs e)
        {
            //dateNavigator1.DateTime = new DateTime(2013, 01, 01);
            dateNavigator1.PosicionarNoAnoAtual(null);

        }

        private void dateNavigator1_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            //if (e.Date.Day == 5)
            //{
            //    SolidBrush solidBrush = new SolidBrush(Color.Red);
            //    e.Graphics.FillRectangle(solidBrush, e.Bounds);
            //    StringFormat sf = new StringFormat();
            //    sf.LineAlignment = StringAlignment.Far;
            //    sf.Alignment = StringAlignment.Far;
            //    e.Graphics.DrawString(e.Date.Day.ToString(), new Font(e.Style.Font.Name, e.Style.Font.Size), Brushes.White, e.Bounds, sf);
            //    e.Handled = true;
            //    e.Style.Font = new Font(e.Style.Font.Name, e.Style.Font.Size, FontStyle.Bold);
            //}
            //if (e.Date.Day == 10)
            //{
            //    e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font, Brushes.Red, e.Bounds);
            //    e.Handled = true;
            //}
            //if (e.Date.Day == 20)
            //{
            //    e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            //    e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font, Brushes.White, e.Bounds);
            //    e.Handled = true;
            //}


            //if (e.Date.DayOfWeek.Contido(DayOfWeek.Saturday, DayOfWeek.Sunday))
            //{
            //    e.Style.ForeColor = this.dateNavigator1.Selection
            //            .OfType<DateTime>()
            //            .Where(w => e.Date == w.Date)
            //            .NuloOuVazio()
            //        ? Color.Red
            //        : Color.White;
            //}

            //foreach (DateTime dt in dateEditCalendarBase.Selection)
            //    if (fimDeSemana && e.Date == dt.Date)
            //        e.Style.ForeColor = Color.White;

            //if (!SettingsStore.Instance.DrawBoldDates)
            //    return;



            //if (e.Date.Day == 25)
            //{
            //    Color backColor = Color.Yellow;

            //    if (dateNavigator1.Selection.Contains(e.Date))
            //        backColor = Color.Gray;

            //    RectangleF rect = new RectangleF(e.Bounds.Location, e.Bounds.Size);
            //    StringFormat sFormat = new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far };


            //    e.Graphics.FillRectangle(new SolidBrush(backColor), rect);
            //    e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font, new SolidBrush(e.Style.ForeColor), rect, sFormat);
            //    e.Handled = true;

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateNavigator1.PosicionarNoAnoAtual(null);
        }
    }


    public class CustomDateNavigator : DateNavigator
    {
        private class CustomDateEditInfoArgs : DateEditInfoArgs
        {
            public CustomDateEditInfoArgs(DateEditCalendarBase calendar)
                : base(calendar)
            {
            }

            protected override void CalcDayNumberCells()
            {
                base.CalcDayNumberCells();

                base.DayCells
                    .OfType<DayNumberCellInfo>()
                    .ToList()
                    .ForEach(f => f.Appearance.ForeColor = f.Selected
                        ? Color.White
                        : f.Date.DayOfWeek.Contido(DayOfWeek.Saturday, DayOfWeek.Sunday)
                            ? Color.Red
                            : f.IsActive
                                ? Color.Black
                                : Color.Gainsboro);
            }
        }

        internal void PosicionarNoAnoAtual(IEnumerable<DateTime> lista)
        {
            if (lista.NuloOuVazio())
            {
                this.Selection.Clear();
                DateTime dateTime = DateTime.Now.Date;// Globus5.WPF.Comum.WebServices.ControleWSApp.RetornarDataHoraBanco();                

                //

                //this.Selection.Add(dateTime.Date);
                //this.DateTime = this.AdjustSelectionEnd(
                //    new DateTime(dateTime.Year, 2, 1),
                //    new DateTime(dateTime.Year, 12, 31));

                //this.DateTime = this.AdjustSelectionStart(
                //    new DateTime(dateTime.Year, 2, 1),
                //    new DateTime(dateTime.Year, 12, 31));


                //OnDateTimeChanged(dateTime);

                //CreateSelection(dateTime);
                //GetFirstDayOfMonth(new DateTime(2013, 3, 1));
                //GetStartOfWeekCore(new DateTime(2013, 3, 1), DayOfWeek.Friday);
                //ChangeStartDate(new DateTime(2013, 2, 1));
                ChangeStartDate(new DateTime(2013, 1, 1));

                
                //this.
            }
            else
                lista
                    .ToList()
                    .ForEach(f => this.Selection.Add(f));
        }

        protected override DateEditInfoArgs CreateInfoArgs()
        {
            return new CustomDateEditInfoArgs(this);
        }

    }

}
