namespace _07Scleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while-Schleife- die Kopfgesteuerte  Schleife
            //Syntax:
            //while(<kondition>)
            //{ }

            int zaehler = 0;
            while (true) // SOLANGE die Kondition wahr ist:
            { //führe folgenden Code aus:
                Console.Clear();
                Console.WriteLine(zaehler);
                zaehler++;

                //Die folgende Codezeile  hat nichts mit Schleife zu tun 
                //Sie lässt die Anweisung für 1000ms pausieren, damit wir sehen können wie der Zähler zählt.
                //Thread.Sleep(1000);

                //}

                

            }


        }
    }
}
