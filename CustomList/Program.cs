namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> myList = new CustomList<string>();


            //Act
            myList.Add("hey");
            myList.Add("hey");
            myList.Add("hey");
            myList.Add("hey");
            myList.Add("hey");
            myList.Add("hey");
            myList.Remove("hey");
            Console.WriteLine($"{myList.items[5]}");

        }
    }
}