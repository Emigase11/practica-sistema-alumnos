namespace Empleados;

public class EmpleadoPorHora : Empleado
{
    public decimal PagoPorHora { get; set; }
    public decimal HorasTrabajadas { get; set; }

    public EmpleadoPorHora(string nombre, decimal pagoPorHora, decimal horasTrabajadas) : base(nombre)
    {
        PagoPorHora = pagoPorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularSueldo() => PagoPorHora * HorasTrabajadas;
}
