using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 5, 4, 7, 3, 8, 1 };
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(",", numbers));
            Console.ReadLine();
        }
    }
}
