using System;

// You are to debug this program by correcting any syntax errors so 
// the program will compile & execute 
// Additionally, you are to answer the questions in the accompanying 
// Debug Questions.docx Word document (it is in the same folder as
// the Debug Exercise.sln file. To answer the questions you need to 
// examine the Autos and/or Locals output windows while the program 
// is 'stopped' (paused) at a breakpoint. If you Autos/Locals windows
// are missing (should be below the editor window) you can make them
// visible by going to the Debug menu, selection the Windows sub-menu
// and the Autos or Locals as appropriate. Please note, the options 
// for Autos/Locals will only appear while the program is running
//
//

namespace Debug_Exercise
{
    class Program
    {
        static Random gener = new Random(Support.GetSeed());

        const int MIN = Support.MIN;
        const int MAX = Support.MAX;

        static string[] name = { "ybraD", "ecnerwaL", "haraS", "refinneJ", "yevaD", "atteirneH", "selrahC", "sicnarF", "yrograM",
                                  "wemelohtraB", "moT", "leahciM", "ymereJ", "ennA", "elleinaD", "mailliW", "suiriS", "enoimreH",
                                  "naitsabeS", "nosaJ", "adnamA", "ettedO", "pirT", "noiraM", "enerI", "auhsoJ", "ellehciM" };


        // there is one error in the Main method - it is a simple typo that needs to
        // be corrected. You do not need to add any additional programming statements
        static void Main(string[] args)
        {
            int age = Support.GetAge(gener.Next(MIN, MAX));
            string who = Support.GetName(name[gener.Next(name.Length)]);     // this line should have a breakpoint

            DisplayUserInfo(who, age);                                          // this line should have a breakpoint

            SayABCs();

            Console.ReadKey();
        }

        // There are two errors in the DisplayUserInfo method. The variables used in 
        // the method do not match the parameters and/or local variables. Either 
        // update the variables being used or update the definitions so the identifer
        // names being used match the identifiers names defined. You do not need to 
        // add any additional programming statements
        public static void DisplayUserInfo(string name, int age)
        {
            Console.Write("Please provide a warm welcome to my next guest, ");
            Console.WriteLine(name + ", on the occasion of turning " + age +" years old!");
        }

        // there are 2 errors in the SayABCs method. One is an incorrect variable 
        // name and the other is a 'punctuation' error. You do not need to add any 
        // additional programming statements
        public static void SayABCs()
        {
            for(int ndx = 97; ndx <= 122; ndx++)
            {
                if ((ndx + 3) % 10 == 0)
                {
                    Console.WriteLine();
                }
                if (ndx == 97)
                    Console.Write("\n" + (char)ndx + " ");                          // this line should have a breakpoint
                else
                    Console.Write((char)ndx + " ");
            }
            Console.WriteLine();
        }
    }
}
