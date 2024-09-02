using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ItaceramicaAPI.Models
{
    public class Compra
    {
     public Compra(uint _id,Produto _produto, Usuario _usuario,DateTime? _dataCompra){
        this.id=_id;
        this.produto=_produto;
        this.usuario=_usuario;
        this.dataCompra=_dataCompra ?? DateTime.Now;
     }   
     public uint id { get; set; }
     public Produto produto { get; set; }
     public Usuario usuario { get; set;}
     public DateTime dataCompra { get;}
    }
}