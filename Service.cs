using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class Service
    {
        string _input;
        CongTyChuyenDo company;
        public Service()
        {
            company = new CongTyChuyenDo();
        }
        public void NhapKhachHang()
        {
            do
            {
                KhachHang customer = new KhachHang();
                customer.Ten = HamTao.GetInputWithRegex("tên khách hàng", @"^[a-zA-Z]+$");
                customer.Tuoi = Convert.ToInt32(HamTao.GetInputWithRegex("tuổi khách hàng", @"^[\d]+$"));
                customer.SoDienThoai = HamTao.GetInputWithRegex("số điện thoại khác hàng", @"^[0]{1}[\d]{10}$");
                customer.DiaChi = HamTao.GetInput("địa chỉ của khách hàng");
                customer.NhapDoDung();
                company.AddKhachHang(customer);
                do
                {
                    _input = HamTao.GetInput("có tiếp tục không");
                    if(String.Compare(_input,"có",true) != 0 && String.Compare(_input,"không",true) !=0)
                    {
                        Console.WriteLine("Chỉ được nhập có hoặc không");
                    }
                } while (String.Compare(_input, "có", true) != 0 && String.Compare(_input, "không", true) != 0);
            } while (String.Compare(_input, "có", true) == 0);
        }
        public void XuatThongTin()
        {
            if (HamTao.CheckCount(company.ArrLstKhachHang))
            {
                foreach (var item in company.ArrLstKhachHang)
                {
                    KhachHang kh = (KhachHang)item;
                    kh.InRa_ThongTinKhachHang();
                }
                
            }
        }
        public void XoaKhachHang()
        {
            company.DeleteKhachHang();
        }
        public void XoaDoDungKhachHang()
        {
            if (HamTao.CheckCount(company.ArrLstKhachHang))
            {
                int count = 0;
                foreach (var item in company.ArrLstKhachHang)
                {
                    KhachHang khach = (KhachHang)item;
                    Console.WriteLine($"Khách hàng thứ: {count+1}");
                    khach.InRa_ThongTinKhachHang();
                    count++;
                }
                int chonKhachHangXoaDoDung = Convert.ToInt32(HamTao.GetInputWithRegex("vị trí khách hàng cần xóa đồ dùng", @"^[\d]+$"));
                if(chonKhachHangXoaDoDung - 1 >= company.ArrLstKhachHang.Count)
                {
                    Console.WriteLine("Khách hàng không tồn tại");
                    return;
                }
                KhachHang kh = (KhachHang)company.ArrLstKhachHang[chonKhachHangXoaDoDung - 1];
                kh.XoaDoDung();
                company.ArrLstKhachHang[chonKhachHangXoaDoDung-1] = kh; 
                Console.WriteLine("Thay đổi thành công");
            }
        }
        public void KetLuanVanChuyen()
        {
            company.CheckVanChuyen();
        }
        public void ThemDoDung()
        {
            company.ThemDoDungKhachHang();
        }
        public void SuaDoKh()
        {
            company.SuaDoKhachHang();
        }
    }
}
