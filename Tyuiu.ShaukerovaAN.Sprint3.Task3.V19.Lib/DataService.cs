using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShaukerovaAN.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char chr in value)
            { 
                if (chr == replaceable)
                {
                    res +=replacement; 
                }
                else
                {
                    res += chr;
                }
            }
            return res;
        }
    }
}
