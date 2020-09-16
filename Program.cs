using System;

namespace THE_EPICEST_QUIZ_EVER______
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Question Answer
            string a;
            //Second Question Answer
            string b;
            //Third Question Answer
            string c;
            //Fourth Question Answer
            string d;
            //Fifth Question Answer
            string e;
            //Score
            int s = 0;
            //Text Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Window Title
            Console.Title = "THE EPICEST QUIZ EVER!!!!";
            //Welcome Screen
            Console.WriteLine("Welcome To The Epicest Quiz Ever!");
            Console.ReadKey();
            //First Question
            Console.WriteLine("First Question, What is 1+1?");
            a = Console.ReadLine();
            if (a == "11")
            {
                Console.WriteLine("Correct!!! You're a Genius!");
                s = (s + 1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong!!!! You're Stupid.");
                Console.ReadKey();
            }
            //Second Question
            Console.WriteLine("Second Question, What is the best drink ever?(Please no caps)");
            b = Console.ReadLine();
            if (b == "coke")
            {
                Console.WriteLine("You Are Correct");
                s = (s + 1);
                Console.ReadKey();
            }
            else if (b == "coca cola")
            {
               Console.WriteLine("You Are Correct");
               s = (s + 1);
               Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine("You Are Wrong");
                Console.ReadKey();
            }
            //Third Question
            Console.WriteLine("Third Question, what is the best food ever?(No Caps)");
            c = Console.ReadLine();
            if (c == "hamburger")
            {
                Console.WriteLine("Yay!! You did it.");
                s = (s + 1);
                Console.ReadKey();
            }
            else if (c == "burger")
            {
                Console.WriteLine("Yay!! You did it.");
                s = (s + 1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("OOF!! You're Wrong.");
                Console.ReadKey();
            }
            //Fourth Question
            Console.WriteLine("What is the best meme ever?(NO CAPS)");
            d = Console.ReadLine();
            if (d == "uganda knuckles")
            {
                Console.WriteLine("Incredible, you did it!!!!");
                s = (s + 1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("really....YOU'RE WRONG!!");
                Console.ReadKey();
            }
            //Fifth Question
            Console.WriteLine("What is the best CryptoCurrency?(NO CAPS)");
            e = Console.ReadLine();
            if (e == "dogecoin")
            {
                Console.WriteLine("GIGANTIC YES!!!");
                s = (s + 1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("GIGANTIC OOF!!!");
                Console.ReadKey();
            }
            //Show Score and give link.
            Console.WriteLine("Your Score is " + s +"/5");
            if (s == 5)
            {
                Console.WriteLine("google.com");
            }
            Console.ReadKey();
        }
    }
}
