using System;

class ContaBancaria
{
    private double saldo;
    private string titular;

    public ContaBancaria(string titular)
    {
        this.titular = titular;
        saldo = 0.0;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Novo saldo: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Novo saldo: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor de saque inválido.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual da conta de {titular}: {saldo:C}");
    }
}


