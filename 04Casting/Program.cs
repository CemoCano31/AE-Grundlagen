namespace _04Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Casting ist die Möglichkeit einen Datentyp in einen anderen zu konvertieren.
            short klein = 1;
            int mittel = klein; // implizentes Casting
            //Console.WriteLine(mittel);

            mittel = 32767 + 1;
            klein = (short)mittel; // explizites Casting, der Zieldatentyp wird in die Klammern geschrieben.
            //Console.WriteLine(klein);

            double kommazahl = 5.5;
            int ganzahl = (int)kommazahl;
            //Console.WriteLine(ganzahl);
            double nachkommazahl = kommazahl - ganzahl;
            //Console.WriteLine($"{nachkommazahl} ist der Wert nach dem Komma von {kommazahl} ");

            // Mit Hilfe der Convert-Klasse können wir einen String in einen Zahlendatentyp umwandeln.
            string zeichenkette = "2"; // Dieser String lässt sich innach int konvertieren.
            string zeichenkette2 = "2b"; // Dieser String lässt sich nicht nach int konventieren
            int zahl = Convert.ToInt32(zeichenkette);
            //Console.WriteLine(zahl);

            // Beispiel 
            string name;
            double alter;

            Console.WriteLine("Hallo User! Bitte gib deinen Namen ein");
            name = Console.ReadLine();

            Console.WriteLine("Gib bitte noch dein alter an");
            //alter = Convert.ToInt32(Console.ReadLine());
            string alterString = Console.ReadLine();
            alter = Convert.ToInt32(alterString);
            Console.WriteLine($"Hallo {name}. In einem Jahr bist du {alter + 1} Jahre alt.");

            // Aufgabe: Es soll eine zweite Person Name und Alter angeben 
            // Dann soll das durchnittsalter der beiden personen berechnet und ausgegeben werden.
            
            double alter2;
            Console.WriteLine("gib bitte das Alter der zweiten Person an:");
            //alter = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Das Durchnitsalter beträgt {alter} / {alter});
            string alterString2 = Console.ReadLine();
            alter2 = Convert.ToInt32(alterString2);
            Console.WriteLine($"Hallo {name}. das Durchnitssalter beträgt {(alter + alter2) / 2}");

            // Musterlösung:

            string name2;
            int alter2;

            Console.WriteLine("Hallo User2, Bitte gib deinen Namen ein:");
            name2 = Console.ReadLine();
            Console.WriteLine("Gib Bitte Dein Alter ein:");
            alter2 = Convert.ToInt32(Console.ReadLine());

            double durchschnittsalter = (alter + alter2) / 2d;
            Console.WriteLine($"Euer Durchschnittsalter beträgt: {durchschnittsalter} Jahre");
        }



    }
    }
}
