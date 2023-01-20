using System;
using System.CodeDom.Compiler;
using System.Diagnostics.Contracts;
using System.Xml.Schema;
using Tester;

namespace FSPG1
{
    class Submission
    {
        /*
         * This lab is NOT interactive - that means there should be no 
         * calls to the Console class (no Write/WriteLine/ReadLine/ReadKey)
         * 
         * You cannot use multiple return statements any of these methods. 
         * Additionally the use of var is not permitted
         * 
        */

        // Test 1 – Convert char array to int array
        // Given an array of char, phrase, convert each element to an
        // equivalent int value and place in an int array.
        // Return the int array
        public static int[] Test1(char[] phrase)
        {
            int[] ints = new int[phrase.Length];
            for(int i=0;i<phrase.Length;i++)
                ints[i] = phrase[i];
            return ints;
        }

        // Test 2 - Array statistics
        // Given an array of double, data, find the smallest element, 
        // the largest element and the numeric mean (average). Store the 
        // results in an array (in that order: smallest, largest, mean).
        // Return the array
        public static double[] Test2(double[] data)
            
        {
            double smallest = data[0];
            double largest = data[0];
            double mean = 0;
            double sum = 0;
        
            
            for (int i = 0; i < data.Length; i++)
            {
                if(smallest>data[i])
                {
                    smallest = data[i];
                }
                if (largest < data[i])
                {
                    largest = data[i];
                }
                sum+=data[i];
                mean=sum/data.Length;
            }
            //did I divide by the correct item for mean?
            
            


            double[] result = new double[3] { smallest, largest, mean };
            return result;
        }

        // Test 3 - Normalize an array (of double)
        // Given an array of double, numbers, normalize the array. To 
        // normalize an array:
        // 1) Find the largest element stored in the array
        // 2) Divide each element in the array by the largest value
        //    and replace each array element with the result of the 
        //    division.
        // Since the array's contents are being modified, there is 
        // nothing to return
        public static void Test3(double[] numbers)
        {
            double largest=numbers[0];
            for(int n=1; n<numbers.Length; n++)
                if(numbers[n] > largest)
                {
                    largest = numbers[n];
                }
            for(int n=0; n<numbers.Length; n++)
                numbers[n] = numbers[n]/largest;

        }

        // Test 4 - Uniqueness
        // Given an array of string, names, verify that each name is unique
        // mean that none of the names are duplicated within the array.
        // If the array is unique, return true; otherwise, return false
        public static bool Test4(string [] names)
        {
            bool unique = true;
            for (int k = 0; k < names.Length && unique; k++)
                for (int O = k + 1; O < names.Length; O++)
                    if (names[k] == names[O])
                    {
                        unique = false;
                        break;
                    }
            return unique;
        }

        // Test 5 - Acronym
        // Given an array of string, words, create a string that is the 
        // acronym (first letter of each word). Return the string
        public static string Test5(string [] words)
        {
            string rearrange = "";
            for (int L = 0; L < words.Length; L++)
                rearrange = rearrange + words[L][0];
            return rearrange;
        }

        // Test 6 - Array reverse
        // Given a char array, letters, create another array that has the
        // same elements but in reverse order. Return the array
        // 
        // You are not allowed to use Array.Reverse (or any existing
        // method) to reverse the array
        //
        public static char[] Test6(char[] letters)
        {
            char[] reversereverse=new char[letters.Length];
            int i = letters.Length - 1;
            for(int Q=0;Q<letters.Length;Q++)
            { reversereverse[Q] = letters[i];
                i--;
            return reversereverse;
        }

        // Test 7 - Transpose array
        // Given a 2-Dimension array of int, table, create a new array that 
        // 'transposes' the original array. Transposing means that each row 
        // in the original array will be a column in the new array and each
        // column in the original array will be a row in the new array.
        // For example, given
        //   4   3   1   5
        //   2   7   0   8
        //
        // The transposed array would be
        //   4   2
        //   3   7
        //   1   0
        //   5   8
        //
        public static int[,] Test7(int [,] table)
        {
                int[,] Answer7 = new int[table.Length(1), table.GetLength(0)];
                for(int r=0;r<table.GetLength(0);r++)
                    for(int c=0;c<table.GetLength(1);c++)
                        Answer7[r,c] = table[r,c];

            return Answer7;
        }

        // Test 8 – Return a 2D array
        // Given three arrays of the same type (int) and size, combine the 
        // arrays into a single 2D array. Return the 2D array
        // NOTE: This solution requires a single loop (not three)
        // 
        public static int [,] Test8(int [] mins, int [] maxes, int [] seeds)
        {
                int[,] Answer8 = new int[3, mins.Length];
                for(int m=0;m<mins.Length;m++)
                {
                    Answer8[0,m] = mins[m];
                    Answer8[1,m] = maxes[m];
                    Answer8[2,m]= seeds[m];

                }
            return Answer8;
        }

        // Test 9 – Convert int array to char array
        // Given an array of int, ascii, convert each element to an
        // equivalent char value and place in a char array.
        // Return the char array
        public static char[] Test9(int[] ascii)
        {
                char[] answer = new char[ascii.Length];
                for(int B=0;B<ascii.Length;B++)
                {
                    answer[B]=(char)ascii[B];
                }
            return answer;
        }

        // Test 10 – Modify an existing array
        // Given an array of char (all uppercase), modify the array so
        // that every other element will be lowercase (even indexes are 
        // upper, odd indexes are lower)
        public static void Test10(char[] word)
        {
                for (int t = 1; t < word.Length; t+=2)
                {
                    word[t]=char.ToLower(word[t]);
                }
        }
    }
}
