using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BroadcastorService
{
    [ServiceContract(CallbackContract = typeof(IBroadcastorCallBack))]
    public interface IBroadcastorService
    {
        [OperationContract(IsOneWay = true)]
        void RegisterClient(string clientName);

        [OperationContract(IsOneWay = true)]
        void NotifyServer(EventDataType eventData);
    }

    [DataContract()]
    public class EventDataType
    {
        [DataMember]
        public string ClientName { get; set; }

        [DataMember]
        public string EventMessage { get; set; }
    }

    public interface IBroadcastorCallBack
    {
        [OperationContract(IsOneWay = true)]
        void BroadcastToClient(EventDataType eventData);
    }
}
