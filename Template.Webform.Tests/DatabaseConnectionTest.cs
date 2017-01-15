using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Template.Webform.Tests
{
    [TestClass]
    public class DatabaseConnectionTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            Webform.Code.DatabaseConnection target = new Webform.Code.DatabaseConnection("TestDatabase");

            ConnectTest(target);
            DisconnectTest(target);
        }

        [TestMethod]
        public void ConnectTest(Webform.Code.DatabaseConnection target)
        {
            target.Connect();
            Assert.IsTrue((target.Connection.State & ConnectionState.Open) != 0);
        }


        [TestMethod]
        public void DisconnectTest(Webform.Code.DatabaseConnection target)
        {
            target.Disconnect();
            Assert.IsTrue((target.Connection.State & ConnectionState.Closed) != 0);
        }





    }
}
