using SistemaAlumnos;

List<Alumno> alumnos = new();
Alumno alumnoEjemplo = new("Ana Pérez", 40123456, 1234);
alumnoEjemplo.CargarNotas(7, 7);
Profesor profesor = new("Marta Díaz", 28543210, "Programación");
Preceptor preceptor = new("Carlos Ruiz", 32111222);
List<Materia> materias = new()
{
    new Materia("PROG1", "Programación I", 128),
    new Materia("BD1", "Bases de Datos I", 96)
};
List<Persona> personas = new() { alumnoEjemplo, profesor, preceptor };
List<IExportable> exportables = new() { alumnoEjemplo, profesor, materias[0], materias[1] };
string? opcion;

do
{
    Console.WriteLine("\nSistema de alumnos");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar por legajo");
    Console.WriteLine("4. Promedio general del curso");
    Console.WriteLine("5. Cantidad de aprobados");
    Console.WriteLine("6. Presentaciones");
    Console.WriteLine("7. Exportar datos");
    Console.WriteLine("8. Salir");
    Console.Write("Opción: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            int documento = LeerEntero("Documento: ");
            int legajo = LeerEntero("Legajo: ");
            decimal nota1 = LeerDecimal("Primera nota: ");
            decimal nota2 = LeerDecimal("Segunda nota: ");

            Alumno nuevoAlumno = new(nombre, documento, legajo);
            if (nuevoAlumno.CargarNotas(nota1, nota2))
            {
                alumnos.Add(nuevoAlumno);
                personas.Add(nuevoAlumno);
                exportables.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado.");
            }
            else
            {
                Console.WriteLine("Las notas deben estar entre 0 y 10. El alumno no se agregó.");
            }
            break;

        case "2":
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados.");
            }
            else
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }
            break;

        case "3":
            int legajoBuscado = LeerEntero("Legajo a buscar: ");
            Alumno? encontrado = null;
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Legajo == legajoBuscado)
                {
                    encontrado = alumno;
                    break;
                }
            }

            if (encontrado == null)
            {
                Console.WriteLine("No se encontró un alumno con ese legajo.");
            }
            else
            {
                Console.WriteLine(encontrado);
            }
            break;

        case "4":
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos para calcular el promedio.");
            }
            else
            {
                decimal suma = 0;
                foreach (Alumno alumno in alumnos)
                {
                    suma += alumno.Promedio();
                }
                Console.WriteLine($"Promedio general: {suma / alumnos.Count:0.##}");
            }
            break;

        case "5":
            int aprobados = 0;
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.EstaAprobado())
                {
                    aprobados++;
                }
            }
            Console.WriteLine($"Alumnos aprobados: {aprobados}");
            break;

        case "6":
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.Presentarse());
            }
            break;

        case "7":
            foreach (IExportable exportable in exportables)
            {
                Console.WriteLine(exportable.ExportarLinea());
            }
            break;

        case "8":
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != "8" && opcion != null);

static int LeerEntero(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            return numero;
        }
        Console.WriteLine("Ingresá un número entero válido.");
    }
}

static decimal LeerDecimal(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        if (decimal.TryParse(Console.ReadLine(), out decimal numero))
        {
            return numero;
        }
        Console.WriteLine("Ingresá un número válido.");
    }
}
