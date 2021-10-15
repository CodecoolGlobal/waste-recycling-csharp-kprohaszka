namespace Codecool.WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { get; private set; }

        public void Squeeze()
        {
            Squeezed = true;
        }
    }
}
