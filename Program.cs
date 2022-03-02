using System;

namespace MethotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, answer;
            Console.Write("Please, enter your name : ");
            name = Console.ReadLine();
            Console.Write("Please, enter your surname : ");
            surname = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(surname))
            {
                answer = Message(name);
            }
            else
                answer = Message(name, surname);

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static string Message(string name)
        {
            string firstLetter = name.Substring(0, 1).ToUpper();
            string theRest = name.Substring(1).ToLower();
            string text = "Dear" + firstLetter + theRest + ", your welcome.";
            return text;

        }

        static string Message(string name , string surname)
        {
            string firstLetter = name.Substring(0, 1).ToUpper();
            string theRest = name.Substring(1).ToLower();

            string firstLetter1 = surname.Substring(0, 1).ToUpper();
            string theRest1 = surname.Substring(1).ToLower();
            string text = "Dear "+ firstLetter + theRest +firstLetter1+theRest1+", your welcome.";
            return text;
        }
    }
}
