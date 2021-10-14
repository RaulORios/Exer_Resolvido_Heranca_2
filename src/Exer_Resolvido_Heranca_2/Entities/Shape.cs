using Exer_Resolvido_Heranca_2.Entities.Enums;

namespace Exer_Resolvido_Heranca_2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
                
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();


    }
}
