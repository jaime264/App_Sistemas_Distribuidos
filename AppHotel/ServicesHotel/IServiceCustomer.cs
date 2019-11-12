using ServicesHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicesHotel
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
        void DeleteCustomer(int customerId);
    }

    [DataContract]
    [Serializable]
    public class CustomerBE
    {
        private int customerId;
        private string name;
        private string surName;
        private string documentType;
        private int documentNumber;

        [DataMember]
        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }
        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        [DataMember]
        public string SurName
        {
            get
            {
                return surName;
            }

            set
            {
                surName = value;
            }
        }
        [DataMember]
        public string DocumentType
        {
            get
            {
                return documentType;
            }

            set
            {
                documentType = value;
            }
        }
        [DataMember]
        public int DocumentNumber
        {
            get
            {
                return documentNumber;
            }

            set
            {
                documentNumber = value;
            }
        }
    }
}
