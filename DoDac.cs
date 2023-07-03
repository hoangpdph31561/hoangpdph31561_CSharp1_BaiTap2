using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal abstract class DoDac
    {
        private double chieuDai;
        private double chieuRong;
        private double chieuSau;
        protected double theTich;

        public DoDac()
        {
            
        }

        public DoDac(double chieuDai, double chieuRong, double chieuSau)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.chieuSau = chieuSau;
            theTich = TinhTheTich(chieuDai,chieuRong,chieuSau);
        }

        public double ChieuDai { get => chieuDai; set => chieuDai = value; }
        public double ChieuRong { get => chieuRong; set => chieuRong = value; }
        public double ChieuSau { get => chieuSau; set => chieuSau = value; }
        public double TheTich { get => TinhTheTich(chieuDai,chieuRong,chieuSau);  }

        private double TinhTheTich(double chieuDai, double chieuRong, double chieuSau)
        {
            return chieuDai * chieuRong * chieuSau;
        }
        public abstract void InThongTin();


    }
}
