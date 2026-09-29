using Empleados;

List<Empleado> empleados = new()
{
    new EmpleadoMensual("Ana", 120000),
    new EmpleadoPorHora("Luis", 2500, 40)
};

foreach (Empleado empleado in empleados)
{
    Console.WriteLine($"{empleado.Nombre}: ${empleado.CalcularSueldo()}");
}
