namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        //this.questions refers to private Question[] questions of this class
        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;// to display question numbers
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}"); // displays 1 and for next iteration is 2
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is {questionNumber - 1}. {question.Answers[question.CorrectAnswerIndex]}");

                }

            }

            DisplayResult();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine(question.QuestionText);
            //write each answer
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }


        }

        // get index of the choice
        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            //This tries to convert the user input (input) into an integer and stores the result in the variable choice.
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                input = Console.ReadLine();
            }
            return choice - 1; // adjust for index as in user will put in 1 to 4 but i need it to match the correct index of 0 to 3
        }

        private void DisplayResult()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is {_score}");
            double percentage = (double)_score / _questions.Length * 100;
            Console.WriteLine($"You had {percentage} % correct answers");

            if (percentage > 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excelent Work!");

            }
            else if (percentage >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing!");
            }
            Console.ResetColor();
        }
    }
}
