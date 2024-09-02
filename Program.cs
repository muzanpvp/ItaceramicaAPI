using ItaceramicaAPI.Models;
using Newtonsoft.Json;
using System;

//Serializar json
List<Produto> produtos = new List<Produto>();

Produto produto = new Produto(1,"Cimento Voltoran","Construção",30.45M);
Produto produto2 = new Produto(2,"Massa corrida","Construção",32.30M);
Produto produto3 = new Produto(3,"Telha","Construção",78.53M);

produtos.Add(produto);
produtos.Add(produto2);
produtos.Add(produto3);

string serialized = JsonConvert.SerializeObject(produtos);

File.WriteAllText("assets/products/produtos.json",serialized);

List<Usuario> usuarios = new List<Usuario>();

Usuario usuario = new Usuario(1,"Layane Bispo dos Anjos", new DateTime(2003, 03, 29));
Usuario usuario2 = new Usuario(2,"Marcos Venício da Palma Dias", new DateTime(2002, 04, 16));
Usuario usuario3 = new Usuario(3,"Leticia Bispo dos Anjos", new DateTime(2017, 11, 11));

usuarios.Add(usuario);
usuarios.Add(usuario2);
usuarios.Add(usuario3);

string serialized2 = JsonConvert.SerializeObject(usuarios);

File.WriteAllText("assets/users/users.json",serialized2);

List<Compra> compras = new List<Compra>();

Compra compra = new Compra(1,produto,usuario,DateTime.Now);
Compra compra2 = new Compra(2,produto2,usuario2,DateTime.Now);
Compra compra3 = new Compra(3,produto3,usuario3,DateTime.Now);

compras.Add(compra);
compras.Add(compra2);
compras.Add(compra3);

string serialized3 = JsonConvert.SerializeObject(compras);

File.WriteAllText("assets/shopping/compras.json",serialized3);

//Deserializar json
string deserializarProdutos = File.ReadAllText("assets/products/produtos.json");

List<Produto> lerProduto = JsonConvert.DeserializeObject<List<Produto>>(deserializarProdutos);

foreach(Produto lerproduto in lerProduto){
    Console.WriteLine($"Id:{lerproduto.id}\n Nome:{lerproduto.nome} \n Categoria:{lerproduto.categoria} \n Valor:{lerproduto.valor} \n \n  ");
}

string deserializarUsuarios = File.ReadAllText("assets/users/users.json");

List<Usuario> lerUsuario = JsonConvert.DeserializeObject<List<Usuario>>(deserializarUsuarios);

foreach(Usuario lerusuario in lerUsuario){
    Console.WriteLine($"Id:{lerusuario.id} \n Nome completo:{lerusuario.nomeCompleto} \n Data de Nascimento:{lerusuario.dataNascimento} \n \n ");
}

string deserializarCompras = File.ReadAllText("assets/shopping/compras.json");

List<Compra> lerCompra = JsonConvert.DeserializeObject<List<Compra>>(deserializarCompras);

foreach(Compra lercompra in lerCompra){
    Console.WriteLine($"Id:{lercompra.id} \n Produto:{lercompra.produto.nome} \n Usuario:{lercompra.usuario.nomeCompleto} \n Data da compra:{lercompra.dataCompra.ToString("dd/MM/yyyy HH:mm:ss")} \n \n");
}
