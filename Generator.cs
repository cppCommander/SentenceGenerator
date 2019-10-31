using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceGenerator
{
    class Generator
    {
        private string[] wordArray0 = { "automatic", "best", "thin", "big", "blue" };
        private string[] wordArray1 = { "unicorn", "T-rex", "programmer", "hippopotamus" };
        private string[] wordArray2 = { "goes", "learns", "like", "wants", "loves" };
        private string[] wordArray3 = { "play", "sleep", "lay", "clean", "cook" };
        private string[] wordArray4 = { "on the table", "in the forest", "at work", "under the desk", "at grandma's" };
        
        private Random random = new Random();

        private int Roll()
        {
            return random.Next(4);
        }

        public void RandomSentence()
        {

            Console.WriteLine("{0} {1} {2} to {3} {4}", wordArray0[Roll()], wordArray1[Roll()], wordArray2[Roll()], wordArray3[Roll()], wordArray4[Roll()]);
        }
    }
}
