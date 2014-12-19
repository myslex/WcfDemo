using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemo.Service
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Contact Select(Guid id);

        [OperationContract]
        IEnumerable<Contact> All();

        [OperationContract]
        void Save(Contact contact);

        [OperationContract]
        void Remove(Contact contact);
    }

    [DataContract]
    public class Contact
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
