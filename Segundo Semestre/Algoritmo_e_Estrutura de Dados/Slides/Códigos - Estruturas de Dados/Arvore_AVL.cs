using System;

class No {
	public int elemento; // Conteudo do no.
	public No esq, dir; // Filhos da esq e dir.
	public int nivel; // Numero de niveis abaixo do no

	
	public No(int elemento) {
		this.elemento = elemento;
		this.esq = null;
		this.dir = null;
		nivel =1;
	}

	
	public No(int elemento, No esq, No dir, int nivel) {
		this.elemento = elemento;
		this.esq = esq;
		this.dir = dir;
		this.nivel = nivel;
	}

	public void SetNivel() {
		this.nivel = 1 + Math.Max(GetNivel(esq), GetNivel(dir));
	}

	public static int GetNivel(No no) {
		return (no == null) ? 0 : no.nivel;
	}
}


class AVL {
	public No raiz; // Raiz da arvore.

	public AVL() {
		raiz = null;
	}

	
	public bool Pesquisar(int x) {
		return Pesquisar(x, raiz);
	}

	public bool Pesquisar(int x, No i) {
		bool resp;
		if (i == null) {
			resp = false;
		} else if (x == i.elemento) {
			resp = true;
		} else if (x < i.elemento) {
			resp = Pesquisar(x, i.esq);
		} else {
			resp = Pesquisar(x, i.dir);
		}
		return resp;
	}

	public void CaminharCentral() {
		Console.WriteLine("[ ");
		CaminharCentral(raiz);
		Console.WriteLine("]");
	}

	public void CaminharCentral(No i) {
		if (i != null) {
			CaminharCentral(i.esq); // Elementos da esquerda.
			Console.Write(i.elemento + " "); // Conteudo do no.
			CaminharCentral(i.dir); // Elementos da direita.
		}
	}

	
	public void CaminharPre() {
		Console.WriteLine("[ ");
		CaminharPre(raiz);
		Console.WriteLine("]");
	}

	public void CaminharPre(No i) {
		if (i != null) {
			Console.Write(i.elemento + "(fator " + (No.GetNivel(i.dir) - No.GetNivel(i.esq)) + ") "); // Conteudo do no.
			CaminharPre(i.esq); // Elementos da esquerda.
			CaminharPre(i.dir); // Elementos da direita.
		}
	}

	public void CaminharPos() {
		Console.WriteLine("[ ");
		CaminharPos(raiz);
		Console.WriteLine("]");
	}

	
	public void CaminharPos(No i) {
		if (i != null) {
			CaminharPos(i.esq); // Elementos da esquerda.
			CaminharPos(i.dir); // Elementos da direita.
			Console.Write(i.elemento + " "); // Conteudo do no.
		}
	}

	public void Inserir(int x){
		raiz = Inserir(x, raiz);
	}

	public No Inserir(int x, No i){
		if (i == null) {
			i = new No(x);
		} else if (x < i.elemento) {
			i.esq = Inserir(x, i.esq);
		} else if (x > i.elemento) {
			i.dir = Inserir(x, i.dir);
		} else {
			throw new Exception("Erro ao inserir!");
		}
		return Balancear(i);
	}

	
	public void Remover(int x) {
		raiz = Remover(x, raiz);
	}

	public No Remover(int x, No i){
		if (i == null) {
			throw new Exception("Erro ao remover!");
		} else if (x < i.elemento) {
			i.esq = Remover(x, i.esq);
		} else if (x > i.elemento) {
			i.dir = Remover(x, i.dir);
		// Sem no a direita.
		} else if (i.dir == null) {
			i = i.esq;
		// Sem no a esquerda.
		} else if (i.esq == null) {
			i = i.dir;
		// No a esquerda e no a direita.
		} else {
			i.esq = MaiorEsq(i, i.esq);
		}
		return Balancear(i);
	}

	public No MaiorEsq(No i, No j) {
		// Encontrou o maximo da subarvore esquerda.
		if (j.dir == null) {
			i.elemento = j.elemento; // Substitui i por j.
			j = j.esq; // Substitui j por j.ESQ.
		// Existe no a direita.
		} else {
			// Caminha para direita.
			j.dir = MaiorEsq(i, j.dir);
		}
		return Balancear(j);
	}

	public No Balancear(No no) {
		if (no != null) {
			int fator = No.GetNivel(no.dir) - No.GetNivel(no.esq);
			// Se balanceada
			if (Math.Abs(fator) <= 1) {
				no.SetNivel();
			// Se desbalanceada para a direita
			} else if (fator == 2) {
				int fatorFilhoDir = No.GetNivel(no.dir.dir) - No.GetNivel(no.dir.esq);
				// Se o filho a direita tambem estiver desbalanceado
				if (fatorFilhoDir == -1) {
					no.dir = RotacionarDir(no.dir);
				}
				no = RotacionarEsq(no);
			// Se desbalanceada para a esquerda
			} else if (fator == -2) {
				int fatorFilhoEsq = No.GetNivel(no.esq.dir) - No.GetNivel(no.esq.esq);
				// Se o filho a esquerda tambem estiver desbalanceado
				if (fatorFilhoEsq == 1) {
					no.esq = RotacionarEsq(no.esq);
				}
				no = RotacionarDir(no);
			} else {
				throw new Exception(
						"Erro no No(" + no.elemento + ") com fator de balanceamento (" + fator + ") invalido!");
			}
		}
		return no;
	}

	public No RotacionarDir(No no) {
		Console.WriteLine("Rotacionar DIR(" + no.elemento + ")");
		No noEsq = no.esq;
		No noEsqDir = noEsq.dir;

		noEsq.dir = no;
		no.esq = noEsqDir;
		no.SetNivel(); // Atualizar o nivel do no
		noEsq.SetNivel(); // Atualizar o nivel do noEsq

		return noEsq;
	}

	public No RotacionarEsq(No no) {
		Console.WriteLine("Rotacionar ESQ(" + no.elemento + ")");
		No noDir = no.dir;
		No noDirEsq = noDir.esq;

		noDir.esq = no;
		no.dir = noDirEsq;

		no.SetNivel(); // Atualizar o nivel do no
		noDir.SetNivel(); // Atualizar o nivel do noDir
		return noDir;
	}
}

class Program {
	public static void Main(String[] args) {
		try {
			AVL avl = new AVL();
			int []array = {4,35,10,13,3,30,15,12,7,40,20};
			//int []array = {1,2,3,4,5,6,7,8,9,10};
			for(int i = 0; i < array.Length; i++){
				Console.WriteLine("Inserindo -> " + array[i]);
				avl.Inserir(array[i]);
				//avl.CaminharPre();
			}
			avl.CaminharPre();
			avl.Remover(13);
			avl.CaminharPre();
		} catch (Exception erro) {
			Console.WriteLine(erro.Message);
		}
	}
}