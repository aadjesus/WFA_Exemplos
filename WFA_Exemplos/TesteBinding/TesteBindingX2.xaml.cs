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

namespace WFA_Exemplos.TesteBinding
{
    /// <summary>
    /// Interaction logic for TesteBindingX2.xaml
    /// </summary>
    public partial class TesteBindingX2 : UserControl
    {
        public TesteBindingX2()
        {
            InitializeComponent();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            xxxxx.Visibility = System.Windows.Visibility.Collapsed == System.Windows.Visibility.Visible
                ? System.Windows.Visibility.Collapsed
                : System.Windows.Visibility.Visible;

        }
    }
}
