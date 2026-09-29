namespace Vehiculos;

public class Auto : Vehiculo
{
    public Auto(string marca) : base(marca, 4)
    {
    }

    public override string Describir()
    {
        return $"Auto {Marca} de {Ruedas} ruedas.";
    }
}
