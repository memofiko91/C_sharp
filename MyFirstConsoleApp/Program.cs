using System.ComponentModel.DataAnnotations;

namespace MyFirstConsoleApp
{
    // format code: strg + k + d
    // mehrere Zeilen auskommentieren: strg + k + c (rückgängig mit strg+k+u)
    // 

    // $ vor de String ermöglicht das Einbauen von Variablen mit {}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, world!");
            Console.WriteLine("this is my first program.");

            // mit ae als string objekt 
            Console.WriteLine("hallo, wie heißt du?");
            string name = Console.ReadLine();
            Console.WriteLine("wie alt bist du?");
            string age = Console.ReadLine();
            Console.WriteLine($"dein name ist {name} und du bist {age} jahre alt!");

            // mit funktion convert.toint32 (--> um mit variable zu rechnen)
            Console.WriteLine("bitte gib dein alter an: ");
            int yourage = Convert.ToInt32(Console.ReadLine());
            int myage = 33;
            Console.WriteLine($"du heißt {name} und zusammen sind wir {myage + yourage} jahre alt!");

            // division zweier zahlen
            int a = 12;
            int b = 7;
            double erg1 = (double)a / b;  // muss gecastet werden, damit nachkommazahlen angezeigt werden
            Console.WriteLine(erg1);

            // division mit konsolen eingabe  
            Console.WriteLine("bitte gib zahl 1 ein: ");
            double x = Convert.ToDouble(Console.ReadLine());    // muss converted werden, damit nachkommazahlen angezeigt werden
            Console.WriteLine("bitte gib zahl 2 ein: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double erg2 = x / y;
            Console.WriteLine($"{x} dividiert durch {y} ist {erg2}");

            // Arrays und Konsoleneingabe
            String[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Please insert a number between 0 and 6:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= weekdays.Length)
            {
                Console.WriteLine("You choose: " + weekdays[number]);
            }
            else { Console.WriteLine("Invalid number!"); }

            // Lösung mit while Schleife
            while (number > weekdays.Length | number < 0)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Please insert a number between 0 and 6:");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You choose: " + weekdays[number]);
        }
    }
}
