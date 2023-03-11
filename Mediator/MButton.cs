using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class MButton : Component
    {
        public Button MyButton { get; } = new Button();
        public MButton(Button button)
        {
            MyButton = button;
            MyButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object? sender, EventArgs e)
        {
            _mediator.Notify(this, Args.BUTTON_CLEAR_CLICKED);
        }
    }
}
