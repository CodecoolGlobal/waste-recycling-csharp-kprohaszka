namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public PlasticGarbage(string name) :
            base(name)
        {
        }

        public bool Cleaned { get; private set; }

        public void Clean()
        {
            Cleaned = true;
        }
    }
}
