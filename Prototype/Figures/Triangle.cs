using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Figures
{
    internal class Triangle : Shape
    {
        public override Shape Clone()
        {
            return (Triangle)this.MemberwiseClone(); //płytka kopia
        }

        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
    }
}
