using System;

class Celula
{
    private int elemento;
    private Celula prox;

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

}

class Pilha {
    private Celula topo;
    public Pilha () {
        topo = null;
    }
    
    public void Inserir(int x) {  
        Celula tmp = new Celula(x);  
        tmp.Prox = topo;
        topo = tmp;  
        tmp = null;
    }
    
    public int Remover()  {
        if (topo == null)
            throw new Exception("Erro!");  
        int elemento = topo.Elemento;  
        Celula tmp = topo;
        topo = topo.Prox;  
        tmp.Prox = null;  
        tmp = null;  
        return elemento;
    }
    
    public void Mostrar() {  
        Console.Write("[ ");
        for (Celula i = topo; i != null; i = i.Prox){
             Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }

}

class Program {

    static void Main() {
        Console.WriteLine("==== PILHA FLEXÍVEL ====");
        Pilha pilha = new Pilha();
        int x1, x2, x3;
        pilha.Inserir(1);
        pilha.Inserir(7);
        pilha.Inserir(9);
        pilha.Mostrar();
        x1 = pilha.Remover();
        x2 = pilha.Remover();
        x3 = pilha.Remover();
        Console.Write(x1 + ", " + x2 + ", " + x3);
   }
}