using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverUebung 
{
    class FilePartyListener : AbstractFileAddedListener
    {
        public override void NotifyFileAdded(string file)
        {
            Console.WriteLine("PARTY");
        }
    }
}
