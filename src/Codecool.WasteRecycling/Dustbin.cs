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

        public override string ToString()
        {
            string houseWasteContent = "";
            string paperWasteContent = "";
            string plasticWasteContent = "";
            int houseWasteCount = 0;
            int paperWasteCount = 0;
            int plasticWasteCount = 0;
            foreach (var garbage in GarbageBin._array)
            {
                if (garbage is PaperGarbage)
                {
                    paperWasteCount++;
                    paperWasteContent += $"{garbage.Name} nr.{paperWasteCount} ";
                }
                else if (garbage is PlasticGarbage)
                {
                    plasticWasteCount++;
                    plasticWasteContent += $"{garbage.Name} nr.{plasticWasteCount} ";
                }
                else if (garbage != null)
                {
                    houseWasteCount++;
                    houseWasteContent += $"{garbage.Name} nr.{houseWasteCount} ";
                }
            }
            return $"{Color} Dustbin!\nHouse waste content:{houseWasteCount} item(s) {houseWasteContent} \n" +
                $"Paper content: {paperWasteCount} item(s) {paperWasteContent} \n" +
                $"Plastic content: {plasticWasteCount} item(s) {plasticWasteContent}";
        }

        public void DisplayContents()
        {
            System.Console.WriteLine(ToString());
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
