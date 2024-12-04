class FilaCircular
{
    private string[] elementos;
    private int capacidade;
    private int tamanho;
    private int inicio;
    private int fim;

    public FilaCircular(int capacidade)
    {
        this.capacidade = capacidade;
        this.elementos = new string[capacidade];
        this.tamanho = 0;
        this.inicio = 0;
        this.fim = -1;
    }

    public int Tamanho
    {
        get { return tamanho; }
    }

    public void Enfileirar(string elemento)
    {
        if (tamanho < capacidade)
        {
            fim = (fim + 1) % capacidade;
            elementos[fim] = elemento;
            tamanho++;
        }
        else
        {
            Console.WriteLine("Fila cheia. Não é possível adicionar mais clientes.");
        }
    }

    public string Desenfileirar()
    {
        if (tamanho > 0)
        {
            string elementoAtendido = elementos[inicio];
            inicio = (inicio + 1) % capacidade;
            tamanho--;
            return elementoAtendido;
        }
        return null;
    }

    public string ProximoCliente()
    {
        if (tamanho > 0)
        {
            return elementos[inicio];
        }
        return null;
    }
}