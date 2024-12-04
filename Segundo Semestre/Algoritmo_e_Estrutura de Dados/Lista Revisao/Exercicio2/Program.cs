
class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria("Guilherme");

        conta.Depositar(1000.0);
        conta.Sacar(500.0);
        conta.ExibirSaldo();
    }
}