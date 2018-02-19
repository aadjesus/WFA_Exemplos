using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Exemplos.GEDConsultaDeDocumentos
{
    public partial class FrmConsultaDeDocumentos : Form
    {
        public FrmConsultaDeDocumentos()
        {
            InitializeComponent();
            this.treeList1.ExpandAll();
        }

        private void FrmConsultaDeDocumentos_Shown(object sender, EventArgs e)
        {
            gridControl2.DataSource = Enumerable.Range(0, 50)
                .Select(s => new
                {
                    Codigo = s,
                    Descricao = s.GetHashCode(),
                    Data = DateTime.Now.AddDays(s),
                    Imagem = Image.FromFile(@"c:\GlobusMais\Frameworks\FGlobus\Componentes.WinForms\Resources\Logo_GlobusMais_Terminal.png")
                })
                .ToArray();
        }
    }
}


//Codigo Descricao Data Imagem = I