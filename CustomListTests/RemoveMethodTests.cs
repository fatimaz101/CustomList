using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CustomListTests
{
    [TestClass()]
    public class RemoveMethodTests
    {
        [TestMethod()]
        public void Remove_TakeAwayOneItem_CountDecreasesByOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myBiggerList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);//trying with initial array space

            int listCount = myList.Count - 1;

            myList.Remove(1);
            

            myBiggerList.Add(1);
            myBiggerList.Add(2);
            myBiggerList.Add(3);
            myBiggerList.Add(4);
            myBiggerList.Add(5);//trying with bigger array space

            int biggerListCount = myBiggerList.Count - 1;

            myBiggerList.Remove(1);



            //Assert
            Assert.AreEqual(listCount,myList.Count); //test intial
            Assert.AreEqual(biggerListCount, myBiggerList.Count);//test bigger array


        }

        [TestMethod]

        public void Remove_RemoveItem_MethodReturnsTrue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();



            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            bool isTrue = myList.Remove(3);

            //Assert
            Assert.AreEqual(isTrue, true);


        }

        [TestMethod]

        public void Remove_AddInvalidItem_CountStaysTheSame()
        {


            //Arrange
            CustomList<int> myList = new CustomList<int>();



            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            int startCount = myList.Count;

           myList.Remove(4);

            //Assert
            Assert.AreEqual(startCount,myList.Count);


        }

        [TestMethod]

        public void Remove_RemoveOneItem_NextItemGoesIntoRemovedIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Remove(3);



            //Assert
            Assert.AreEqual(4, myList.items[2]);
            Assert.AreEqual(6, myList.items[4]);
            


        }

        [TestMethod]

        public void Remove_RemoveAnItemThatReapeats_RemoveTheFirstIntstanceOfThatItem()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();


            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(2); 
            myList.Add(6);
            myList.Remove(2);



            //Assert

            Assert.AreEqual(3, myList.items[1]);
            Assert.AreEqual(2, myList.items[3]);


        }

    }
}