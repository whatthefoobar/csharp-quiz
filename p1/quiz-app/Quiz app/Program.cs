// See https://aka.ms/new-console-template for more information


int result;

Console.WriteLine("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Choose an operation: +, -, *, /");
string operation = Console.ReadLine();

if (operation == "+")
{
    result = num1 + num2;
    Console.WriteLine($"Result: {result}");
}
else if (operation == "-")
{
    result = num1 - num2;
    Console.WriteLine($"Result: {result}");
}
else if (operation == "*")
{
    result = num1 * num2;
    Console.WriteLine($"Result: {result}");

}
else if (operation == "/")
{
    if (num2 == 0) { Console.WriteLine("Error: Division by zero is not allowed."); }
    else
    {
        result = num1 / num2;
        Console.WriteLine($"Result: {result}");
    }

}
else Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");

Console.ReadKey();

//int result;

//Console.WriteLine("Enter the first number:\nEnter the second number:\nChoose an operation(+,-,*,/)");
//string userInput = Console.ReadLine();

//string[] parts = userInput.Split(',');

//int num1 = int.Parse(parts[0]);
//int num2 = int.Parse(parts[1]);

//string operation = parts[2];

//if (operation == "+")
//{
//    result = num1 + num2;
//    Console.WriteLine($"The result is {result}");
//}
//else if (operation == "-")
//{
//    result = num1 - num2;
//    Console.WriteLine($"The result is {result}");
//}
//else if (operation == "*")
//{
//    result = num1 * num2;
//    Console.WriteLine($"The result is {result}");

//}
//else if (operation == "/")
//{
//    if (num2 == 0) { Console.WriteLine("Cannot divide by 0"); }
//    else
//    {
//        result = num1 / num2;
//        Console.WriteLine($"The result is {result}");
//    }

//}
//else Console.WriteLine("No valid operation selected");

//Console.ReadKey();









// switch(operation){

// case addition : result = num1 + num2;
//                 break;
// case subtraction: result = num1 - num2;
//                 break;
// case multiplication: result = num1 - num2;
//                 break;
// case division: result = num1 - num2;
//                 break;
// default: result;


// }

//string question1 = "What is the capital of Romania?";
//string answer1 = "Bucharest";

//string question2 = "what is 2+2 ?";
//string answer2 = "4";

//string question3 = "What do you get when you mix blue and yellow?";
//string answer3 = "Green";

//int score = 0;


//Console.WriteLine(question1);
//string userAnswer = Console.ReadLine();
//if (userAnswer.ToLower().Trim() == answer1.ToLower())
//{
//    Console.WriteLine("Correct!");
//    score++;
//}
//else Console.WriteLine("Incorrect!");

//Console.WriteLine(question2);
//userAnswer = Console.ReadLine();

//if (userAnswer.Trim() == answer2)
//{
//    Console.WriteLine("Correct!");
//    score++;
//}
//else Console.WriteLine("Incorrect!");

//Console.WriteLine(question3);
//userAnswer = Console.ReadLine();
//if (userAnswer.ToLower().Trim() == answer3.ToLower())
//{
//    Console.WriteLine("Correct!");
//    score++;
//}
//else Console.WriteLine("Incorrect!");







//Console.WriteLine($"Your score is now {score}/3");
//if (score == 3) Console.WriteLine("Congratulations you got all questions right!"
//);
//else if (score > 0) Console.WriteLine("Keep trying and keep learning"); else Console.WriteLine(""); ;
//Console.ReadKey();




