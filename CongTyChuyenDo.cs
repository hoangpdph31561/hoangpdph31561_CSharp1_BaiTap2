using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class CongTyChuyenDo
    {
        const double theTichChoPhep = 20;
        private string tenCongTy;
        private ArrayList arrLstKhachHang;
        public CongTyChuyenDo()
        {
            arrLstKhachHang = new ArrayList();
        }

        public CongTyChuyenDo(string tenCongTy)
        {
            this.tenCongTy = tenCongTy;
            arrLstKhachHang = new ArrayList();
        }

        public static double TheTichChoPhep => theTichChoPhep;

        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public ArrayList ArrLstKhachHang { get => arrLstKhachHang; set => arrLstKhachHang = value; }
        public ArrayList AddKhachHang(KhachHang custormer)
        {
            arrLstKhachHang.Add(custormer);
            return arrLstKhachHang;
        }
        public void DeleteKhachHang()
        {
            if(HamTao.CheckCount(arrLstKhachHang))
            {
                Console.WriteLine("Thông tin khách hàng");
                int count = 0;
                int indexXoaKhachHang;
                foreach (var item in arrLstKhachHang)
                {
                    Console.WriteLine($"Khác hàng thứ: {count + 1}");
                    KhachHang customer = (KhachHang)item;
                    customer.InRa_ThongTinKhachHang();
                }
                indexXoaKhachHang = Convert.ToInt32(HamTao.GetInput("vị trí khách hàng muốn xóa"));
                if(indexXoaKhachHang-1 >= arrLstKhachHang.Count)
                {
                    Console.WriteLine("Không có khách hàng mà bạn chọn");
                    return;
                }
                arrLstKhachHang.RemoveAt(indexXoaKhachHang-1);
                Console.WriteLine("Xóa thành công");
            }
        }
        public void CheckVanChuyen()
        {
            if (HamTao.CheckCount(arrLstKhachHang))
            {
                foreach (var item in arrLstKhachHang)
                {
                    KhachHang kh = (KhachHang)item;
                    kh.InRa_ThongTinKhachHang();
                    double sum = kh.TongTheTich();
                    Console.WriteLine($"{(sum <= theTichChoPhep ? "Đủ tiêu chuẩn để vận chuyển":"Không đủ tiêu chuẩn")}");
                }
            }
        }
    }
}
