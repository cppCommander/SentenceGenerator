using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator Zdanie = new Generator();
            for(int i=0; i< 10; i++) Zdanie.RandomSentence();
            
            Console.ReadKey();
        }
    }
}
