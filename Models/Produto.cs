using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItaceramicaAPI.Models
{
    public class Produto
    {
       public Produto(uint _id, string _nome, string _categoria, decimal _valor){
        this.id=_id;
        this.nome=_nome;
        this.categoria=_categoria;
        this.valor=_valor;
       } 
    
    public uint id { get; set; }
    public string nome { get; set;}
    public string categoria { get; set;}
    public decimal valor { get; set;}
    }
}