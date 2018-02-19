using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using eOcultar = WFA_Exemplos.GroupControlBGM.GroupControlBGMDemoX.eOcultar;
using FGlobus.Util;

namespace WFA_Exemplos.GroupControlBGM
{
    [ToolboxItem(true)]
    public partial class GroupControlBGMDemoXOcultar : UserControl
    {
        public GroupControlBGMDemoXOcultar(object valor)
        {
            InitializeComponent();

            _ocultar = valor.Converter<eOcultar>();

            this.btnLeft.Tag = eOcultar.Left;
            this.btnRight.Tag = eOcultar.Right;
            this.btnTop.Tag = eOcultar.Top;
            this.btnNenhum.Tag = eOcultar.None;
            this.btnBotton.Tag = eOcultar.Bottom;

            foreach (var item in this.ListaCheckButton)
                item.Checked = item.Tag.Converter<eOcultar>() == _ocultar;
        }

        private void btnNenhum_Click(object sender, EventArgs e)
        {
            CheckButton checkButton = sender as CheckButton;
            foreach (var item in this.ListaCheckButton)
                item.Checked = item.Name == checkButton.Name && !checkButton.Checked;

            _ocultar = checkButton.Tag.Converter<eOcultar>();
            Image = checkButton.Image;
        }

        private eOcultar _ocultar;
        public Image Image {get;set;}
        

        public eOcultar Ocultar
        {
            get
            {
                return _ocultar;
            }
        }

        private IEnumerable<CheckButton> _listaCheckButton;

        private IEnumerable<CheckButton> ListaCheckButton
        {
            get
            {
                if (_listaCheckButton.NuloOuVazio())
                    _listaCheckButton = tableLayoutPanel1.Controls
                        .OfType<CheckButton>();

                return _listaCheckButton;
            }
        }

    }
}
