using System;
using System.Linq;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin dustbin = new Dustbin("blue");
            var regularGarbage1 = new Garbage("Chewed Apple");
            var regularGarbage2 = new Garbage("Something weird and moldy");
            var paperGarbage1 = new PaperGarbage("Unfinished Essay");
            var paperGarbage2 = new PaperGarbage("Unpayed Bills");
            var paperGarbage3 = new PaperGarbage("House Mortgage");
            var plasticGarbage1 = new PlasticGarbage("Mineral Water Bottle");
            var plasticGarbage2 = new PlasticGarbage("McDonalds Fork");
            var plasticGarbage3 = new PlasticGarbage("Wrapper");
        }
    }
}
