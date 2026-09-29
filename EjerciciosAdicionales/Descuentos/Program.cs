using Descuentos;

List<IDescontable> descuentos = new()
{
    new Producto("Libro", 10000, 10),
    new Suscripcion("Música", 5000, 20)
};

foreach (IDescontable descontable in descuentos)
{
    Console.WriteLine($"Precio con descuento: ${descontable.PrecioConDescuento()}");
}
