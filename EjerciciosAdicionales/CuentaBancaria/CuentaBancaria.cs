namespace CuentaBancaria;

public class CuentaBancaria
{
    public string Titular { get; set; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(string titular)
    {
        Titular = titular;
    }

    public bool Depositar(decimal monto)
    {
        if (monto < 0)
        {
            return false;
        }

        Saldo += monto;
        return true;
    }

    public bool Extraer(decimal monto)
    {
        if (monto < 0 || monto > Saldo)
        {
            return false;
        }

        Saldo -= monto;
        return true;
    }
}
