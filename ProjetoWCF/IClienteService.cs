using ProjetoWCF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClienteService" in both code and config file together.
    [ServiceContract]
    public interface IClienteService : IDisposable
    {
        [OperationContract]
        [ReferencePreservingDataContractFormat]
        List<Cliente> FindAll();

        [OperationContract]
        [ReferencePreservingDataContractFormat]
        Cliente Find(int id);

        [OperationContract]
        Cliente New(Cliente produto);

        [OperationContract]
        Cliente Update(Cliente produto);

        [OperationContract]
        Cliente Delete(int id);

        [OperationContract]
        Cliente Detete(Cliente produto);

    }
}
