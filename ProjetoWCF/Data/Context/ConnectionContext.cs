using ProjetoWCF.Data.Entities;
using ProjetoWCF.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ProjetoWCF.Data.Context
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext()
            : base("ProjectWCFEntities")
        {
            Database.SetInitializer<ConnectionContext>(null);
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
        }
    }
}