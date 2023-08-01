using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        public T[] items;
        private int capacity;
        private int count;
      
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public T this[int index]
        {


            get
            {
                
                    if (index < Count && index >= 0)
                    {
                        return items[index];
                    }
                    else
                    {
                        Console.WriteLine("Index out of range.");
                    return default(T);
                    }


                
            }
            set
            {
                items[index] = value;

            }


            
        }




        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;

            items = new T[capacity];
            
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array


            //Count = items.Count;
            if (count >= Capacity)
            {
                Capacity = capacity * 2;
               
                T[] newItems = items;
                Array.Resize<T>(ref items, capacity);
                Array.Copy(items, newItems, Count);

                items[count] = item;
               
                count++;


            }
            else if (count < Capacity)
            {
                items[count] = item;
                count++;

            }
            
            
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.

            int index = Array.IndexOf(items, item);


            int checkPoint = Count - index;


            if (items.Contains(item) == true)//checks whether item exists in array
                {


                 


                    for (int i = 0; i < checkPoint; i++)
                    {


                    if (i != (checkPoint - 1))
                        {

                            items[index] = items[index + 1];
                        }else if(i == (checkPoint-1))
                        {

                            items[index] = default(T);
                        }


                    index++;

                    }



                   count--;
                   return true;



                }else if (items.Contains(item) == false)
                {


                Console.WriteLine("Item doesnt exist in your List.");
                return false;

                  }
                else
                {
                Console.WriteLine("Fail");
                return false;
                }
                




        }

        public override string ToString()
        {
            //returns a single string that contains all items from array

            var slice = items.Skip(0).Take(Count);



            string separator = " ";
            
            string result = String.Join(separator, slice);

            return result;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 

            int newLength = firstList.Count + secondList.Count;

            T[] result = new T[newLength];


            if (firstList.Count > 0)
            {


                for (int i = 0; i < (firstList.Count); i++)
                {
                    result[i] = firstList[i];
                }


                if (secondList.Count > 0)
                {


                    for (int x = 0; x < (secondList.Count ); x++)
                    {
                        result[firstList.count + x] = secondList[x];
                    }
                }




            } else if (secondList.Count > 0)
            {


                for (int x = 0; x < (secondList.Count - 1); x++)
                {
                    result[firstList.count + x] = secondList[x];
                }
            }
           

            CustomList<T> newResult = new CustomList<T>();
            for (int y = 0; y < newLength; y++)
            {
                newResult.Add(result[y]);
            }



            return newResult;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList




            return null;
        }

       
        


    }
}
