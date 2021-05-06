using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace E_Maths_Learning
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        /// <summary>
        /// Constructor for the main menu.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            //ImageGenerator.GenerateEquations();
            
            AppStyle.defineStyleCode();
            mainMenuPage.Background = AppStyle.getbackgroundColours()[AppStyle.getStyleCode()];
            titleLabel.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            titleLabel.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            titleLabel.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];

            topicsBtn.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            topicsBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            topicsBtn.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];

            settingsBtn.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            settingsBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            settingsBtn.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];
        }

        /// <summary>
        /// Activates when the "Topics" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicsBtn_Click(object sender, RoutedEventArgs e)
        {
            // Object representing Topic Menu page.
            TopicMenu topicMenu = new TopicMenu();

            // Navigates to the Topic Menu page.            
            NavigationService.Navigate(topicMenu);
        }

        /// <summary>
        /// Event handler for when the "Settings" Button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            // Object representing Flash Card Menu page.
            SettingsPage settingsPage= new SettingsPage();

            // Navigates to the Flash Card Menu page.
            NavigationService.Navigate(settingsPage);
        }
    }
}
