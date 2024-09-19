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
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is my first program.");

            // Mit ae als String Objekt 
            Console.WriteLine("Hallo, wie heißt du?");
            String name = Console.ReadLine();
            Console.WriteLine("Wie alt bist du?");
            String age = Console.ReadLine();
            Console.WriteLine($"Dein Name ist {name} und du bist {age} Jahre alt!");

            // mit Funktion Convert.ToInt32 (--> um mit variable zu rechnen)
            Console.WriteLine("Bitte gib dein Alter an: ");
            int yourage = Convert.ToInt32(Console.ReadLine());
            int myage = 33;
            Console.WriteLine($"Du heißt {name} und zusammen sind wir {myage + yourage} Jahre alt!");

            // Division zweier Zahlen
            int a = 12;
            int b = 7;
            double erg = (double) a / b;  // muss gecastet werden, damit Nachkommazahlen angezeigt werden
            Console.WriteLine(erg);

        }
    }
}
