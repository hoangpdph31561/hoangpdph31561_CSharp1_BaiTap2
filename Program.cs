using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            int chon;
            Service sv = new Service(); 
            do
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1. Nhập thông tin khác hàng và đồ dùng");
                Console.WriteLine("2. Xuất thông tin khách hàng và đồ dùng");
                Console.WriteLine("3. Xóa khách hàng từ công ty");
                Console.WriteLine("4. Thêm đồ dùng cho khách hàng");
                Console.WriteLine("5. Sửa đồ dùng cho khách hàng");
                Console.WriteLine("6. Xóa đồ dùng khách hàng");
                Console.WriteLine("7. Kết luận vận chuyển");
                Console.WriteLine("0. Thoát chương trình");
                chon = Convert.ToInt32(HamTao.GetInput("Chọn chương trình"));
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        sv.NhapKhachHang();
                        break;
                    case 2:
                        sv.XuatThongTin();
                        break;
                    case 3:
                        sv.XoaKhachHang();
                        break;
                    case 4:
                        sv.ThemDoDung();
                        break;
                    case 5:
                        sv.SuaDoKh();
                        break;
                    case 6:
                        sv.XoaDoDungKhachHang();
                        break;
                    case 7:
                        sv.KetLuanVanChuyen();
                        break;
                    default:
                        Console.WriteLine("Chọn sai chương trình mời chọn lại");
                        break;
                }
            } while (chon !=0);
        }
    }
}
