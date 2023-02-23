using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    internal class Application
    {
        private IUIElementsFactory _systemFactory;
        public Application(IUIElementsFactory systemFactory)
        {
            _systemFactory = systemFactory;
        }

        public void RenderUI()
        {
            var newFileButton = _systemFactory.CreateButton();
            var searchTextBox = _systemFactory.CreateTextBox();

            newFileButton.Render();
            searchTextBox.Render();
        }

        public void HandleClickUI()
        {
            var newFileButtonClick = _systemFactory.CreateButton();

            newFileButtonClick.HandleClick();
        }
        public void HandleInputUI()
        {
            var searchTextBoxInputHandle = _systemFactory.CreateTextBox();

            searchTextBoxInputHandle.HandleInupt();
        }

    }
}
