using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace E_Maths_Learning
{
    class MathsEngine
    {
        public MathsEngine()
        {
            questions = new List<string> { };
            answers = new List<string> { };
            random = new Random();

            questionIDs = new List<float> { };
            questionIDs.Add(2);
            questionIDs.Add(5);
        }

        private List<float> questionIDs;

        private List<string> questions;
        private List<string> answers;
        private List<string> ansVar;

        private string topic;

        private string questionText;

        private Random random;

        // 
        Variables variable;

        // Struct to store all the algebraic 
        struct Variables
        {
            public float a;
            public float b;
            public float c;

            public float d;
            public float e;
            public float f;

            public float g;
            public float h;
            public float i;

            public float m;

            public float u;
            public float v;
            public float w;

            public float x;
            public float y;
            public float z;
        }

        /// <summary>
        /// Gets the question(s).
        /// </summary>
        /// <returns>A List<string> of the question(s)</returns>
        public List<string> getQuestions()
        {
            return questions;
        }

        public List<string> getAnswers()
        {
            return answers;
        }

        public List<string> getVarNames()
        {
            return ansVar;
        }

        public string getQuestionText()
        {
            return questionText;
        }

        public void genQuestion(float qId)
        {
            questions = new List<string> { };
            answers = new List<string> { };
            ansVar = new List<string> { };

            int questionID = 0;

            switch (qId)
            {
                // Algebra
                case 0:                    
                    questionID = random.Next(0, 3);

                    // Expansion question.
                    if (questionID == 0)
                    {
                        genExpansionQuestion();
                        questionText = "Expand the following";
                    }

                    // Factorisation 
                    else if (questionID == 1)
                    {
                        genFactorisationQue();
                        questionText = "Factorise";
                    }

                    // Algerbraic Eqaution
                    else if (questionID == 2)
                    {
                        genAlgerbriacQue();
                    }

                    break;

                // Calculus
                case 1:
                    questionID = random.Next(0, 2);

                    if (questionID == 0)
                    {
                        genDyDxQue();
                        questionText = "Differentiate";
                    }

                    if (questionID == 1)
                    {
                        genIntergrationQue();
                        questionText = "Integrate";
                    }

                    break;

                // Geometry
                case 2:
                    questionID = random.Next(0, 3);

                    // Line Equation 1
                    if (questionID == 0)
                    {
                        genLineEq();
                    }

                    // Midpoint of a Line
                    if (questionID == 1)
                    {
                        genMidPointEq();
                    }

                    // Distance between two points
                    if (questionID == 2)
                    {
                        genDistenceQue();
                    }

                    break;

                // Simultaneous Equations
                case 3:
                    questionText = "Find the value of x and y";
                    genSimEq();
                    break;

                // Trigonometry
                case 4:
                    questionID = random.Next(0, 3);

                    // Line Equation 1
                    if (questionID == 0)
                    {
                        genLineEq();
                    }

                    // Midpoint of a Line
                    if (questionID == 1)
                    {
                        genMidPointEq();
                    }

                    // Distance between two points
                    if (questionID == 2)
                    {
                        genDistenceQue();
                    }

                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        public void genExpansionQuestion()
        {
            // (ax±b)^c(dx±e)^f(gx±h)^i

            int groupCount;
            int numOfValueX;
            int numOfValueInt;
            string equation;
            int count;
            List<int> terms;

            do
            {
                groupCount = 0;
                numOfValueX = 0;
                numOfValueInt = 0;
                equation = "";
                count = 0;
                terms = new List<int>();

                if (groupCount < 3)
                {
                    variable.a = random.Next(-8, 8);
                    variable.b = random.Next(-8, 8);
                    variable.c = random.Next(0, 4);

                    groupCount += Convert.ToInt32(variable.c);

                    if ((groupCount <= 3) && ((variable.c > 0) && ((variable.a != 0) || (variable.b != 0))))
                    {
                        equation += String.Format("({0}x{1})^{2}", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString());
                        numOfValueX += Convert.ToInt32(variable.a);
                        numOfValueInt += Convert.ToInt32(variable.b);

                        while (count < variable.c)
                        {
                            terms.Add(Convert.ToInt32(variable.a));
                            terms.Add(Convert.ToInt32(variable.b));
                            count++;
                        }
                    }
                }

                if (groupCount < 3)
                {
                    variable.d = random.Next(-8, 8);
                    variable.e = random.Next(-8, 8);
                    variable.f = random.Next(0, 4);

                    groupCount += Convert.ToInt32(variable.f);

                    if ((groupCount <= 3) && ((variable.f > 0) && ((variable.d != 0) || (variable.e != 0))))
                    {
                        equation += String.Format("({0}x{1})^{2}", (variable.d).ToString("+0;-#"), (variable.e).ToString("+0;-#"), (variable.f).ToString());
                        numOfValueX += Convert.ToInt32(variable.d);
                        numOfValueInt += Convert.ToInt32(variable.e);

                        count = 0;
                        while (count < variable.f)
                        {
                            terms.Add(Convert.ToInt32(variable.d));
                            terms.Add(Convert.ToInt32(variable.e));
                            count++;
                        }
                    }

                    else
                    {
                        groupCount -= Convert.ToInt32(variable.f);
                    }
                }

                if (groupCount < 3)
                {
                    variable.g = random.Next(-8, 8);
                    variable.h = random.Next(-8, 8);
                    variable.i = random.Next(0, 4);

                    groupCount += Convert.ToInt32(variable.i);

                    if ((groupCount <= 3) && ((variable.i > 0) && ((variable.g != 0) || (variable.h != 0))))
                    {
                        equation += String.Format("({0}x{1})^{2}", (variable.g).ToString("+0;-#"), (variable.h).ToString("+0;-#"), (variable.i).ToString());
                        numOfValueX += Convert.ToInt32(variable.g);
                        numOfValueInt += Convert.ToInt32(variable.h);

                        count = 0;
                        while (count < variable.i)
                        {
                            terms.Add(Convert.ToInt32(variable.g));
                            terms.Add(Convert.ToInt32(variable.h));
                            count++;
                        }
                    }

                    else
                    {
                        groupCount -= Convert.ToInt32(variable.i);
                    }
                }
            }
            while ((groupCount <= 1) || (numOfValueX == 0) || (numOfValueInt == 0));

            if (terms.Count < 6)
            {
                terms.Add(Convert.ToInt32(0));
                terms.Add(Convert.ToInt32(1));
            }
            terms.ToArray();

            // adgx^3+(adh+aeg+bdg)x^2+(aeh+bdh+ebg)x+beh
            string coefficient1 = (terms[0] * terms[2] * terms[4]).ToString("+0;-#") + "x^3";
            string coefficient2 = ((terms[0] * terms[2] * terms[5]) + (terms[0] * terms[3] * terms[4]) + (terms[1] * terms[2] * terms[4])).ToString("+0;-#") + "x^2";
            string coefficient3 = ((terms[0] * terms[3] * terms[5]) + (terms[0] * terms[3] * terms[5]) + (terms[3] * terms[1] * terms[4])).ToString("+0;-#") + "x";
            string coefficient4 = (terms[1] * terms[3] * terms[5]).ToString("+0;-#");

            questions.Add(equation);
            formateEquation(questions);

            answers.Add(coefficient1 + coefficient2 + coefficient3 + coefficient4);
            formateEquation(answers);

            Trace.WriteLine(answers[0]);
        }

        /// <summary>
        /// Generates a factorisation question.
        /// </summary>
        public void genFactorisationQue()
        {
            // Do...
            do
            {
                // Randomly generates a value for a in (ax+b)(cx+b)
                variable.a = random.Next(-4, 4);

                // Randomly generates a value for b in (ax+b)(cx+b)
                variable.b = random.Next(-8, 8);

                // Randomly generates a value for c in (ax+b)(cx+b)
                variable.c = random.Next(-4, 4);

                // Randomly generates a value for d in (ax+b)(cx+b)
                variable.d = random.Next(-8, 8);
            
              // while a, b, c and d are 0.
            } while ((variable.a == 0) || (variable.b == 0) || (variable.c == 0) || (variable.d == 0));

            // question.
            string temp = (variable.a * variable.c).ToString("+0;-#") + "x^2" + ((variable.a * variable.d) + (variable.b * variable.c)).ToString("+0;-#") + "x" + (variable.b * variable.d).ToString("+0;-#");
            questions.Add(temp);

            formateEquation(questions);

            answers.Add(String.Format("({0}x{1})({2}x{3})", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString("+0;-#"), (variable.d).ToString("+0;-#")));
            formateEquation(answers);

            Trace.WriteLine(answers[0]);
        }

        public void genAlgerbriacQue()
        {
            variable.a = random.Next(-10, 10);
            variable.b = random.Next(-10, 10);
            variable.c = random.Next(-10, 10);

            questions.Add(String.Format("{0}x^2{1}x{2}=0", (variable.a).ToString("0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString("+0;-#")));

            answers.Add(Math.Round((-variable.b + (Math.Sqrt(Math.Pow(variable.b, 2)) - (4 * variable.a * variable.c))) / (2 * variable.c), 2).ToString());
            answers.Add(Math.Round((-variable.b - (Math.Sqrt(Math.Pow(variable.b, 2)) - (4 * variable.a * variable.c))) / (2 * variable.c), 2).ToString());

            ansVar.Add("x₁");
            ansVar.Add("x₂");

            Trace.WriteLine(answers[0]);
            Trace.WriteLine(answers[1]);
        }

        /// <summary>
        /// 
        /// </summary>
        public void genDyDxQue()
        {
            // |±ax^4| |±bx^3| |±cx^2| |±dx| |±e|
            variable.a = random.Next(-15, 15);
            variable.b = random.Next(-15, 15);
            variable.c = random.Next(-15, 15);
            variable.d = random.Next(-15, 15);
            variable.e = random.Next(-15, 15);

            questions.Add(String.Format("\\frac{{dy}}{{dx}}({0}x^4{1}x^3{2}x^2{3}x{4})", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString("+0;-#"), (variable.d).ToString("+0;-#"), (variable.e).ToString("+0;-#")));

            formateEquation(questions);

            answers.Add((variable.a * 4).ToString("+0;-#") + "x^3" + (variable.b * 3).ToString("+0;-#") + "x^2" + (variable.c * 2).ToString("+0;-#") + "x" + (variable.d * 1).ToString("+0;-#"));

            formateEquation(answers);

            Trace.WriteLine(answers[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        public void genIntergrationQue()
        {
            // |±ax^4| |±bx^3| |±cx^2| |±dx| |±e|
            variable.a = random.Next(-15, 15);
            variable.b = random.Next(-15, 15);
            variable.c = random.Next(-15, 15);
            variable.d = random.Next(-15, 15);
            variable.e = random.Next(-15, 15);

            questions.Add("\\int" + (variable.a * 4).ToString("+0;-#") + "x^3" + (variable.b * 3).ToString("+0;-#") + "x^2" + (variable.c * 2).ToString("+0;-#") + "x" + (variable.d * 1).ToString("+0;-#"));

            formateEquation(questions);

            answers.Add(String.Format("{0}x^4{1}x^3{2}x^2{3}x+c", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString("+0;-#"), (variable.d).ToString("+0;-#")));

            formateEquation(answers);

            Trace.WriteLine(answers[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        public void genLineEq()
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;

            int mn = 0;
            int md = 0;

            int cn = 0;
            int cd = 0;

            while ((md == 0) || (cd == 0))
            {
                x1 = random.Next(-10, 10);
                y1 = random.Next(-10, 10);
                x2 = random.Next(-10, 10);
                y2 = random.Next(-10, 10);

                mn = y2 - y1;
                md = x2 - x1;

                cn = (x2 * y1) - (x1 * y2);
                cd = x2 - x1;
            }

            string form;
            string mform;
            string cform;

            string m = "";
            string c = "";

            if (mn % md == 0)
            {
                m = (mn / md).ToString();
                mform = "m is a whole number";
            }

            else
            {
                mform = "m is a fraction";

                int smallest = Math.Abs(mn);

                if (md < mn)
                {
                    smallest = Math.Abs(md);
                }

                for (int i = smallest; i >= 1; i--)
                {
                    if ((mn % i == 0) && (md % i == 0))
                    {
                        string sign = (mn / md).ToString("+0;-#").Substring(0, 1);

                        if (sign == "+")
                        {
                            sign = "";
                        }

                        m = sign + String.Format("\\frac{0}{1}", "{" + (Math.Abs(mn / i)).ToString() + "}", "{" + (Math.Abs(md / i)).ToString() + "}");
                        break;
                    }
                }
            }

            if (cn % cd == 0)
            {
                cform = "c is a whole number.";
                c = (cn / cd).ToString("+0;-#");
            }

            else
            {
                cform = "c is a fraction.";

                int smallest = Math.Abs(cn);

                if (cd < cn)
                {
                    smallest = Math.Abs(cd);
                }

                for (int i = smallest; i >= 1; i--)
                {
                    if ((cn % i == 0) && (cd % i == 0))
                    {
                        c = (cn / cd).ToString("+0;-#").Substring(0, 1) + String.Format("\\frac{0}{1}", "{" + (Math.Abs(cn) / i).ToString() + "}", "{" + (Math.Abs(cd) / i).ToString() + "}");
                        break;
                    }
                }
            }

            questionText = String.Format("Find the equation of the line in the form y=mx+c that passes through points \n({0},{1}) and ({2},{3}). Where {4} and {5}", x1, y1, x2, y2, mform, cform);
            questions.Add(" ");

            formateEquation(questions);

            answers.Add(String.Format("y={0}x{1}", m, c));

            formateEquation(answers);

            Trace.WriteLine(answers[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        public void genMidPointEq()
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;

            while ((x1 == x2) && (y1 == y2))
            {
                x1 = random.Next(-10, 10);
                y1 = random.Next(-10, 10);
                x2 = random.Next(-10, 10);
                y2 = random.Next(-10, 10);
            }

            float x = ((float)x1 + (float)x2) / 2;
            float y = ((float)y1 + (float)y2) / 2;

            questionText = String.Format("Find the mid-point of the line that passes through the points \n({0},{1}) and ({2},{3}) in the form (x, y).", x1, y1, x2, y2);

            questions.Add(" ");

            answers.Add(String.Format("({0},{1})", x.ToString(), y.ToString()));
        }

        /// <summary>
        /// 
        /// </summary>
        public void genDistenceQue()
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;

            while ((x1 == x2) && (y1 == y2))
            {
                x1 = random.Next(-10, 10);
                y1 = random.Next(-10, 10);
                x2 = random.Next(-10, 10);
                y2 = random.Next(-10, 10);
            }

            double distence = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow(y2-y1, 2));

            questionText = String.Format("Calcuate the distence between the point ({0},{1}) and ({2},{3}) to two decimal places.", x1, y1, x2, y2);

            questions.Add(" ");

            answers.Add(Math.Round(distence, 2).ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        public void genSimEq()
        {
            // Generates the 
            variable.x = random.Next(-20, 20);
            variable.y = random.Next(-20, 20);

            variable.a = random.Next(-15, 15);
            variable.b = random.Next(-15, 15);
            variable.c = (variable.a * variable.x) + (variable.b * variable.y);

            variable.d = random.Next(-15, 15);
            variable.e = random.Next(-15, 15);
            variable.f = (variable.d * variable.x) + (variable.e * variable.y);

            questions.Add(String.Format("{0}x{1}y={2}", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString()));
            questions.Add(String.Format("{0}x{1}y={2}", (variable.d).ToString("+0;-#"), (variable.e).ToString("+0;-#"), (variable.f).ToString()));

            formateEquation(questions);

            answers.Add((variable.x).ToString());
            answers.Add((variable.y).ToString());

            ansVar.Add("x");
            ansVar.Add("y");

            Trace.WriteLine(answers[0]);
            Trace.WriteLine(answers[1]);
        }

        /// <summary>
        /// 
        /// </summary>
        public void genAreaQue()
        {
            variable.h = random.Next(1, 10);
            variable.b = random.Next(1, 10);


            answers.Add(String.Format("{0}x^4{1}x^3{2}x^2{3}x+c", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString("+0;-#"), (variable.d).ToString("+0;-#")));


            questions.Add("\\int" + (variable.a * 4).ToString("+0;-#") + "x^3" + (variable.b * 3).ToString("+0;-#") + "x^2" + (variable.c * 2).ToString("+0;-#") + "x" + (variable.d * 1).ToString("+0;-#"));

            formateEquation(questions);

            answers.Add(String.Format("{0}x^4{1}x^3{2}x^2{3}x+c", (variable.a).ToString("+0;-#"), (variable.b).ToString("+0;-#"), (variable.c).ToString("+0;-#"), (variable.d).ToString("+0;-#")));

            formateEquation(answers);

            Trace.WriteLine(answers[0]);
        }

        public Boolean checkAnswers(List<string> userAnswers, Boolean ordered)
        {
            Boolean correct = true;

            if (ordered == false)
            {
                userAnswers.Sort();
                answers.Sort();
            }

            for (int i = 0; i < answers.Count; i++)
            {
                if (userAnswers[i] == answers[i])
                {
                    correct = true;
                }

                else
                {
                    correct = false;
                }
            }

            return correct;
        }

        public void formateEquation(List<string> qalist)
        {
            for (int i = 0; i < qalist.Count; i++)
            {
                qalist[i] = qalist[i].Replace("-1x", "-x");
                qalist[i] = qalist[i].Replace("+1x", "+x");
                qalist[i] = qalist[i].Replace("-1y", "-y");
                qalist[i] = qalist[i].Replace("+1y", "+y");

                qalist[i] = Regex.Replace(qalist[i], @"(\+0x\^[0-9])", "");

                qalist[i] = qalist[i].Replace("+0y", "");
                qalist[i] = qalist[i].Replace("+0x", "");
                qalist[i] = qalist[i].Replace("+0", "");
                qalist[i] = qalist[i].Replace("(+", "(");
                qalist[i] = qalist[i].Replace("^1", "");

                qalist[i] = qalist[i].Replace("y=0x", "y=");
                qalist[i] = qalist[i].Replace("y=1x", "y=x");

                if (qalist[i].StartsWith('+') == true)
                {
                    qalist[i] = qalist[i].Substring(1);
                }
            }
        }

    }
}
