

namespace AbstraccionQ22025
{
    public abstract class Figura
    {
        public abstract double Area();
        public abstract double Perimetro();
        public void Imprimir(string NombreFigura)
        {
            Console.WriteLine($"Area del {NombreFigura}: {Area()} cm2");
            Console.WriteLine($"Perímetro del {NombreFigura}: {Perimetro()} cm");
        }
    }
}
