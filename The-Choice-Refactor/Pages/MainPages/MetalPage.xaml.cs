using System.Windows;
using System.Windows.Controls;
using The_Choice_Refactor.Classes;
using The_Choice_Refactor.Pages.ListBoxPages;

namespace The_Choice_Refactor.Pages.MainPages
{
    /// <summary>
    /// Interaction logic for MetalPage.xaml
    /// </summary>
    public partial class MetalPage : Page
    {
        private MetalListPage _list;
        public MetalPage()
        {
            InitializeComponent();
            _list = new MetalListPage();
            _list.DataContext = new MetalVM();
            ListBoxFrame_Frm.Navigate(_list);
        }
        private void favoriteMode_ChBx_Checked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new MetalFavoriteVM();
        }

        private void favoriteMode_ChBx_Unchecked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new MetalVM();
        }
    }
}
