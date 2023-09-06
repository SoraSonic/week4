using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Toa_Do toado1 = new Toa_Do("O", 5, 5);
            HinhTron hinhtron1 = new HinhTron(toado1, 5);

            hinhtron1.xuatHinhTron(hinhtron1);
            Console.ReadKey();
        }
    }
}
