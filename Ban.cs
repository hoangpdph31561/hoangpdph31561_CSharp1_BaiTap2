using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class Ban : DoDac
    {
        public Ban()
        {
            
        }

        public Ban(double chieuDai, double chieuRong, double chieuSau) : base(chieuDai, chieuRong, chieuSau)
        {
        }

        public override void InThongTin()
        {
            Console.WriteLine($"Bàn có chiều dài: {ChieuDai}|" +
                $" chiều rộng: {ChieuRong}|" +
                $" chiều sâu: {ChieuSau}");
        }
    }
}
