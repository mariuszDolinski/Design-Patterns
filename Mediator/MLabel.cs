using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class MLabel : Component
    {
        public Label MyLabel { get; } = new Label();
        public MLabel(Label label) 
        {
            MyLabel = label;
        }
    }
}
