
using AbstraccionQ22025;

Circulo circulo = new Circulo();
Rectangulo rectangulo = new Rectangulo();

const string CIRCULO = "Círculo";
const string RECTANGULO = "Rectángulo";

Console.Write("Ingrese el Radio: ");
circulo.Radio = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la Base: ");
rectangulo.Base = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la Altura: ");
rectangulo.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"{CIRCULO}:");
circulo.Imprimir(CIRCULO);

Console.WriteLine();
Console.WriteLine($"{RECTANGULO}:");
rectangulo.Imprimir(RECTANGULO);