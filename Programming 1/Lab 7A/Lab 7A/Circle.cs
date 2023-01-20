using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    internal class Circle
    {
        float _x;
        float _y;
        float _radius;

        public Circle(float x, float y, float radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }   
        public float GetX()
        { return _x; }
        public float GetY()
            { return _y; }
        public float GetRadius()
            { return _radius; }
        public float GetArea()
        {
            float area = (float)Math.PI * _radius * _radius;
            return area;
        }
        public bool Contains(float px,float py)
        {
            bool C=false;
            float c=(float)Math.Sqrt(Math.Pow((px-_x),2) + Math.Pow((py - _y),2));
            if(c<=_radius)
                C=true;
            return C;
        }

        public float GetCircumference()
        {
            float c=2*(float)Math.PI*_radius;
            return c;
        }
        
        

    }
}
