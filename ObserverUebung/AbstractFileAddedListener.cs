using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverUebung
{
    abstract class AbstractFileAddedListener
    {
        public abstract void NotifyFileAdded(string file);
    }
}
