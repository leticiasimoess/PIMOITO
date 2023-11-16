using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMOITO.Models
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();

        public Pessoa()
        {

        }
        public Pessoa(int id, string nome, long cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }
    }
}
