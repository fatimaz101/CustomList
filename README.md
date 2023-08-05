# CustomList<T>.Remove(T) Method



Defintion- Removes the specified item from the first place it's found in your Custom List<T>
           

Example:  CustomList<int> ExampleList = new CustomList<int>();

            ExampleList.Add(3);
            ExampleList.Add(1);
            ExampleList.Add(3);
            ExampleList.Add(4);

            //The List Contains {3,1,3,4};

            ExampleList.Remove(3);
            //Output is 1,3,4


Parameters: items T    -where the items are stored in the list. Once an item is removed it goes to its's replaced with the default value.

Syntax: CustomList<T>.Remove(T) Method //Call the method but using the .Remove(T)


Return Type: bool //If item was removed this method will return true , but if the item didnt exist or wasnt succesfully removed    		          the method will return false.
            
