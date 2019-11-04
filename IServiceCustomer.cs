using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCustomer" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCustomer
    {
        [OperationContract]
        void DoWork();
    }

    [DataContract]
    [Serializable]
    public class CustomerBE
    {
        private int CustomerId;
        private string Name;
        private string SurName;
        private string DocumentType;
        private string DocumentNumber;

        public int CustomerId1 { get => CustomerId; set => CustomerId = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string SurName1 { get => SurName; set => SurName = value; }
        public string DocumentType1 { get => DocumentType; set => DocumentType = value; }
        public string DocumentNumber1 { get => DocumentNumber; set => DocumentNumber = value; }
    }
}
