using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Exemplos.TreeList
{
    public partial class FrmTreeList : Form
    {
        public FrmTreeList()
        {
            InitializeComponent();
        }

        private void FrmTreeList_Shown(object sender, EventArgs e)
        {
            List<Teste> lista = new List<Teste>();
            lista.Add(new Teste() { Codigo = "1", ParentCodigo = "0" });
            lista.Add(new Teste() { Codigo = "2", ParentCodigo = "1" });
            lista.Add(new Teste() { Codigo = "3", ParentCodigo = "2" });
            lista.Add(new Teste() { Codigo = "4", ParentCodigo = "1" });
            lista.Add(new Teste() { Codigo = "5", ParentCodigo = "3" });
            lista.Add(new Teste() { Codigo = "6", ParentCodigo = "1" });

            lista.Add(new Teste() { Codigo = "10", ParentCodigo = "00" });
            lista.Add(new Teste() { Codigo = "20", ParentCodigo = "10" });
            lista.Add(new Teste() { Codigo = "30", ParentCodigo = "20" });
            lista.Add(new Teste() { Codigo = "40", ParentCodigo = "10" });
            lista.Add(new Teste() { Codigo = "50", ParentCodigo = "30" });
            lista.Add(new Teste() { Codigo = "60", ParentCodigo = "10" });

            lista.Add(new Teste() { Codigo = "10-01", ParentCodigo = "00-01" });
            lista.Add(new Teste() { Codigo = "20-01", ParentCodigo = "10-01" });
            lista.Add(new Teste() { Codigo = "30-01", ParentCodigo = "20-01" });
            lista.Add(new Teste() { Codigo = "40-01", ParentCodigo = "10-01" });
            lista.Add(new Teste() { Codigo = "50-01", ParentCodigo = "30-01" });
            lista.Add(new Teste() { Codigo = "60-01", ParentCodigo = "10-01" });


            lista.Add(new Teste() { Codigo = "10-02", ParentCodigo = "00-02" });
            lista.Add(new Teste() { Codigo = "20-02", ParentCodigo = "10-02" });
            lista.Add(new Teste() { Codigo = "30-02", ParentCodigo = "20-02" });
            lista.Add(new Teste() { Codigo = "40-02", ParentCodigo = "10-02" });
            lista.Add(new Teste() { Codigo = "50-02", ParentCodigo = "30-02" });
            lista.Add(new Teste() { Codigo = "60-02", ParentCodigo = "10-02" });

            treeList1.DataSource = lista;
        }

        private void treeList1_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e)
        {
            e.NodeImageIndex = e.Node.HasChildren
                ? (e.Node.Expanded
                    ? 1
                    : 0)
                : 2;

        }
    }

    public class Teste
    {
        public string Codigo { get; set; }
        public string ParentCodigo { get; set; }
    }
}
