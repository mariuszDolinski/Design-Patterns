namespace Abstract_Factory.Interfaces
{
    internal interface IUIElementsFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
