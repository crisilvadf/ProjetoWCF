using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace ProjetoWCF
{
    public class ReferencePreservingDataContractFormat
        : Attribute, IOperationBehavior
    {
        #region IOperationBehavior Members

        public void AddBindingParameters(OperationDescription description,
            BindingParameterCollection parametes)
        {

        }

        public void ApplyClientBehavior(OperationDescription description,
            ClientOperation proxy)
        {
            IOperationBehavior innerBehavior =
                new ReferencePreservingDataContractSerializerOperationBehavior(description);
            innerBehavior.ApplyClientBehavior(description, proxy);
        }

        public void ApplyDispatchBehavior(OperationDescription description,
            DispatchOperation dispatch)
        {
            IOperationBehavior innerBehavior =
                new ReferencePreservingDataContractSerializerOperationBehavior(description);
            innerBehavior.ApplyDispatchBehavior(description, dispatch);
        }

        public void Validate(OperationDescription description)
        {

        }

        #endregion
    }
}