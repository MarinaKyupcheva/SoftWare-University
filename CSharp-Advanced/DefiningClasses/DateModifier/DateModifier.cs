using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierProblem
{
    public static class DateModifier
    {
       public static int GetDiffBetwenDays (string firstDateStr, string secondDateStr)
        {
            DateTime dateOne = DateTime.Parse(firstDateStr);
            DateTime dateTwo = DateTime.Parse(secondDateStr);

            TimeSpan diff = dateOne - dateTwo;

            return Math.Abs(diff.Days);


        }

    }
}
