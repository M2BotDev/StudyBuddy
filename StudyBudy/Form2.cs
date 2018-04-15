using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBudy
{
    public partial class frmQuiz : Form
    {
        public int currentQuestionNumber;
        public Quiz currentQuiz;
        public int questionsWrong;
        private bool currentAnswerCorrect;

        public frmQuiz()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = currentQuiz.questions.ToArray()[currentQuestionNumber].question;
            lblQuestionsRight.Text = (currentQuiz.questions.Count - questionsWrong) + "/" + currentQuiz.questions.Count;
            Text = "Quiz - " + currentQuiz.qName;

            btnOptionOne.Text = "A : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[0].answerChoice;
            btnOptionTwo.Text = "B : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[1].answerChoice;
            btnOptionThree.Text = "C : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[2].answerChoice;
            btnOptionFour.Text = "D : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[3].answerChoice;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            new frmStudyBuddy().Show();
            Close();
        }

        private void lblQuestionNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionNumber += 1;
            if (!currentAnswerCorrect)
            {
                questionsWrong += 1;
                string correctAnswers = "Incorrect! The correct answer(s) were: ";
                for (int i = 0; i < currentQuiz.questions.Count; ++i)
                {
                    try
                    {
                        Answer ans = currentQuiz.questions.ToArray()[currentQuestionNumber-1].answers.ToArray()[i];
                        if (ans.correct)
                        {
                            if (i == 0)
                            {
                                correctAnswers += "A ";
                            }
                            if (i == 1)
                            {
                                correctAnswers += "B ";
                            }
                            if (i == 2)
                            {
                                correctAnswers += "C ";
                            }
                            if (i == 3)
                            {
                                correctAnswers += "D ";
                            }
                        }
                    } catch
                    {
                        continue;
                    }
                }
                MessageBox.Show(correctAnswers);

            }
            else
            {
                MessageBox.Show("Correct!");
            }
            if (currentQuestionNumber >= currentQuiz.questions.Count)
            {
                double score;
                score = Math.Floor(((Convert.ToDouble(currentQuiz.questions.Count - questionsWrong) / currentQuiz.questions.Count)*100));
                MessageBox.Show("Your score is " + score +"%");
                new frmStudyBuddy().Show();
                Close();
                return;
            }

            lblQuestion.Text = currentQuiz.questions.ToArray()[currentQuestionNumber].question;
            lblQuestionsRight.Text = (currentQuiz.questions.Count - questionsWrong) + "/" + currentQuiz.questions.Count;
            lblQuestionNumber.Text = currentQuestionNumber.ToString();

            btnOptionOne.Text = "A : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[0].answerChoice;
            btnOptionTwo.Text = "B : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[1].answerChoice;
            btnOptionThree.Text = "C : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[2].answerChoice;
            btnOptionFour.Text = "D : " + currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[3].answerChoice;

            currentAnswerCorrect = false;
            btnOptionOne.BackColor = Color.Transparent;
            btnOptionTwo.BackColor = Color.Transparent;
            btnOptionThree.BackColor = Color.Transparent;
            btnOptionFour.BackColor = Color.Transparent;
        }

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            if (currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[0].correct)
            {
                currentAnswerCorrect = true;
            } else
            {
                currentAnswerCorrect = false;
            }
            btnOptionOne.BackColor = Color.MediumSeaGreen;
            btnOptionTwo.BackColor = Color.Transparent;
            btnOptionThree.BackColor = Color.Transparent;
            btnOptionFour.BackColor = Color.Transparent;
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            if (currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[1].correct)
            {
                currentAnswerCorrect = true;
            }
            else
            {
                currentAnswerCorrect = false;
            }
            btnOptionOne.BackColor = Color.Transparent;
            btnOptionTwo.BackColor = Color.MediumSeaGreen;
            btnOptionThree.BackColor = Color.Transparent;
            btnOptionFour.BackColor = Color.Transparent;
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            if (currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[2].correct)
            {
                currentAnswerCorrect = true;
            }
            else
            {
                currentAnswerCorrect = false;
            }
            btnOptionOne.BackColor = Color.Transparent;
            btnOptionTwo.BackColor = Color.Transparent;
            btnOptionThree.BackColor = Color.MediumSeaGreen;
            btnOptionFour.BackColor = Color.Transparent;
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            if (currentQuiz.questions.ToArray()[currentQuestionNumber].answers.ToArray()[3].correct)
            {
                currentAnswerCorrect = true;
            }
            else
            {
                currentAnswerCorrect = false;
            }
            btnOptionOne.BackColor = Color.Transparent;
            btnOptionTwo.BackColor = Color.Transparent;
            btnOptionThree.BackColor = Color.Transparent;
            btnOptionFour.BackColor = Color.MediumSeaGreen;
        }
    }
}
