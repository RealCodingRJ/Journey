using System;
using System.Collections;

namespace Samnpe
{
    class App
    {

        static void Main(string[] args)
        {
            ArrayList list = [];
            list.Add("Ryan");
            list.Add("Learning CSharp");
            list.Add("Loser");

            foreach (string lists in list)
            {
                Console.WriteLine(lists);

            }

        }
    }
}