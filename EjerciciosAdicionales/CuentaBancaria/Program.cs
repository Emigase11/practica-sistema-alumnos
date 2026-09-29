using CuentaBancaria;

CuentaBancaria.CuentaBancaria cuenta = new("Ana Pérez");
Console.WriteLine($"Titular: {cuenta.Titular}");
Console.WriteLine($"Depósito de 1000: {cuenta.Depositar(1000)}");
Console.WriteLine($"Depósito de -50: {cuenta.Depositar(-50)}");
Console.WriteLine($"Extracción de 300: {cuenta.Extraer(300)}");
Console.WriteLine($"Extracción de 900: {cuenta.Extraer(900)}");
Console.WriteLine($"Saldo: {cuenta.Saldo}");
