using System.Formats.Asn1;

namespace _02Variablen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eine Variabel speichert Werte eines bestimmten Datentyps.
            //Die Deklaration einer Variabel erfolgt im Format
            //<datentyp> <Variablename>
            // Der Variablenname wird auch ""Bezeichner" genannt 
            //Beispiel für eine Intenger-Variablel:

            int zahlEins;

            //Initialisierung der Variabeln (Erstmalige Wertzuweisung)
            zahlEins = 123;
            Console.WriteLine("Wert der Variabeln nach der Initialisierung" + zahlEins);

            // Zuweisung eines neuen werts durch Überschreibung 
            zahlEins = -555;
                Console.WriteLine($"Wert der Variabeln nach der Wertüberschreibung: {zahlEins}");
            zahlEins = zahlEins + 1;
            Console.WriteLine($"Ergebnis nach der Division:{zahlEins}");

            zahlEins = 5 / 2;
            Console.WriteLine($"Ergebnis nach der Division: {zahlEins}");
            // Arbeiten mit (Gleit-)Kommazahlen:
            double kommazahl = 2.5;// beachte die amerikanische Punktnotation
            Console.WriteLine($"Kommazahl:{kommazahl}");

            kommazahl = 7.0 / 2.0;
            Console.WriteLine($"Komazahl:  {kommazahl}");

            // Ein weiterer Datentyp ist der Float Tyo, dieser ist wenig Ressourcenuintensiv kann aber auch Kommazahlen abbilden
            float kommazahl2 = 3.5f;
            Console.WriteLine(kommazahl2);

            //Arbeiten mit einzelnen Zeichen (Chars)
            char zeichen = 'a';
            Console.WriteLine(zeichen);

            //Arbeiten mit Strings (Zeichenketten)
            string text1 = "Hallo Welt";
            Console.WriteLine(text1);

            //Arbeiten mit Wahrheitswerten (Boolean)
            bool istHeuteDienstag = false;
            Console.WriteLine($"Stimmt es, das heute Dienstag ist? Antwort:{istHeuteDienstag}");

            // Deklaration und Initialisierung mehrerer Variabeln desselben Typs durch Kommasepparierung
            int x = 5, y = 6, z = 7;

            // Speicher verschiedener Datentypen
            byte eineSehrKleinePositiveZahl; //Byte Größe: 1 Byte => 8bit - 256 Zahlen, mögliche Werte: 0 - 255

            sbyte eineSehrKleineZahl; // s steht für signed, mögliche Werte: -128 bis 127

            short eineKleineKommaZahl; //Int16 Größe: 2Bytes 2*8Bit = 16Bit, mögliche Werte: -32.768 bis 32.767

            ushort eineKleinePositiveKommazahl; // u steht für unsigned, mögliche Werte; 0 - 65.535
            int eineMittelgroßeZahl; // Int32 Größe: 4Bytes => 4*8 Bit = 32 Bit, mögliche Werte 2^^32 (ca. 4,3 Milliarden Zahlen)
                                    //kleinster möglicher Wert -2.174.4383.648 größter möglicher Wert: 2.174.483.647

            UniversalTagNumber eineMittelgroßePositiveZahl; // mögliche Werte: 0 -4.394.968.295

            // Zur Bessere Lesbarkeit f+rfen Zahlen in C# so geschrieben werden:

            eineMittelgroßeZahl = 2_147_483_647;
            Console.WriteLine($"Maximaler Wert für Int32: {eineMittelgroßeZahl}");
            int neueZahl = eineMittelgroßeZahl + 1;
            Console.WriteLine($"Overflow:  {neueZahl}");

            
                long eineSehrgroßeZahl; //Int64 mögliche Werte: -9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807
            ulong eineSehrGroßePositveZahl; //18.446.744.073.709.551.615

            //Kommazahlen
            float kleineKommazahl = 0.123456789f; //4 Bytes
            double mittelgroßeKommazahl = 0.123456789123456789d; //8 Bytes
            decimal großeKommazahl = 0.123456789123456789123456789M; //24 Bytes
                                                                     //Wenn mit Geld gerechnet wird, ist Decimal immer der Datentyp der Wahl.
            bool wahrheit; //1 Bit => 2 Zustände

            char einZeichen; //2 Bytes

            string wort; //Die Größe bemisst sich nach dem Inhalt des Strings







        }
    }
}
