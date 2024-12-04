﻿using System;

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

class Lista
{
    private Celula primeiro, ultimo;

    public Lista()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public void InserirInicio(int x)
    {
        Celula tmp = new Celula(x);
        tmp.Prox = primeiro.Prox;
        primeiro.Prox = tmp;
        if (primeiro == ultimo)
        {
            ultimo = tmp;
        }
        tmp = null;
    }

    public void InserirFim(int x)
    {
        ultimo.Prox = new Celula(x);
        ultimo = ultimo.Prox;
    }

    public int RemoverInicio()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        Celula tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;
        tmp.Prox = null;
        tmp = null;
        return elemento;
    }

    public int RemoverFim()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        Celula i;
        for (i = primeiro; i.Prox != ultimo; i = i.Prox) ;
        int elemento = ultimo.Elemento;
        ultimo = i;
        i = ultimo.Prox = null;
        return elemento;
    }

    public int Tamanho()
    {
        int tam = 0;
        for (Celula i = primeiro; i != ultimo; i = i.Prox)
        {
            tam++;
        }
        return tam;
    }


    public void Inserir(int x, int pos)
    {
        int tamanho = Tamanho();
        if (pos < 0 || pos > tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            InserirInicio(x);
        }
        else if (pos == tamanho)
        {
            InserirFim(x);
        }
        else
        {
            Celula i = primeiro;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            Celula tmp = new Celula(x);
            tmp.Prox = i.Prox;
            i.Prox = tmp;
            tmp = i = null;
        }

    }

    public int Remover(int pos)
    {
        int elemento, tamanho = Tamanho();
        if (primeiro == ultimo || pos < 0 || pos >= tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            elemento = RemoverInicio();
        }
        else if (pos == tamanho - 1)
        {
            elemento = RemoverFim();
        }
        else
        {
            Celula i = primeiro;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            Celula tmp = i.Prox;
            elemento = tmp.Elemento;
            i.Prox = tmp.Prox;
            tmp.Prox = null;
            i = tmp = null;
        }
        return elemento;
    }


    public void Mostrar()
    {
        Console.Write("[");
        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }
        Console.WriteLine("]");
    }

    public void UnirListas(Lista segundaLista)
    {
        for (Celula i = segundaLista.primeiro.Prox; i != null; i = i.Prox)
        {
            InserirFim(i.Elemento);
        }

    }

    public int tamanhoLista()
    {
        return tamanhoRecursivo(primeiro.Prox);
    }

    private int tamanhoRecursivo(Celula celula)
    {
        if (celula == null)
        {
            return 0;
        }
        return 1 + tamanhoRecursivo(celula.Prox);
    }
}