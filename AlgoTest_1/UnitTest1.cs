using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddIntegerAsc_1()
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
        public void TestAddIntegerAsc_2()
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
        public void TestAddIntegerAsc_3()
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
        public void TestAddIntegerAsc_4()
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
        public void TestAddIntegerDes_3()
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
        public void TestAddIntegerDes_4()
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
        public void TestAddIntegerDes_5()
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
        public void TestAddIntegerDes_6()
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


        [TestMethod]
        public void TestAddStringAsc_1()
        {
            OrderedList<string> ord = new OrderedList<string>(true);

            ord.Add("Ace");
            ord.Add("Button");
            ord.Add("Close");

            Assert.AreEqual("Ace", ord.head.value);
            Assert.AreEqual("Button", ord.head.next.value);
            Assert.AreEqual("Close", ord.head.next.next.value);
        }


        [TestMethod]
        public void TestAddStringAsc_2()
        {
            OrderedList<string> ord = new OrderedList<string>(true);

            ord.Add("Aces");
            ord.Add("Ace");
            ord.Add("Crow");
            ord.Add("Acer");

            Assert.AreEqual("Ace", ord.head.value);
            Assert.AreEqual("Acer", ord.head.next.value);
            Assert.AreEqual("Aces", ord.head.next.next.value);
            Assert.AreEqual("Crow", ord.head.next.next.next.value);
        }


        [TestMethod]
        public void TestAddStringAsc_3()
        {
            OrderedList<string> ord = new OrderedList<string>(true);

            ord.Add("AxeX");
            ord.Add("AxeY");
            ord.Add("Axe");
            ord.Add("Axe1");
            ord.Add("A");
            ord.Add("1Axe");

            Assert.AreEqual("1Axe", ord.head.value);
            Assert.AreEqual("A", ord.head.next.value);
            Assert.AreEqual("Axe", ord.head.next.next.value);
            Assert.AreEqual("Axe1", ord.head.next.next.next.value);
            Assert.AreEqual("AxeX", ord.head.next.next.next.next.value);
            Assert.AreEqual("AxeY", ord.head.next.next.next.next.next.value);
        }


        [TestMethod]
        public void TestAddStringAsc_4()
        {
            OrderedList<string> ord = new OrderedList<string>(true);

            ord.Add(" ");
            ord.Add("1");
            ord.Add("C");

            Assert.AreEqual(" ", ord.head.value);
            Assert.AreEqual("1", ord.head.next.value);
            Assert.AreEqual("C", ord.head.next.next.value);
        }


        [TestMethod]
        public void TestAddStringAsc_5()
        {
            OrderedList<string> ord = new OrderedList<string>(true);

            ord.Add("");
            ord.Add("1");
            ord.Add("C");

            Assert.AreEqual("", ord.head.value);
            Assert.AreEqual("1", ord.head.next.value);
            Assert.AreEqual("C", ord.head.next.next.value);
        }


        [TestMethod]
        public void TestAddStringAsc_6()
        {
            OrderedList<string> ord = new OrderedList<string>(true);
            
            ord.Add("");
            ord.Add("");
            Assert.AreEqual("", ord.head.value);
            Assert.AreEqual("", ord.head.next.value);
            Assert.AreEqual("", ord.tail.value);
            Assert.AreEqual("", ord.tail.prev.value);

            ord.Add(" ");
            Assert.AreEqual(" ", ord.head.next.next.value);
            Assert.AreEqual("", ord.tail.prev.value);

            Assert.AreEqual(3, ord.Count());
        }


        [TestMethod]
        public void TestAddStringAsc_7()
        {
            OrderedList<string> ord = new OrderedList<string>(true);

            ord.Add("Car");
            ord.Add("Point");
            ord.Add("Car");

            Assert.AreEqual("Car", ord.head.value);
            Assert.AreEqual("Car", ord.head.next.value);
            Assert.AreEqual("Point", ord.head.next.next.value);
        }


        [TestMethod]
        public void TestAddStringDes_1()
        {
            OrderedList<string> ord = new OrderedList<string>(false);

            ord.Add("Ace");
            ord.Add("Button");
            ord.Add("Close");

            Assert.AreEqual("Close", ord.head.value);
            Assert.AreEqual("Button", ord.head.next.value);
            Assert.AreEqual("Ace", ord.head.next.next.value);
        }


        [TestMethod]
        public void TestAddStringDes_2()
        {
            OrderedList<string> ord = new OrderedList<string>(false);

            ord.Add("Aces");
            ord.Add("Ace");
            ord.Add("Crow");
            ord.Add("Acer");

            Assert.AreEqual("Crow", ord.head.value);
            Assert.AreEqual("Aces", ord.head.next.value);
            Assert.AreEqual("Acer", ord.head.next.next.value);
            Assert.AreEqual("Ace", ord.head.next.next.next.value);
        }


        [TestMethod]
        public void TestAddStringDes_3()
        {
            OrderedList<string> ord = new OrderedList<string>(false);

            ord.Add("AxeX");
            ord.Add("AxeY");
            ord.Add("Axe");
            ord.Add("Axe1");
            ord.Add("A");
            ord.Add("1Axe");

            Assert.AreEqual("AxeY", ord.head.value);
            Assert.AreEqual("AxeX", ord.head.next.value);
            Assert.AreEqual("Axe1", ord.head.next.next.value);
            Assert.AreEqual("Axe", ord.head.next.next.next.value);
            Assert.AreEqual("A", ord.head.next.next.next.next.value);
            Assert.AreEqual("1Axe", ord.head.next.next.next.next.next.value);
        }


        [TestMethod]
        public void TestDeleteIntegerAsc_1()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(4);
            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            ord.Delete(2);

            Assert.AreEqual(4, ord.tail.value);
            Assert.AreEqual(3, ord.tail.prev.value);
            Assert.AreEqual(1, ord.tail.prev.prev.value);
            Assert.AreEqual(null, ord.tail.prev.prev.prev);

            Assert.AreEqual(1, ord.head.value);
            Assert.AreEqual(3, ord.head.next.value);
            Assert.AreEqual(4, ord.head.next.next.value);
            Assert.AreEqual(null, ord.head.next.next.next);
        }


        [TestMethod]
        public void TestDeleteIntegerAsc_2()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(4);
            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            ord.Delete(1);

            Assert.AreEqual(4, ord.tail.value);
            Assert.AreEqual(3, ord.tail.prev.value);
            Assert.AreEqual(2, ord.tail.prev.prev.value);
            Assert.AreEqual(null, ord.tail.prev.prev.prev);

            Assert.AreEqual(null, ord.head.next.prev.prev);
            Assert.AreEqual(2, ord.head.value);
            Assert.AreEqual(3, ord.head.next.value);
            Assert.AreEqual(4, ord.head.next.next.value);
        }


        [TestMethod]
        public void TestDeleteIntegerAsc_3()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(2);
            ord.Add(1);

            ord.Delete(1);

            Assert.AreEqual(2, ord.tail.value);
            Assert.AreEqual(null, ord.tail.prev);

            Assert.AreEqual(2, ord.head.value);
            Assert.AreEqual(null, ord.head.next);

            Assert.AreEqual(ord.head, ord.tail);
        }


        [TestMethod]
        public void TestDeleteIntegerAsc_4()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            ord.Delete(1);
            ord.Delete(2);
            ord.Delete(3);

            Assert.AreEqual(null, ord.tail);
            Assert.AreEqual(null, ord.tail);

            Node<int> node = ord.Find(1);

            Assert.AreEqual(null, node);
        }


        [TestMethod]
        public void TestDeleteIntegerAsc_5()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            ord.Delete(1);
            ord.Delete(2);
            ord.Delete(3);
            ord.Delete(4);

            Assert.AreEqual(null, ord.tail);
            Assert.AreEqual(null, ord.tail);
        }


        [TestMethod]
        public void TestCountAsc_1()
        {
            OrderedList<int> ord = new OrderedList<int>(true);

            ord.Add(3);
            ord.Add(2);
            ord.Add(1);

            Assert.AreEqual(3, ord.Count());

            ord.Delete(1);

            Assert.AreEqual(2, ord.Count());

            ord.Delete(2);
            ord.Delete(3);

            Assert.AreEqual(0, ord.Count());

            ord.Delete(1);

            Assert.AreEqual(0, ord.Count());
        }
    }
}
