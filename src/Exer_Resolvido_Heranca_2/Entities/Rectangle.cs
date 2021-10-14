using Exer_Resolvido_Heranca_2.Entities.Enums;

namespace Exer_Resolvido_Heranca_2.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,Color color):base(color)
        {
            Width = width;
            Height = height;
        }


        public override double Area()
        {
            return Width * Height;
        }
    }
}
