using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Figures
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }
        public override Shape Clone()
        {
            Circle baseClone = (Circle)this.MemberwiseClone(); //płytka kopia dopisujemy kod kopii głebokiej
            //w przypadku zagnieżdzenia typów bazowych można np. serializować typ do json a potem deserializować do nowego obiektu
            baseClone.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };

            return baseClone;
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
