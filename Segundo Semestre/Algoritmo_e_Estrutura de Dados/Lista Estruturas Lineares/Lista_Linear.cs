using System;

class Lista {
    static void Main(string[] args)
    {
        Lista  lista = new Lista();
        lista.inserirFim(3);
    }
    private int[] array;
    private int n;
    
    public Lista (){
    
        Inicializar(0);
    }
    public Lista (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new int[tamanho];
        this.n = 0;
    }
    
    public void inserirInicio(int x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > 0; i--){
            array[i] = array[i-1];
        }
        array[0] = x;
        n++;
    }
    
    public void inserirFim(int x) {
        if (n >= array.Length)
            throw new Exception("Erro!");
        array[n] = x;
        n++;
    }
    
    public void inserir(int x, int pos) {
        if (n >= array.Length || pos < 0 || pos > n)
            throw new Exception("Erro!");
        //levar elementos para o fim do array
        for (int i = n; i > pos; i--){
            array[i] = array[i-1];
        }
        array[pos] = x;
        n++;
    }
    
    public int removerInicio() {
        if (n == 0)
            throw new Exception("Erro!");
        int resp = array[0];
        n--;
        for (int i = 0; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public int removerFim() {
        if (n == 0)
            throw new Exception("Erro!");
        n = n-1;
        return array[n];
    }
    
    public int remover(int pos) {
        if (n == 0 || pos < 0 || pos >= n)
            throw new Exception("Erro!");
        int resp = array[pos];
        n--;
        for (int i = pos; i < n; i++){
            array[i] = array[i+1];
        }
        return resp;
    }
    
    public void mostrar (){
        Console.Write("[ ");
        for (int i = 0; i < n; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("==== LISTA LINEAR ====");
        Lista lista = new Lista(6);
        int x1, x2, x3;
        lista.inserirInicio(1);
        lista.inserirFim(7);
        lista.inserirFim(9);
        lista.inserirInicio(3);
        lista.inserir(8, 3);
        lista.inserir(4, 2);
        lista.mostrar();
        x1 = lista.removerInicio();
        x2 = lista.removerFim();
        x3 = lista.remover(2);
        Console.Write(x1 + ", " + x2 + ", " + x3);
        lista.mostrar();
    }
}
