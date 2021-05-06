using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using MSHTML;

namespace E_Maths_Learning
{
    /// <summary>
    /// Interaction logic for Topic.xaml
    /// </summary>
    public partial class Study : Page
    {
        public Study(CheckBox[] topics)
        {
            InitializeComponent();

            if (topics[0].IsChecked == false)
            {
                topicTree.Items.Remove(algebraTreeItem);
            }

            if (topics[1].IsChecked == false)
            {
                topicTree.Items.Remove(calculusTreeItem);
            }

            if (topics[2].IsChecked == false)
            {
                topicTree.Items.Remove(geometryTreeItem);
            }

            if (topics[3].IsChecked == false)
            {
                topicTree.Items.Remove(simEquTreeItem);
            }

            if (topics[4].IsChecked == false)
            {
                topicTree.Items.Remove(trigonometryTreeItem);
            }

            studyPage.Background = AppStyle.getbackgroundColours()[AppStyle.getStyleCode()];
            topicTree.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            topicNameLabel.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            webBrowserBorder.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            webBrowser.Visibility = Visibility.Hidden;
        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            // topic menu object.
            TopicMenu topicMenu = new TopicMenu();

            // Sets the frame to the topic menu page.
            NavigationService.Navigate(topicMenu);
        }
        
        private void algebraTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Algebra.html"));

            topicNameLabel.Content = "Topic: " + "Algebra";

            webBrowser.Visibility = Visibility.Visible;
        }

        private void calculusTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (calculusTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Calculus.html"));
                topicNameLabel.Content = "Topic: " + "Calculus";
            }

            webBrowser.Visibility = Visibility.Visible;
        }

        private void differentiationTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (differentiationTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Calculus.html#Differentiation"));
                topicNameLabel.Content = "Topic: " + "Calculus - Differentiation";
            }

            webBrowser.Visibility = Visibility.Visible;
        }
        
        private void integrationTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (integrationTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Calculus.html#Integration"));
                topicNameLabel.Content = "Topic: " + "Calculus - Integration";
            }

            webBrowser.Visibility = Visibility.Visible;
        }

        private void geometryTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (geometryTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Geometry.html"));
                topicNameLabel.Content = "Topic: " + "Geometry";
            }
        }
        
        private void lineEquTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (lineEquTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Geometry.html#Equation_of_a_Straight_Line"));
                topicNameLabel.Content = "Topic: " + "Geometry";
            }

            webBrowser.Visibility = Visibility.Visible;
        }

        private void gradientTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (gradientTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Geometry.html#Gradient_of_a_Straight_Line"));
                topicNameLabel.Content = "Topic: " + "Geometry";
            }

            webBrowser.Visibility = Visibility.Visible;
        }

        private void midpointTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (midpointTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Geometry.html#Midpoint_of_a_Line"));
                topicNameLabel.Content = "Topic: " + "Geometry";
            }

            webBrowser.Visibility = Visibility.Visible;
        }

        private void distenceTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (distenceTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Geometry.html#Distence_between_two_points"));
                topicNameLabel.Content = "Topic: " + "Geometry";
            }

            webBrowser.Visibility = Visibility.Visible;
        }

        private void simEquTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (simEquTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\SimultaneousEquations.html"));
                topicNameLabel.Content = "Topic: " + "Simultaneous Equations";
            }
        }

        private void SubMethodTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (SubMethodTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\SubstitutionMethod.html"));
                topicNameLabel.Content = "Topic: " + "Simultaneous Equations";
            }

            topicNameLabel.Content = "Topic: " + "Simultaneous Equations Substitution Method";

            webBrowser.Visibility = Visibility.Visible;
        }

        private void RedMethodTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            if (RedMethodTreeItem.IsSelected == true)
            {
                webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\ReductionMethod.html"));
                topicNameLabel.Content = "Topic: " + "Simultaneous Equations";
            }

            topicNameLabel.Content = "Topic: " + "Simultaneous Equations Reduction Method";

            webBrowser.Visibility = Visibility.Visible;
        }

        private void trigonometryTreeItem_Selected(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri(string.Format(Directory.GetCurrentDirectory() + "\\Trigonometry.html"));
            topicNameLabel.Content = "Topic: " + "Trigonometry";

            webBrowser.Visibility = Visibility.Visible;
        }


    }
}