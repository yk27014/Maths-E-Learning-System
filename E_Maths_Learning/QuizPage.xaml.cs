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
using System.Windows.Shapes;
using WpfMath;

namespace E_Maths_Learning
{
    /// <summary>
    /// Interaction logic for QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Page
    {
        public QuizPage(CheckBox[] topics)
        {
            InitializeComponent();

            if (topics[0].IsChecked == true)
            {
                topicList.Add(0);

                algebraCorrectCount = 0;
                algebraIncorrectCount = 0;

                algebraCorrectLabel.Content = algebraCorrectCount.ToString();
                algebraIncorrectLabel.Content = algebraIncorrectCount.ToString();
            }

            if (topics[1].IsChecked == true)
            {
                topicList.Add(1);

                calculusCorrectCount = 0;
                calculusIncorrectCount = 0;

                calculusCorrectLabel.Content = calculusCorrectCount.ToString();
                calculusIncorrectLabel.Content = calculusIncorrectCount.ToString();
            }

            if (topics[2].IsChecked == true)
            {
                topicList.Add(2);

                geometryCorrectCount = 0;
                geometryIncorrectCount = 0;

                geometryCorrectLabel.Content = geometryCorrectCount.ToString();
                geometryIncorrectLabel.Content = geometryIncorrectCount.ToString();
            }

            if (topics[3].IsChecked == true)
            {
                topicList.Add(3);

                simultaneousEquationCorrectCount = 0;
                simultaneousEquationIncorrectCount = 0;

                simEqCorrectLabel.Content = simultaneousEquationCorrectCount.ToString();
                simEqIncorrectLabel.Content = simultaneousEquationIncorrectCount.ToString();
            }

            if (topics[4].IsChecked == true)
            {
                topicList.Add(4);

                trigonometryCorrectCount = 0;
                trigonometryIncorrectCount = 0;

                trigCorrectLabel.Content = trigonometryCorrectCount.ToString();
                trigIncorrectLabel.Content = trigonometryIncorrectCount.ToString();
            }
             
            imgList.Add(queImg1);
            imgList.Add(queImg2);

            skipBtn.IsEnabled = false;
            toggleAnsBtn.IsEnabled = false;

            quizPage.Background = AppStyle.getbackgroundColours()[AppStyle.getStyleCode()];
            questionLabel.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            statsGrid1.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            clipboardBox.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            queImgBorder.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            AnsImgBorder.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            inputTxtBox.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            answerBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            skipBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            homeBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            fractionBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            powerBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            endQuizBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            toggleAnsBtn.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            queImg1Border.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            queImg2Border.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            ansImg1Border.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            ansImg2Border.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];

            ans1TxtBox.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
            ans2TxtBox.Background = AppStyle.getBoxColours()[AppStyle.getStyleCode()];
        }

        private MathsEngine mathsEngine = new MathsEngine();
        private List<Image> imgList = new List<Image>() { };
        private List<float> topicList = new List<float>() { };
        
        private Random random = new Random();

        private string quizMode = "";

        private int questionCountID = 0;
        private int questionCount = 0;

        private bool displayAnswer = false;

        private int algebraCorrectCount;
        private int algebraIncorrectCount;

        private int calculusCorrectCount;
        private int calculusIncorrectCount;

        private int geometryCorrectCount;
        private int geometryIncorrectCount;

        private int simultaneousEquationCorrectCount;
        private int simultaneousEquationIncorrectCount;

        private int trigonometryCorrectCount;
        private int trigonometryIncorrectCount;

        private int correctCount;
        private int incorrectCount;

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            // main menu object.
            MainMenu mainMenu = new MainMenu();

            // Sets the frame to the main menu page.
            this.NavigationService.Navigate(mainMenu);
        }

        private void answerBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((answerBtn.Content.ToString() == "Start") || (answerBtn.Content.ToString() == "Next Question"))
            {
                if (answerBtn.Content.ToString() == "Start")
                {
                    skipBtn.IsEnabled = true;
                    toggleAnsBtn.IsEnabled = true;
                }

                answerBtn.Content = "Answer";
                nextQuestion();

                questionCount += 1;
                questionCountLabel.Content = questionCount;
            }

            else if (answerBtn.Content.ToString() == "Answer")
            {
                List<string> tempAns = new List<string>() { };
                 
                if (mathsEngine.getAnswers().Count > 1)
                {
                    tempAns.Add(ans1TxtBox.Text);
                    tempAns.Add(ans2TxtBox.Text);
                }

                else
                {
                    tempAns.Add(inputTxtBox.Text);
                }

                if (mathsEngine.checkAnswers(tempAns, true))
                {
                    resultLabel.Content = "Correct";
                    correctCount += 1;

                    if (topicList[questionCountID] == 0)
                    {
                        algebraCorrectCount += 1;
                        algebraCorrectLabel.Content = algebraCorrectCount.ToString();
                    }

                    else if (topicList[questionCountID] == 1)
                    {
                        calculusCorrectCount += 1;
                        calculusCorrectLabel.Content = calculusCorrectCount.ToString();
                    }

                    else if (topicList[questionCountID] == 2)
                    {
                        geometryCorrectCount += 1;
                        geometryCorrectLabel.Content = geometryCorrectCount.ToString();
                    }

                    else if (topicList[questionCountID] == 3)
                    {
                        simultaneousEquationCorrectCount += 1;
                        simEqCorrectLabel.Content = simultaneousEquationCorrectCount.ToString();
                    }
                    
                    else
                    {
                        trigonometryCorrectCount += 1;
                        trigCorrectLabel.Content = trigonometryCorrectCount.ToString();
                    }

                }

                else
                {
                    resultLabel.Content = "Incorrect";
                    incorrectCount += 1;

                    textToImg(mathsEngine.getAnswers()[0], ansImg);

                    if (topicList[questionCountID] == 0)
                    {
                        algebraIncorrectCount += 1;
                        algebraIncorrectLabel.Content = algebraIncorrectCount.ToString();
                    }

                    else if (topicList[questionCountID] == 1)
                    {
                        calculusIncorrectCount += 1;
                        calculusIncorrectLabel.Content = calculusIncorrectCount.ToString();
                    }

                    else if (topicList[questionCountID] == 2)
                    {
                        geometryIncorrectCount += 1;
                        geometryIncorrectLabel.Content = geometryIncorrectCount.ToString();
                    }

                    else if (topicList[questionCountID] == 3)
                    {
                        simultaneousEquationIncorrectCount += 1;
                        simEqIncorrectLabel.Content = simultaneousEquationIncorrectCount.ToString();
                    }

                    else
                    {
                        trigonometryIncorrectCount += 1;
                        trigIncorrectLabel.Content = trigonometryIncorrectCount.ToString();
                    }
                }
                
                answerBtn.Content = "Next Question";
            }
        }

        private void inputTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textToImg(inputTxtBox.Text, ansImg);
        }

        private void ans1TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textToImg(ans1TxtBox.Text, ansImg1);
        }

        private void ans2TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textToImg(ans2TxtBox.Text, ansImg2);
        }

        private void skipBtn_Click(object sender, RoutedEventArgs e)
        {
            inputTxtBox.Clear();
            ansImg.Source = null;
            textToImg("", queImg);
            nextQuestion();
        }

        private void textToImg(string text, Image img)
        {
            if (text.Length > 0)
            {
                try
                {
                    var parser = new TexFormulaParser();

                    var formula = parser.Parse(text);

                    var renderer = formula.GetRenderer(TexStyle.Text, 375.0, "Cambria Math");

                    var bitmapSource = renderer.RenderToBitmap(0.0, 0.0);

                    img.Source = bitmapSource;

                }

                catch
                {

                }
            }

            else
            {
                img.Source = null;
            }
        }

        private void nextQuestion()
        {
            questionCountID = random.Next(topicList.Count);
            mathsEngine.genQuestion(topicList[questionCountID]);

            if (mathsEngine.getQuestions().Count > 1)
            {
                twoQueDisp.Visibility = Visibility.Visible;

                queImgBorder.Visibility = Visibility.Hidden;

                for (int i = 0; i < mathsEngine.getQuestions().Count; i++)
                {
                    textToImg(mathsEngine.getQuestions()[i], imgList[i]);
                }
            }

            else
            {
                twoQueDisp.Visibility = Visibility.Hidden;

                queImgBorder.Visibility = Visibility.Visible;
                
                textToImg(mathsEngine.getQuestions()[0], queImg);
            }

            if (mathsEngine.getAnswers().Count > 1)
            {
                ans1TxtBox.Clear();
                ans2TxtBox.Clear();

                textToImg("", ansImg1);
                textToImg("", ansImg2);

                textToImg("", queImg1);
                textToImg("", queImg2);

                twoAnsInput.Visibility = Visibility.Visible;
                twoAnsDisp.Visibility = Visibility.Visible;

                inputTxtBox.Visibility = Visibility.Hidden;
                AnsImgBorder.Visibility = Visibility.Hidden;

                xLabel.Content = mathsEngine.getVarNames()[0];
                yLabel.Content = mathsEngine.getVarNames()[1];

                for (int i = 0; i < mathsEngine.getQuestions().Count; i++)
                {
                    textToImg(mathsEngine.getQuestions()[i], imgList[i]);
                }
            }

            else
            {
                inputTxtBox.Clear();
                textToImg("", ansImg);
                textToImg("", queImg);

                twoAnsInput.Visibility = Visibility.Hidden;
                twoAnsDisp.Visibility = Visibility.Hidden;

                inputTxtBox.Visibility = Visibility.Visible;
                AnsImgBorder.Visibility = Visibility.Visible;

                textToImg(mathsEngine.getQuestions()[0], queImg);
            }

            questionLabel.Content = mathsEngine.getQuestionText();
        }

        private void toggleAnsBtn_Click(object sender, RoutedEventArgs e)
        {
            displayAnswer = !displayAnswer;

            if (displayAnswer == true)
            {
                if (mathsEngine.getAnswers().Count == 1)
                {
                    textToImg(mathsEngine.getAnswers()[0], ansImg);
                }

                else
                {
                    textToImg(mathsEngine.getAnswers()[0], ansImg1);
                    textToImg(mathsEngine.getAnswers()[1], ansImg2);
                }
            }

            else
            {
                if (mathsEngine.getAnswers().Count == 1)
                {
                    textToImg(inputTxtBox.Text, ansImg);
                }

                else
                {
                    textToImg(ans1TxtBox.Text, ansImg1);
                    textToImg(ans2TxtBox.Text, ansImg2);
                }
                textToImg("", queImg);
            }

        }

        private void fractionBtn_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("\\frac{x}{y}");
        }

        private void powerBtn_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("x^y");
        }

        private void endQuizBtn_Click(object sender, RoutedEventArgs e)
        {
            float total = correctCount + incorrectCount;

            if (total != 0)
            {
                MessageBoxResult result = MessageBox.Show((((float)correctCount / total) * 100).ToString() + "%", "Results", MessageBoxButton.OK);
            }

            // main menu object.
            TopicMenu topicMenu = new TopicMenu();

            // Sets the frame to the main menu page.
            this.NavigationService.Navigate(topicMenu);
        }
    }
}
