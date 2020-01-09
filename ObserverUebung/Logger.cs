using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObserverUebung
{
    class Logger
    {
        private TextWriter textWriter = null;
        public Logger(String logfile)
        {
            textWriter = new StreamWriter(logfile);
        }

        public Logger(TextWriter textWriter = null)
        {
            this.textWriter = textWriter;
        }

        public void WriteLine(string line)
        {
            textWriter.WriteLine(line);
            textWriter.Flush();
        }
    }
}
