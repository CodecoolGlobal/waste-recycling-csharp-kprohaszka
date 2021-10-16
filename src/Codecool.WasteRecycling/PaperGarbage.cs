namespace Codecool.WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public PaperGarbage(string name) :
            base(name)
        {
        }
        public bool Squeezed { get; private set; }

        public void Squeeze()
        {
            Squeezed = true;
        }
    }
}
