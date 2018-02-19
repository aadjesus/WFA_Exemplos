using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using FGlobus.Util;
using WFA_Workflow.Legenda;

namespace WFA_Workflow
{
    public partial class LegendaDemo : UserControl
    {
        public LegendaDemo()
        {
            InitializeComponent();
        }

        private List<EditorButton> _listaEditorButton = null;
        private ItemLegendaCollection _itemLegendaCollection;

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _listaEditorButton
                .ForEach(f => f.Visible = !f.Visible);

            if (_listaEditorButton.FirstOrDefault().Visible)
            {
                this.Height = 30;
                this.Top = this.Top - this.panelControl1.Height;
            }
            else
            {
                this.Height = 10;
                this.Top = this.Top + this.panelControl1.Height;
            }

        }
        private void CmpLegenda_Load(object sender, EventArgs e)
        {

            if (_listaEditorButton == null)
                _listaEditorButton = this.buttonEdit1.Properties.Buttons
                    .OfType<EditorButton>()
                    .ToList();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(CollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public ItemLegendaCollection ItensLegenda
        {
            get
            {
                if (_itemLegendaCollection == null)
                    _itemLegendaCollection = new ItemLegendaCollection(this);


                //panelControl1.Controls.AddRange(_itensLegenda
                //    .OfType<RadioGroupItem>()
                //    .Except(_radioGroup1.Properties.Items
                //                .OfType<RadioGroupItem>())
                //    .ToArray());

                //if (_itemLegendaCollection != null && _itemLegendaCollection.Count > 0)
                //    panelControl1.Controls.AddRange(_itemLegendaCollection
                //                       .OfType<ItemLegenda>()
                //                       .Select(s => new UserControl1(s.Titulo, s.Cor, s.ToolTip) { Dock = DockStyle.Left })
                //                       .Except(panelControl1.Controls
                //                                   .OfType<UserControl1>())
                //                       .ToArray());
                return _itemLegendaCollection;
            }
        }

        public class ItemLegenda
        {
            public ItemLegenda() { }

            public ItemLegenda(string titulo)
            {
                _titulo = titulo;
            }

            public ItemLegenda(string titulo, Color cor)
            {
                _titulo = titulo;
                _cor = cor;
            }

            public ItemLegenda(string titulo, Color cor, string toolTip)
            {
                _titulo = titulo;
                _cor = cor;
                _toolTip = toolTip;
            }

            private string _titulo;
            private Color _cor = Color.Black;
            private string _toolTip;

            [Category(Constantes.CATEGORIA)]
            [DisplayName("Titulo")]
            [Description("Informa ou retorna o titulo.\nNome: Titulo")]
            [DefaultValue(null)]
            public string Titulo
            {
                get { return _titulo; }
                set { _titulo = value; }
            }

            [Category(Constantes.CATEGORIA)]
            [DisplayName("Cor")]
            [Description("Informa ou retorna o titulo.\nNome: Cor")]
            [DefaultValue(typeof(Color), "Black")]
            public Color Cor
            {
                get { return _cor; }
                set { _cor = value; }
            }

            [Category(Constantes.CATEGORIA)]
            [DisplayName("ToolTip")]
            [Description("Informa ou retorna o tooltip.\nNome: ToolTip")]
            [DefaultValue(null)]
            public string ToolTip
            {
                get { return _toolTip; }
                set { _toolTip = value; }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns>string</returns>
            public override string ToString()
            {
                return String.IsNullOrEmpty(_titulo)
                    ? base.ToString()
                    : String.Concat("Titulo= ",
                                    _titulo,
                                    (String.IsNullOrEmpty(_toolTip) ? "" : ", ToolTip= " + _toolTip));

            }
        }

        public sealed class ItemLegendaCollection : CollectionBase
        {
            private LegendaDemo _ownerCmpLegenda;

            internal ItemLegendaCollection(LegendaDemo ownerCmpLegenda)
            {
                _ownerCmpLegenda = ownerCmpLegenda;
            }

            public ItemLegenda this[int index]
            {
                get
                {
                    return List[index] as ItemLegenda;
                }
                set
                {
                    List[index] = value;
                    //_ownerCmpLegenda.Invalidate();
                }
            }

            protected override void OnInsert(int index, object value)
            {
                ItemLegenda itemLegenda = value as ItemLegenda;
                if (itemLegenda != null)
                {
                    uCtlLegenda wserControl1 = new uCtlLegenda(itemLegenda.Titulo, itemLegenda.Cor, itemLegenda.ToolTip) { Dock = DockStyle.Left };
                    if (!_ownerCmpLegenda.Controls
                        .OfType<uCtlLegenda>()
                        .Contains(wserControl1))
                        _ownerCmpLegenda.Controls.Add(wserControl1);
                }

                base.OnInsert(index, value);
            }

            public int Add(ItemLegenda itemLegenda)
            {
                return base.List.Add(itemLegenda);
            }

            public void AddRange(ItemLegenda[] listaItemLegenda)
            {
                if (listaItemLegenda != null && listaItemLegenda.Count() > 0)
                    listaItemLegenda
                        .ToList()
                        .ForEach(f => this.Add(new ItemLegenda(f.Titulo, f.Cor, f.ToolTip)));
                //foreach (ItemLegenda itemLegenda in listaItemLegenda)
                //    this.Add(itemLegenda);
            }
        }

    }
}
