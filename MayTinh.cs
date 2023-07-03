using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class MayTinh : DoDac
    {
        public MayTinh()
        {
            
        }

        public MayTinh(double chieuDai, double chieuRong, double chieuSau) : base(chieuDai, chieuRong, chieuSau)
        {
        }

        public override void InThongTin()
        {
            Console.WriteLine($"Máy tính có chiều dài: {ChieuDai}" +
                $"| Chiều rộng: {ChieuRong}" +
                $"| Chiều sâu: {ChieuSau}");
        }
    }
}
