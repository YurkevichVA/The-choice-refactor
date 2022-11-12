using Newtonsoft.Json;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using The_Choice_Refactor.Classes;
using The_Choice_Refactor.Pages.MainPages;

namespace The_Choice_Refactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Config? config;     // application configuration (theme, language, currency)
        private Page currentPage;   // page that showed in frame at the moment
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();                                                                               // init http client to work with apis
            config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@"..\..\..\UserData\Configuration.json"));  // load configuration from json-file
            WindowState = WindowState.Maximized;
            currentPage = new MainPage();                                                                               // create MainPage and set to current page
            PageFrame_Frm.Navigate(currentPage);                                                                        // navigate frame to current page
        }

        private void MainPage_Btn_Click(object sender, RoutedEventArgs e)
        {
            currentPage = new MainPage();           // create MainPage and set to current page
            PageFrame_Frm.Navigate(currentPage);    // navigate frame to current page
        }

        private void CryptoPage_Btn_Click(object sender, RoutedEventArgs e)
        {
            currentPage = new CryptoPage();
            PageFrame_Frm.Navigate(currentPage);
        }

        private void CurrencyPage_Btn_Click(object sender, RoutedEventArgs e)
        {
            // to implement
        }

        private void MetalPage_Btn_Click(object sender, RoutedEventArgs e)
        {
            // to implement
        }

        private void SharePage_Btn_Click(object sender, RoutedEventArgs e)
        {
            // to implement
        }

        private void Options_Btn_Click(object sender, RoutedEventArgs e)
        {
            OptionsWindow options = new OptionsWindow(config);
            options.ShowDialog();
        }
    }
}
