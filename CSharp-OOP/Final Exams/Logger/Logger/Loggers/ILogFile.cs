using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Loggers
{
    public interface ILogFile
    {
        public int Size { get;}
        void Write(string content);
    }
}
