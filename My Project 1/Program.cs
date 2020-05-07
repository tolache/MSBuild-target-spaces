using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace My_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int?> numbers = null;
            int? i = null;

            if (numbers == null)
            {
                numbers = new List<int?>();
            }

            if (i == null)
            {
                numbers.Add(i = 17);
                numbers.Add(i = 20);
            }

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }
    }
}
