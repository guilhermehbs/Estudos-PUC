using System;

/*
class Celula {
	private int elemento; // Elemento inserido na celula.
	private Celula prox; // Aponta a celula prox.

	public Celula(int elemento) {
		this.elemento = elemento;
		this.prox = null;
	}

	public Celula(int elemento, Celula prox) {
		this.elemento = elemento;
		this.prox = prox;
	}
}

class Lista {
	public Celula primeiro; // Primeira celula: SEM elemento valido.
	public Celula ultimo; // Ultima celula: COM elemento valido.

	public Lista() {
		primeiro = new Celula(-1);
		ultimo = primeiro;
	}

	public void Mostrar() {
		Console.WriteLine("[ "); // Comeca a mostrar.
		for (Celula i = primeiro.prox; i != null; i = i.prox) {
			Console.Write(i.elemento + " ");
		}
		Console.WriteLine("] "); // Termina de mostrar.
	}

	public bool Pesquisar(int x) {
		bool retorno = false;
		for (Celula i = primeiro.prox; i != null; i = i.prox) {
         if(i.elemento == x){
            retorno = true;
            i = ultimo;
         }
		}
		return retorno;
	}

	public void InserirInicio(int elemento) {
		Celula tmp = new Celula(elemento);
        tmp.prox = primeiro.prox;
		primeiro.prox = tmp;
		if (primeiro == ultimo) {
			ultimo = tmp;
		}
      tmp = null;
	}

	public void InserirFim(int elemento) {
		Celula tmp = new Celula(elemento);
		ultimo.prox = tmp;
		ultimo = ultimo.prox;
        tmp = null;
	}

   public void InserirMeio(int x, int posicao) {
      Celula i;
      int cont;

		// Caminhar ate chegar na posicao anterior a insercao
      for(i = primeiro, cont = 0; (i.prox != ultimo && cont < posicao); i = i.prox, cont++);
		
		// Se indice for incorreto:
		if (posicao < 0 || posicao > cont + 1) {
			throw new Exception("Erro ao inserir (posicao " + posicao + "(cont = " + cont + ") invalida)!");

      } else if (posicao == cont + 1) {
         InserirFim(x);
		}else{
         Celula tmp = new Celula(x);
         tmp.prox = i.prox;
         i.prox = tmp;
         tmp = i = null;
      }
   }


	public int RemoverInicio() {
      int resp = -1;

		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover (vazia)!");
		}else{
         primeiro = primeiro.prox;
         resp = primeiro.elemento;
      }

		return resp;
	}

	public int RemoverFim() {
      int resp =  -1;
      Celula i = null;

		if (primeiro == ultimo) {
			throw new Exception("Erro ao remover (vazia)!");
		} else {

         resp = ultimo.elemento;

		   // Caminhar ate a penultima celula:
         for(i = primeiro; i.prox != ultimo; i = i.prox);

         ultimo = i;
         i = ultimo.prox = null;
      }

		return resp;
	}

	
	public int RemoverMeio(int posicao){
      Celula i;
      int resp = -1, cont;

		if (primeiro == ultimo){
			throw new Exception("Erro ao remover (vazia)!");
      }else{

		   // Caminhar ate chegar na posicao anterior a insercao
         for(i = primeiro, cont = 0; (i.prox != ultimo && cont < posicao); i = i.prox, cont++);

         // Se indice for incorreto:
		   if (posicao < 0 || posicao > cont + 1) {
            throw new Exception("Erro ao remover (posicao " + posicao + " invalida)!");

         } else if (posicao == cont + 1) {
            resp = removerFim();
         }else{
            Celula tmp = i.prox;
            resp = tmp.elemento;
            i.prox = tmp.prox;
            tmp.prox = null;
            i = tmp = null;
         }
      }

		return resp;
	}
}
*/

class Celula
{
    private int elemento;
    private Celula proximo;

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.proximo = null;
    }

    public Celula()
    {
        this.elemento = 0;
        this.proximo = null;
    }

    public Celula Prox
    {
        get { return proximo; }
        set { proximo = value; }
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

}

class Lista {
    private Celula primeiro, ultimo;
    
    public Lista () {
        primeiro = new Celula();  
        ultimo = primeiro;
    }
   
    public void InserirInicio(int x) {  
        Celula tmp = new Celula(x);  
        tmp.Prox = primeiro.Prox;  
        primeiro.Prox = tmp;
        if (primeiro == ultimo) {  
            ultimo = tmp;
        }
        tmp = null;
    }
    
    public void InserirFim(int x) { 
        ultimo.Prox = new Celula(x);  
        ultimo = ultimo.Prox;
    }
        
    public int RemoverInicio(){
        if (primeiro == ultimo)
            throw new Exception("Erro!");  
        Celula tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;  
        tmp.Prox = null;
        tmp = null;  
        return elemento;
    }
    
    public int RemoverFim() {
        if (primeiro == ultimo)
            throw new Exception("Erro!");  
        Celula i;
        for(i = primeiro; i.Prox != ultimo; i = i.Prox);  
        int elemento = ultimo.Elemento;  
        ultimo = i;
        i = ultimo.Prox = null;  
        return elemento;
    }
    
    public int Tamanho() {
        int tam = 0; 
        for(Celula i = primeiro; i != ultimo; i = i.Prox){
             tam++;
        }
        return tam;
    }

    
    public void Inserir(int x, int pos) {
        int tamanho = Tamanho();
        if (pos < 0 || pos > tamanho){	
            throw new Exception("Erro!");
        } 
        else if (pos == 0){	
            InserirInicio(x);
        } 
        else if (pos == tamanho){
            InserirFim(x);
        } 
        else {
            Celula i = primeiro;
            for(int j = 0; j < pos; j++, i = i.Prox);  
            Celula tmp = new Celula(x);  
            tmp.Prox = i.Prox;
            i.Prox = tmp;  
            tmp = i = null;
        } 
        
    }
    
    /*public int RemoverPosicao(int pos) {	

        int elemento, tamanho = Tamanho();
        if (primeiro == ultimo || pos < 0 || pos >= tamanho){ 
            throw new Exception("Erro!");
        } 
        else if (pos == 0) {
            elemento = RemoverInicio();
        } 
        else if (pos == tamanho - 1){
            elemento = RemoverFim();
        } 
        else {
            Celula i = primeiro;
            for(int j = 0; j < pos; j++, i = i.Prox);  
            Celula tmp = i.Prox;
            elemento = tmp.Elemento;	
            i.Prox = tmp.Prox;  
            tmp.Prox = null;	
            i = tmp = null;
        }
        return elemento;
    }*/
    
    
    public int RemoverPosicao(int posicao){
      Celula i;
      int resp = -1, cont, pos = Pesquisar(posicao);

		if (primeiro == ultimo){
			throw new Exception("Erro ao remover (vazia)!");
        }else{

		   // Caminhar ate chegar na posicao anterior a insercao
         for(i = primeiro, cont = 0; (i.Prox != ultimo && cont < pos); i = i.Prox, cont++);

         // Se indice for incorreto:
		   if (pos < 0 || pos > cont + 1) {
            throw new Exception("Erro ao remover (posicao " + pos + " invalida)!");

         } else if (posicao == cont + 1) {
            resp = RemoverFim();
         }else{
            Celula tmp = i.Prox;
            resp = tmp.Elemento;
            i.Prox = tmp.Prox;
            tmp.Prox = null;
            i = tmp = null;
         }
      }

		return resp;
	}
    
    
    public int Pesquisar(int x) {
		int retorno = -1, cont  = 0;
		for (Celula i = primeiro.Prox; i != null; i = i.Prox) {
         if(i.Elemento == x){
            retorno = cont;
            i = ultimo;
         }
         cont++;
		}
		return retorno;
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




class HashIndiretoLista {
   public Lista []tabela;
   public int tamanho;
   const int NULO = -1;

   public HashIndiretoLista() {
      this.tamanho = 13;
      tabela = new Lista[tamanho];
      for (int i = 0; i < tamanho; i++) {
         tabela[i] = new Lista();
      }
   }

   public HashIndiretoLista(int tamanho) {
      this.tamanho = tamanho;
      tabela = new Lista[tamanho];
      for (int i = 0; i < tamanho; i++) {
         tabela[i] = new Lista();
      }
   }

   public int Hash(int elemento) {
      return elemento % tamanho;
   }

   public int Pesquisar(int elemento) {
      int pos = Hash(elemento);
      return tabela[pos].Pesquisar(elemento);
   }

   public void InserirInicio(int elemento) {
      int pos = Hash(elemento);
      tabela[pos].InserirInicio(elemento);
   }

   public int Remover(int elemento) {
      int resp = NULO;
      if (Pesquisar(elemento) == -1) {
         throw new Exception("Erro ao remover!");
      } else {
         int pos = Hash(elemento);
         resp = tabela[pos].RemoverPosicao(elemento);
      }
      return resp;
   }
}


class Program{
    public static void Main(string []args){
        HashIndiretoLista h = new HashIndiretoLista();
        h.InserirInicio(10);
        h.InserirInicio(20);
        h.InserirInicio(30);
        h.InserirInicio(40);
        h.InserirInicio(50);
        h.InserirInicio(7);
        h.InserirInicio(36);
        
        //h.Imprimir();
        
        int r = h.Remover(20);
        if(r != -1){
            Console.WriteLine("Elemento removido com sucesso! ");
        }
        else{
            Console.WriteLine("Elemento não encontrado no HASH! ");
        }
        
        h.InserirInicio(35);
        
        
       
        while(true){
            Console.WriteLine("Entre com um elemento para verificar se ele está no Hash: ");
            int el = int.Parse(Console.ReadLine());
            int res = h.Pesquisar(el);
            if(res != -1){
                Console.WriteLine("Elemento se encontra no HASH!");
            }
            else{
                Console.WriteLine("Elemento não se encontra no HASH!");
            }
            Console.WriteLine("\nSe deseja sair, digite 0, senão digite 1: ");
            int v = int.Parse(Console.ReadLine());
            if(v == 0){
                break;
            }
        }
    }
}