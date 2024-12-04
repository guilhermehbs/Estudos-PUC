using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        TestarAlgoritmo("BubbleSort", CriarVetorAleatorio(1000), BubbleSort);
        TestarAlgoritmo("BubbleSort", CriarVetorOrdenado(1000), BubbleSort);
        TestarAlgoritmo("BubbleSort", CriarVetorInversamenteOrdenado(1000), BubbleSort);

        TestarAlgoritmo("InsertionSort", CriarVetorAleatorio(1000), InsertionSort);
        TestarAlgoritmo("InsertionSort", CriarVetorOrdenado(1000), InsertionSort);
        TestarAlgoritmo("InsertionSort", CriarVetorInversamenteOrdenado(1000), InsertionSort);

        TestarAlgoritmo("SelectionSort", CriarVetorAleatorio(1000), SelectionSort);
        TestarAlgoritmo("SelectionSort", CriarVetorOrdenado(1000), SelectionSort);
        TestarAlgoritmo("SelectionSort", CriarVetorInversamenteOrdenado(1000), SelectionSort);

        TestarAlgoritmo("BubbleSort", CriarVetorEstudantesAleatorio(1000), BubbleSort);
        TestarAlgoritmo("BubbleSort", CriarVetorEstudantesOrdenado(1000), BubbleSort);
        TestarAlgoritmo("BubbleSort", CriarVetorEstudantesInversamenteOrdenado(1000), BubbleSort);

        TestarAlgoritmo("InsertionSort", CriarVetorEstudantesAleatorio(1000), InsertionSort);
        TestarAlgoritmo("InsertionSort", CriarVetorEstudantesOrdenado(1000), InsertionSort);
        TestarAlgoritmo("InsertionSort", CriarVetorEstudantesInversamenteOrdenado(1000), InsertionSort);

        TestarAlgoritmo("SelectionSort", CriarVetorEstudantesAleatorio(1000), SelectionSort);
        TestarAlgoritmo("SelectionSort", CriarVetorEstudantesOrdenado(1000), SelectionSort);
        TestarAlgoritmo("SelectionSort", CriarVetorEstudantesInversamenteOrdenado(1000), SelectionSort);

    }

    static void TestarAlgoritmo<T>(string nomeAlgoritmo, T[] vetor, Action<T[]> algoritmo)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int comparacoes = 0;
        int movimentacoes = 0;

        algoritmo(vetor);

        stopwatch.Stop();

        Console.WriteLine($"Algoritmo: {nomeAlgoritmo}");
        Console.WriteLine($"Tipo de Vetor: Aleatório");
        Console.WriteLine($"Tamanho do Vetor: {vetor.Length}");
        Console.WriteLine($"Tempo de Execução: {stopwatch.Elapsed.TotalMilliseconds} ms");
        Console.WriteLine($"Número de Comparações: {comparacoes}");
        Console.WriteLine($"Número de Movimentações: {movimentacoes}"); 
        Console.WriteLine();
    }


    static int[] CriarVetorAleatorio(int tamanho)
    {
        Random random = new Random();
        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = random.Next(100);
        }

        return vetor;
    }

    static int[] CriarVetorOrdenado(int tamanho)
    {
        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = i;
        }

        return vetor;
    }

    static int[] CriarVetorInversamenteOrdenado(int tamanho)
    {
        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = tamanho - i - 1;
        }

        return vetor;
    }

    static Estudante[] CriarVetorEstudantesAleatorio(int tamanho)
    {
        Random random = new Random();
        Estudante[] vetorEstudantes = new Estudante[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetorEstudantes[i] = new Estudante
            {
                Matricula = random.Next(1000),
                Nome = GerarNomeAleatorio(),
                CursoMatriculado = GerarCursoAleatorio(),
                CoeficienteRendimento = random.Next(10),
                PeriodoAtual = random.Next(1, 9)
            };
        }

        return vetorEstudantes;
    }

    static Estudante[] CriarVetorEstudantesOrdenado(int tamanho)
    {
        Estudante[] vetorEstudantes = new Estudante[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetorEstudantes[i] = new Estudante
            {
                Matricula = i + 1,
                Nome = GerarNomeAleatorio(),
                CursoMatriculado = GerarCursoAleatorio(),
                CoeficienteRendimento = i % 10,
                PeriodoAtual = i % 8 + 1
            };
        }

        return vetorEstudantes;
    }

    static Estudante[] CriarVetorEstudantesInversamenteOrdenado(int tamanho)
    {
        Estudante[] vetorEstudantes = new Estudante[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetorEstudantes[i] = new Estudante
            {
                Matricula = tamanho - i,
                Nome = GerarNomeAleatorio(),
                CursoMatriculado = GerarCursoAleatorio(),
                CoeficienteRendimento = i % 10,
                PeriodoAtual = i % 8 + 1
            };
        }

        return vetorEstudantes;
    }

    static void ImprimirVetorEstudantes(string mensagem, Estudante[] vetorEstudantes)
    {
        Console.WriteLine(mensagem);
        foreach (var estudante in vetorEstudantes)
        {
            Console.WriteLine($"{estudante}");
        }
        Console.WriteLine();
    }

    static string GerarNomeAleatorio()
    {
        string[] nomes = { "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Henry", "Ivy", "Jack" };
        Random random = new Random();
        return nomes[random.Next(nomes.Length)];
    }

    static string GerarCursoAleatorio()
    {
        string[] cursos = { "Engenharia", "Ciência da Computação", "Administração", "Medicina", "Direito" };
        Random random = new Random();
        return cursos[random.Next(cursos.Length)];
    }


    static void BubbleSort(int[] arr, out int comparacoes, out int movimentacoes)
    {
        int n = arr.Length;
        comparacoes = 0;
        movimentacoes = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                comparacoes++;

                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    movimentacoes += 3;
                }
            }
        }
    }
    static void BubbleSort<T>(T[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (Comparer<T>.Default.Compare(arr[j], arr[j + 1]) > 0)
                {
                    TrocarElementos(arr, j, j + 1);
                }
            }
        }
    }

    static void InsertionSort<T>(T[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; ++i)
        {
            T chave = arr[i];
            int j = i - 1;

            while (j >= 0 && Comparer<T>.Default.Compare(arr[j], chave) > 0)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = chave;
        }
    }

    static void SelectionSort<T>(T[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indiceMinimo = i;

            for (int j = i + 1; j < n; j++)
            {
                if (Comparer<T>.Default.Compare(arr[j], arr[indiceMinimo]) < 0)
                {
                    indiceMinimo = j;
                }
            }

            TrocarElementos(arr, indiceMinimo, i);
        }
    }

    static void TrocarElementos<T>(T[] arr, int i, int j)
    {
        T temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}


class Estudante
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string CursoMatriculado { get; set; }
    public int CoeficienteRendimento { get; set; }
    public int PeriodoAtual { get; set; }

    public override string ToString()
    {
        return $"Matrícula: {Matricula}, Nome: {Nome}, Curso: {CursoMatriculado}, CR: {CoeficienteRendimento}, Período: {PeriodoAtual}";
    }
}

