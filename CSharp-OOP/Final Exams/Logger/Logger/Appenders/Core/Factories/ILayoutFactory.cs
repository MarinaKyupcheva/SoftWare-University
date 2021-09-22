using Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders.Core.Factories
{
  public interface ILayoutFactory 
    {
        ILayout CreateLayout(string type);
    }
}
