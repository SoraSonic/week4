using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    class Toa_Do
    {
        string ten;
        float x, y;

        //get set
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        //end get set


        public Toa_Do()
        {
        }
        public Toa_Do(string ten, float x, float y)
        {
            this.ten = ten;
            this.x = x;
            this.y = y;
        }
        
    }
}
