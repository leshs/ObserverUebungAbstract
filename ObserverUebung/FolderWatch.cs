using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObserverUebung
{
    class FolderWatch
    {
        public List<AbstractFileAddedListener> FileAddedListeners = new List<AbstractFileAddedListener>();

        
        public FolderWatch(string folder)
        {

        }
        //sollte protected sein
        public void FileAdded(string file)
        {
            foreach (AbstractFileAddedListener listener in FileAddedListeners)
            {
                listener.NotifyFileAdded(file);
            }
        }
    }
}
