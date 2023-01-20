using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSPG1
{
    public class Test
    {
        public static void Run()
        {
            for(int cntr = 0; cntr < TestUtilities.deltas.Length;cntr++)
            {
                TestUtilities.deltas[cntr] = new Triangle(TestUtilities.gen);
            }

            int[] set1 = new int[5];
            int[] set2a = new int[5];
            int[] set2b = new int[5];
            int[] set2c = new int[5];
            bool[] set3 = new bool[5];
            double[] set4a = new double[5];
            bool[] set4b = new bool[5];
            int[] set5 = new int[5];
            Triangle [] set6a = new Triangle[5];
            Triangle [] set6b = new Triangle[5];
            Triangle[] set7 = new Triangle[5];
            double[] set8 = new double[5];


            for (int cntr = 0; cntr < 5;cntr++)
            {
                set1[cntr] = TestUtilities.t1[TestUtilities.gen.Next(TestUtilities.t1.Length)];
                set2a[cntr] = TestUtilities.t2[TestUtilities.gen.Next(TestUtilities.t2.Length)];
                set2b[cntr] = TestUtilities.t2[TestUtilities.gen.Next(TestUtilities.t2.Length)];
                set2c[cntr] = TestUtilities.t1[TestUtilities.gen.Next(TestUtilities.t1.Length)];
                set3[cntr] = (TestUtilities.gen.Next() % 2) == 0;
                set4a[cntr] = TestUtilities.t4[TestUtilities.gen.Next(TestUtilities.t4.Length)];
                set4b[cntr] = (TestUtilities.gen.Next() % 2) == 0;
                set5[cntr] = TestUtilities.t5[TestUtilities.gen.Next(TestUtilities.t5.Length)];
                set6a[cntr] = TestUtilities.deltas[TestUtilities.gen.Next(TestUtilities.deltas.Length)];
                set6b[cntr] = TestUtilities.gen.Next() % 2 == 0 ? set6a[cntr].Duplicate() : 
                                       TestUtilities.deltas[TestUtilities.gen.Next(TestUtilities.deltas.Length)];
                set7[cntr] = TestUtilities.deltas2[TestUtilities.gen.Next(TestUtilities.deltas2.Length)];
                set8[cntr] = TestUtilities.t8[TestUtilities.gen.Next(TestUtilities.t8.Length)];
            }


            double passScore = 0;
            double testScore = 0;
            double labScore = 0;
            string indicator = "Fail";

            Console.WriteLine("\t\t\tTest 1");
            for(int cntr = 0;cntr < set1.Length;cntr++)
            {
                MathOperator exp = TestUtilities.T1(set1[cntr]);
                MathOperator sub = Submissions.Test1(set1[cntr]);
                if (exp == sub)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                //Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)" +  "  { " + set1[cntr] + " } ");
                //int y = Console.CursorTop;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                int y = Console.CursorTop;
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + set1[cntr] + " } ");
                Console.SetCursorPosition(31, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(55, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 1 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 2");
            for (int cntr = 0; cntr < set2a.Length; cntr++)
            {
                int exp = TestUtilities.T2(set2a[cntr], set2b[cntr], TestUtilities.T1(set2c[cntr]));
                int sub = Submissions.Test2(set2a[cntr],set2b[cntr], TestUtilities.T1(set2c[cntr]));
                if (exp == sub)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                int y = Console.CursorTop;
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + set2a[cntr] + ", " + set2b[cntr] + ", " + TestUtilities.T1(set2c[cntr]) + " }");
                Console.SetCursorPosition(49, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(71, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 2 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 3");
            for (int cntr = 0; cntr < set3.Length; cntr++)
            {
                string exp = TestUtilities.T3(set3[cntr]);
                string sub = Submissions.Test3(set3[cntr]);
                if (string.Compare(exp, sub, true) == 0)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                int y = Console.CursorTop;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + set3[cntr] + " }");
                Console.SetCursorPosition(35, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(57, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 3 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 4");
            for (int cntr = 0; cntr < set4a.Length; cntr++)
            {
                double exp = TestUtilities.T4(set4a[cntr],set4b[cntr]);
                double sub = Submissions.Test4(set4a[cntr], set4b[cntr]);
                if (exp == sub)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                int y = Console.CursorTop;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + set4a[cntr] + ", " + set4b[cntr] + " }");
                Console.SetCursorPosition(45, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(69, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 4 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 5");
            for (int cntr = 0; cntr < set5.Length; cntr++)
            {
                string exp = TestUtilities.T5(set5[cntr]);
                string sub = Submissions.Test5(set5[cntr]);
                if (string.Compare(exp, sub, true) == 0)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                int y = Console.CursorTop;
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + set5[cntr] + " }");
                Console.SetCursorPosition(31, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(63, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 5 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 6");
            for (int cntr = 0; cntr < set6a.Length; cntr++)
            {
                bool exp = TestUtilities.T6(set6a[cntr], set6b[cntr]);
                bool sub = Submissions.Test6(set6a[cntr], set6b[cntr]);
                if (exp == sub)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                int y = Console.CursorTop;
                Console.SetCursorPosition(24, y);
                Console.Write("{ T1 " + set6a[cntr] + ", T2 " + set6b[cntr] + " }");
                Console.SetCursorPosition(52, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(73, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 6 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 7");
            for (int cntr = 0; cntr < set7.Length; cntr++)
            {
                int a = (int)set7[cntr].GetA();
                int b = (int)set7[cntr].GetB();
                int c = (int)set7[cntr].C;
                bool exp = new Triangle(a,b,c).IsRightTriangle();
                bool sub = Submissions.Test7(a,b,c);
                if (exp == sub)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                int y = Console.CursorTop;
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + a + ", " + b + ", " + c + " }");
                Console.SetCursorPosition(40, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(61, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 7 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\t\tTest 8");
            for (int cntr = 0; cntr < set8.Length; cntr++)
            {
                //char exp = new Triangle(a, b, c).IsRightTriangle();
                char exp = Char.ToUpper(TestUtilities.T8(set8[cntr]));
                char sub = Char.ToUpper(Submissions.Test8(set8[cntr]));
                if (exp == sub)
                {
                    indicator = "Pass";
                    passScore = 2.5;
                }
                testScore += passScore;
                Console.Write("Pass " + (cntr + 1) + ": " + indicator + " (" + passScore + " pts)");
                int y = Console.CursorTop;
                Console.SetCursorPosition(24, y);
                Console.Write("{ " + set8[cntr] + " }");
                Console.SetCursorPosition(35, y);
                Console.Write("Expected: { " + exp + " }");
                Console.SetCursorPosition(52, y);
                Console.WriteLine("Submitted: { " + sub + " }");
                passScore = 0;
                indicator = "Fail";
            }
            Console.WriteLine("\tTest 8 score: " + testScore + "\n");
            labScore += testScore;
            testScore = 0;

            /////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nLab 4A score: " + labScore +"\n");

        }


    }
}
