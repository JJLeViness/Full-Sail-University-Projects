using System;
using System.Text;
using Lab_7A;

namespace FSPG1
{
    public class Submission
    {
        public static StringBuilder Test1(string [] names)
        {
            StringBuilder sb = new StringBuilder();
            for(int L=0;L<names.Length;L++)
                sb.Append(names[L][0]);
            return sb ;
        }

        public static object Test2(float x, float y, float radius)
        {
            Circle Circle1=new Circle(x,y,radius);
            return Circle1;
        }

        public static object Test3(float x, float y, float radius)
        {
            Circle Circle2=new Circle(x,y,radius);
            return Circle2;
        }

        public static object Test4(float x, float y, float radius)
        {
            Circle Circle3=new Circle(x,y,radius);
            return Circle3;
        }

        public static object Test5(float x, float y, float radius)
        {
            Circle Circle4=new Circle(x,y,radius);
            return Circle4;
        }

        public static int Test6(string str1, string str2, bool ignoreCase)
        {
            
            return string.Compare(str1,str2,ignoreCase) ;
        }

        public static string Test7(sbyte offset, string message)
        {
            TextCodec Code = new TextCodec(offset);
            string answer = Code.Encode(message);

            return answer ;
        }

        public static string Test8(sbyte offset, string message)
        {
            TextCodec CodeC=new TextCodec(offset);
            return CodeC.Decode(message);
        }
    }
}
