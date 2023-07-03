using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class TuDo: DoDac
    {
        public TuDo()
        {
            
        }

        public TuDo(double chieuDai, double chieuRong, double chieuSau) : base(chieuDai, chieuRong, chieuSau)
        {
        }

        public override void InThongTin()
        {
            Console.WriteLine($"Tủ đồ có chiều dài: {ChieuDai}|" +
                $" chiều rộng: {ChieuRong}|" +
                $" chiều sâu: {ChieuSau}");
        }
    }
}
