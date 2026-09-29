using Rectangulo;

Rectangulo.Rectangulo rectangulo = new(5, 3);
Rectangulo.Rectangulo cuadrado = new(4, 4);

Console.WriteLine($"Rectángulo: área {rectangulo.Area()}, perímetro {rectangulo.Perimetro()}, cuadrado: {rectangulo.EsCuadrado()}");
Console.WriteLine($"Cuadrado: área {cuadrado.Area()}, perímetro {cuadrado.Perimetro()}, cuadrado: {cuadrado.EsCuadrado()}");
