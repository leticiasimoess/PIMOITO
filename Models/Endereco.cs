using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMOITO.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; } = new List<Pessoa>();

        public Endereco()
        {

        }

        public Endereco(int id, string logradouro, int numero, int cep, string bairro, string cidade, string estado)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public override string ToString()
        {
            return Logradouro +
                ", " + Numero +
                " - " + Bairro +
                ", " + Cidade +
                " - " + Estado +
                ", " + Cep;
        }
    }
}

