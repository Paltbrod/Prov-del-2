using System;

namespace Prov_del_2
{
    class Program
    {
        static void Main(string[] args)
        {

            snark();
            Console.ReadLine();
        }

        static void snark()
        {
            Random generator = new Random();

            string[] varor = { "fläsk", "läsk", "paltbröd", "pizza", "craigslistgarderob" };
            string[] vikt = { };

            Console.WriteLine("Hur mycket kan du bära?");
            string viktcap = Console.ReadLine();
            int cap = int.Parse(viktcap);
            Console.WriteLine("här är alla varor som går att köpa inklusive vikterna");
            Console.WriteLine(varor);




        }

    }

}
