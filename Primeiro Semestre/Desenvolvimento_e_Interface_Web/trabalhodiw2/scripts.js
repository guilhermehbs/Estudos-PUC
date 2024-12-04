// Função para carregar os produtos da API
function carregarProdutos() {


  // Fazer uma requisição GET para a API de produtos
  fetch('https://diwserver.vps.webdock.cloud/products')
    .then(res => res.json()) // Converter a resposta para JSON
    .then(data => {

      // Obter a lista de produtos da resposta
      const produtos = data.products.slice(0, 20);



      // Obter o container dos cards de produtos
      const cardContainer = document.getElementById("cardContainer");
      cardContainer.innerHTML = ""; // Limpar o conteúdo existente



      // Iterar sobre os produtos e criar os cards
      for (let i = 0; i < produtos.length; i++) {
        const produto = produtos[i];



      // Criar o elemento do card
        const card = document.createElement("div");
        card.classList.add("card", "col-md-4", "mb-3");



      // Criar a imagem do produto
        const image = document.createElement("img");
        image.src = produto.image;
        image.classList.add("card-img-top", "h-60", "w-50", "mx-auto");
        card.appendChild(image);



        // Adicionar evento de clique na imagem para redirecionar para a página de detalhes
        image.addEventListener("click", () => {
          const productId = produto.id;
          window.location.href = `detalhes.html?id=${productId}`;
        });



        // Criar o corpo do card
        const cardBody = document.createElement("div");
        cardBody.classList.add("card-body");
        card.appendChild(cardBody);



        // Adicionar o título do produto
        const title = document.createElement("h5");
        title.classList.add("card-title");
        title.textContent = produto.title;
        cardBody.appendChild(title);



        // Adicionar a descrição do produto
        const description = document.createElement("div");
        description.classList.add("card-text");
        description.innerHTML = produto.description;
        



        // Adicionar o preço do produto
        const price = document.createElement("p");
        price.classList.add("card-text");
        price.textContent = `Price: $${produto.price}`;
        cardBody.appendChild(price);

        const category = document.createElement("h5");
        category.classList.add("card-text");
        category.textContent = `Categoria: ${produto.category}`;
        cardBody.appendChild(category);



        // Adicionar o card ao container
        cardContainer.appendChild(card);
      }
    });
}


      // Chamar a função para carregar os produtos ao carregar a página
      document.addEventListener("DOMContentLoaded", carregarProdutos);


      // Capturar o elemento select do filtro
       const categoriaSelect = document.getElementById("Categorias");



      // Adicionar um evento de mudança ao select
      categoriaSelect.addEventListener("change", filtrarProdutosPorCategoria);



      // Função para filtrar os produtos por categoria
       function filtrarProdutosPorCategoria() {


      // Obter o valor selecionado no filtro
       const categoriaSelecionada = categoriaSelect.value;


      // Fazer uma requisição à API para obter todos os produtos
       fetch("https://diwserver.vps.webdock.cloud/products")
       .then(response => response.json())
       .then(produtos => {
           
      // Filtrar os produtos com base na categoria selecionada
       const produtosFiltrados = produtos.filter(produto => produto.category === categoriaSelecionada);


      // Chamar uma função para exibir os produtos filtrados
       exibirProdutosFiltrados(produtosFiltrados);
    });




      // Função para exibir os produtos filtrados
      function exibirProdutosFiltrados(produtos) {

      // Limpar o contêiner dos cards
      const cardContainer = document.getElementById("cardContainer");
       cardContainer.innerHTML = "";


      // Loop pelos produtos filtrados e criar os cards
       produtos.forEach(produto => {
       const card = document.createElement("div");
       card.classList.add("card");


      // Adicionar o código HTML do card com as informações do produto
       card.innerHTML = `
       <img src="${produto.image}" class="card-img-top" alt="Imagem do produto">
       <div class="card-body">
        <h5 class="card-title">${produto.title}</h5>
        <p class="card-text">${produto.description}</p>
        <p class="card-text">Price: $${produto.price}</p>
        <p class="card-text">Category: ${produto.category}</p>
        <p class="card-text">Rating: ${produto.rating.rate}</p>
      </div>
    `;




      // Adicionar o card ao contêiner
       cardContainer.appendChild(card);
  });
}
}

 exibirProdutosFiltrados(produtos);





 function filtroRapido() {
  var categoria = document.getElementById("categoriaSelect").value;


  if (categoria == "Apparel - Topwear") {
  var link = `https://diwserver.vps.webdock.cloud/products/category/${categoria}`;
  } else if (categoria == "Footwear - Shoes") {
  var link = `https://diwserver.vps.webdock.cloud/products/category/${categoria}`;
  } else if (categoria == "Apparel - Apparel Set") {
  var link = `https://diwserver.vps.webdock.cloud/products/category/${categoria}`;
  }



  fetch(link)
    .then(res => res.json())
    .then(data => {
    exibirprodutosfiltrados(data);
    });
  }
