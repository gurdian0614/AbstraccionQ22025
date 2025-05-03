
namespace AbstraccionQ22025
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Math.Round(Base * Altura);
        }

        public override double Perimetro()
        {
            return Math.Round(2 * (Base + Altura));
        }
    }
}
