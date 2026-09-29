namespace Descuentos;

public class Producto : IDescontable
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public decimal Descuento { get; set; }

    public Producto(string nombre, decimal precio, decimal descuento)
    {
        Nombre = nombre;
        Precio = precio;
        Descuento = descuento;
    }

    public decimal PrecioConDescuento() => Precio * (1 - Descuento / 100);
}
