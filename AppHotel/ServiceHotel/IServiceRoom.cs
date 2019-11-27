using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using ServiceHotel.util;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceRoom" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceRoom
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        List<Room> GetAll();

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        Confirm Create(Room room);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        Confirm Update(Room room);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        Confirm Delete(int idRoom);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        List<Room> Find(string type);
    }

    [DataContract]
    [Serializable]
    public class RoomBE
    {
        [DataMember]
        public string TypeRoom { get; set; }

        [DataMember]
        public string NumberRoom { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}
