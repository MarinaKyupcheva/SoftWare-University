using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders
{
    public interface IAppender
    {
        void Append(string date, ReportLevel reportLevel, string message);
    }
}
