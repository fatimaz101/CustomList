namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Fatima");
            myList.Add("is");
            myList.Add("dazzling!");



            //Act
            string result = myList.ToString();


            Console.WriteLine($"{result}");

        }
    }
}