using Abstract_Factory.Interfaces;

namespace Abstract_Factory.WindowsComponents
{
    public class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle Windows button click event");
        }

        public void Render()
        {
            Console.WriteLine("Render Windows button");
        }
    }
}
