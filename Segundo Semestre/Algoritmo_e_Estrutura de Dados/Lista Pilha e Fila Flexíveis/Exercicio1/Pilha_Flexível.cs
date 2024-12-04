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

    public void inverter()
    {
        Pilha auxiliar1 = new Pilha();

        for (Celula i = topo; i != null; i = i.Prox)
     
        {
            auxiliar1.Inserir(i.Elemento);
        }

        Pilha auxiliar2 = new Pilha();

        for (Celula i = auxiliar1.topo; i != null; i = i.Prox)

        {
            auxiliar2.Inserir(i.Elemento);
        }


        for (Celula i = topo; i != null; i = topo.Prox)

        {
            Console.WriteLine(i.Elemento + " ");
            if (topo == null)
                throw new Exception("Erro!");
            int elemento = topo.Elemento;
            Celula tmp = topo;
            topo = topo.Prox;
            tmp.Prox = null;
            tmp = null;
        }

        for (Celula i = auxiliar2.topo; i != null; i = i.Prox)
        {
            Celula tmp = new Celula(i.Elemento);
            tmp.Prox = topo;
            topo = tmp;
            tmp = null;
           
        }

    }
}