using QueriesToOracle.Controllers;
using QueriesToOracle.Core;
using System;

namespace QueriesToOracle
{
    class Program
    {
        public static Store CurrentStore { get; set; }
        static void Main()
        {
            CurrentStore = new Store(new EntityQuery());
            CurrentStore.Load();
            Console.ReadKey();
        }
    }
}
