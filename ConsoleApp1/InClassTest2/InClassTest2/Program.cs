using System;
using System.Text.RegularExpressions;

namespace InClassTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string textToSearch = "This is Sparta!";
            string regex = "[a-z]";
            MatchCollection matchResults = Regex.Matches(textToSearch, regex);
            foreach (Match m in matchResults)
            {
                Console.WriteLine(m);
            }

            string textToSearch2 = "afgkk24679ggZXVFcatcat9970b02dogMaryxxxxbbbb22FHDFISHMOTHERfaskldjflasjfjasdfjzxcv xcEYERTR345262372546vbcvb0000000carTT2356236623732623462366johnxcxcxvbdfsdgvxc vC#00002499xbvvcfgooglecvcvxzvdfgsdjiiruewortuiwerioptunvxn990348590234523907854034s dnskfshwateririweotowyuwerituwreutpwetuwertueryuwertwerutpweurtpuweptnvmxcvnnxcxcxvb";
            regex = "[a-z]at";

            matchResults = Regex.Matches(textToSearch2, regex);

            foreach (Match m in matchResults)
            {
                Console.WriteLine(m);
            }
        }
    }
}
