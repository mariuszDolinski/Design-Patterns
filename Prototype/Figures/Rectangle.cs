using System;
using System.Collections.Generic;
namespace Prototype.Figures
{
    internal class Rectangle : Shape
    {
        public override Shape Clone()
        {
            Rectangle baseClone = (Rectangle)this.MemberwiseClone(); //płytka kopia dopisujemy kod kopii głebokiej

            baseClone.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color,
            };

            return baseClone;
        }

        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }
    }
}
