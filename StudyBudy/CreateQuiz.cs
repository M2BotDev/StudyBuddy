using Newtonsoft.Json;
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
    public partial class CreateQuiz : Form
    {
        public Quiz currentQuiz;

        public CreateQuiz()
        {
            InitializeComponent();
        }

        private void btnCorrect1_Click(object sender, EventArgs e)
        {
            btnCorrect1.BackColor = btnCorrect1.BackColor == Color.Green ? Color.Red : Color.Green;

        }

        private void btnCorrect2_Click(object sender, EventArgs e)
        {
            btnCorrect2.BackColor = btnCorrect2.BackColor == Color.Green ? Color.Red : Color.Green;
        }

        private void btnCorrect3_Click(object sender, EventArgs e)
        {
            btnCorrect3.BackColor = btnCorrect3.BackColor == Color.Green ? Color.Red : Color.Green;
        }

        private void btnCorrect4_Click(object sender, EventArgs e)
        {
            btnCorrect4.BackColor = btnCorrect4.BackColor == Color.Green ? Color.Red : Color.Green;
        }

        private void btnBonusQuestion_Click(object sender, EventArgs e)
        {
            btnBonusQuestion.BackColor = btnBonusQuestion.BackColor == Color.Gray ? Color.Gold : Color.Gray;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Question question = new Question(txtQuestionName.Text, btnBonusQuestion.BackColor == Color.Gold, 0);
            question.id = currentQuiz.questions.ToArray().Length;
            question.answers.Add(new Answer(txtChoice1.Text, btnCorrect1.BackColor == Color.Green, 0));
            question.answers.Add(new Answer(txtChoice2.Text, btnCorrect2.BackColor == Color.Green, 1));
            question.answers.Add(new Answer(txtChoice3.Text, btnCorrect3.BackColor == Color.Green, 2));
            question.answers.Add(new Answer(txtChoice4.Text, btnCorrect4.BackColor == Color.Green, 3));

            currentQuiz.questions.Add(question);

            lstQuestions.Items.Add(question.id);
            txtChoice1.Text = "";
            txtChoice2.Text = "";
            txtChoice3.Text = "";
            txtChoice4.Text = "";
            txtQuestionName.Text = "";
            btnBonusQuestion.BackColor = Color.Gray;
            btnCorrect1.BackColor = Color.Green;
            btnCorrect2.BackColor = Color.Red;
            btnCorrect3.BackColor = Color.Red;
            btnCorrect4.BackColor = Color.Red;
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentQuiz.questions.ToArray().Length; i++)
            {
                Question currentQuestion = currentQuiz.questions.ToArray()[i];
                if (lstQuestions.SelectedItems.Count > 0)
                {
                    if (lstQuestions.Items[i] == lstQuestions.SelectedItems[0])
                    {
                        lstQuestions.Items.RemoveAt(i);
                        currentQuiz.questions.RemoveAt(i);
                    }
                }
            }
        }

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentQuiz.questions.ToArray().Length; i++)
            {
                Question currentQuestion = currentQuiz.questions.ToArray()[i];
                if (lstQuestions.SelectedItems.Count > 0)
                {
                    if (lstQuestions.Items[i] == lstQuestions.SelectedItems[0])
                    {
                        txtChoice1.Text = currentQuestion.answers[0].answerChoice;
                        txtChoice2.Text = currentQuestion.answers[1].answerChoice;
                        txtChoice3.Text = currentQuestion.answers[2].answerChoice;
                        txtChoice4.Text = currentQuestion.answers[3].answerChoice;
                        txtQuestionName.Text = currentQuiz.questions[i].question;
                        btnBonusQuestion.BackColor = currentQuestion.bonus == true ? Color.Gold : Color.Gray;
                        btnCorrect1.BackColor = currentQuestion.answers[0].correct == true ? Color.Green : Color.Red;
                        btnCorrect2.BackColor = currentQuestion.answers[1].correct == true ? Color.Green : Color.Red; ;
                        btnCorrect3.BackColor = currentQuestion.answers[2].correct == true ? Color.Green : Color.Red; ;
                        btnCorrect4.BackColor = currentQuestion.answers[3].correct == true ? Color.Green : Color.Red; ;
                    }
                }
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            new frmStudyBuddy().Show();
            Close();
        }

        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentQuiz.questions.ToArray().Length; i++)
            {
                Question currentQuestion = currentQuiz.questions.ToArray()[i];
                if (lstQuestions.SelectedItems.Count > 0)
                {
                    if (lstQuestions.Items[i] == lstQuestions.SelectedItems[0])
                    {
                        currentQuestion.answers[0] = new Answer(txtChoice1.Text, btnCorrect1.BackColor == Color.Green, 0);
                        currentQuestion.answers[1] = new Answer(txtChoice2.Text, btnCorrect2.BackColor == Color.Green, 1);
                        currentQuestion.answers[2] = new Answer(txtChoice3.Text, btnCorrect3.BackColor == Color.Green, 2);
                        currentQuestion.answers[3] = new Answer(txtChoice4.Text, btnCorrect4.BackColor == Color.Green, 3);
                        currentQuestion.answers[0].answerChoice = txtChoice1.Text;
                        currentQuestion.answers[1].answerChoice = txtChoice2.Text;
                        currentQuestion.answers[2].answerChoice = txtChoice3.Text;
                        currentQuestion.answers[3].answerChoice = txtChoice4.Text;
                        currentQuestion.question = txtQuestionName.Text;
                        currentQuestion.bonus = btnBonusQuestion.BackColor == Color.Gold ? true : false;
                    }
                }
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            if (lstQuestions.Items.Count <= 0)
            {
                MessageBox.Show("You need at least 1 question to save this quiz.");
                return;
            }
            currentQuiz.qName = txtQuizName.Text;
            SaveFileDialog saveQuiz = new SaveFileDialog();
            saveQuiz.Filter = "Json File (.json) |*.json";
            saveQuiz.FilterIndex = 1;

            if (saveQuiz.ShowDialog() == DialogResult.OK)
            {

                string json = JsonConvert.SerializeObject(currentQuiz);

                //write string to file
                System.IO.File.WriteAllText(saveQuiz.FileName, json);
            }
        }

        private void txtChoice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
