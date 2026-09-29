namespace Descuentos;

public class Suscripcion : IDescontable
{
    public string Servicio { get; set; }
    public decimal PrecioMensual { get; set; }
    public decimal Descuento { get; set; }

    public Suscripcion(string servicio, decimal precioMensual, decimal descuento)
    {
        Servicio = servicio;
        PrecioMensual = precioMensual;
        Descuento = descuento;
    }

    public decimal PrecioConDescuento() => PrecioMensual * (1 - Descuento / 100);
}
