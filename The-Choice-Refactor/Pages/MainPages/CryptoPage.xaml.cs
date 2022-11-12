using System.Windows;
using System.Windows.Controls;
using The_Choice_Refactor.Pages.ListBoxPages;
using The_Choice_Refactor.Classes;

namespace The_Choice_Refactor.Pages.MainPages
{
    /// <summary>
    /// Interaction logic for CryptoPage.xaml
    /// </summary>
    public partial class CryptoPage : Page
    {
        private CryptoListPage _list;
        public CryptoPage()
        {
            InitializeComponent();
            _list = new CryptoListPage();
            _list.DataContext = new CryptoVM();
            ListBoxFrame_Frm.Navigate(_list);
        }

        private void favoriteMode_ChBx_Checked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new CryptoFavoriteVM();
        }

        private void favoriteMode_ChBx_Unchecked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new CryptoVM();
        }
    }
}
