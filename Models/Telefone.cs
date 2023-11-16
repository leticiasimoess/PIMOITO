using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMOITO.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Ddd { get; set; }
        public TipoDeTelefone Tipo { get; set; }
       
        public Telefone()
        {

        }

        public Telefone(int id, int numero, int ddd, TipoDeTelefone tipo)
        {
            Id = id;
            Numero = numero;
            Ddd = ddd;
            Tipo = tipo;
        }
    }
}
