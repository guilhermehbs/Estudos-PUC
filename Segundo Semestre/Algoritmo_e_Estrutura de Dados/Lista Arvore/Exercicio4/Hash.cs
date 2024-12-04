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
        return elemento % m1;
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
            else if (reserva < m2)
            {
                Console.WriteLine("pos = {0} e elemento = {1}!", m1 + reserva, elemento);
                tabela[m1 + reserva] = elemento;
                reserva++;
                resp = true;
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
            Console.WriteLine("pos = " + pos);
        }
        else if (tabela[pos] != NULO)
        {
            for (int i = 0; i < reserva; i++)
            {
                if (tabela[m1 + i] == elemento)
                {
                    Console.WriteLine("pos = " + (m1 + i));
                    resp = true;
                    i = reserva;
                }
            }
        }
        return resp;
    }
    public bool Remover(int elemento)
    {
        int pos = _Hash(elemento);
        bool removido = false;

        if (tabela[pos] == elemento)
        {
            tabela[pos] = NULO;
            removido = true;
        }
        else if (tabela[pos] != NULO)
        {
            for(int i = 0; i < reserva; i++)
            {
                if (tabela[m1 + i] == elemento)
                {
                    tabela[m1 + i] = NULO;
                    removido = true;
                    break;
                }
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