using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    class HinhTron
    {
        Toa_Do tam;
        float banKinh;

        //get set
        internal Toa_Do Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public float BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        //end get set

        //constructor
        public HinhTron()
        {
        }

        public HinhTron(Toa_Do tam, float banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        //end constructor

        //method
        public float Tinh_ChuVi(float banKinh)
        {
            return banKinh*2* (float)Math.PI;
        }

        public float Tinh_DienTich(float banKinh)
        {
            return banKinh *banKinh * (float)Math.PI;
        }
        public void nhapHinhTron()
        {

        }

        public void xuatHinhTron(HinhTron x)
        {
            Console.WriteLine("Hinh tron co tam \tBan Kinh \tDien Tich \tChu Vi");
            Console.WriteLine(String.Format("{0,10}({1},{2}) \t{3,-10} \t{4} \t{5}\n",tam.Ten, tam.X, tam.Y, BanKinh, Tinh_DienTich(banKinh), Tinh_ChuVi(banKinh)));
        }
        //end method
    }
}
