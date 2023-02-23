using Abstract_Factory.Interfaces;

namespace Abstract_Factory.WindowsComponents
{
    internal class WindowsTextBox : ITextBox
    {
        public void HandleInupt()
        {
            Console.WriteLine("Handle Windows textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render Windows textbox");
        }
    }
}
