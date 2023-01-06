using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxingUnBoxing bu = new BoxingUnBoxing();
            bu.Boxing();

            delegates d = new delegates();
            d.delegatesE();
        }
    }
}
