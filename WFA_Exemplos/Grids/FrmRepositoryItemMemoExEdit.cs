using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace WFA_Workflow
{
    public partial class FrmRepositoryItemMemoExEdit : Form
    {
        public FrmRepositoryItemMemoExEdit()
        {
            InitializeComponent();
        }

        private void FrmRepositoryItemMemoExEdit_Shown(object sender, EventArgs e)
        {
            List<cFrmRepositoryItemMemoExEdit> lista = new List<cFrmRepositoryItemMemoExEdit>();

            Enumerable.Range(0, 50)
                .Aggregate(lista, (a, b) =>
                {
                    a.Add(new cFrmRepositoryItemMemoExEdit()
                    {
                        codigo = ((b % 10) == 0)
                            ? -1
                            : ((b % 10) == 5)
                                ? -2
                                : 0,
                        Descricao1 = String.Concat("Descricao1", b),
                        Descricao2 = String.Concat("Descricao2", b),
                        Descricao3 = String.Concat("Descricao3", b)
                    });
                    return a;
                });

            gridControl1.DataSource = lista;
        }
         

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            //gridView1.FocusedValue
            //gridView1.SelectedRowsCount
            //gridView1.GetRow(gridView1.FocusedRowHandle)
            
            //(gridView1.GetFocusedRow() as DataRow)[""]
            //gridView1.GetDataRow(gridView1.FocusedRowHandle)[""

            DataRow aaa = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (aaa != null)
            {
                
            }


            cFrmRepositoryItemMemoExEdit xxx = e.Row as cFrmRepositoryItemMemoExEdit;
            if (e.Column.FieldName == "gridColumn5" && 
                e.IsGetData &&
                xxx != null
                )
                e.Value = String.Concat(
                    xxx.codigo,Environment.NewLine,
                    xxx.Descricao1,Environment.NewLine,
                    xxx.Descricao2, Environment.NewLine,
                    xxx.Descricao3, Environment.NewLine

                    
                    );

        }

        //private void xxxxxxxxxxxxxx(object sender, EventArgs e)
        //{ 

        //}

        //private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        //{
        //    //ItinerarioServicoDTO itinerarioServicoDTO = this.grdVwIda.GetRow(e.RowHandle) as ItinerarioServicoDTO;
        //    //if (itinerarioServicoDTO != null &&
        //    //    e.Column.Name == this.colCritica.Name &&
        //    //    itinerarioServicoDTO.CodIntLinha < 0)
        //    //{
        //    //    e.DisplayText = itinerarioServicoDTO.CodIntLinha == -1
        //    //        ? "xxxxxxxxxx"
        //    //        : "zzzzzzzzzzz";
        //    //}
        //    //repositoryItemMemoExEdit1.            
        //    cFrmRepositoryItemMemoExEdit itinerarioServicoDTO = this.gridView1.GetRow(e.RowHandle) as cFrmRepositoryItemMemoExEdit;
        //    if (itinerarioServicoDTO != null &&
        //        e.Column.Name == this.gridColumn5.Name
        //        )
        //    {
        //        //RepositoryItemMemoExEdit aa = new RepositoryItemMemoExEdit()
        //        //(e.Column.ColumnEdit as RepositoryItemMemoExEdit).ShowIcon = itinerarioServicoDTO.codigo < 0;
        //        e.DisplayText = "wwwwwwwwwwwwwwwwwwwwwwwwwwww";
        //    }

        //}

        //void repositoryItemMemoExEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        //{
        //    e.DisplayText = "asdadasdas";           
        //}

        //private string GetCellHintText(GridView view, int rowHandle, DevExpress.XtraGrid.Columns.GridColumn column)
        //{
        //    string ret = view.GetRowCellDisplayText(rowHandle, column);
        //    foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
        //        if (col.VisibleIndex < 0)
        //            ret += string.Format("\r\n {0}: {1}", col.GetTextCaption(), view.GetRowCellDisplayText(rowHandle, col));
        //    return ret;
        //}

        //string[] ColumnHints = new string[] {"Number automatically assigned to new product.", "", 
        //    "Quantity per unit (e.g., 24-count case, 1-liter bottle).", "", "", "", 
        //    "Minimum units to maintain in stock.", 
        //    "Yes - means item is no longer available."};

        //private string GetColumnHintText(DevExpress.XtraGrid.Columns.GridColumn column)
        //{
        //    string ret = ColumnHints[gridView1.Columns.IndexOf(column)];
        //    if (ret == "") ret = column.GetTextCaption();
        //    return ret;
        //}

        //private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        //{
        //    if (e.SelectedControl == gridControl1)
        //    {
        //        ToolTipControlInfo info = null;
        //        try
        //        {
        //            GridView view = gridControl1.GetViewAt(e.ControlMousePosition) as GridView;
        //            if (view == null) return;
        //            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
        //            if (hi.InRowCell)
        //            {
        //                info = new ToolTipControlInfo(new CellToolTipInfo(hi.RowHandle, hi.Column, "cell"), GetCellHintText(view, hi.RowHandle, hi.Column));
        //                return;
        //            }
        //            if (hi.Column != null)
        //            {
        //                info = new ToolTipControlInfo(hi.Column, GetColumnHintText(hi.Column));
        //                return;
        //            }
        //            if (hi.HitTest == GridHitTest.GroupPanel)
        //            {
        //                info = new ToolTipControlInfo(hi.HitTest, "Group panel");
        //                return;
        //            }

        //            if (hi.HitTest == GridHitTest.RowIndicator)
        //            {
        //                info = new ToolTipControlInfo(GridHitTest.RowIndicator.ToString() + hi.RowHandle.ToString(), "Row Handle: " + hi.RowHandle.ToString());
        //                return;
        //            }
        //        }
        //        finally
        //        {
        //            e.Info = info;
        //        }

                
                
        //    }                
            

        //}
        

        
    }

    public class cFrmRepositoryItemMemoExEdit
    {
        public int codigo { get; set; }
        public string Descricao1 { get; set; }
        public string Descricao2 { get; set; }
        public string Descricao3 { get; set; }
    }

}
