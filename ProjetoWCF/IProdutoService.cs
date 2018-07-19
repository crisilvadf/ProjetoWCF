using ProjetoWCF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Xml;

namespace ProjetoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProdutoService" in both code and config file together.
    [ServiceContract]
    public interface IProdutoService : IDisposable
    {
        [OperationContract]
        [ReferencePreservingDataContractFormat]
        List<Produto> FindAll();

        [OperationContract]
        [ReferencePreservingDataContractFormat]
        Produto Find(int id);

        [OperationContract]
        Produto New(Produto produto);

        [OperationContract]
        Produto Update(Produto produto);

        [OperationContract]
        Produto Delete(int id); 

        [OperationContract]
        Produto Detete(Produto produto);
    }
}
