using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Xml.XPath;
using System.Diagnostics.Tracing;
using Newtonsoft.Json;
using PG2Input;

namespace Lab2
{
    public static class PG2Sorting
    {
        public static List<string> ReadFile(string filename)
        {
            string filedata = File.ReadAllText(filename);
            string[] data = filedata.Split(',');
            List<string> list = data.ToList();
            return list;

        }

        // ---------------------------------------------------
        //
        // PART 2: Load the file
        //
        // Write a method to read the file and return a list of strings.
        // Open and read the line from the inputFile.csv file.
        // The line in the file contains a list of comic book titles separated by commas.
        // Split the string and store each title in a List of strings.
        // Return the list of strings.
        //
        // NOTE: the inputFile.csv has been added to the project with the copy properties set so that you do not need to add a path to read the file. Just use the filename.
        //


        // ---------------------------------------------------
        //
        // PART 3: Bubble Sort
        //
        // Write a method to implement the Bubble sort algorithm. You want to keep the original list unsorted so make sure to clone the list inside of Bubble sort.
        // Your code MUST follow the pseudocode. 
        // NOTE: swap is a method that is not provided by C#. You can create your own method or you can insert the swap logic inside the if. See the lectures slides for how to swap 2 items in a list.
        //
        // Keep track of how many times the for loop executes for the whole method. At the end of the method, print out the number of items in the list and the number of times the algorithm had to loop.
        // 
        //procedure bubbleSort(A : list of sortable items)
        //  n := length(A)
        //  repeat
        //      swapped := false
        //      for i := 1 to n - 1 inclusive do
        //          if A[i - 1] > A[i] then
        //              swap(A, i - 1, i)
        //              swapped = true
        //          end if
        //      end for
        //      n := n - 1
        //  while swapped
        //end procedure
        //
        public static void BubbleSorter(ref List<string> unsorted, ref int numberofswaps,ref int numberofloops)
        {
            List<string> list = unsorted.ToList();
            bool swap;
            int listcount = list.Count;
            numberofswaps = 0;
            numberofloops = 0;
            do
            {
                numberofloops++;
                swap = false;
                for (int i = 1; i <= listcount - 1; i++)
                {
                    if (list[i - 1].CompareTo(list[i]) > 0)
                    {
                        string temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;

                        (unsorted[i], unsorted[i - 1]) = (unsorted[i - 1], unsorted[i]);
                        swap = true;
                        numberofswaps++;
                    }
                }
                listcount--;

            } while (swap);






        }








        // ---------------------------------------------------
        //
        // PART 4: Merge Sort
        //
        // Write a method to implement the Merge sort algorithm. Merge sort will return a new sorted list so there is no need to clone the list that is passed in to MergeSort.
        // Your code MUST follow the pseudocode.

        //function merge_sort(list m) is
        // if length of m ≤ 1 then
        //      return m            
        // var left := empty list
        // var right := empty list
        // for I = 0 to length(m) do
        //      if i<(length of m)/2 then
        //          add m[i] to left
        //      else
        //          add m[i] to right
        //
        // left := merge_sort(left)
        // right := merge_sort(right)
        // return merge(left, right)

        //function merge(left, right) is
        //  var result := empty list
        //  while left is not empty and right is not empty do
        //  {
        //      if first(left) ≤ first(right) then
        //          add first(left) to result
        //          remove first from left
        //      else
        //          add first(right) to result
        //          remove first from right
        //  }
        //  while left is not empty do
        //  {
        //      add first(left) to result
        //      remove first from left
        //  }
        //  while right is not empty do
        //  {
        //      add first(right) to result
        //      remove first from right
        //  }
        // return result
        //
        public static List<string> MergeSort(List<string> unsortedlist)
        {
            if (unsortedlist.Count <= 1)
            {
                return unsortedlist;
            }
            List<string> left = new List<string>();
            List<string> right = new List<string>();
            int mid = (unsortedlist.Count / 2);

            for (int i = 0; i < unsortedlist.Count; i++)
            {
                if (i < mid)
                    left.Add(unsortedlist[i]);
                else
                    right.Add(unsortedlist[i]);


            }



            left = MergeSort(left);
            right = MergeSort(right);








            return Merge(left, right);

        }

        private static List<string> Merge(List<string> left, List<string> right)
        {
            var result = new List<string>();



            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First().CompareTo(right.First()) < 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            while (right.Count > 0)
            {
                result.Add(right.First());
                right.Remove(right.First());
            }
            while (left.Count > 0)
            {
                result.Add(left.First());
                left.Remove(left.First());
            }
            return result;
        }




        // ---------------------------------------------------
        //
        // PART 5: Binary Search
        //
        // Write a method to implement the Binary Search algorithm.
        // Keep track of how many times the binary search method is called when searching for a word. 
        // Your code MUST follow the pseudocode. 
        //
        //BinarySearch(A[0..N-1], searchTerm, low, high)
        //{
        //  if (high<low)
        //      return -1 // -1 means not found
        //  mid = (low + high) / 2
        //  if (searchTerm<A[mid])
        //      return BinarySearch(A, searchTerm, low, mid-1)
        //  else if (searchTerm > A[mid])
        //      return BinarySearch(A, searchTerm, mid+1, high)
        //  else
        //      return mid //the searchTerm was found
        //
        //}
        //
        public static int BinarySearch(List<string> sortedlist, string item, int min, int max,ref int number)
        {
            




            number++;
            if (min>max)
            {
                return -1;
            }

            int mid = (min + max )/ 2;

            if (sortedlist[mid].CompareTo(item) > 0)
            {
                
                return (BinarySearch(sortedlist, item, min, max - 1,ref number));
            }
            else if (sortedlist[mid].CompareTo(item) < 0)
            {
                
                return (BinarySearch(sortedlist, item, min+1, max,ref number));
            }
            else
            {
                return mid;
            }

        }


        // ---------------------------------------------------
        //
        // PART 6: Save
        //
        // Write a method to serialize a sorted list to a save file.
        // Ask the user for the name of the save file. Use GetString from Lab 1 to get the name of the file.
        // If the name does not have the json extension, add it to the file name. Look at the Path methods GetExtension, HasExtension, and ChangeExtension to make sure you get the extension set correctly.
        //
        // Take a clone of the unsorted, sort using one of your sort algorithms, then save the sorted list to a json file.
        // You will need to serialize the list in JSON format. Use the JSON.net library.
        // 
        //


    }


}
