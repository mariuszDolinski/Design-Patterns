using Abstract_Factory.Interfaces;

namespace Abstract_Factory.MacComponents
{
    internal class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle Mac button click event");
        }

        public void Render()
        {
            Console.WriteLine("Render Mac button");
        }
    }
}
