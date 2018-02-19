using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using DevExpress.Xpf.LayoutControl;
using FGlobus.Util.ExtensaoLinq;
using DevExpress.Xpf.Core;

namespace WFA_Exemplos.TesteBinding
{
    /// <summary>
    /// Interaction logic for TesteBinding.xaml
    /// </summary>
    public partial class TesteBindingX : UserControl
    {
        public TesteBindingX()
        {
            InitializeComponent();
        }

        private BindingAba _bindingAbaAssociados;
        private static List<BindingAba> _listaBindingAba;

        public BindingAba AbaAssociados
        {
            get
            {
                if (_bindingAbaAssociados == null)
                    _bindingAbaAssociados = new BindingAba()
                    {
                        Codigo = -1,
                        Descricao = "Associados"
                    };

                return _bindingAbaAssociados;
            }
            set { _bindingAbaAssociados = value; }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            _listaBindingAba = new List<BindingAba>();

            _listaBindingAba.Add(this.AbaAssociados);
            _listaBindingAba.AddRange(Enumerable.Range(1, 10)
                  .Aggregate(new List<BindingAba>(), (a, b) =>
                  {
                      BindingAba bindingAba = new BindingAba()
                      {
                          Codigo = b,
                          Descricao = "BindingAba - " + b.ToString(),
                          ListaItem = Enumerable.Range(1, random.Next(2, b + 50))
                              .Aggregate(new List<BindingItem>(), (a1, b1) =>
                              {
                                  a1.Add(new BindingItem()
                                  {
                                      CodigoPai = b,
                                      Codigo = b1,
                                      Descricao = "BindingItem - " + b1.ToString(),
                                  });

                                  return a1;
                              })
                      };
                      a.Add(bindingAba);

                      this.AbaAssociados.ListaItemGeral.AddRange(bindingAba.ListaItem);
                      
                      return a;
                  }));

            this.DXTabControl1.ItemsSource = _listaBindingAba
                .OrderBy(o => o.Codigo)
                .ToArray();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            Tile tile = sender as Tile;
            if (tile != null)
            {
                BindingItem bindingItem = tile.DataContext as BindingItem;
                if (bindingItem != null)
                    bindingItem.Marcou = !bindingItem.Marcou;

                this.DXTabControl1.Items.Refresh();
                tile.DataContext = null;
                tile.DataContext = bindingItem;
            }
        }

        private void Button_MarcarOuDesmarcar(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                (button.Tag as List<BindingItem>)
                    .ForEach(f => f.Marcou = button.Content.Equals("Marcar"));

                //((button.DataContext as DevExpress.Xpf.Core.DXTabItem)).Owner	{DevExpress.Xpf.Core.DXTabControl Items.Count:11}	DevExpress.Xpf.Core.ITabControl {DevExpress.Xpf.Core.DXTabControl}

                //(DXTabControl1.Items[0] as DXTabItem).Content

                //DXTabItem dXTabItem = (button.DataContext as DevExpress.Xpf.Core.DXTabItem);
                //dXTabItem.UpdateLayout();
                this.DXTabControl1.Items.Refresh();
            }
        }
    }

    public class FormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IEnumerable<BindingItem> listaBindingItem = value as IEnumerable<BindingItem>;
            if (listaBindingItem != null &&
                listaBindingItem
                    .GroupBy(g => g.CodigoPai)
                    .Count() > 1)
            {
                return listaBindingItem
                    .Where(w => w.Marcou)
                    .ToList();
            }
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BindingAba
    {
        #region Atributos

        private int _qtdeItens;
        private int _qtdeItensMarcados;
        private List<BindingItem> _listaItem;
        private List<BindingItem> _listaItemGeral;
        private string _descricao;


        #endregion

        #region Propriedades

        public int Codigo { get; set; }
        public string Descricao { get ; set; }

        public List<BindingItem> ListaItem
        {
            get
            {
                if (_listaItem == null)
                    _listaItem = new List<BindingItem>();

                return this.Codigo == -1
                    ? _listaItemGeral
                    : _listaItem;
            }
            set { _listaItem = value; }
        }
        public List<BindingItem> ListaItemGeral
        {
            get
            {
                if (_listaItemGeral == null)
                    _listaItemGeral = new List<BindingItem>();

                return _listaItemGeral;
            }
            set { _listaItemGeral = value; }
        }

        public int QtdeItens
        {
            get
            {
                return this.ListaItem.Count;
            }
            set { _qtdeItens = value; }
        }
        public int QtdeItensMarcados
        {
            get
            {
                return this.ListaItem.Count(c => c.Marcou);
            }
            set { _qtdeItensMarcados = value; }
        }

        #endregion
    }

    public class BindingItem
    {
        #region Propriedades

        public int CodigoPai { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Marcou { get; set; }
        public bool Todos { get; set; }

        #endregion
    }

}
