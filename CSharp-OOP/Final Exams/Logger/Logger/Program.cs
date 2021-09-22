using Logger.Appenders;
using Logger.Appenders.Core.Factories;
using Logger.Core.Factories;
using Logger.Layouts;
using Logger.Loggers;
using SOLID.Enum;
using System;
using System.Collections.Generic;

namespace Logger
{
    class Program
    {
        private static IAppendarFactory apeenderFactory;
        private static ILayoutFactory layoutFactory;
        public static object IAppenderFactory { get; private set; }

        static void Main(string[] args)
        {
             apeenderFactory = new AppendarFactory();
            layoutFactory = new LayoutFactory();

            int n = int.Parse(Console.ReadLine());


            IAppender[] appenders = ReadAppenders(n);

            ILogger logger = new Loggerrr(appenders);

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "END")
                {
                    break;
                }

                string[] parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                ReportLevel reportLevel = Enum.Parse<ReportLevel>(parts[0], true);
                string date = parts[1];
                string message = parts[2];

                switch (reportLevel)
                {
                    case ReportLevel.Info:
                        logger.Info(date, message);
                        break;
                    case ReportLevel.Critical:
                        logger.Critical(date, message);
                        break;
                    case ReportLevel.Warning:
                        logger.Warning(date, message);
                        break;
                    case ReportLevel.Error:
                        logger.Error(date, message);
                        break;
                    case ReportLevel.Fatal:
                        logger.Fatal(date, message);
                        break;
                }

            }

            Console.WriteLine(logger);
        }

        private static IAppender[] ReadAppenders(int n)
        {
            IAppender[] appenders = new IAppender[n];
            for (int i = 0; i < n; i++)
            {
                string[] appenderParts = Console.ReadLine().Split();

                string appenderType = appenderParts[0];
                string layoutType = appenderParts[1];
                ReportLevel reportedLevel = appenderParts.Length == 3
                    ? Enum.Parse<ReportLevel>(appenderParts[2], true)
                    : ReportLevel.Info;
                ILayout layout = layoutFactory.CreateLayout(layoutType);
                IAppender appender = apeenderFactory.CreateAppender(appenderType, layout
                    , reportedLevel);
                appenders[i] = appender;

            }
            return appenders;
        }
    }
}
