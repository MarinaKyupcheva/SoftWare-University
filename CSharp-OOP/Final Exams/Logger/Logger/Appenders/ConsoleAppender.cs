using IdentityServer3.Core.Resources;
using Logger.Layouts;
using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

     
        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if(!this.CanAppend(reportLevel))
            {
                return;
            }

            this.Messages += 1;
            string content = string.Format(this.layout.Template, date, reportLevel, message);

            Console.WriteLine(content);
        }

       
    }
}
