using Abstract_Factory.Interfaces;

namespace Abstract_Factory.MacComponents
{
    internal class MacTextBox : ITextBox
    {
        public void HandleInupt()
        {
            Console.WriteLine("Handle Mac textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render Mac textbox");
        }
    }
}
