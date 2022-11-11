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
            currentPage = new MainPage();
            PageFrame_Frm.Navigate(currentPage);
        }
    }
}
