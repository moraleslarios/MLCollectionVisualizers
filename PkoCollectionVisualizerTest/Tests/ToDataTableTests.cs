using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLCollectionVisualizers2017;

namespace PkoCollectionVisualizerTest
{
    [TestClass]
    public class ToDataTableTests
    {
        //[TestMethod]
        //public void ToDataTable_GoodCollection_OK()
        //{
        //    ToDataTableActions act = new ToDataTableActions();



        //}


        [TestMethod]
        public void GetType_GoodCollection_OK()
        {
            IEnumerable<string> colec = new List<string>() { "Hola" };
            Type expect = "Hola".GetType();

            Type result = ToDataTableActions.GetTypeItems(colec);

            Assert.IsTrue(result == expect, "Ha fallado GetType_GoodCollection_OK, el tipo de la coleción no es el mismo ");
        }

        [TestMethod]
        public void GetType_GoodCollection_FAIL()
        {
            IEnumerable<string> colec = new List<string>() { "Hola" };
            Type expect = 1.GetType();

            Type result = ToDataTableActions.GetTypeItems(colec);

            Assert.IsFalse(result == expect, "Ha fallado GetType_GoodCollection_OK, el tipo de la coleción no es el mismo ");
        }


        [TestMethod]
        public void GetFirstItem_GoodCollection_OK()
        {
            IEnumerable<string> colec = new List<string>() { "Hola" };
            object expect = "Hola";

            object result = ToDataTableActions.GetFirstItem(colec);

            Assert.IsTrue(result == expect, "Ha fallado GetFirstItem_GoodCollection_OK, el tipo de la coleción no es el mismo ");
        }


        [TestMethod]
        public void GetFirstItem_GoodCollection_FAIL()
        {
            IEnumerable<string> colec = new List<string>() { "Hola" };
            object expect = 1.GetType();

            object result = ToDataTableActions.GetFirstItem(colec);

            Assert.IsFalse(result == expect, "Ha fallado GetFirstItem_GoodCollection_FAIL, el tipo de la coleción no es el mismo ");
        }



        [TestMethod]
        public void IsSimpleItem_GoodCollection_OK()
        {
            IEnumerable<object> colec = new List<object>() { "Hola", 10, 10.1m, DateTime.Today, new int?(1), DayOfWeek.Friday };
            bool expect = true;

            foreach (var obj in colec)
            {
                bool result = ToDataTableActions.IsSimpleItem(new List<object>(){ obj });

                Assert.IsTrue(result == expect, "Fallo al comprobar si es dato simple");
            }

            
        }


        [TestMethod]
        public void IsSimpleItem_GoodCollection_FAIL()
        {
            IEnumerable<object> colec = new List<object>() {new Viewer(new System.Data.DataTable()) };
            bool expect = true;

            foreach (var obj in colec)
            {
                bool result = ToDataTableActions.IsSimpleItem(new List<object>() { obj });

                Assert.IsFalse(result == expect, "Fallo al comprobar si es dato simple");
            }


        }


    }
}
