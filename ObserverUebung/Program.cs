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
            FolderWatch folderWatch = new FolderWatch("C:\\Users\\lschubert\\Documents\\TestFolder");
            Logger logger1 = new Logger(Console.Out);
            Logger logger2 = new Logger("C:\\Users\\lschubert\\Documents\\report.txt");
            folderWatch.FileAddedListeners.Add(new FileAddedListener(logger1));
            folderWatch.FileAddedListeners.Add(new FileAddedListener(logger2));



            //Test des Programms.
            while(true)
            {
                string file = Console.ReadLine();
                folderWatch.FileAdded(file);
            }
        }
    }
}
