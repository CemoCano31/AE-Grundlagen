namespace _03Userinteraktion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo User! Bitte gib ein Wort ein");
            // Mit der Methode ReadLine kann man die näcchste Zeile, in unserem Fall das was der User eingeben wird, einlesen.
            //Die Zeichenkette muss in einer Variablen gespeichert werden. Der Wert, also der Inhalt der Variablen, ist dann zur Laufzeit 
            //des Programms im Arbeitsspeicher vorhanden.
            
            string userinput = Console.ReadLine();

            //Ausgabe des im Arbeitsspeicher vorliegenden Werts über die Variable userInput
            Console.WriteLine($"Du hast folgedes Eingegeben: \t\t{userinput}");
            Console.WriteLine("Das hast du bisher gut gemacht!");
            Console.WriteLine("Gib bitte als nächstes deinen Namen ein: ");
            string Name = Console.ReadLine();
            // AUfgabe: der USer soll neben seinem Vornamen auch Nachname , E-Mail adresse, Hobby und Alter eingeben können.
            // Gebe dann die gespeicherten Daten in der Konsole aus.

            Console.WriteLine($"Hallo {Name},Gib bitte deinen Vornamen ein:");
            string vorname = Console.ReadLine();
            
            Console.WriteLine("Gib jetzt deinen email ein:");
            string email = Console.ReadLine();

            Console.WriteLine("Nenne mir deine Hobbys:");
            string hobby = Console.ReadLine();
            
            Console.WriteLine("nenne mir dein Alter:");
            string alter = Console.ReadLine();
            
            Console.WriteLine("Danke für die Antworten");
            Console.WriteLine($"vielen Dank! Deine Antworten Lauten: \n \nNachname:\t{Name} \n Vorname:\t{vorname} \n Email:\t\t{email} \n Hobby:\t\t{hobby} \n Alter:\t\t{alter}");

            // oder alle strings am anfang bennennen und dannach weglassen 


            





            

            





        }
    }
}
