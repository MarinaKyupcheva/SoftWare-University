using Logger.Appenders;
using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Loggers
{
    public class Loggerrr : ILogger
    {
        private readonly IAppender[] appenders;

        public Loggerrr(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Info(string date, string message)
        {
            AppendToAppenders(date, ReportLevel.Info, message);
        }

        public void Warning(string date, string message)
        {
            AppendToAppenders(date, ReportLevel.Warning, message);
        }
        public void Error(string date, string message)
        {
            AppendToAppenders(date, ReportLevel.Error, message);
        }

        
        public void Critical(string date, string message)
        {
            AppendToAppenders(date, ReportLevel.Critical, message);
        }
        public void Fatal(string date, string message)
        {
            AppendToAppenders(date, ReportLevel.Fatal, message);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().Trim();
        }

        private void AppendToAppenders(string date, ReportLevel reportLevel, string message)
        {
            foreach (var appender in appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }

      
    }
}
