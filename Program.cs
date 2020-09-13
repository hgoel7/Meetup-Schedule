using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Meetup_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstDayCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> firstDay = new List<int>();

            for (int i = 0; i < firstDayCount; i++)
            {
                int firstDayItem = Convert.ToInt32(Console.ReadLine().Trim());
                firstDay.Add(firstDayItem);
            }

            int lastDayCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> lastDay = new List<int>();

            for (int i = 0; i < lastDayCount; i++)
            {
                int lastDayItem = Convert.ToInt32(Console.ReadLine().Trim());
                lastDay.Add(lastDayItem);
            }

            int result = Result.countMeetings(firstDay, lastDay);
            Console.WriteLine("Result : " + result);

        }
    }
}


class Result
{
    //private static List<int> appointmentSchedule;

    /*
     * Complete the 'countMeetings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY firstDay
     *  2. INTEGER_ARRAY lastDay
     */

    public static int countMeetings(List<int> firstDay, List<int> lastDay)
    {   
        int length = 0;
        
        length = firstDay.Count();
        
        Dictionary<int,int> dictData = new Dictionary<int, int>();

        for(int i = 0; i< length; i++) {
            int currFDay = firstDay.ElementAt(i);
            int currLDay = lastDay.ElementAt(i);
            bool saved = false;
            while (!saved) {
                if( !dictData.ContainsKey(currFDay) ) {
                    dictData.Add(currFDay, currLDay);
                    saved = true;
                }
                else if (currFDay < currLDay)
                {
                    currFDay++;
                    continue;
                }
                else
                {
                    int lDay = dictData[currFDay];
                    if( lDay == currFDay ) {
                        saved = true;
                    }
                    else
                    {
                        dictData[currFDay] = currLDay;
                        currLDay = lDay;
                        continue;
                    }
                }
            }
        }
        return dictData.Count;        
    }
}

