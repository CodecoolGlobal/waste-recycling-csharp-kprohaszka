using System;
using System.Linq;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin dustbin = new Dustbin("blue");
            Garbage Paper = new PaperGarbage();
            PlasticGarbage plastic = new PlasticGarbage();
            Garbage RegularGarbage = new Garbage();
            plastic.Clean();
            dustbin.ThrowOutGarbage(plastic);
            dustbin.GarbageBin._array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        }
    }
}
