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
    /// Interaction logic for TopicMenu.xaml
    /// </summary>
    public partial class TopicMenu : Page
    {
        public TopicMenu()
        {
            InitializeComponent();

            topics = new CheckBox[] { algebraCheckBox, calculusCheckBox, geometryCheckBox, simultaneousEquationCheckBox, trigonometryCheckBox };

            topicChecked = false;

            topicMenuPage.Background = AppStyle.getbackgroundColours()[AppStyle.getStyleCode()];
            topicTitleLabel.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            topicBorder.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            studyBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            randomBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            homeBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            topicOptionsBox.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            algebraCheckBox.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            calculusCheckBox.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            geometryCheckBox.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            simultaneousEquationCheckBox.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            trigonometryCheckBox.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];

            topicTitleLabel.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];

            homeBtn.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            randomBtn.Foreground = AppStyle.getTextColours()[AppStyle.getStyleCode()];
            homeBtn.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];
            randomBtn.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];

            topicTitleLabel.BorderBrush = AppStyle.getBoxOutlineColours()[AppStyle.getStyleCode()];
        }

        private CheckBox[] topics;

        private bool topicChecked;

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            // main menu object.
            MainMenu mainMenu = new MainMenu();

            // Sets the frame to the main menu page.
            this.NavigationService.Navigate(mainMenu);
        }

        /// <summary>
        /// Event handler for when the Study button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudyBtn_Click(object sender, RoutedEventArgs e)
        {
            // If topics have been selected...
            if (topicsSelected() == true)
            {
                // Study page object.
                Study studyPage = new Study(topics);

                // Navigate to the study page.
                NavigationService.Navigate(studyPage);
            }

            // Otherwise... 
            else 
            {
                // Message box informing that no topics have been selected and asks the user to select a topic. 
                MessageBoxResult result = MessageBox.Show("Please Select A Topic.", "No Topic Selected", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void testBtn_Click(object sender, RoutedEventArgs e)
        {
            if (topicsSelected() == true)
            {
                // quizPage object.
                QuizPage quizPage = new QuizPage(topics);

                // Sets the frame to the topic menu page.
                NavigationService.Navigate(quizPage);
            }

            else
            {
                MessageBoxResult result = MessageBox.Show("Please Select A Topic.", "No Topic Selected", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private Boolean topicsSelected()
        {
            foreach (CheckBox topic in topics)
            {
                if (topic.IsChecked == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}