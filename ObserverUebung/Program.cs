using System;
using System.IO;

namespace ObserverUebung
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            FolderWatch folderWatch = new FolderWatch("C:\\Users\\...\\Documents\\TestFolder");
            Logger logger1 = new Logger(Console.Out);
            Logger logger2 = new Logger("C:\\Users\\lschubert\\...\\report.txt");
            folderWatch.FileAddedListeners.Add(new FileAddedListener(logger1));
            folderWatch.FileAddedListeners.Add(new FileAddedListener(logger2));
            FilePartyListener filePartyListener = new FilePartyListener();
            folderWatch.FileAddedListeners.Add(filePartyListener);


            //Test des Programms.
            //Der "hinzugefügte" File wird auf der Konsole angegeben
            //Ein tatsächlicher File-Name ist nicht notwendig
            //Beispiel-Eingabe: "abc"
            //Die Eingabe soll auf der Konsole und im Logfile ausgegeben werden.
            while(true)
            {
                string file = Console.ReadLine();
                folderWatch.FileAdded(file);
            }
        }
    }
}
