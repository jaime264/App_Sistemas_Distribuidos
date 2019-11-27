using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Script.Serialization;
using System.Net;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using ServicesTestHotel.util;

namespace ServicesTestHotel
{
    /// <summary>
    /// Descripción resumida de UnitTestRoom
    /// </summary>
    [TestClass]
    public class UnitTestRoom
    {

        [TestMethod]
        public void TestMethodGetAll()
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/GetAll");

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = 0;
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var model = JsonConvert.DeserializeObject<List<Room>>(responseString);
            var count = model.Count;

            Assert.AreEqual(9, count);
        }

        [TestMethod]
        public void TestMethodCreate()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Room room = new Room()
            {
                TypeRoom = "Queen",
                NumberRoom = "17",
                Price = 150
            };
            var postData = js.Serialize(room);
            var data = Encoding.UTF8.GetBytes(postData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/Create");

            request.Method = "POST";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";

            var dataStream = request.GetRequestStream();
            dataStream.Write(data, 0, data.Length);
            //dataStream.Close();

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var model = JsonConvert.DeserializeObject<Confirm>(responseString);

            Assert.AreEqual("OK", model.Status);
        }

        [TestMethod]
        public void TestMethodUpdate()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            Room room = new Room()
            {
                id = 1,
                TypeRoom = "Solo",
                NumberRoom = "22",
                Price = 255
            };
            var postData = js.Serialize(room);
            var data = Encoding.UTF8.GetBytes(postData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/Create");

            request.Method = "POST";
            request.ContentLength = data.Length;
            request.ContentType = "application/json";

            var dataStream = request.GetRequestStream();
            dataStream.Write(data, 0, data.Length);
            //dataStream.Close();

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var model = JsonConvert.DeserializeObject<Confirm>(responseString);

            Assert.AreEqual("OK", model.Status);
        }

        [TestMethod]
        public void TestMethodDelete()
        {
            String value = "?idRoom=16";
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/Delete"+value);
            request.Method = "GET";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var model = JsonConvert.DeserializeObject<Confirm>(responseString);
            

            Assert.AreEqual("OK", model.Status);
        }

        [TestMethod]
        public void TestMethodDeleteError()
        {
            String value = "?idRoom=3";
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/Delete" + value);
            request.Method = "GET";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var model = JsonConvert.DeserializeObject<Confirm>(responseString);

            Assert.AreEqual(true, model.Status.Contains("error"));

        }

        [TestMethod]
        public void TestMethodFind()
        {
            String value = "?type=solo";
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/Find"+value);

            request.Method = "GET";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var model = JsonConvert.DeserializeObject<List<Room>>(responseString);
            var count = model.Count;

            Assert.AreEqual(7, count);
        }
    }
}
