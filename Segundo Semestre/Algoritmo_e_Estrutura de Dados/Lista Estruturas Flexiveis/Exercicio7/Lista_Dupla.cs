using System;
using Exercicio7;

class CelulaDupla
{
    private Contato elemento;
    private CelulaDupla prox, ant;

    public CelulaDupla(Contato elemento)
    {
        this.elemento = elemento;
        this.prox = null;
        this.ant = null;
    }

    public CelulaDupla()
    {
        this.elemento = null;
        this.prox = null;
        this.ant = null;
    }

    public CelulaDupla Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public CelulaDupla Ant
    {
        get { return ant; }
        set { ant = value; }
    }

    public Contato Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

}

class ListaDupla
{
    private CelulaDupla primeiro, ultimo;
    public ListaDupla()
    {
        primeiro = new CelulaDupla();
        ultimo = primeiro;
    }

    public void InserirInicio(Contato x)
    {
        CelulaDupla tmp = new CelulaDupla(x);
        tmp.Ant = primeiro;
        tmp.Prox = primeiro.Prox;
        primeiro.Prox = tmp;
        if (primeiro == ultimo)
        {
            ultimo = tmp;
        }
        else
        {
            tmp.Prox.Ant = tmp;
        }
        tmp = null;
    }

    public void InserirFim(Contato x)
    {
        ultimo.Prox = new CelulaDupla(x);
        ultimo.Prox.Ant = ultimo;
        ultimo = ultimo.Prox;
    }

    public Contato RemoverInicio()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        CelulaDupla tmp = primeiro;
        primeiro = primeiro.Prox;
        Contato elemento = primeiro.Elemento;
        tmp.Prox = primeiro.Ant = null;
        tmp = null;
        return elemento;
    }

    public Contato RemoverFim()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");

        Contato elemento = ultimo.Elemento;
        ultimo = ultimo.Ant;
        ultimo.Prox.Ant = null;
        ultimo.Prox = null;
        return elemento;
    }

    public int Tamanho()
    {
        int tam = 0;
        for (CelulaDupla i = primeiro; i != ultimo; i = i.Prox)
        {
            tam++;
        }

        return tam;
    }


    public Contato Remover(int pos)
    {
        Contato elemento; 
        int tamanho = Tamanho();
        if (primeiro == ultimo)
        {
            throw new Exception("Erro!");
        }
        else if (pos < 0 || pos >= tamanho)
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
            CelulaDupla i = primeiro.Prox;
            for (int j = 0; j < pos; j++, i = i.Prox) ;
            i.Ant.Prox = i.Prox;
            i.Prox.Ant = i.Ant;
            elemento = i.Elemento;
            i.Prox = i.Ant = null;
            i = null;
        }
        return elemento;
    }


    public Contato Recuperar(int pos)
    {
        if (pos >= 0 && pos < Tamanho())
        {
            CelulaDupla celula = EncontrarCelula(pos);
            return celula.Elemento;
        }
        return null;
    }

    private CelulaDupla EncontrarCelula(int pos)
    {
        CelulaDupla celula = primeiro.Prox;
        for (int i = 0; i < pos; i++)
        {
            celula = celula.Prox;
        }
        return celula;
    }

    public void AlterarElemento(int pos, Contato novoContato)
    {
        if (pos >= 0 && pos < Tamanho())
        {
            CelulaDupla celula = EncontrarCelula(pos);
            celula.Elemento = novoContato;
        }
    }
}

