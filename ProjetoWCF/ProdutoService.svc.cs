using ProjetoWCF.Data.Context;
using ProjetoWCF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProdutoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProdutoService.svc or ProdutoService.svc.cs at the Solution Explorer and start debugging.
    public class ProdutoService : IProdutoService
    {

        private readonly ConnectionContext _db;

        public ProdutoService()
        {
            _db = new ConnectionContext();
        }

        public List<Produto> FindAll()
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            List<Produto> produto = _db.Produto.Include("Cliente").ToList();
            return produto;
        }

        public Produto Find(int id)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            Produto produto = _db.Produto.Single(x => x.ProdutoId.Equals(id));
            return produto;
        }

        public Produto New(Produto produto)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            _db.Produto.Add(produto);
            _db.SaveChanges();
            return produto;
        }

        public Produto Update(Produto produto)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            _db.Entry(produto).State = System.Data.EntityState.Modified;
            _db.SaveChanges();
            return produto;
        }

        public Produto Delete(int id)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            Produto produto = _db.Set<Produto>().Find(id);
            _db.Set<Produto>().Remove(produto);
            _db.SaveChanges();
            return produto;
        }

        public Produto Detete(Produto produto)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            _db.Set<Produto>().Remove(produto);
            _db.SaveChanges();
            return produto;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
