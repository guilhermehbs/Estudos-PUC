using System;

class Pilha {

    private int[] array;
    private int topo;
    
    public Pilha (){
    
        Inicializar(5);
    }
    public Pilha (int tamanho){
        Inicializar(tamanho);
    }
    private void Inicializar(int tamanho){
        this.array = new int[tamanho];
        this.topo = 0;
    }
    
    
    public void push(int x) {
        if (topo >= array.Length)
            throw new Exception("Erro!");
        array[topo] = x;
        topo++;
    }
    
    
    public int pop() {
        if (topo == 0)
            throw new Exception("Erro!");
        topo = topo-1;
        return array[topo];
    }
    
    public void mostrar() {
        Console.Write("[ ");
        for (int i = 0; i < topo; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ]");
    }
    
}

class Program
{
    static void Main()
    {
        Console.WriteLine("==== PILHA LINEAR ====");
        Pilha pilha = new Pilha(6);
        int x1, x2, x3;
        pilha.push(1);
        pilha.push(7);
        pilha.push(9);
        pilha.mostrar();
        x1 = pilha.pop();
        x2 = pilha.pop();
        x3 = pilha.pop();
        Console.Write(x1 + ", " + x2 + ", " + x3);
    }
}