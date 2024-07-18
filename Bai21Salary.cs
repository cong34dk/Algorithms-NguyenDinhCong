using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Recursive
{
    public class Bai21Salary
    {
        //Ham tinh luong su dung de quy
        public static double CalSalaryRecursive(double salary, int n)
        {
            if (n == 0)
            {
                return salary;
            }
            else
            {
                return CalSalaryRecursive(salary * 1.1, n-1);
            }
        }

        //Ham tinh luong ko dung de quy
        public static double CalSalaryLoop(double salary, int n)
        {
            for (int i = 0; i < n; i++)
            {
                salary *= 1.1;
            }
            return salary;
        }
    }
}
