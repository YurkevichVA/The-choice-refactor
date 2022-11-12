using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using The_Choice_Refactor.Classes;
using The_Choice_Refactor.Pages.ListBoxPages;

namespace The_Choice_Refactor.Pages.MainPages
{
    /// <summary>
    /// Interaction logic for SharePage.xaml
    /// </summary>
    public partial class SharePage : Page
    {
        private ShareListPage _list;
        public SharePage()
        {
            InitializeComponent();
            _list = new ShareListPage();
            _list.DataContext = new ShareVM();
            ListBoxFrame_Frm.Navigate(_list);
        }

        private void favoriteMode_ChBx_Checked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new ShareFavoriteVM();
        }

        private void favoriteMode_ChBx_Unchecked(object sender, RoutedEventArgs e)
        {
            _list.DataContext = new ShareVM();
        }
    }
}
