using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class MTextBox : Component
    {
        public TextBox MyTextBox { get; } = new TextBox();
        public MTextBox(TextBox textBox)
        {
            MyTextBox = textBox;
        }
    }
}
