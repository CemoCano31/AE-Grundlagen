using System.Xml.XPath;

namespace _05Verzweigung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bedingte Anweisungen und Verzweigungen sind Kontrollstrukturen. 
            //Diese ermöglichen uns, den Fluss des Codes und damit welcher Teile des Codes ausgeführt werden sollen
            //zu bestimmen.


            //Arbeiten mit Wahrheitswerten (Booleans)
            bool istHeuteMontag = false;
            //Console.WriteLine($"Stimmt es das heute Montag ist ?: {istHeuteMontag}");

            //Logische Operatoren 
            bool b1 = !true; // ändert den Wert in das Gegenteil. Dies wird auch als toggle bezeichnet
            bool b2 = false && true; //&& AND: Ergibt true wenn alle Werte true sind.
            bool b3 = false || true || false; // OR: Ergibt True wenn mindestens ein Wert true ist. 
            bool b4 = true ^ false ^ true; // ^ XOR: Ergibt True wenn die Anzahl an Truewerten ungerade sind.


            // Vergleichsoperatoren 

            int x1 = 1, x1b = 1, x2 = 2, x3 = 3;

            bool b5 = (x1 == x1b);// == Ergibt True wenn beide Werte gleich sind
            bool b6 = (x1 <= x1b);// < > <= >= kleiner, größer, kleiner gleich, größer gleich: Ergibt die Bedingung wenn eins erfüllt ist .
            bool b7 = (x1 != x1b); // Ergibt true wenn beide Werte nicht gleich sind. 

            //Alle Operatoren können miteinander kombiniert werden: 

            bool b8 = (x1 < x3) || (x2 > x3);


            //Console.WriteLine(b8);

            bool istHeuteWerktag = true;

            //if (istHeuteWerktag== true)
            //{
            //    // DANN
            //    Console.WriteLine("Der Wecker klingelt um 6:30");
            //}
            //else// ansonsten 
            //{
            //    Console.WriteLine("Wochenende! Ausschlafen!");
            //}


            //Console.WriteLine(DateTime.Now.DayOfWeek);
            //bool istHeuteMittwoch = (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday);
            //istHeuteMontag = (DateTime.Now.DayOfWeek == DayOfWeek.Monday);

            //if(istHeuteMittwoch)
            //{
            //    Console.WriteLine("Heute ist Mittwoch)");
            //}
            //else
            //{
            //    if ( istHeuteMontag)
            //    {
            //        Console.WriteLine("Heute ist Montag");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Heute ist weder Montag noch ; Mittwoch");
            //    }
            //}

            // Aufgabe:
            // Der User soll ein Passwort eingeben. er soll drei versuche haben um das passwort richtig einzugeben 
            //// Nach jedem fehlversuch, soll angegeben werden wie viele versuche noch übrig bleiben.
            ///// Nach dem dritten Fehlversuch soll die Meldung kommen : "Konto Gesperrt"

            //string passwort = "1234";
            //int anzahlVersuche = 3;
            //Console.WriteLine($"User, bitte gib dein Passwort ein, du hast{anzahlVersuche} Versuche");
            //string userEingabe = Console.ReadLine();
            //bool userHatRichtigesPasswort = (passwort == userEingabe);

            //if(userHatRichtigesPasswort)
            //{

            //    Console.WriteLine("Du bist eingeloggt. Willkommen im System User. ");
            //}
            //else
            //{
            //    Console.WriteLine("Du hast das falsche Passwort eingegeben");
            //    anzahlVersuche --; // Zieht 1 ab von anzahlVersuche übrig bleibt 2
            //    Console.WriteLine($"Versuche es nochmal und gebe dein passwort ein. du hast noch {anzahlVersuche} Versuche");
            //    userEingabe = Console.ReadLine();
            //    userHatRichtigesPasswort = (passwort == userEingabe);
            //    if (userHatRichtigesPasswort)
            //    {
            //        Console.WriteLine("Du bist eingeloggt. Willkommen im System User.");

            //    }
            //    else
            //    {
            //        anzahlVersuche--;
            //        Console.WriteLine($"Du hast jetzt noch {anzahlVersuche} Versuche");
            //        userEingabe = Console.ReadLine();
            //        if (userHatRichtigesPasswort)
            //        {
            //            Console.WriteLine("Du bist eingeloggt. Willkommen im System User.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Konto gesperrt!");
            //        }
            //    }        
            //}



            //Console.WriteLine("\t\t\tWillkommen im Verlies des Vergessens");

            //            Console.WriteLine("\t\t__________________________________________________________");

            //            Console.WriteLine("\t\t\tVor dir erstreckt sich eine finstere Höhle. Wie ist das Zauberwort ?");

            //            string passwort = "1234";

            //            string eingabe = Console.ReadLine();

            //            int versuche = 2;

            //            //bool userHatRichtigesPasswort = (passwort == userEingabe) 

            //            if (eingabe == passwort) //(userHatRichtigesPasswort == true)

            //            {

            //                Console.WriteLine("Das schwere Tor öffnet sich. Du betrittst das Herz des Verlieses.");

            //            }

            //            else

            //            {

            //                Console.WriteLine($"\t\t\tFalsches Passwort. Noch {versuche} Versuche verbleibend.");

            //                Console.WriteLine("\t\t\tEin unheimliches Grollen hallt durch die Höhle.");

            //                Console.WriteLine("\t\t\tGib erneut das Passwort ein, um weiter voranzuschreiten.");

            //                eingabe = Console.ReadLine();

            //                versuche--; //Mit -- führen wir ein Dekrement durch. Sprich wir verringern den Wert um 1.

            //                if (eingabe == passwort) //(userHatRichtigesPasswort) Die Prüfung auf == true muss nicht explizit angegeben werden. Diese Prüfung ist der Standardfall.

            //                {

            //                    Console.WriteLine("\t\t\tDie Dunkelheit weicht zurück. Du setzt deinen Weg fort.");

            //                }

            //                else

            //                {

            //                    Console.WriteLine($"\t\t\tFalsches Passwort. Noch {versuche} Versuche verbleibend.");

            //                    Console.WriteLine("\t\t\tDas Klirren von Ketten und das Zischen von Ungeheuern sind zu hören.");

            //                    Console.WriteLine("\t\t\tLetzter Versuch: Gib das richtige Passwort ein, um das Verlies zu überwinden.");

            //                    eingabe = Console.ReadLine();

            //                    versuche--;

            //                    if (eingabe == passwort)

            //                    {

            //                        Console.WriteLine("\t\t\tDie Tore des Verlieses öffnen sich. Du hast die Gefahr überwunden.");

            //                    }

            //                    else

            //                    {

            //                        Console.WriteLine("\t\t\tEin magischer Bann sperrt dich ein. Dein Schicksal ist dem Verlies überlassen.");


            //                    }

            //                }

            //            }

            //Der User soll Ihnen mitteilen, ob das Wetter gerade "sonnig" oder "regnerisch" ist. 
            //Auch die Temperatur soll der User angeben können.
            //Liegt die Temperatur bei oder über 20°C und es ist sonnig, empfehlen sie dem User ein T-Shirt zu tragen.
            //Liegt die Temperatur unter 20°C und es ist sonnig, empfehlen Sie eine Jacke anzuziehen.
            //Bei regnerischen Wetter müssen ebenfalls die Kleiderempfehlung ausgesprochen werden die sich nach der jeweiligen Temperatur richten.
            //Zusätzlich soll der User drauf hingewiesen werden, dass ein Regenschirm mitgenommen werden soll.

            //string userEingabe;
            //int temperatur;

            //Console.WriteLine("Ist es sonnig oder regnerisch?");
            //userEingabe = Console.ReadLine();

            //Console.WriteLine("Wie viel Grad haben wir?");
            //temperatur = Convert.ToInt32(Console.ReadLine()); // eine ReadLine ist "immer" eine String !


            //if (temperatur >= 20 && userEingabe == "sonnig")
            //{
            //    Console.WriteLine("Trage ein T-Shirt!");
            //}
            //else if (temperatur < 20 && userEingabe == "sonnig")
            //{
            //    Console.WriteLine("Trage eine Jacke!");
            //}
            //else if (temperatur >= 20 && userEingabe == "regnerisch")
            //{
            //    Console.WriteLine("Trage ein T-Shirt und nimm bitte ein Regenschirm mit!");
            //}
            //else if (temperatur < 20 && userEingabe == "regnerisch")
            //{
            //    Console.WriteLine("Trage eine Jacke und nimm bitte einen Regenschirm mit!");
            //}
            //else
            //{
            //    Console.WriteLine("ungültige Wettereingabe");
            //}




            //Version mit do-while:
            //
            //do
            //{
            //    Console.WriteLine("Ist es sonnig oder regnerisch?");
            //    userEingabe = Console.ReadLine();

            //}
            //while (userEingabe != "sonnig" && userEingabe != "regnerisch");

            //do
            //{
            //    Console.WriteLine("Wie viel Grad haben wir?");
            //    //temperatur = Convert.ToInt32(Console.ReadLine()); // eine ReadLine ist "immer" eine String !

            //}
            //while (!int.TryParse(Console.ReadLine(), out temperatur));


            //if (temperatur >= 20)
            //{
            //    if (userEingabe == "sonnig")
            //    {
            //        Console.WriteLine("Trage ein T-Shirt!");
            //    }
            //    else if (userEingabe == "regnerisch")
            //    {
            //        Console.WriteLine("Trage ein Jacke und nimm bitte ein Regenschirm mit!");
            //    }
            //}
            //else if (temperatur < 20)
            //{
            //    if (userEingabe == "sonnig")
            //    {
            //        Console.WriteLine("Trage ein Jacke!");
            //    }
            //    else if (userEingabe == "regnerisch")
            //    {
            //        Console.WriteLine("Trage ein Jacke und nimm bitte ein Regenschirm mit!");
            //    }
            //}

            //Aufgabe 3 :
            //Wenn der User etwas anderes als eine der drei Vorgaben auswählt, soll "Ungültige Eingabe" ausgegeben werden.
            //Andernfalls soll die Koonsollenschriftfarbe in die entsprechende Auswahl geändert werden. (Recherchiert selber wie man die Farbe ändert)
            //Der User darf dabei entweder den Anfangsbuchstaben verwenden oder das ganze Wort.
            //Und die Aufgabe soll mit switch-case umgesetzt werden, es darf keine if und else struktur geben.
            //(Selbstständig recherchieren wie man switch case nutzt)

            //Console.WriteLine("User, wähle eine Farbe aus: (r)ot, (b)lau, (g)gelb");


            //string userInput = Console.ReadLine().ToLower();

            //switch (userInput)
            //{
            //    case "r":
            //    case "rot":
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Die Schriftfarbe ist jetzt Rot.");
            //        break;

            //    case "g":
            //    case "grün":
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Die Schriftfarbe ist jetzt Grün.");
            //        break;

            //    case "b":
            //    case "blau":
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine("Die Schriftfarbe ist jetzt Blau.");
            //        break;

            //    default:
            //        Console.WriteLine("Ungültige Eingabe.");
            //        break;
            //}

            Console.WriteLine("User, wähle eine Farbe aus: (r)ot, (b)lau, (g)gelb");
            string farbe = Console.ReadLine();
            farbe = farbe.ToLower(); //.ToLower ist eine Methode die jeder string besitzt. Damit werden Alle Buchstaben im String zu Kleinbuchstaben.

            // Mehrseitige Fallauswahl : Switch

            switch (farbe)
            {
                case "r":
                case "rot":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "b":
                case "blau":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "g":
                case "gelb":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                break;
                    Console.WriteLine("Ungültige Eingabe");
                
            }
            Console.WriteLine("Neue Farbe wenn geändert");

            
        











        }
    }
}

