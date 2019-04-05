using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace riot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter summoner name: ");
            string input = Console.ReadLine();
            Summoner summoner = new Summoner(input);

        }
    }
}
