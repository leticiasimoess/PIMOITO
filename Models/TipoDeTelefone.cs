using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMOITO.Models
{
    public class TipoDeTelefone
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();

        public TipoDeTelefone()
        {

        }

        public TipoDeTelefone(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }
}
