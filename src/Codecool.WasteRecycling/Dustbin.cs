using System.Collections.Generic;

namespace Codecool.WasteRecycling
{
    public class Dustbin
    {

        public Dustbin(string color)
        {
            Color = color;
            GarbageBin = new DynamicArray();
        }
        public string Color { get; private set; }
        public DynamicArray GarbageBin { get; private set; }
        public int HouseWasteCount { get; private set; }
        public int PaperWasteCount { get; private set; }
        public int PlasticWasteCount { get; private set; }

        public void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PaperGarbage)
            {
                PaperGarbage paperGarbage = (PaperGarbage)garbage;
                if (!paperGarbage.Squeezed)
                {
                    throw new DustbinContentException();
                }
            }
            if (garbage is PlasticGarbage)
            {
                PlasticGarbage plasticGarbage = (PlasticGarbage)garbage;
                if (!plasticGarbage.Cleaned)
                {
                    throw new DustbinContentException();
                }
            }
            GarbageBin.Add(garbage);
        }

        public void EmptyContents()
        {
            GarbageBin.Clear();
        }


    }
}



































//if (garbage.GetType() == typeof(PlasticGarbage)
//        {
//    if (garbage.Cleaned = true)
//    {
//        var DynamicArray = new DynamicArray();
//        DynamicArray.Add(garbage);
//        GarbageBin = DynamicArray._array;
//        Garbage Garbagerw = new PlasticGarbage(false);
//        Garbagerw.
//            }
//}
//else if (garbage.GetType() == typeof(PaperGarbage))
//{
//    if (PaperGarbage = true)
//    {
//        var DynamicArray = new DynamicArray();
//        DynamicArray.Add(garbage);
//        GarbageBin = DynamicArray._array;
//    }
//}
//else if (garbage.GetType() != typeof(PaperGarbage) ||
//    garbage.GetType() != typeof(PaperGarbage))
//{
//    var DynamicArray = new DynamicArray();
//    DynamicArray.Add(garbage);
//    GarbageBin = DynamicArray._array;
//}
//else
//{
//    throw new DustbinContentException();
//}
