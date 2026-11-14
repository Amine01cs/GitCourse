using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Func : a build-in delegate thats accept from 0 to 16 inputs and return only one output.
    // Action : a build-in delegate thats accept from 0 to 16 inputs and Doesn't return any thing;
    // Predicate : a build-in delegate thats accept Only one inpukt and return a boolean type,.
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int,int,int> Adding = (x, y) => x + y;

            Console.WriteLine(Adding(10,5));

            Action<string, string> Name = (name, Job) => Console.WriteLine($"{name} : {Job}");
            Name("Ahmed", "Financiale Guy");

            Predicate<int> IsEven = (x) => x % 2 == 0;

            Console.WriteLine(IsEven(34));

        }
    }
}
