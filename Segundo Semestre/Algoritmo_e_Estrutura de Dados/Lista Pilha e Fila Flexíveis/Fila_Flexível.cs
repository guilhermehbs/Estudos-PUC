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

class Fila {
    private Celula primeiro, ultimo;
    
    public Fila () {
        primeiro = new Celula();  
        ultimo = primeiro;
    }
    
    public void Inserir(int x) { 
        ultimo.Prox = new Celula(x);  
        ultimo = ultimo.Prox;
    }
    
    public int Remover(){
        if (primeiro == ultimo)
            throw new Exception("Erro!");  
        Celula tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;  
        tmp.Prox = null;
        tmp = null;  
        return elemento;
    }
    
    public void Mostrar() {
        Console.Write("[");
        for (Celula i = primeiro.Prox; i != null; i = i.Prox) 
        {     	
        	Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }


}


class Program {

    static void Main() {
        Console.WriteLine("==== FILA FLEXÍVEL ====");
        Fila fila = new Fila();
        int x1, x2, x3;
        fila.Inserir(1);
        fila.Inserir(3);
        fila.Inserir(5);
        fila.Inserir(7);
        fila.Inserir(9);
        //fila.inserir(2);
        fila.Mostrar();
        x1 = fila.Remover();
        x2 = fila.Remover();
        fila.Inserir(4);
        fila.Inserir(6);
        x3 = fila.Remover();
        fila.Inserir(8);
        fila.Mostrar();
        Console.Write(x1 + ", " + x2 + ", " + x3);
   }
}