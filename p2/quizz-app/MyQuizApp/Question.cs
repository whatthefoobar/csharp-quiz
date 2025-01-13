namespace MyQuizApp
{
    // Question class w 3 vars and 2 methods
    internal class Question
    {
        // used properties as they are more public facing vars
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        // constructor for props
        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;

        }

        public bool IsCorrectAnswer(int choice)
        {
            // ret true or fapse if choice matched the correctAnswerIndex
            return CorrectAnswerIndex == choice;
        }

    }
}
