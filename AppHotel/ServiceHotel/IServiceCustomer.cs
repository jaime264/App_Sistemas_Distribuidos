using ServiceHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCustomer" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCustomer
    {
        [OperationContract]
        List<Customer> ListCustomer();

        [OperationContract]
        Confirm CreateCustomer(CustomerBE customerBE);

        [OperationContract]
        Confirm UpdateCustomer(Customer customer);

        [OperationContract]
        void DeleteCustomer(int customerId);
    }

    [DataContract]
    [Serializable]
    public class CustomerBE
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String SurName { get; set; }

        [DataMember]
        public String DocumentType { get; set; }

        [DataMember]
        public int DocumentNumber { get; set; }

        [DataMember]
        public int Phone { get; set; }

    }
}
