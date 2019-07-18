    
using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Axel\Desktop\learn_C#\advent_of_code\day01\input.txt");

            long total = lines.Sum(x => Convert.ToInt64(x));
            Console.WriteLine(total);

            Console.ReadLine();
        }  
    }
}
