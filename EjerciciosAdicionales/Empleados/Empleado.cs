namespace Empleados;

public abstract class Empleado
{
    public string Nombre { get; set; }

    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public abstract decimal CalcularSueldo();
}
