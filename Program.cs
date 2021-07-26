using System;

namespace csharpDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual!");
            }

            Console.WriteLine(data);



        }
    }
}
