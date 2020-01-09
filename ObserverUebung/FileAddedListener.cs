using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverUebung
{
    class FileAddedListener : AbstractFileAddedListener
    {
        private Logger logger = null;

        public FileAddedListener(Logger logger)
        {
            this.logger = logger;
        }

        public override void NotifyFileAdded(String file)
        {
            logger.WriteLine(file);
        }

    }
}
