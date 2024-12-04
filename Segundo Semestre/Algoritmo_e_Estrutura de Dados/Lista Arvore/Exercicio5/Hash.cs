using System;
class Hash
{
    public int[] tabela;
    public int m1, m2, m, reserva;
    const int NULO = -1;
    public Hash()
    {
        this.m1 = 13;
        this.m2 = 7;
        this.m = m1 + m2;
        this.tabela = new int[this.m];
        for (int i = 0; i < m1; i++)
        {
            tabela[i] = NULO;
        }
        reserva = 0;
    }
    public Hash(int m1, int m2)
    {
        this.m1 = m1;
        this.m2 = m2;
        this.m = m1 + m2;
        this.tabela = new int[this.m];
        for (int i = 0; i < m1; i++)
        {
            tabela[i] = NULO;
        }
        reserva = 0;
    }
    public int _Hash(int elemento)
    {
        return elemento % m;
    }
    public int _Rehash(int elemento)
    {
        return ++elemento % m;
    }
    public bool Inserir(int elemento)
    {
        bool resp = false;
        if (elemento != NULO)
        {
            int pos = _Hash(elemento);
            if (tabela[pos] == NULO)
            {
                tabela[pos] = elemento;
                resp = true;
            }
            else
            {
                pos = _Rehash(elemento);
                Console.WriteLine("Pos = " + pos);
                if (tabela[pos] == NULO)
                {
                    tabela[pos] = elemento;
                    resp = true;
                }
            }
        }
        return resp;
    }
    public bool Pesquisar(int elemento)
    {
        bool resp = false;
        int pos = _Hash(elemento);
        if (tabela[pos] == elemento)
        {
            resp = true;
        }
        else if (tabela[pos] != NULO)
        {
            pos = _Rehash(elemento);
            if (tabela[pos] == elemento)
            {
                resp = true;
            }
        }
        else if (tabela[pos] == NULO)
        {
            pos = _Rehash(elemento);
            if (tabela[pos] == elemento)
            {
                resp = true;
            }
        }
        return resp;
    }
    public bool Remover(int elemento)
    {
        bool removido = false;
        int pos = _Hash(elemento);

        if (tabela[pos] == elemento)
        {
            tabela[pos] = NULO;
            removido = true;
        }
        else if (tabela[pos] != NULO)
        {
            pos = _Rehash(elemento);
            if (tabela[pos] == elemento)
            {
                tabela[pos] = NULO;
                removido = true;
            }
        }

        return removido;
    }
    public void Imprimir()
    {
        int i = 0;
        for (i = 0; i < m1; i++)
        {
            if (tabela[i] != NULO)
            {
                Console.WriteLine("{0} - {1} ", i, tabela[i]);
            }
        }
        if (reserva > 0)
        {
            for (i = 0; i < reserva; i++)
            {
                Console.WriteLine("{0} - {1} ", (m1 + i), tabela[m1 + i]);
            }
        }
    }
}