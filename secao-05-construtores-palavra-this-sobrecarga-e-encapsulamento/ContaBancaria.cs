using System;
using System.Globalization;

class ContaBancaria
{
    public int NumeroConta { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(int numeroConta, string titular)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = 0.0;
    }

    public void Deposito(double valor)
    {
        Saldo += valor;
    }

    public void Saque(double valor)
    {
        Saldo -= valor + 5.0;
    }

    public override string ToString()
    {
        return "Conta "
            + NumeroConta
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
}