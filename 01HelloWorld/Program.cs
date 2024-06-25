namespace _01HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ich bin ein einzeiliger Kommentar.
            //Wir sind hier in einer Methode namens "Main" die sich in einer Klasse befindet namens "Program",
            //die sich in unserem Namespace befindet.

            /*
             Ich bin ein mehrzeiliger
            Kommentar
            */

            //Der Console WriteLine-Befehl führt dazu, dass eine Ausgabe in der Konsole erfolgt.
            Console.WriteLine("Hallo Welt");
            Console.WriteLine("Konsole, schreibe noch eine Zeile");
            Console.WriteLine("und noch eine Zeile");

            //MIt\n wird ein Zeilenumbruch deklariert:
            Console.WriteLine("Hallo WElt!\nKonsole, schreibe eine neue Zeile!");
           
            // Mit\t hat man einen Tabulator-Einzug:
            Console.WriteLine("1.\tDIe erste Zeile");

            //. Write schreibt ihr in eine Zeile.
            Console.Write("hello World!");
            Console.Write("I will print on the same Line");
            Console.WriteLine(); // Ist das Gleiche wie :
            Console.WriteLine("Hallo Welt\n");

        }
    }
} 