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

namespace E_Maths_Learning
{
    /// <summary>
    /// Interaction logic for FlashCardMenu.xaml
    /// </summary>
    public partial class FlashCardMenu : Page
    {
        public FlashCardMenu()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // main menu object.
            MainMenu mainMenu = new MainMenu();

            // Sets the frame to the main menu page.
            this.NavigationService.Navigate(mainMenu);
        }
    }
}
