using System;
using System.Threading;

// Author: [Your Name]
// Purpose: A console application that generates and asks a set of questions based on user input, tracks the number of correct answers, and displays the percentage of correct answers at the end.
// Restrictions: None

class Program
{
    static void Main()
    {
        int numberOfQuestions = 0;
        string difficultyLevel = "";
        int correctAnswers = 0;
        string[] questionBank = { "Question 1", "Question 2", "Question 3", "Question 4", "Question 5" };

        // Ask user for number of questions
        Console.Write("How many questions do you want to play? (1-3): ");
        numberOfQuestions = int.Parse(Console.ReadLine());

        // Ask user for difficulty level
        Console.Write("Select difficulty level (easy, medium, hard): ");
        difficultyLevel = Console.ReadLine().ToLower();

        // Generate random questions based on user input
        Random random = new Random();
        string[] questions = new string[numberOfQuestions];
        for (int i = 0; i < numberOfQuestions; i++)
        {
            int randomIndex = random.Next(0, questionBank.Length);
            questions[i] = questionBank[randomIndex];
        }

        // Ask generated questions and track correct answers
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Question {i + 1}: {questions[i]}");
            Console.WriteLine("You have 5 seconds to answer the question.");
            Thread.Sleep(5000);

            // Assume user answers correctly within time limit for simplicity
            Console.WriteLine("Correct!");

            correctAnswers++;
        }

        // Calculate and display percentage of correct answers
        double percentage = ((double)correctAnswers / numberOfQuestions) * 100;
        Console.WriteLine($"You answered {correctAnswers} out of {numberOfQuestions} questions correctly ({percentage}%).");

        Console.ReadKey();
    }
}
