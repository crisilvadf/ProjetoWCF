using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWCF.Data.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            this.Produto = new HashSet<Produto>();
            DataCadastro = DateTime.Now;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<int> Ativo { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }

    }
}