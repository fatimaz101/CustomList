using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{

    [TestClass]
    public class PlusOperatorTests
    {


        [TestMethod]
        public void PlusOperator_AddTwoStringLists_ReturnACustomListWithAddedLists()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            yourList.Add(4);
            yourList.Add(5);
            yourList.Add(6);

            CustomList<int> testList = myList + yourList;
            int[] Test = { 1, 2, 3, 4, 5, 6, 0, 0 };//zeros added to fulfil the capacity of a new list which doubles once over capacity
            //Assert

            CollectionAssert.AreEqual(Test, testList.items);



        }



        [TestMethod]

        public void PlusOperator_AddTwoLists_FirstListLongerThanSecond()
        {


            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            yourList.Add(6);
            yourList.Add(7);
            yourList.Add(8);

            CustomList<int> testList = myList + yourList;
            int[] Test = { 1, 2, 3, 4, 5, 6, 7, 8 };//zeros added to fulfil the capacity of a new list which doubles once over capacity
            //Assert

            CollectionAssert.AreEqual(Test, testList.items);






        }



        [TestMethod]

        public void PlusOperator_AddTwoLists_SecondListLongerThanSecond()
        {


            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            yourList.Add(4);
            yourList.Add(5);
            yourList.Add(6);
            yourList.Add(7);
            yourList.Add(8);

            CustomList<int> testList = myList + yourList;
            int[] Test = { 1, 2, 3, 4, 5, 6, 7, 8 };

            CollectionAssert.AreEqual(Test, testList.items);






        }


        [TestMethod]

        public void PlusOperator_AddAListAndAddAnEmptyList_NewListShouldBeFirtListUnchanged()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
       

            CustomList<int> testList = myList + yourList;
            int[] Test = { 1, 2, 3, 4 };

            CollectionAssert.AreEqual(Test, testList.items);







        }





        //Second list is longer than first list
        // If one list is empty, result is unchanged

    }
}
