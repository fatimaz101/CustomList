using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests;

[TestClass]
public class ToStringTests
{
    [TestMethod]
    public void ToString_ArrayOfStrings_AllItemsShouldBeReturnedInAString()
    {
        //Arrange

        CustomList<string> myList = new CustomList<string>();
        myList.Add("Fatima");
        myList.Add("is");
        myList.Add("dazzling!");



        //Act
         string result= myList.ToString();
        Console.WriteLine($"{result}");


        //Assert

        Assert.AreEqual(result, "Fatima is dazzling!");
    }



    [TestMethod]
    public void ToString_ArrayOfNumbers_AllItemsShouldBeReturnedInAString()
    {
        //Arrange

        CustomList<int> myList = new CustomList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);



        //Act
        string result = myList.ToString();
        Console.WriteLine($"{result}");


        //Assert

        Assert.AreEqual(result, "1 2 3 4 5");
    }



    [TestMethod]
    public void ToString_EmptyArray_ReturnEmptyString()
    {
        //Arrange

        CustomList<int> myList = new CustomList<int>();
       



        //Act
        string result = myList.ToString();
        


        //Assert

        Assert.AreEqual(result, "");
    }
}