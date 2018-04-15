using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StudyBudy
{
    public partial class frmStudyBuddy : Form
    {
        public Quiz currentQuiz;
        CreateQuiz createQuiz;
        public frmStudyBuddy()
        {
            InitializeComponent();
        }

        private void btnNewQuiz_Click(object sender, EventArgs e)
        {
            // Show the window. Create new quiz.
            currentQuiz = new Quiz(null);
            createQuiz = new CreateQuiz();
            createQuiz.currentQuiz = currentQuiz;
            createQuiz.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadQuiz_Click(object sender, EventArgs e)
        {
            OpenFileDialog savedQuiz = new OpenFileDialog();
            savedQuiz.Filter = "Json File (.json) |*.json";
            savedQuiz.FilterIndex = 1;

            if (savedQuiz.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader re = new StreamReader(savedQuiz.FileName);
                    JsonTextReader reader = new JsonTextReader(re);
                    JsonSerializer se = new JsonSerializer();
                    object parsedData = se.Deserialize(reader);
                    JObject jsonFile = JObject.Parse(parsedData.ToString());
                    string nme;
                    if (jsonFile["qName"].ToString() == "" || jsonFile["qName"] == null)
                    {
                        nme = "NO NAME";
                    } else
                    {
                        nme = jsonFile["qName"].ToString();
                    }
                    currentQuiz = new Quiz(nme);
                    foreach (var question in jsonFile["questions"])
                    {
                        Question q = new Question(question["question"].ToString(), question["bonus"].ToObject<bool>(), question["id"].ToObject<int>());
                        foreach(var answer in question["answers"])
                        {
                            q.answers.Add(new Answer(answer["answerChoice"].ToString(), answer["correct"].ToObject<bool>(), answer["id"].ToObject<int>()));
                        }
                        currentQuiz.questions.Add(q);
                    }
                    Hide();
                    frmQuiz qqq = new frmQuiz();
                    qqq.currentQuiz = currentQuiz;
                    qqq.Show();

                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load json file. Please make sure it's a quiz file.");
                }
            }
        }

        private void frmStudyBuddy_Load(object sender, EventArgs e)
        {

        }
    }
}
