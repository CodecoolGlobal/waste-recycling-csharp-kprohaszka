namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; private set; }

        public void Clean()
        {
            Cleaned = true;
        }
    }
}
