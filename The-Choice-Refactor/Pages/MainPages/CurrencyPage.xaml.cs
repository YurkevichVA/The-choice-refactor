using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using The_Choice_Refactor.Classes;
using The_Choice_Refactor.Pages.ListBoxPages;

namespace The_Choice_Refactor.Pages.MainPages
{
    /// <summary>
    /// Interaction logic for CurrencyPage.xaml
    /// </summary>
    public partial class CurrencyPage : Page
    {
        private CurrencyListPage _list;
        public CurrencyPage()
        {
            InitializeComponent();
            _list = new CurrencyListPage();
            _list.DataContext = new CurrencyVM();
            ListBoxFrame_Frm.Navigate(_list);
        }
        private void favoriteMode_ChBx_Checked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new CurrencyFavoriteVM();
        }
        private void favoriteMode_ChBx_Unchecked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new CurrencyVM();
        }
    }
}
