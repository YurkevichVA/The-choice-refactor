using System;
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
using System.Windows.Shapes;
using The_Choice_Refactor.Classes;
using The_Choice_Refactor.Pages.OptionsPages;

namespace The_Choice_Refactor
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        private Config config;      // application configuration (theme, language, currency)
        private Page currentPage;   // page that showed in frame at the moment
        public OptionsWindow(Config config)
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;      // ban resizing 
            this.config = config;
            currentPage = new MainOptionsPage();        // create MainOptionsPage and set to current page
            OptionsFrame_Frm.Navigate(currentPage);     // navigate frame to current page
        }

        private void MainOptions_Btn_Click(object sender, RoutedEventArgs e)
        {
            currentPage = new MainOptionsPage();        // create MainOptionsPage and set to current page
            OptionsFrame_Frm.Navigate(currentPage);     // navigate frame to current page
        }

        private void Tutorial_Btn_Click(object sender, RoutedEventArgs e)
        {
            currentPage = new TutorialPage();           // create TutorialPage and set to current page
            OptionsFrame_Frm.Navigate(currentPage);     // navigate frame to current page
        }

        private void AboutUs_Btn_Click(object sender, RoutedEventArgs e)
        {
            currentPage = new AboutUsPage();            // create AboutUsPage and set to current page
            OptionsFrame_Frm.Navigate(currentPage);     // navigate frame to current page
        }
    }
}
