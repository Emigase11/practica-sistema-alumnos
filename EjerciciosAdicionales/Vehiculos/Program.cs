using Vehiculos;

List<Vehiculo> vehiculos = new()
{
    new Auto("Toyota"),
    new Moto("Honda"),
    new Auto("Ford")
};

foreach (Vehiculo vehiculo in vehiculos)
{
    Console.WriteLine(vehiculo.Describir());
}
