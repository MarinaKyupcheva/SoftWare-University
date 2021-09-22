using Logger.Appenders;
using Logger.Layouts;
using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Core.Factories
{
    public interface IAppendarFactory
    {
        IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel);
    }
}
