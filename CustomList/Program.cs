namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

        }
    }
}