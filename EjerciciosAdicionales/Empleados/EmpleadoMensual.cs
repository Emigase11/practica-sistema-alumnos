namespace Empleados;

public class EmpleadoMensual : Empleado
{
    public decimal SueldoFijo { get; set; }

    public EmpleadoMensual(string nombre, decimal sueldoFijo) : base(nombre)
    {
        SueldoFijo = sueldoFijo;
    }

    public override decimal CalcularSueldo() => SueldoFijo;
}
