using System.Collections.Generic;

namespace Codecool.WasteRecycling
{
    public class Dustbin
    {

        public Dustbin(string color)
        {
            Color = color;
        }
       public string Color { get; private set; }
       public List<Garbage> GarbageBin { get; private set; }
    }
}
