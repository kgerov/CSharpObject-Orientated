using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students
{
    static class Extentions
    {
        public static bool ContainsDoubleTwo(this List<int> grades)
        {
            int counter = 0;
            grades.ForEach(x => {
                                    if(x == 2) 
                                    { 
                                        counter++;
                                    }}
                                );
            return counter == 2 ? true : false;
        }
    }
}
