using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{

    [TestClass]
    public class MinusOperatorTests
    {

        [TestMethod]

        public void MinusOperator_SubtractTwoLists_EveryOccuranceOfAnItemFromSecondListShoudBeMissingFromFirstList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            yourList.Add(1);
            yourList.Add(5);
            yourList.Add(6);
            

            CustomList<int> testList = myList - yourList;
            int[] Test = { 2, 3, 0,0 };

            CollectionAssert.AreEqual(Test, testList.items);

        }

        [TestMethod]
        public void MinusOperator_SubtractTwoListsFirstOneIsLonger_EveryOccuranceOfAnItemFromSecondListShoudBeMissingFromFirstList()
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
            
            yourList.Add(1);
            yourList.Add(5);
            yourList.Add(6);


            CustomList<int> testList = myList - yourList;
            int[] Test = { 2, 3, 4, 0, 0, 0, 0, 0, };

            CollectionAssert.AreEqual(Test, testList.items);

        }


        [TestMethod]
        public void MinusOperator_SubtractTwoListSecondListIsLonger_EveryOccuranceOfAnItemFromSecondListShoudBeMissingFromFirstList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
           
            yourList.Add(1);
            yourList.Add(5);
            yourList.Add(6);
            yourList.Add(2);
            yourList.Add(2);


            CustomList<int> testList = myList - yourList;
            int[] Test = { 3, 0,0, 0, };

            CollectionAssert.AreEqual(Test, testList.items);

        }



        [TestMethod]
        public void MinusOperator_SubtractTwoLists_OnlyOneOccuranceOfAnItemIsRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();

            //Act

            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(3);
            myList.Add(3);
            myList.Add(3);
            

            yourList.Add(1);
            yourList.Add(5);
            yourList.Add(6);
            yourList.Add(3);
            yourList.Add(2);


            CustomList<int> testList = myList - yourList;
            int[] Test = { 1, 1, 3, 3, 0, 0, 0, 0, };

            CollectionAssert.AreEqual(Test, testList.items);

        }


    }
}
