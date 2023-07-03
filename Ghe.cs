using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class Ghe: DoDac
    {
        public Ghe()
        {
            
        }

        public Ghe(double chieuDai, double chieuRong, double chieuSau) : base(chieuDai, chieuRong, chieuSau)
        {
        }

        public override void InThongTin()
        {
            Console.WriteLine($"Ghế có chiều dài: {ChieuDai}|" +
                $" chiều rộng: {ChieuRong}|" +
                $" chiều sâu: {ChieuSau}");
        }
    }
}
