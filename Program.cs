using System;
using WShop2.Extensions;
namespace WShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter = String.Empty
                               .AddHeading(DateTime.Now, "GM Office, San Juan");
            Console.WriteLine(letter);
        }
    }
}
