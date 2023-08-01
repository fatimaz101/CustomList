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

            CustomList<string> yourList = new CustomList<string>();
            yourList.Add("day");
            yourList.Add("hello");

            CustomList<string> fatima = yourList + myList;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{fatima[i]}");
            }





        }
    }
}