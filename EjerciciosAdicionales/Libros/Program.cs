using Libros;

List<Libro> libros = new()
{
    new Libro("El principito", "Antoine de Saint-Exupéry"),
    new Libro("Don Quijote", "Miguel de Cervantes"),
    new Libro("Rayuela", "Julio Cortázar")
};

string? opcion;
do
{
    Console.WriteLine("\n1. Prestar libro");
    Console.WriteLine("2. Devolver libro");
    Console.WriteLine("3. Listar disponibles");
    Console.WriteLine("4. Salir");
    Console.Write("Opción: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
        case "2":
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {libros[i].Titulo} - {libros[i].Autor}");
            }
            Console.Write("Número de libro: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= libros.Count)
            {
                Libro libro = libros[numero - 1];
                bool realizado = opcion == "1" ? libro.Prestar() : libro.Devolver();
                Console.WriteLine(realizado ? "Operación realizada." : "No se puede realizar la operación.");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
            break;

        case "3":
            bool hayDisponibles = false;
            foreach (Libro libro in libros)
            {
                if (!libro.EstaPrestado)
                {
                    Console.WriteLine($"{libro.Titulo} - {libro.Autor}");
                    hayDisponibles = true;
                }
            }
            if (!hayDisponibles)
            {
                Console.WriteLine("No hay libros disponibles.");
            }
            break;

        case "4":
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != "4" && opcion != null);
