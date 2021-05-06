using System;
using System.Collections.Generic;
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
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace E_Maths_Learning
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            changeStyle();
        }

        private string[] files = { "StyleDefault.css", "StyleDyslexic.css", "StyleHighContrast.css" };
        private string currentStyle;

        private void styleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (string fileName in files)
            {
                if (File.Exists("CSS_Styles\\" + fileName) == false)
                {
                    currentStyle = fileName;
                }
            }

            File.Move("CSS_Styles\\StyleSheet.css", "CSS_Styles\\" + currentStyle);
            File.Move("CSS_Styles\\Style" + Regex.Replace(((ComboBoxItem)styleComboBox.SelectedItem).Content.ToString() + ".css", @"\s+", ""), "CSS_Styles\\StyleSheet.css");
            File.Delete("CSS_Styles\\Style" + Regex.Replace(((ComboBoxItem)styleComboBox.SelectedItem).Content.ToString() + ".css", @"\s+", ""));

            AppStyle.defineStyleCode();
            changeStyle();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // main menu object.
            MainMenu mainMenu = new MainMenu();

            // Sets the frame to the main menu page.
            this.NavigationService.Navigate(mainMenu);
        }

        private void changeStyle()
        {
            settingsPage.Background = AppStyle.getbackgroundColours()[AppStyle.getStyleCode()];

            settingsLabel.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            settingsLabel.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            settingsLabel.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];

            homeBtn.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            homeBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            homeBtn.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];
        }
    }
}
