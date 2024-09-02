using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItaceramicaAPI.Models
{
    public class Usuario
    {
        public Usuario(uint _id, string _nomeCompleto, DateTime _dataNascimento){
            this.id=_id;
            this.nomeCompleto=_nomeCompleto;
            this.dataNascimento=_dataNascimento;
        }

        public uint id { get; set; }
        public string nomeCompleto { get; set; }
        public DateTime dataNascimento { get; set;}
    }
}