using System;

namespace WShop2.Extensions
{
    public static partial class LetterExtensions 
    {
        public static string AddHeading (this string letter, DateTime date, string place) {
            return letter += $"Hoy {date.ToShortDateString()}{place}\n";
        }
    }
}