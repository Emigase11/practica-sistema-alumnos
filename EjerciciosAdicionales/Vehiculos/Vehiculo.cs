namespace Vehiculos;

public class Vehiculo
{
    public string Marca { get; set; }
    public int Ruedas { get; set; }

    public Vehiculo(string marca, int ruedas)
    {
        Marca = marca;
        Ruedas = ruedas;
    }

    public virtual string Describir()
    {
        return $"Vehículo {Marca} de {Ruedas} ruedas.";
    }
}
