using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddAsc_1()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(1);
            ord.Add(2);
            ord.Add(3);
            ord.Add(4);

            Assert.AreEqual(ord.head.value, 1);
            Assert.AreEqual(ord.head.next.value, 2);
            Assert.AreEqual(ord.head.next.next.value, 3);
            Assert.AreEqual(ord.head.next.next.next.value, 4);
            Assert.AreEqual(ord.head.next.next.next.next, null);
            Assert.AreEqual(ord.tail.value, 4);
            Assert.AreEqual(ord.tail.prev.value, 3);
            Assert.AreEqual(ord.tail.prev.prev.prev.prev, null);
        }


        [TestMethod]
        public void TestAddAsc_2()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(1);
            ord.Add(22);
            ord.Add(3);
            ord.Add(14);

            Assert.AreEqual(ord.tail.value, 22);
            Assert.AreEqual(ord.tail.prev.value, 14);
            Assert.AreEqual(ord.head.value, 1);
            Assert.AreEqual(ord.head.next.value, 3);
        }


        [TestMethod]
        public void TestAddAsc_3()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(4);
            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            Assert.AreEqual(ord.tail.value, 4);
            Assert.AreEqual(ord.tail.prev.value, 3);
            Assert.AreEqual(ord.head.value, 1);
            Assert.AreEqual(ord.head.next.value, 2);
        }


        [TestMethod]
        public void TestAddAsc_4()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(-1);
            ord.Add(0);
            ord.Add(-2);
            ord.Add(-3);

            Assert.AreEqual(ord.tail.value, 0);
            Assert.AreEqual(ord.tail.prev.value, -1);
            Assert.AreEqual(ord.head.value, -3);
            Assert.AreEqual(ord.head.next.value, -2);
        }


        [TestMethod]
        public void TestAddDes_3()
        {
            OrderedList<int> ord = new OrderedList<int>(false);

            ord.Add(4);
            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            Assert.AreEqual(ord.tail.value, 1);
            Assert.AreEqual(ord.tail.prev.value, 2);
            Assert.AreEqual(ord.head.value, 4);
            Assert.AreEqual(ord.head.next.value, 3);
        }


        [TestMethod]
        public void TestAddDes_4()
        {
            OrderedList<int> ord = new OrderedList<int>(false);

            ord.Add(-1);
            ord.Add(0);
            ord.Add(-2);
            ord.Add(-3);

            Assert.AreEqual(ord.tail.value, -3);
            Assert.AreEqual(ord.tail.prev.value, -2);
            Assert.AreEqual(ord.head.value, 0);
            Assert.AreEqual(ord.head.next.value, -1);
        }


        [TestMethod]
        public void TestAddDes_5()
        {
            OrderedList<int> ord = new OrderedList<int>(false);

            ord.Add(1);
            ord.Add(22);
            ord.Add(3);
            ord.Add(14);

            Assert.AreEqual(ord.head.value, 22);
            Assert.AreEqual(ord.head.next.value, 14);
            Assert.AreEqual(ord.tail.value, 1);
            Assert.AreEqual(ord.tail.prev.value, 3);
        }


        [TestMethod]
        public void TestAddDes_6()
        {
            OrderedList<int> ord = new OrderedList<int>(false);

            ord.Add(5);
            ord.Add(13);
            ord.Add(3);
            ord.Add(14);

            Assert.AreEqual(ord.tail.value, 3);
            Assert.AreEqual(ord.tail.prev.value, 5);
            Assert.AreEqual(ord.tail.prev.next.value, 3);
            Assert.AreEqual(ord.head.value, 14);
            Assert.AreEqual(ord.head.next.value, 13);
            Assert.AreEqual(ord.head.next.prev.value, 14);
        }
    }
}
