using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace TG.Exam.Refactoring
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        Order LoadOrder(string orderId);
    }


    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public int OrderCustomerId { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }
    }
}
