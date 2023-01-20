using System;
using PG2Input;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "inputFile.csv";
            





            string[] MenuOptions = new string[5];
            MenuOptions[0] = "1. Bubble Sort";
            MenuOptions[1] = "2. Merge Sort";
            MenuOptions[2] = "3. Binary Search";
            MenuOptions[3] = "4. Save";
            MenuOptions[4] = "5. Exit";



            //
            // PART 1
            // Show a menu to the user so they can select one of the algorithms(bubble, merge, and binary search), save a sorted list, and Exit.
            // Use the GetMenuChoice method you created in the first lab.
            // 1. Bubble Sort
            // 2. Merge Sort
            // 3. Binary Search
            // 4. Save
            // 5. Exit
            //
            int userselection = 0;
            
            while (userselection != 5)
            {


                Input.GetMenuChoice("Please make a selection", MenuOptions, out userselection);
                switch (userselection)
                {
                    case 1:
                        {
                            userselection = 1;
                            List<string> unsortedlist = PG2Sorting.ReadFile(filename);
                            List<string> bubblelist=new List<string>(unsortedlist);
                            int numberofswaps=0;
                            int numberofloops=0;
                            PG2Sorting.BubbleSorter(ref bubblelist,ref numberofswaps,ref numberofloops);
                            Console.Clear();
                            Console.WriteLine("\nBubble Sort");
                            Console.WriteLine("_____________________");
                            Console.WriteLine($"There are {bubblelist.Count} number of items, the method looped {numberofloops} times and {numberofswaps} swaps occured while sorting");
                            for(int i = 0; i < unsortedlist.Count; i++)
                            {
                                Console.WriteLine(unsortedlist[i]);
                                Console.CursorLeft = 70;
                                Console.WriteLine(bubblelist[i]);

                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:

                        {
                            userselection = 2;
                            List<string> unsort = PG2Sorting.ReadFile(filename);
                            List<string> merged=PG2Sorting.MergeSort(unsort);
                            Console.Clear();
                            Console.WriteLine("Merge Sort");
                            Console.WriteLine("_________________");
                            for(int i=0;i<unsort.Count;i++)
                            {
                                Console.WriteLine(unsort[i]);
                                Console.CursorLeft = 70;
                                Console.WriteLine(merged[i]);
                                
                               
                            }
                            Console.ReadKey();
                            Console.Clear();
                            
                            break;
                        }
                    case 3:
                        {
                            userselection = 3;

                            //Confused on the second number, In the video it displayed the IndexOf as the second number.
                            //But in another place it is displaying the number of MethodCalls
                            List<string> tobesorted = PG2Sorting.ReadFile(filename);
                            List<string> sorted=tobesorted.ToList();
                            int number = 0;
                            int loop = 0;
                            Console.Clear();
                            Console.WriteLine("\n Binary Search");
                            Console.WriteLine("___________________________");
                            Console.WriteLine();
                            
                            PG2Sorting.BubbleSorter(ref sorted, ref number,ref loop);
                            
                            for(int k=0;k<sorted.Count;k++)
                            {
                                int calls = 0;
                                
                                int found = PG2Sorting.BinarySearch(sorted, sorted[k],0,sorted.Count-1,ref calls);
                                Console.WriteLine(sorted[k]);
                                int indexof=sorted.IndexOf(sorted[k]);
                                Console.CursorLeft = 50;
                                Console.Write($"Index:{found}");
                                Console.CursorLeft = 90;
                                Console.WriteLine($" Method Calls {calls}");

                                
                            }

                            Console.ReadKey();
                            Console.Clear();
                            

                            break;
                        }
                    case 4:
                        {
                            userselection = 4;
                            Console.Clear();
                            string savefile= "";
                            int swaps = 0;
                            Input.GetString("What would you like to name the file?",ref savefile);
                            List<string> unsortedlist = PG2Sorting.ReadFile(filename);
                            List<string> sortedlist=unsortedlist.ToList();
                            int loops=0;
                            PG2Sorting.BubbleSorter(ref sortedlist , ref swaps,ref loops);
                            for(int m=0;m<unsortedlist.Count;m++)
                            {
                                Console.WriteLine(unsortedlist[m]);
                                Console.CursorLeft = 70;
                                Console.WriteLine(sortedlist[m]);
                            }
                            savefile = Path.ChangeExtension(savefile, ".json");
                            using (StreamWriter sw = new StreamWriter(savefile))
                            {
                                using (JsonTextWriter json = new JsonTextWriter(sw))
                                {
                                    JsonSerializer serializer = new JsonSerializer();
                                    serializer.Serialize(json, sortedlist);

                                }

                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            userselection = 5;
                            Console.Clear();

                            break;
                        }
                }
            }
        }
    }
}
