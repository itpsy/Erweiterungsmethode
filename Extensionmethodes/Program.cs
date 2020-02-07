using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethodes
{
    class Program
    {
        /*
         * Aufgabe 1:
         *          Schreiben Sie eine Erweiterungsmethode, die es Ihnen ermöglicht bei der Ausgabe eines Strings 
         *          dessen Anzahl an Buchstaben auszugeben.
         *          
         * Aufgabe 2:
         *          Schreiben Sie eine Erweiterungsmethode, die es Ihnen ermöglicht bei der Ausgabe eines Strings 
         *          die Anzahl der verwendeten Wörter innerhalb eines Strings auszugeben.
         *
         * Aufgabe 3:
         *          Haben Sie sich auch schon einmal darüber echauffiert, dass Text-Diebe die Artikelbeschreibungen,
         *          die Sie unter viel Aufwand erstellt haben - ohne Sie zu fragen - in ihren eigenen Ebay-Anzeigen
         *          verwenden? Machen Sie schluss damit!
         *          
         *          Schreiben Sie eine Erweiterungsmethode, die es Ihnen ermöglicht bei der Ausgabe eines Strings
         *          Copyright-Informationen (z.B. Werbung) in den Text einzubringen
         */
         public static string text = ("In visions of the dark night \n" +
                                        "I have dreamed of joy departed \n" +
                                        "But a waking dream of life and light \n" +
                                        "Hath left me broken-hearted. " + "\n \n" +

                                        "Ah! what is not a dream by day \n" +
                                        "To him whose eyes are cast \n" +
                                        "On things around him with a ray \n" +
                                        "Turned back upon the past? \n \n" +

                                        "That holy dream, that holy dream, \n" +
                                        "While all the world were chiding, \n" +
                                        "Hath cheered me as a lovely beam \n" +
                                        "A lonely spirit guiding. \n \n" +

                                        "What though that light, thro’ storm and night, \n" +
                                        "So trembled from afar \n" +
                                        "What could there be more purely bright \n" +
                                        "In Truth’s day-star ? \n");

        //public static string copyright = "BitLC Erkrath";


        static void Main(string[] args)
        {
            // Anzahl an Buchstaben
            Console.WriteLine("bitte ein wort eingeben");
            string s = Console.ReadLine();
            Console.WriteLine("Die Anzahl der Buchstaben beträgt: {0}", s.CountChar());

            Console.ReadKey();
            Console.Clear();

            // Anzahl an Wörtern
            Console.WriteLine("Geben Sie jetzt einen Satz ein");
            s = Console.ReadLine();
            Console.WriteLine("Die Anzahl der Wörter beträgt: {0}", s.CountWords());

            Console.ReadKey();
            Console.Clear();

            //addCopyright Methode
            s = text;

            Console.WriteLine("Bitte geben Sie Ihr Copyright jetzt ein");
            string copyright = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geben Sie jetzt eine Zahl ein, nach wievielen Wörtern Ihr Copyright eingetragen werden soll");
            int stellenwert = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            s.AddCopyright(s, copyright, stellenwert);

            Console.ReadKey();
            Console.Clear();
        }

        
    }
}
