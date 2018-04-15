using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyBudy
{
    public class Answer
    {
        public string answerChoice;
        public bool correct;
        public int id;

        public Answer(string answer, bool correct, int id)
        {
            answerChoice = answer;
            this.correct = correct;
            this.id = id;
        }
    }
    public class Question
    {
        public string question;
        public bool bonus;
        public int id;

        public List<Answer> answers = new List<Answer>();

        public Question(string q, bool bQuestion, int id)
        {
            question = q;
            bonus = bQuestion;
            this.id = id;
        }
    }
    public class Quiz
    {
        public string qName;

        public List<Question> questions = new List<Question>();

        public Quiz(string name)
        {
            qName = name;
        }
    }
}
