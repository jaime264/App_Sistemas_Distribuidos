using ServiceHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceRoom" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceRoom.svc o ServiceRoom.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceRoom : IServiceRoom
    {
        public Confirm Create(Room room)
        {
            Confirm confirm = new Confirm();
            try
            {
                HotelEntities hotel = new HotelEntities();
                hotel.Room.Add(room);
                hotel.SaveChanges();

                confirm.Status = "OK";
                confirm.Clase = "CreateRoom";

            }
            catch(Exception e)
            {
                confirm.Status = e.Message;
                confirm.Clase = "CreateRoom";
                //throw new Exception(e.Message);
            }
            return confirm;
        }

        public Confirm Delete(int idRoom)
        {
            Confirm confirm = new Confirm();
            try
            {
                HotelEntities hotel = new HotelEntities();
                var query = (from r in hotel.Room where r.id == idRoom select r).FirstOrDefault();
                hotel.Room.Remove(query);
                hotel.SaveChanges();

                confirm.Status = "OK";
                confirm.Clase = "DeleteRoom";

            }
            catch(Exception e)
            {
                confirm.Status = e.Message;
                confirm.Clase = "DeleteRoom";
                //throw new Exception(e.Message);
            }
            return confirm;
        }

        public List<Room> Find(string type)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();
                var data = (from r in hotel.Room where r.TypeRoom.Contains(type) select r).ToList();

                return data;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            

            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            try
            {
                HotelEntities hotel = new HotelEntities();
                var data = hotel.Room.ToList();
                return data;

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Room> ListRoom(int HotelID)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();

                var data = (from r in hotel.Room
                            join e in hotel.Reservation on r.id equals e.RoomId
                            where e.HotelId == HotelID
                            select r).ToList();

                var query = hotel.Room.ToList().Except(data).ToList();

                return query;

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Confirm Update(Room room)
        {
            Confirm confirm = new Confirm();
            try
            {
                HotelEntities hotel = new HotelEntities();
                var query = (from r in hotel.Room where r.id == room.id select r).FirstOrDefault();
                query.NumberRoom = room.NumberRoom;
                query.Price = room.Price;
                query.TypeRoom = room.TypeRoom;
                hotel.SaveChanges();

                confirm.Status = "OK";
                confirm.Clase = "UpdateRoom";

            }
            catch (Exception e)
            {
                confirm.Status = e.Message;
                confirm.Clase = "UpdateRoom";
                //throw new Exception(e.Message);
            }

            return confirm;
        }
    }
}
