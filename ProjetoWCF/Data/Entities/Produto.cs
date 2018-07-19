using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWCF.Data.Entities
{
    public class Produto
    {

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Disponivel { get; set; }
        public Nullable<int> ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

    }
}