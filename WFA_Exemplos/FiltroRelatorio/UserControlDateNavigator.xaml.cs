using System;
using System.Windows;
using System.Windows.Controls;

namespace WFA_Workflow.WPFDateNavigator
{
    /// <summary>
    /// Interaction logic for UserControlDateNavigator.xaml
    /// </summary>
    public partial class UserControlDateNavigator : UserControl
    {
        public UserControlDateNavigator()
        {
            InitializeComponent();
        }

        private void dateNavigator1_Loaded(object sender, RoutedEventArgs e)
        {
            dateNavigator1.SpecialDates.Add(new DateTime(2013, 8, 5));
            dateNavigator1.SpecialDates.Add(new DateTime(2013, 8, 6));
            dateNavigator1.SpecialDates.Add(DateTime.Now);     
        }
        
    }
}
