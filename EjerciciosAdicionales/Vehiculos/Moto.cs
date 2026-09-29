namespace Vehiculos;

public class Moto : Vehiculo
{
    public Moto(string marca) : base(marca, 2)
    {
    }

    public override string Describir()
    {
        return $"Moto {Marca} de {Ruedas} ruedas.";
    }
}
