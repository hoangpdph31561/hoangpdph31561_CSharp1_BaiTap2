using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace hoangpdph31561_CSharp1_BaiTap2
{
    internal class KhachHang
    {
        private string ten;
        private int tuoi;
        private string soDienThoai;
        private string diaChi;
        private ArrayList arrLstDoDung;
        public KhachHang()
        {
            arrLstDoDung = new ArrayList();
        }

        public KhachHang(string ten, int tuoi, string soDienThoai, string diaChi)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
            arrLstDoDung = new ArrayList();
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public ArrayList ArrLstDoDung { get => arrLstDoDung; set => arrLstDoDung = value; }
        public void NhapDoDung()
        {
            int chonDoMuonThem;
            do
            {
                Console.WriteLine("Chọn đồ dùng mà bạn muốn thêm");
                Console.WriteLine("1. Bàn");
                Console.WriteLine("2. Ghế");
                Console.WriteLine("3. Giường");
                Console.WriteLine("4. Máy tính");
                Console.WriteLine("5. Tủ đồ");
                Console.WriteLine("0. Thoát chọn đồ");
                Console.WriteLine("Mời bạn chọn đồ dùng muốn thêm");
                chonDoMuonThem = Convert.ToInt32(Console.ReadLine());
                switch (chonDoMuonThem)
                {
                    case 0:
                        break;
                    case 1:
                        Ban desk = new Ban();
                        desk.ChieuDai = Convert.ToDouble(HamTao.GetInputWithRegex("chiều dài bàn", @"^[\d]+\,?[\d]*$"));
                        desk.ChieuRong = Convert.ToDouble(HamTao.GetInputWithRegex("chiều rộng bàn", @"^[\d]+\,?[\d]*$"));
                        desk.ChieuSau = Convert.ToDouble(HamTao.GetInputWithRegex("chiều sâu bàn", @"^[\d]+\,?[\d]*$"));
                        arrLstDoDung.Add(desk);
                        break;
                    case 2:
                        Ghe chair = new Ghe();
                        chair.ChieuDai = Convert.ToDouble(HamTao.GetInputWithRegex("chiều dài ghế", @"^[\d]+\,?[\d]*$"));
                        chair.ChieuRong = Convert.ToDouble(HamTao.GetInputWithRegex("chiều rộng ghế", @"^[\d]+\,?[\d]*$"));
                        chair.ChieuSau = Convert.ToDouble(HamTao.GetInputWithRegex("chiều sâu ghế", @"^[\d]+\,?[\d]*$"));
                        arrLstDoDung.Add(chair);
                        break;
                    case 3:
                        Giuong bed = new Giuong();
                        bed.ChieuDai = Convert.ToDouble(HamTao.GetInputWithRegex("chiều dài giường", @"^[\d]+\,?[\d]*$"));
                        bed.ChieuRong = Convert.ToDouble(HamTao.GetInputWithRegex("chiều rộng giường", @"^[\d]+\,?[\d]*$"));
                        bed.ChieuSau = Convert.ToDouble(HamTao.GetInputWithRegex("chiều sâu giường", @"^[\d]+\,?[\d]*$"));
                        arrLstDoDung.Add(bed);
                        break;
                    case 4:
                        MayTinh computer = new MayTinh();
                        computer.ChieuDai = Convert.ToDouble(HamTao.GetInputWithRegex("chiều dài máy tính", @"^[\d]+\,?[\d]*$"));
                        computer.ChieuRong = Convert.ToDouble(HamTao.GetInputWithRegex("chiều rộng máy tính", @"^[\d]+\,?[\d]*$"));
                        computer.ChieuSau = Convert.ToDouble(HamTao.GetInputWithRegex("chiều sâu máy tính", @"^[\d]+\,?[\d]*$"));
                        arrLstDoDung.Add(computer);
                        break;
                    case 5:
                        TuDo wardrobe = new TuDo();
                        wardrobe.ChieuDai = Convert.ToDouble(HamTao.GetInputWithRegex("chiều dài tủ đồ", @"^[\d]+\,?[\d]*$"));
                        wardrobe.ChieuRong = Convert.ToDouble(HamTao.GetInputWithRegex("chiều rộng tủ đồ", @"^[\d]+\,?[\d]*$"));
                        wardrobe.ChieuSau = Convert.ToDouble(HamTao.GetInputWithRegex("chiều sâu tủ đồ", @"^[\d]+\,?[\d]*$"));
                        arrLstDoDung.Add(wardrobe);
                        break;
                    default:
                        Console.WriteLine("Chọn sai đồ thêm, mời chọn lại");
                        break;
                }
            } while (chonDoMuonThem != 0);
        }
        public void XoaDoDung()
        {
            if (HamTao.CheckCount(ArrLstDoDung))
            {
                int count = 0;
                int indexMuonXoa;
                Console.WriteLine("Thông tin đồ dùng");
                foreach (var item in arrLstDoDung)
                {
                    DoDac dd = (DoDac)item;
                    Console.WriteLine($"Đồ thứ {count + 1}");
                    dd.InThongTin();
                    count++;
                }
                indexMuonXoa = Convert.ToInt32(HamTao.GetInput("stt muốn xóa"));
                if(indexMuonXoa - 1 >= arrLstDoDung.Count)
                {
                    Console.WriteLine("Đồ bạn nhập không tồn tại");
                    return;
                }
                arrLstDoDung.RemoveAt(indexMuonXoa-1);
                Console.WriteLine("Xóa đồ thành công");
            }
        }
        public void InRa_ThongTinKhachHang()
        {
            Console.WriteLine($"Tên khách hàng: {ten}|" +
                $" Tuổi khách hàng: {tuoi}");
            foreach (var item in arrLstDoDung)
            {
                DoDac dd = (DoDac)item;
                dd.InThongTin();
            }
        }
        public double TongTheTich()
        {
            double sum = 0;
            if (HamTao.CheckCount(arrLstDoDung))
            {
                foreach (var item in arrLstDoDung)
                {
                    DoDac dd = (DoDac)item;
                    sum += dd.TheTich;
                }
            }
            return sum;
        }
    }
}
