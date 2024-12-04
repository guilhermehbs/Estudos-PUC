using System;

class Hash {
   public int [] tabela;
   public int m1, m2, m, reserva;
   const int NULO = -1;

   public Hash() {
      this.m1 = 13;
      this.m2 = 7;
      this.m = m1 + m2;
      this.tabela = new int[this.m];
      for (int i = 0; i < m1; i++) {
         tabela[i] = NULO;
      }
      reserva = 0;
   }

   public Hash(int m1, int m2) {
      this.m1 = m1;
      this.m2 = m2;
      this.m = m1 + m2;
      this.tabela = new int[this.m];
      for (int i = 0; i < m1; i++) {
         tabela[i] = NULO;
      }
      reserva = 0;
   }

   public int _Hash(int elemento) {
      return elemento % m1;
   }

   public bool Inserir(int elemento) {
      bool resp = false;
      if (elemento != NULO) {
         int pos = _Hash(elemento);
         if (tabela[pos] == NULO) {
            tabela[pos] = elemento;
            resp = true;
         } else if (reserva < m2) {
            Console.WriteLine("pos = {0} e elemento = {1}!", m1+reserva, elemento);
            tabela[m1 + reserva] = elemento;
            reserva++;
            resp = true;
         }
      }
      return resp;
   }

   public bool Pesquisar(int elemento) {
      bool resp = false;
      int pos = _Hash(elemento);
      if (tabela[pos] == elemento) {
         resp = true;
         Console.WriteLine("pos = " + pos);
      } else if (tabela[pos] != NULO) {
         for (int i = 0; i < reserva; i++) {
            if (tabela[m1 + i] == elemento) {
               Console.WriteLine("pos = " + (m1 + i));
               resp = true;
               i = reserva;
            }
         }
      }
      return resp;
   }


   public bool Remover(int elemento) {
      
   }
   
   public void Imprimir(){
       int i = 0;
       for(i = 0; i < m1; i++){
           if(tabela[i] != NULO){
               Console.WriteLine("{0} - {1} ", i, tabela[i]);
           }
       }
       if(reserva > 0){
           for(i = 0; i < reserva; i++){
               Console.WriteLine("{0} - {1} ", (m1+i), tabela[m1+i]);
           }
       }
   }
}

class Program{
    public static void Main(string []args){
        Hash h = new Hash();
        h.Inserir(10);
        h.Inserir(20);
        h.Inserir(30);
        h.Inserir(40);
        h.Inserir(50);
        h.Inserir(7);
        if(h.Inserir(36)){
            Console.WriteLine("Inserção realizada no HASH! ");
        }
        else{
            Console.WriteLine("Não há como inserir esse elemento no HASH! ");
        }
        //h.Imprimir();
        
        if(h.Remover(20)){
            Console.WriteLine("Elemento removido com sucesso! ");   
        }
        else{
            Console.WriteLine("Elemento não presente no HASH "); 
        }
        
        h.Inserir(17);
        h.Imprimir();
        
        while(true){
            Console.WriteLine("Entre com um elemento para verificar se ele está no Hash: ");
            int el = int.Parse(Console.ReadLine());
            if(h.Pesquisar(el)){
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
