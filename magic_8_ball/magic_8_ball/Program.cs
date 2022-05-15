using System;

namespace magic_8_ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We live in difficult times. Everyday there are questions and doubts that we have no answers to. We often choose believing in fate. A Magic 8 ball works like this: think about the question that bothers you, then say the sentence: \"omniscient magic ball number 8, do you think\" ... and ask your question aloud. Next shake the ball(monitor) and the answer will appear after a while...I'm kidding ;)... ");

            Console.WriteLine("Double press \"enter\" to continue");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPlease press \"enter\" to continue otherwise you will not have access to answers");
            }

            string[] answers = { "yes", "no", "yes", "no", "are you really asking me that?you know it yourself!", "everything is possible", "I'm terrified of what's in your head", "I believe in you that's why I think you will succeed", "buahahahaha, what is that question. I fell off my chair!" };

            Random r = new Random();

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
                Console.WriteLine("");
                Console.WriteLine("Ask a question and press enter");
                string userQuestion = Console.ReadLine();
                if (userQuestion.Length > 10)
                {
                    var arrIndex = answers[r.Next(0, answers.Length)];
                    Console.WriteLine(arrIndex);
                    Console.WriteLine("press \"enter\" to continue or press \"x\" to exit");
                }
                else
                {
                    Console.WriteLine("Don't play with me and press \"enter\"");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("You left the program and I'm going to sleep");
        }
    }
}
