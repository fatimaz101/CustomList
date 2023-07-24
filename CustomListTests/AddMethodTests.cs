
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void Add_ValidItem_CountIncreaseByOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);

            //Assert
            Assert.AreEqual(1, myList.Count);


        }
        [TestMethod]
        public void Add_ValidItem_ItemFoundAtZeroIndex()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);

            //Assert
            Assert.AreEqual(1, myList.items[0]);


        }
        [TestMethod]
        public void Add_TwoValidItems_SecondItemAtFirstIndex()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);

            //Assert
            Assert.AreEqual(2, myList.items[1]);




        }
        [TestMethod]
        public void Add_FiveValidItems_CapacityIncreasesWhenExceeded()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);


            //Assert
            Assert.IsTrue(myList.Capacity > 4);




        }

        [TestMethod]
        public void Add_FiveValidItems_ThreeItemsFromOriginalArrayInCorrectIndex()
        {

            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);


            //Assert


            Assert.AreEqual(myList.items[0], 1);
            Assert.AreEqual(myList.items[1], 2);
            Assert.AreEqual(myList.items[3], 4);






        }




    }


}