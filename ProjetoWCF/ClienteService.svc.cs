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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteService.svc or ClienteService.svc.cs at the Solution Explorer and start debugging.
    public class ClienteService : IClienteService
    {

        private readonly ConnectionContext _db;

        public ClienteService()
        {
            _db = new ConnectionContext();
        }

        public List<Cliente> FindAll()
        {
            _db.Configuration.ProxyCreationEnabled = false;

            List<Cliente> cliente = _db.Cliente.ToList();
            return cliente;
        }

        public Cliente Find(int id)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            Cliente cliente = _db.Cliente.Single(x => x.ClienteId.Equals(id));
            return cliente;
        }

        public Cliente New(Cliente cliente)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            _db.Cliente.Add(cliente);
            _db.SaveChanges();
            return cliente;
        }

        public Cliente Update(Cliente cliente)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            _db.Entry(cliente).State = System.Data.EntityState.Modified;
            _db.SaveChanges();
            return cliente;
        }

        public Cliente Delete(int id)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            Cliente cliente = _db.Set<Cliente>().Find(id);
            _db.Set<Cliente>().Remove(cliente);
            _db.SaveChanges();
            return cliente;
        }

        public Cliente Detete(Cliente cliente)
        {
            //Definindo a não trazer o proxy do banco para não levar para a outra aplicação.
            //O contexto do banco fica somente aqui.
            _db.Configuration.ProxyCreationEnabled = false;

            _db.Set<Cliente>().Remove(cliente);
            _db.SaveChanges();
            return cliente;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
