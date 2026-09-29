namespace Libros;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool EstaPrestado { get; private set; }

    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public bool Prestar()
    {
        if (EstaPrestado)
        {
            return false;
        }

        EstaPrestado = true;
        return true;
    }

    public bool Devolver()
    {
        if (!EstaPrestado)
        {
            return false;
        }

        EstaPrestado = false;
        return true;
    }
}
