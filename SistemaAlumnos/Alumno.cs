namespace SistemaAlumnos;

public class Alumno : Persona, IExportable
{
    public int Legajo { get; private set; }
    public decimal Nota1 { get; private set; }
    public decimal Nota2 { get; private set; }

    public Alumno(string nombre, int documento, int legajo) : base(nombre, documento)
    {
        Legajo = legajo;
    }

    public bool CargarNotas(decimal nota1, decimal nota2)
    {
        if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            return false;
        }

        Nota1 = nota1;
        Nota2 = nota2;
        return true;
    }

    public decimal Promedio() => (Nota1 + Nota2) / 2m;

    public bool EstaAprobado() => Promedio() >= 6m;

    public void SubirNota()
    {
        Nota1 = Math.Min(Nota1 + 1m, 10m);
        Nota2 = Math.Min(Nota2 + 1m, 10m);
    }

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {Promedio():0.##})";
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre}, alumno con legajo {Legajo}.";
    }

    public string ExportarLinea()
    {
        return $"ALUMNO;{Legajo};{Nombre};{Promedio():0.##}";
    }
}
