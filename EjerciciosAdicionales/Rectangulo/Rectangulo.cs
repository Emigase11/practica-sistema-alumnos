namespace Rectangulo;

public class Rectangulo
{
    public decimal Base { get; set; }
    public decimal Altura { get; set; }

    public Rectangulo(decimal baseRectangulo, decimal altura)
    {
        Base = baseRectangulo;
        Altura = altura;
    }

    public decimal Area() => Base * Altura;

    public decimal Perimetro() => 2 * (Base + Altura);

    public bool EsCuadrado() => Base == Altura;
}
