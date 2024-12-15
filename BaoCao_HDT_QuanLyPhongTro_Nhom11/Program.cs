using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_HDT_QuanLyPhongTro_Nhom11
{
    //Phòng trọ
    public class PhongTro
    {
        public int MaPhongTro { get; set; }
        public int MaLoaiPhong { get; set; }
        public string TenPhong { get; set; }
        public string TrangThai { get; set; }
        public int SoNguoiDangThue { get; set; }
        public List<DichVu> DichVus { get; set; }
        public decimal DienTich { get; set; }
        public decimal GiaPhong { get; set; }
        public DateTime? NgayBatDauChoThue { get; set; }
        public string GhiChu { get; set; }

        public LoaiPhong LoaiPhong { get; set; }
        public List<KhachTro> KhachTros { get; set; }
        public ChuPhong ChuPhongs { get; set; }
        public List<ChiSoDienNuoc> ChiSoDienNuocs { get; set; }
        public List<HopDong> HopDongs { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }
    //Khách trọ
    public class KhachTro
    {
        public int MaKhachTro { get; set; }
        public int MaPhongTro { get; set; }
        public string HoTenKhachTro { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int CCCD { get; set; }
        public int SDT { get; set; }
        public string QueQuan { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string QuanHeVoiChuPhong { get; set; }
        public DateTime NgayBatDauThuePhong { get; set; }
        public DateTime? NgayKetThucThuePhong { get; set; }
        public string GhiChu { get; set; }

        public PhongTro PhongTro { get; set; }
    }

    //Chủ phòng
    public class ChuPhong
    {
        public int MaChuPhong { get; set; }
        public int MaPhongTro { get; set; }
        public string HoTenChuPhong { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int CCCD { get; set; }
        public int SDT { get; set; }
        public string QueQuan { get; set; }
        public string DiaChiThuongTru { get; set; }
        public DateTime NgayBatDauThuePhong { get; set; }
        public DateTime? NgayKetThucThuePhong { get; set; }
        public string GhiChu { get; set; }

        public PhongTro PhongTro { get; set; }
    }

    //Loại phòng
    public class LoaiPhong
    {
        public int MaLoaiPhong { get; set; }
        public decimal DienTich { get; set; }
        public int SoNguoiToiDa { get; set; }
        public decimal GiaThuePhong { get; set; }
        public string TienNghi { get; set; }
        public string GhiChu { get; set; }

        public List<PhongTro> PhongTros { get; set; }
    }

    //Chỉ số điện nước
    public class ChiSoDienNuoc
    {
        public int MaChiSoDienNuoc { get; set; }
        public int MaCapNhatGia { get; set; }
        public int MaPhongTro { get; set; }
        public int ChiSoDienCu { get; set; }
        public int ChiSoDienMoi { get; set; }
        public decimal DonGiaDienHienTai { get; set; }
        public string DonViTinh { get; set; }
        public decimal ThanhTienDien { get; set; }
        public int ChiSoNuocCu { get; set; }
        public int ChiSoNuocMoi { get; set; }
        public decimal DonGiaNuocHienTai { get; set; }
        public decimal ThanhTienNuoc { get; set; }
        public DateTime NgayCapNhatGia { get; set; }
        public DateTime NgayGhiNhan { get; set; }
        public string GhiChu { get; set; }

        public PhongTro PhongTro { get; set; }
        public CapNhatGiaDienNuoc CapNhatGiaDienNuoc { get; set; }
    }

    //Cập nhật giá điện nước
    public class CapNhatGiaDienNuoc
    {
        public int MaCapNhatGia { get; set; }
        public decimal DonGiaDienMoi { get; set; }
        public decimal DonGiaNuocMoi { get; set; }
        public string DonViTinh { get; set; }
        public DateTime NgayApDungGiaMoi { get; set; }
        public string NguoiCapNhat { get; set; }
        public string GhiChu { get; set; }

        public List<ChiSoDienNuoc> ChiSoDienNuocs { get; set; }
    }

    //Dịch vụ
    public class DichVu
    {
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGiaDichVu { get; set; }
        public string DonViTinh { get; set; }
        public DateTime NgayCapNhatGia { get; set; }
        public string GhiChu { get; set; }

        public PhongTro PhongTro { get; set; }
    }

    //Thanh toán
    public class ThanhToan
    {
        public int MaThanhToan { get; set; }
        public int MaHoaDon { get; set; }
        public decimal SoTienThanhToan { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string NguoiThanhToan { get; set; }
        public string TinhTrangThanhToan { get; set; }
        public string GhiChu { get; set; }

        public HoaDon HoaDon { get; set; }
    }

    //Hóa đơn
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaPhongTro { get; set; }
        public int MaChuPhong { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public decimal TongTienHoaDon { get; set; }
        public DateTime? NgayThanhToanHoaDon { get; set; }
        public string TrangThaiThanhToanHoaDon { get; set; }
        public string GhiChu { get; set; }

        public PhongTro PhongTro { get; set; }
        public ChuPhong ChuPhong { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }

    //Chi tiết hóa đơn
    public class ChiTietHoaDon
    {
        public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public int MaChiSoDienNuoc { get; set; }
        public decimal ThanhTienDien { get; set; }
        public decimal ThanhTienNuoc { get; set; }
        public List<DichVu> DanhSachDichVu { get; set; }
        public decimal TongTienDichVu { get; set; }
        public decimal TongTienHoaDon { get; set; }
        public DateTime NgayGhiNhan { get; set; }
        public string GhiChu { get; set; }

        public HoaDon HoaDon { get; set; }
        public ChiSoDienNuoc ChiSoDienNuoc { get; set; }
    }

    //Hợp đồng
    public class HopDong
    {
        public int MaHopDong { get; set; }
        public int MaPhongTro { get; set; }
        public int MaChuPhong { get; set; }
        public int? MaKhachTro { get; set; }
        public DateTime NgayBatDauHopDong { get; set; }
        public DateTime NgayKetThucHopDong { get; set; }
        public int ThoiHanHopDong { get; set; }
        public decimal TienCoc { get; set; }
        public string DieuKhoanHopDong { get; set; }
        public string TrangThaiHopDong { get; set; }
        public bool GiaHanHopDong { get; set; }
        public DateTime? NgayGiaHanHopDong { get; set; }
        public string GhiChu { get; set; }

        public PhongTro PhongTro { get; set; }
        public ChuPhong ChuPhong { get; set; }
        public KhachTro KhachTro { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }

    public class QuanLyPhongTroDBContext
    {
        public List<PhongTro> PhongTros { get; set; }
        public List<KhachTro> KhachTros { get; set; }
        public List<ChuPhong> ChuPhongs { get; set; }
        public List<LoaiPhong> LoaiPhongs { get; set; }
        public List<ChiSoDienNuoc> ChiSoDienNuocs { get; set; }
        public List<CapNhatGiaDienNuoc> CapNhatGiaDienNuocs { get; set; }
        public List<DichVu> DichVus { get; set; }
        public List<ThanhToan> ThanhToans { get; set; }
        public List<HoaDon> HoaDons { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public List<HopDong> HopDongs { get; set; }

        public QuanLyPhongTroDBContext()
        {
            //Giả lập dữ liệu
            SeederData();
        }

        /*private void SeederData()
        {
            SeederData();
        }*/

        private void SeederData()
        {
            DichVus = new List<DichVu>
            {
                // Dịch vụ Rác
                new DichVu
                {
                    MaDichVu = 1,
                    TenDichVu = "Rác",
                    DonGiaDichVu = 50000, // Đơn giá dịch vụ rác
                    DonViTinh = "VND/tháng",
                    NgayCapNhatGia = new DateTime(2024, 12, 1),
                    GhiChu = "Dịch vụ thu gom rác cho phòng trọ.",
                },

                // Dịch vụ Internet
                new DichVu
                {
                    MaDichVu = 2,
                    TenDichVu = "Internet",
                    DonGiaDichVu = 200000, // Đơn giá dịch vụ internet
                    DonViTinh = "VND/tháng",
                    NgayCapNhatGia = new DateTime(2024, 12, 1),
                    GhiChu = "Dịch vụ Internet tốc độ cao cho phòng trọ.",
                },

                // Dịch vụ An ninh
                new DichVu
                {
                    MaDichVu = 3,
                    TenDichVu = "An ninh",
                    DonGiaDichVu = 100000, // Đơn giá dịch vụ an ninh
                    DonViTinh = "VND/tháng",
                    NgayCapNhatGia = new DateTime(2024, 12, 1),
                    GhiChu = "Dịch vụ bảo vệ, an ninh cho khu vực phòng trọ.",
                },

                // Dịch vụ Giặt ủi
                new DichVu
                {
                    MaDichVu = 4,
                    TenDichVu = "Giặt ủi",
                    DonGiaDichVu = 50000, // Đơn giá dịch vụ giặt ủi
                    DonViTinh = "VND/kg",
                    NgayCapNhatGia = new DateTime(2024, 12, 1),
                    GhiChu = "Dịch vụ giặt ủi cho các phòng trọ.",
                }
            };

            LoaiPhongs = new List<LoaiPhong>
            {
                new LoaiPhong
                {
                    MaLoaiPhong = 1,
                    DienTich = 15.0m,
                    SoNguoiToiDa = 2,
                    GiaThuePhong = 2000000m,
                    TienNghi = "Giường, Tủ, Quạt, WiFi",
                    GhiChu = "Phòng nhỏ phù hợp cho 1-2 người."
                },
                new LoaiPhong
                {
                    MaLoaiPhong = 2,
                    DienTich = 20.0m,
                    SoNguoiToiDa = 3,
                    GiaThuePhong = 3000000m,
                    TienNghi = "Giường, Tủ, Quạt, Điều hòa, WiFi",
                    GhiChu = "Phòng rộng hơn, có điều hòa."
                },
                new LoaiPhong
                {
                    MaLoaiPhong = 3,
                    DienTich = 30.0m,
                    SoNguoiToiDa = 5,
                    GiaThuePhong = 4000000m,
                    TienNghi = "Giường, Tủ, Quạt, Điều hòa, WiFi, Ban công, Máy nước nóng",
                    GhiChu = "Phòng cao cấp, nhiều tiện nghi."
                }
            };

            PhongTros = new List<PhongTro>
            {
                // Phòng 101
                new PhongTro
                {
                    MaPhongTro = 1,
                    MaLoaiPhong = 2,
                    TenPhong = "Phòng 101",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 2,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 101 sử dụng dịch vụ Rác, Internet và An ninh
                        DichVus[0], // Rác
                        DichVus[1], // Internet
                        DichVus[2], // An ninh
                    },
                    DienTich = 20m,
                    GiaPhong = 3000000,
                    NgayBatDauChoThue = new DateTime(2023, 1, 10),
                    GhiChu = "Phòng gần cửa sổ"
                },

                // Phòng 102
                new PhongTro
                {
                    MaPhongTro = 2,
                    MaLoaiPhong = 2,
                    TenPhong = "Phòng 102",
                    TrangThai = "Trống",
                    SoNguoiDangThue = 0,
                    DienTich = 20m,
                    GiaPhong = 3000000,
                    NgayBatDauChoThue = null, //new DateTime(2023, 2, 15),
                    GhiChu = "Phòng có view đẹp"
                },

                // Phòng 103
                new PhongTro
                {
                    MaPhongTro = 3,
                    MaLoaiPhong = 2,
                    TenPhong = "Phòng 103",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 1,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 103 sử dụng dịch vụ Rác và An ninh
                        DichVus[0], // Rác
                        DichVus[2], // An ninh
                    },
                    DienTich = 20m,
                    GiaPhong = 3000000,
                    NgayBatDauChoThue = new DateTime(2023, 3, 1),
                    GhiChu = "Phòng có ban công"
                },

                // Phòng 104
                new PhongTro
                {
                    MaPhongTro = 4,
                    MaLoaiPhong = 1,
                    TenPhong = "Phòng 104",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 2,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 104 sử dụng dịch vụ Rác, Internet và Giặt ủi
                        DichVus[0], // Rác
                        DichVus[1], // Internet
                        DichVus[3], // Giặt ủi
                    },
                    DienTich = 15m,
                    GiaPhong = 2000000,
                    NgayBatDauChoThue = new DateTime(2023, 4, 10),
                    GhiChu = "Phòng thoáng mát"
                },

                // Phòng 105
                new PhongTro
                {
                    MaPhongTro = 5,
                    MaLoaiPhong = 1,
                    TenPhong = "Phòng 105",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 1,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 105 sử dụng dịch vụ Rác, Internet
                        DichVus[0], // Rác
                        DichVus[1], // Internet
                    },
                    DienTich = 15m,
                    GiaPhong = 2000000,
                    NgayBatDauChoThue = new DateTime(2023, 5, 20),
                    GhiChu = "Phòng Sạch đẹp"
                },

                // Phòng 106
                new PhongTro
                {
                    MaPhongTro = 6,
                    MaLoaiPhong = 1,
                    TenPhong = "Phòng 106",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 1,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 106 sử dụng dịch vụ Rác, Internet và An ninh
                        DichVus[0], // Rác
                        DichVus[1], // Internet
                        DichVus[2], // An ninh
                    },
                    DienTich = 15m,
                    GiaPhong = 2000000,
                    NgayBatDauChoThue = new DateTime(2023, 6, 1),
                    GhiChu = "Phòng sơn mới, sạch đẹp"
                },

                // Phòng 107
                new PhongTro
                {
                    MaPhongTro = 7,
                    MaLoaiPhong = 3,
                    TenPhong = "Phòng 107",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 3,
                     DichVus = new List<DichVu>
                     {
                         // Phòng 107 sử dụng dịch vụ Rác và Internet
                        DichVus[0], // Rác
                        DichVus[1], // Internet
                     },
                    DienTich = 30m,
                    GiaPhong = 4000000,
                    NgayBatDauChoThue = new DateTime(2023, 7, 5),
                    GhiChu = "Phòng gần cầu thang"
                },

                // Phòng 108
                new PhongTro
                {
                    MaPhongTro = 8,
                    MaLoaiPhong = 3,
                    TenPhong = "Phòng 108",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 5,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 108 sử dụng dịch vụ Rác, Internet và Giặt ủi
                        DichVus[0], // Rác
                        DichVus[1], // Internet
                        DichVus[3], // Giặt ủi
                    },
                    DienTich = 30m,
                    GiaPhong = 4000000,
                    NgayBatDauChoThue = new DateTime(2023, 8, 10),
                    GhiChu = "Phòng trang trí đẹp"
                },

                // Phòng 109
                new PhongTro
                {
                    MaPhongTro = 9,
                    MaLoaiPhong = 3,
                    TenPhong = "Phòng 109",
                    TrangThai = "Đang cho thuê",
                    SoNguoiDangThue = 4,
                    DichVus = new List<DichVu>
                    {
                        // Phòng 109 sử dụng dịch vụ Rác và An ninh
                        DichVus[0], // Rác
                        DichVus[2], // An ninh
                    },
                    DienTich = 30m,
                    GiaPhong = 4000000,
                    NgayBatDauChoThue = new DateTime(2023, 9, 15),
                    GhiChu = "Phòng mới, sạch sẽ, thoáng mát"
                },

                // Phòng 110
                new PhongTro
                {
                    MaPhongTro = 10,
                    MaLoaiPhong = 3,
                    TenPhong = "Phòng 110",
                    TrangThai = "Đang bảo trì",
                    SoNguoiDangThue = 0,
                    DienTich = 30m,
                    GiaPhong = 4000000,
                    NgayBatDauChoThue = null, //new DateTime(2023, 10, 1),
                    GhiChu = "Phòng đang sửa chữa hệ thống điện"
                }
            };

            ChuPhongs = new List<ChuPhong>
            {
                // Phòng 101: Có 2 người đang thuê, người chủ phòng là người dọn vào đầu tiên.
                new ChuPhong
                {
                    MaChuPhong = 1,
                    MaPhongTro = 1,
                    HoTenChuPhong = "Nguyễn Văn A",
                    NgaySinh = new DateTime(1990, 5, 12),
                    GioiTinh = "Nam",
                    CCCD = 000534956790,
                    SDT = 0987654321,
                    QueQuan = "Hà Nội",
                    DiaChiThuongTru = "123 Nguyễn Trãi, Hà Nội",
                    NgayBatDauThuePhong = new DateTime(2023, 1, 10),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng đầu tiên của phòng 101"
                },

                // Phòng 102: Không có người thuê.

                // Phòng 103: Có 1 người đang thuê, người đó là chủ phòng.
                new ChuPhong
                {
                    MaChuPhong = 3,
                    MaPhongTro = 3,
                    HoTenChuPhong = "Trần Thị B",
                    NgaySinh = new DateTime(1995, 10, 8),
                    GioiTinh = "Nữ",
                    CCCD = 000223344556,
                    SDT = 0912345678,
                    QueQuan = "Hải Phòng",
                    DiaChiThuongTru = "45 Lạch Tray, Hải Phòng",
                    NgayBatDauThuePhong = new DateTime(2023, 3, 1),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng duy nhất của phòng 103"
                },

                // Phòng 104: Có 2 người đang thuê, người chủ phòng là người dọn vào đầu tiên.
                new ChuPhong
                {
                    MaChuPhong = 4,
                    MaPhongTro = 4,
                    HoTenChuPhong = "Lê Văn C",
                    NgaySinh = new DateTime(1988, 7, 20),
                    GioiTinh = "Nam",
                    CCCD = 000334455667,
                    SDT = 0901234567,
                    QueQuan = "Quảng Ninh",
                    DiaChiThuongTru = "56 Đường Bãi Cháy, Quảng Ninh",
                    NgayBatDauThuePhong = new DateTime(2023, 4, 10),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng đầu tiên của phòng 104"
                },

                // Phòng 105: Có 1 người đang thuê, người đó là chủ phòng.
                new ChuPhong
                {
                    MaChuPhong = 5,
                    MaPhongTro = 5,
                    HoTenChuPhong = "Phạm Thị D",
                    NgaySinh = new DateTime(1993, 2, 14),
                    GioiTinh = "Nữ",
                    CCCD = 000445566778,
                    SDT = 0921234567,
                    QueQuan = "Đà Nẵng",
                    DiaChiThuongTru = "78 Hùng Vương, Đà Nẵng",
                    NgayBatDauThuePhong = new DateTime(2023, 5, 20),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng duy nhất của phòng 105"
                },

                // Phòng 106: Có 1 người đang thuê, người đó là chủ phòng.
                new ChuPhong
                {
                    MaChuPhong = 6,
                    MaPhongTro = 6,
                    HoTenChuPhong = "Nguyễn Văn E",
                    NgaySinh = new DateTime(1998, 11, 3),
                    GioiTinh = "Nam",
                    CCCD = 000556677889,
                    SDT = 0931234567,
                    QueQuan = "Hồ Chí Minh",
                    DiaChiThuongTru = "123 Lê Lợi, Hồ Chí Minh",
                    NgayBatDauThuePhong = new DateTime(2023, 6, 1),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng duy nhất của phòng 106"
                },

                // Phòng 107: Có 3 người đang thuê, người chủ phòng là người dọn vào đầu tiên.
                new ChuPhong
                {
                    MaChuPhong = 7,
                    MaPhongTro = 7,
                    HoTenChuPhong = "Trần Văn F",
                    NgaySinh = new DateTime(1985, 3, 22),
                    GioiTinh = "Nam",
                    CCCD = 000667788990,
                    SDT = 0941234567,
                    QueQuan = "Bình Dương",
                    DiaChiThuongTru = "45 Đại lộ Bình Dương, Bình Dương",
                    NgayBatDauThuePhong = new DateTime(2023, 7, 5),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng đầu tiên của phòng 107"
                },

                // Phòng 108: Có 5 người đang thuê, người chủ phòng là người dọn vào đầu tiên.
                new ChuPhong
                {
                    MaChuPhong = 8,
                    MaPhongTro = 8,
                    HoTenChuPhong = "Phạm Văn G",
                    NgaySinh = new DateTime(1991, 6, 18),
                    GioiTinh = "Nam",
                    CCCD = 000778899001,
                    SDT = 0951234567,
                    QueQuan = "Cần Thơ",
                    DiaChiThuongTru = "89 Nguyễn An Ninh, Cần Thơ",
                    NgayBatDauThuePhong = new DateTime(2023, 8, 10),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng đầu tiên của phòng 108"
                },

                // Phòng 109: Có 4 người đang thuê, người chủ phòng là người dọn vào đầu tiên.
                new ChuPhong
                {
                    MaChuPhong = 9,
                    MaPhongTro = 9,
                    HoTenChuPhong = "Lê Thị H",
                    NgaySinh = new DateTime(1994, 4, 9),
                    GioiTinh = "Nữ",
                    CCCD = 000889900112,
                    SDT = 0961234567,
                    QueQuan = "An Giang",
                    DiaChiThuongTru = "12 Trần Phú, An Giang",
                    NgayBatDauThuePhong = new DateTime(2023, 9, 15),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Chủ phòng đầu tiên của phòng 109"
                }

                // Phòng 110: Không có người thuê, không cần dữ liệu.
            };

            KhachTros = new List<KhachTro>
            {
                // Phòng 101: Có 2 người đang thuê, 1 người là chủ phòng, người còn lại là khách trọ.
                new KhachTro
                {
                    MaKhachTro = 1,
                    MaPhongTro = 1,
                    HoTenKhachTro = "Nguyễn Thị Y",
                    NgaySinh = new DateTime(1992, 8, 15),
                    GioiTinh = "Nữ",
                    CCCD = 000456789123,
                    SDT = 0918765432,
                    QueQuan = "Thái Bình",
                    DiaChiThuongTru = "32 Lý Thường Kiệt, Thái Bình",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 2, 1),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ của phòng 101"
                },

                // Phòng 103: Có 1 người đang thuê
                // Phòng 104: Có 2 người đang thuê, 1 người là chủ phòng, người còn lại là khách trọ.
                new KhachTro
                {
                    MaKhachTro = 2,
                    MaPhongTro = 4,
                    HoTenKhachTro = "Phạm Văn Z",
                    NgaySinh = new DateTime(1990, 12, 5),
                    GioiTinh = "Nam",
                    CCCD = 000567890234,
                    SDT = 0923456789,
                    QueQuan = "Thanh Hóa",
                    DiaChiThuongTru = "75 Phố Lê Lợi, Thanh Hóa",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 4, 15),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ của phòng 104"
                },

                // Phòng 105: Có 1 người đang thuê
                // Phòng 106: Có 1 người đang thuê
                // Phòng 107: Có 3 người đang thuê, 1 người là chủ phòng, 2 người còn lại là khách trọ.
                new KhachTro
                {
                    MaKhachTro = 3,
                    MaPhongTro = 7,
                    HoTenKhachTro = "Lê Thị Q",
                    NgaySinh = new DateTime(1997, 3, 12),
                    GioiTinh = "Nữ",
                    CCCD = 000678901345,
                    SDT = 0934567890,
                    QueQuan = "Hà Tĩnh",
                    DiaChiThuongTru = "23 Đường Trần Phú, Hà Tĩnh",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 7, 10),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ nhất của phòng 107"
                },
                new KhachTro
                {
                    MaKhachTro = 4,
                    MaPhongTro = 7,
                    HoTenKhachTro = "Ngô Văn R",
                    NgaySinh = new DateTime(1994, 11, 8),
                    GioiTinh = "Nam",
                    CCCD = 000789012456,
                    SDT = 0945678901,
                    QueQuan = "Nghệ An",
                    DiaChiThuongTru = "45 Đường Lý Tự Trọng, Nghệ An",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 7, 15),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ hai của phòng 107"
                },

                // Phòng 108: Có 5 người đang thuê, 1 người là chủ phòng, 4 người còn lại là khách trọ.
                new KhachTro
                {
                    MaKhachTro = 5,
                    MaPhongTro = 8,
                    HoTenKhachTro = "Trần Văn S",
                    NgaySinh = new DateTime(1993, 9, 25),
                    GioiTinh = "Nam",
                    CCCD = 000890123567,
                    SDT = 0956789012,
                    QueQuan = "Kiên Giang",
                    DiaChiThuongTru = "67 Đường Nguyễn Huệ, Kiên Giang",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 8, 12),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ nhất của phòng 108"
                },
                new KhachTro
                {
                    MaKhachTro = 6,
                    MaPhongTro = 8,
                    HoTenKhachTro = "Nguyễn Thị T",
                    NgaySinh = new DateTime(1996, 1, 30),
                    GioiTinh = "Nữ",
                    CCCD = 000901234678,
                    SDT = 0967890123,
                    QueQuan = "Cà Mau",
                    DiaChiThuongTru = "89 Đường CMT8, Cà Mau",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 8, 15),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ hai của phòng 108"
                },
                new KhachTro
                {
                    MaKhachTro = 7,
                    MaPhongTro = 8,
                    HoTenKhachTro = "Lê Văn U",
                    NgaySinh = new DateTime(1992, 6, 19),
                    GioiTinh = "Nam",
                    CCCD = 000012345789,
                    SDT = 0978901234,
                    QueQuan = "Đồng Tháp",
                    DiaChiThuongTru = "12 Đường Hòa Bình, Đồng Tháp",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 8, 18),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ ba của phòng 108"
                },
                new KhachTro
                {
                    MaKhachTro = 8,
                    MaPhongTro = 8,
                    HoTenKhachTro = "Phạm Thị V",
                    NgaySinh = new DateTime(1990, 4, 7),
                    GioiTinh = "Nữ",
                    CCCD = 000123456890,
                    SDT = 0989012345,
                    QueQuan = "Sóc Trăng",
                    DiaChiThuongTru = "34 Đường Phạm Ngũ Lão, Sóc Trăng",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 8, 20),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ tư của phòng 108"
                },

                // Phòng 109: Có 4 người đang thuê, 1 người là chủ phòng, 3 người còn lại là khách trọ.
                new KhachTro
                {
                    MaKhachTro = 9,
                    MaPhongTro = 9,
                    HoTenKhachTro = "Nguyễn Thị W",
                    NgaySinh = new DateTime(1989, 5, 28),
                    GioiTinh = "Nữ",
                    CCCD = 000234567891,
                    SDT = 0990123456,
                    QueQuan = "Vĩnh Long",
                    DiaChiThuongTru = "23 Đường Phạm Văn Đồng, Vĩnh Long",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 9, 20),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ nhất của phòng 109"
                },
                new KhachTro
                {
                    MaKhachTro = 10,
                    MaPhongTro = 9,
                    HoTenKhachTro = "Trần Văn X",
                    NgaySinh = new DateTime(1997, 12, 4),
                    GioiTinh = "Nam",
                    CCCD = 000345678902,
                    SDT = 0900123456,
                    QueQuan = "Hậu Giang",
                    DiaChiThuongTru = "56 Đường Hùng Vương, Hậu Giang",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 9, 25),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ hai của phòng 109"
                },
                new KhachTro
                {
                    MaKhachTro = 11,
                    MaPhongTro = 9,
                    HoTenKhachTro = "Lê Thị Y",
                    NgaySinh = new DateTime(1995, 10, 15),
                    GioiTinh = "Nữ",
                    CCCD = 000456789013,
                    SDT = 0911123456,
                    QueQuan = "Bạc Liêu",
                    DiaChiThuongTru = "89 Đường Nguyễn Văn Cừ, Bạc Liêu",
                    QuanHeVoiChuPhong = "Bạn cùng thuê",
                    NgayBatDauThuePhong = new DateTime(2023, 9, 30),
                    NgayKetThucThuePhong = null,
                    GhiChu = "Khách trọ thứ ba của phòng 109"
                }
            };

            CapNhatGiaDienNuocs = new List<CapNhatGiaDienNuoc>
            {
                new CapNhatGiaDienNuoc
                {
                    MaCapNhatGia = 1,
                    DonGiaDienMoi = 3500,
                    DonGiaNuocMoi = 15000,
                    DonViTinh = "VND/KWh, VND/m3",
                    NgayApDungGiaMoi = new DateTime(2024, 6, 1),
                    NguoiCapNhat = "Nguyễn Văn A",
                    GhiChu = "Cập nhật giá điện và nước hàng tháng."
                },
                new CapNhatGiaDienNuoc
                {
                    MaCapNhatGia = 2,
                    DonGiaDienMoi = 4000,
                    DonGiaNuocMoi = 16000,
                    DonViTinh = "VND/KWh, VND/m3",
                    NgayApDungGiaMoi = new DateTime(2024, 10, 1),
                    NguoiCapNhat = "Trần Thị B",
                    GhiChu = "Tăng giá điện và nước do thay đổi chính sách."
                }
            };

            ChiSoDienNuocs = new List<ChiSoDienNuoc>
            {
                //Phòng 101 (Có 2 người đang ở)
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 1,
                    MaCapNhatGia = 2, // Áp dụng từ ngày 1/10/2024
                    MaPhongTro = 1,
                    ChiSoDienCu = 50, // Chỉ số điện từ tháng trước
                    ChiSoDienMoi = 80, // Chỉ số điện hiện tại
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (80 - 50) * 4000, // (80 - 50) * 4,000 = 120,000 VND
                    ChiSoNuocCu = 15, // Chỉ số nước từ tháng trước
                    ChiSoNuocMoi = 20, // Chỉ số nước hiện tại
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (20 - 15) * 16000, // (20 - 15) * 16,000 = 80,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 101"
                },

                //Phòng 103 (Có 1 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 2,
                    MaCapNhatGia = 2,
                    MaPhongTro = 3,
                    ChiSoDienCu = 60, // Chỉ số điện từ tháng trước
                    ChiSoDienMoi = 90, // Chỉ số điện hiện tại
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (90 - 60) * 4000, // (90 - 60) * 4,000 = 120,000 VND
                    ChiSoNuocCu = 10, // Chỉ số nước từ tháng trước
                    ChiSoNuocMoi = 15, // Chỉ số nước hiện tại
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (15 - 10) * 16000, // (15 - 10) * 16,000 = 80,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 103"
                },

                //Phòng 104 (Có 2 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 3,
                    MaCapNhatGia = 2,
                    MaPhongTro = 4,
                    ChiSoDienCu = 100,
                    ChiSoDienMoi = 140,
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (140 - 100) * 4000, // 40 * 4,000 = 160,000 VND
                    ChiSoNuocCu = 25,
                    ChiSoNuocMoi = 35,
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (35 - 25) * 16000, // 10 * 16,000 = 160,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 104"
                },

                //Phòng 105 (Có 2 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 4,
                    MaCapNhatGia = 2,
                    MaPhongTro = 5,
                    ChiSoDienCu = 80, // Chỉ số điện từ tháng trước
                    ChiSoDienMoi = 120, // Chỉ số điện hiện tại
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (120 - 80) * 4000, // (120 - 80) * 4,000 = 160,000 VND
                    ChiSoNuocCu = 20, // Chỉ số nước từ tháng trước
                    ChiSoNuocMoi = 30, // Chỉ số nước hiện tại
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (30 - 20) * 16000, // (30 - 20) * 16,000 = 160,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 105"
                },

                //Phòng 106 (Có 3 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 5,
                    MaCapNhatGia = 2,
                    MaPhongTro = 6,
                    ChiSoDienCu = 110, // Chỉ số điện từ tháng trước
                    ChiSoDienMoi = 160, // Chỉ số điện hiện tại
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (160 - 110) * 4000, // (160 - 110) * 4,000 = 200,000 VND
                    ChiSoNuocCu = 25, // Chỉ số nước từ tháng trước
                    ChiSoNuocMoi = 40, // Chỉ số nước hiện tại
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (40 - 25) * 16000, // (40 - 25) * 16,000 = 240,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 106"
                },

                //Phòng 107 (Có 3 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 6,
                    MaCapNhatGia = 2,
                    MaPhongTro = 7,
                    ChiSoDienCu = 150,
                    ChiSoDienMoi = 200,
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (200 - 150) * 4000, // 50 * 4,000 = 200,000 VND
                    ChiSoNuocCu = 30,
                    ChiSoNuocMoi = 45,
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (45 - 30) * 16000, // 15 * 16,000 = 240,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 107"
                },

                //Phòng 108 (Có 5 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 7,
                    MaCapNhatGia = 2,
                    MaPhongTro = 8,
                    ChiSoDienCu = 200,
                    ChiSoDienMoi = 280,
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (280 - 200) * 4000, // 80 * 4,000 = 320,000 VND
                    ChiSoNuocCu = 50,
                    ChiSoNuocMoi = 75,
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (75 - 50) * 16000, // 25 * 16,000 = 400,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 108"
                },
                
                //Phòng 109 (Có 4 người đang ở):
                new ChiSoDienNuoc
                {
                    MaChiSoDienNuoc = 8,
                    MaCapNhatGia = 2,
                    MaPhongTro = 9,
                    ChiSoDienCu = 180,
                    ChiSoDienMoi = 250,
                    DonGiaDienHienTai = 4000,
                    DonViTinh = "VND/KWh, VND/m3",
                    ThanhTienDien = (250 - 180) * 4000, // 70 * 4,000 = 280,000 VND
                    ChiSoNuocCu = 40,
                    ChiSoNuocMoi = 60,
                    DonGiaNuocHienTai = 16000,
                    ThanhTienNuoc = (60 - 40) * 16000, // 20 * 16,000 = 320,000 VND
                    NgayCapNhatGia = new DateTime(2024, 10, 1),
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Ghi nhận chỉ số điện nước cho phòng 109"
                }

            };

            ChiTietHoaDons = new List<ChiTietHoaDon>
            {
                // Phòng 101
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 1,
                    MaHoaDon = 1, // ID hóa đơn của phòng 101
                    MaChiSoDienNuoc = 1,
                    ThanhTienDien = 120000, // Từ dữ liệu chỉ số điện nước phòng 101
                    ThanhTienNuoc = 80000,  // Từ dữ liệu chỉ số điện nước phòng 101
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 2, DonGiaDichVu = 200000 }, // Internet
                        new DichVu { MaDichVu = 3, DonGiaDichVu = 100000 }  // An ninh
                    },
                    TongTienDichVu = 350000, // Tổng tiền dịch vụ
                    TongTienHoaDon = 3000000 + 120000 + 80000 + 350000, // Giá phòng 3,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 101"
                },

                // Phòng 103
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 2,
                    MaHoaDon = 2,
                    MaChiSoDienNuoc = 2,
                    ThanhTienDien = 120000,
                    ThanhTienNuoc = 80000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 3, DonGiaDichVu = 100000 }  // An ninh
                    },
                    TongTienDichVu = 150000,
                    TongTienHoaDon = 3000000 + 120000 + 80000 + 150000, // Giá phòng 3,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 103"
                },

                // Phòng 104
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 3,
                    MaHoaDon = 3,
                    MaChiSoDienNuoc = 3,
                    ThanhTienDien = 160000,
                    ThanhTienNuoc = 160000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 2, DonGiaDichVu = 200000 }, // Internet
                        new DichVu { MaDichVu = 4, DonGiaDichVu = 50000 }  // Giặt ủi
                    },
                    TongTienDichVu = 300000,
                    TongTienHoaDon = 2000000 + 160000 + 160000 + 300000, // Giá phòng 2,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 104"
                },

                // Phòng 105
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 4,
                    MaHoaDon = 4,
                    MaChiSoDienNuoc = 4,
                    ThanhTienDien = 160000,
                    ThanhTienNuoc = 160000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 2, DonGiaDichVu = 200000 }  // Internet
                    },
                    TongTienDichVu = 250000,
                    TongTienHoaDon = 2000000 + 160000 + 160000 + 250000, // Giá phòng 2,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 105"
                },

                // Phòng 106
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 5,
                    MaHoaDon = 5,
                    MaChiSoDienNuoc = 5,
                    ThanhTienDien = 200000,
                    ThanhTienNuoc = 240000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 2, DonGiaDichVu = 200000 }, // Internet
                        new DichVu { MaDichVu = 3, DonGiaDichVu = 100000 }  // An ninh
                    },
                    TongTienDichVu = 350000,
                    TongTienHoaDon = 2000000 + 200000 + 240000 + 350000, // Giá phòng 2,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 106"
                },

                // Phòng 107
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 6,
                    MaHoaDon = 6,
                    MaChiSoDienNuoc = 6,
                    ThanhTienDien = 200000,
                    ThanhTienNuoc = 240000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 2, DonGiaDichVu = 200000 }  // Internet
                    },
                    TongTienDichVu = 250000,
                    TongTienHoaDon = 4000000 + 200000 + 240000 + 250000, // Giá phòng 4,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 107"
                },

                // Phòng 108
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 7,
                    MaHoaDon = 7,
                    MaChiSoDienNuoc = 7,
                    ThanhTienDien = 320000,
                    ThanhTienNuoc = 400000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 2, DonGiaDichVu = 200000 }, // Internet
                        new DichVu { MaDichVu = 4, DonGiaDichVu = 50000 }  // Giặt ủi
                    },
                    TongTienDichVu = 300000,
                    TongTienHoaDon = 4000000 + 320000 + 400000 + 300000, // Giá phòng 4,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 108"
                },

                // Phòng 109
                new ChiTietHoaDon
                {
                    MaChiTietHoaDon = 8,
                    MaHoaDon = 8,
                    MaChiSoDienNuoc = 8,
                    ThanhTienDien = 280000,
                    ThanhTienNuoc = 320000,
                    DanhSachDichVu = new List<DichVu>
                    {
                        new DichVu { MaDichVu = 1, DonGiaDichVu = 50000 }, // Rác
                        new DichVu { MaDichVu = 3, DonGiaDichVu = 100000 }  // An ninh
                    },
                    TongTienDichVu = 150000,
                    TongTienHoaDon = 4000000 + 280000 + 320000 + 150000, // Giá phòng 4,000,000 + điện + nước + dịch vụ
                    NgayGhiNhan = new DateTime(2024, 12, 1),
                    GhiChu = "Hóa đơn tháng 11 cho phòng 109"
                }
            };

            HoaDons = new List<HoaDon>
            {
                // Hóa đơn cho Phòng 101
                new HoaDon
                {
                    MaHoaDon = 1,
                    MaPhongTro = 1,
                    MaChuPhong = 1,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 3550000,
                    NgayThanhToanHoaDon = new DateTime(2024, 12, 5),
                    TrangThaiThanhToanHoaDon = "Đã thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 101",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 1),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 1).ToList()
                },
                // Hóa đơn cho Phòng 103
                new HoaDon
                {
                    MaHoaDon = 2,
                    MaPhongTro = 3,
                    MaChuPhong = 2,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 3350000,
                    NgayThanhToanHoaDon = new DateTime(2024, 12, 8),
                    TrangThaiThanhToanHoaDon = "Đã thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 103",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 3),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 2).ToList()
                },
                // Hóa đơn cho Phòng 104
                new HoaDon
                {
                    MaHoaDon = 3,
                    MaPhongTro = 4,
                    MaChuPhong = 3,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 2620000,
                    NgayThanhToanHoaDon = null,
                    TrangThaiThanhToanHoaDon = "Chưa thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 104",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 4),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 3).ToList()
                },
                // Hóa đơn cho Phòng 105
                new HoaDon
                {
                    MaHoaDon = 4,
                    MaPhongTro = 5,
                    MaChuPhong = 4,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 2570000,
                    NgayThanhToanHoaDon = new DateTime(2024, 12, 10),
                    TrangThaiThanhToanHoaDon = "Đã thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 105",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 5),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 4).ToList()
                },
                // Hóa đơn cho Phòng 106
                new HoaDon
                {
                    MaHoaDon = 5,
                    MaPhongTro = 6,
                    MaChuPhong = 5,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 2890000,
                    NgayThanhToanHoaDon = null,
                    TrangThaiThanhToanHoaDon = "Chưa thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 106",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 6),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 5).ToList()
                },
                // Hóa đơn cho Phòng 107
                new HoaDon
                {
                    MaHoaDon = 6,
                    MaPhongTro = 7,
                    MaChuPhong = 6,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 4490000,
                    NgayThanhToanHoaDon = new DateTime(2024, 12, 15),
                    TrangThaiThanhToanHoaDon = "Đã thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 107",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 7),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 6).ToList()
                },
                // Hóa đơn cho Phòng 108
                new HoaDon
                {
                    MaHoaDon = 7,
                    MaPhongTro = 8,
                    MaChuPhong = 7,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 5020000,
                    NgayThanhToanHoaDon = new DateTime(2024, 12, 20),
                    TrangThaiThanhToanHoaDon = "Đã thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 108",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 8),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 7).ToList()
                },
                // Hóa đơn cho Phòng 109
                new HoaDon
                {
                    MaHoaDon = 8,
                    MaPhongTro = 9,
                    MaChuPhong = 8,
                    NgayLapHoaDon = new DateTime(2024, 12, 1),
                    TongTienHoaDon = 4750000,
                    NgayThanhToanHoaDon = null,
                    TrangThaiThanhToanHoaDon = "Chưa thanh toán",
                    GhiChu = "Hóa đơn tháng 11 cho phòng 109",
                    PhongTro = PhongTros.First(p => p.MaPhongTro == 9),
                    ChiTietHoaDons = ChiTietHoaDons.Where(c => c.MaHoaDon == 8).ToList()
                }
            };

            ThanhToans = new List<ThanhToan>
            {
                // Thanh toán cho Phòng 101
                new ThanhToan
                {
                    MaThanhToan = 1,
                    MaHoaDon = 1,
                    SoTienThanhToan = 3550000,
                    NgayThanhToan = new DateTime(2024, 12, 5),
                    HinhThucThanhToan = "Chuyển khoản",
                    NguoiThanhToan = "Nguyễn Văn A",
                    TinhTrangThanhToan = "Đã thanh toán",
                    GhiChu = "Thanh toán đủ vào ngày 05/12",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 1)
                },
                // Thanh toán cho Phòng 103
                new ThanhToan
                {
                    MaThanhToan = 2,
                    MaHoaDon = 2,
                    SoTienThanhToan = 3350000,
                    NgayThanhToan = new DateTime(2024, 12, 8),
                    HinhThucThanhToan = "Tiền mặt",
                    NguoiThanhToan = "Lê Thị B",
                    TinhTrangThanhToan = "Đã thanh toán",
                    GhiChu = "Thanh toán trực tiếp vào ngày 8/12",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 2)
                },
                // Thanh toán cho Phòng 104
                new ThanhToan
                {
                    MaThanhToan = 3,
                    MaHoaDon = 3,
                    SoTienThanhToan = 2620000,
                    NgayThanhToan = null,
                    HinhThucThanhToan = "Chưa thanh toán",
                    NguoiThanhToan = "",
                    TinhTrangThanhToan = "Chưa thanh toán",
                    GhiChu = "",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 3)
                },
                // Thanh toán cho Phòng 105
                new ThanhToan
                {
                    MaThanhToan = 4,
                    MaHoaDon = 4,
                    SoTienThanhToan = 2570000,
                    NgayThanhToan = new DateTime(2024, 12, 10),
                    HinhThucThanhToan = "Chuyển khoản",
                    NguoiThanhToan = "Trần Văn C",
                    TinhTrangThanhToan = "Đã thanh toán",
                    GhiChu = "Thanh toán đủ vào ngày 10/12",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 4)
                },
                // Thanh toán cho Phòng 106
                new ThanhToan
                {
                    MaThanhToan = 5,
                    MaHoaDon = 5,
                    SoTienThanhToan = 2890000,
                    NgayThanhToan = null,
                    HinhThucThanhToan = "Chưa thanh toán",
                    NguoiThanhToan = "",
                    TinhTrangThanhToan = "Chưa thanh toán",
                    GhiChu = "",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 5)
                },
                // Thanh toán cho Phòng 107
                new ThanhToan
                {
                    MaThanhToan = 6,
                    MaHoaDon = 6,
                    SoTienThanhToan = 4490000,
                    NgayThanhToan = new DateTime(2024, 12, 15),
                    HinhThucThanhToan = "Tiền mặt",
                    NguoiThanhToan = "Phạm Thị D",
                    TinhTrangThanhToan = "Đã thanh toán",
                    GhiChu = "Thanh toán trực tiếp vào ngày 15/12",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 6)
                },
                // Thanh toán cho Phòng 108
                new ThanhToan
                {
                    MaThanhToan = 7,
                    MaHoaDon = 7,
                    SoTienThanhToan = 5020000,
                    NgayThanhToan = new DateTime(2024, 12, 20),
                    HinhThucThanhToan = "Chuyển khoản",
                    NguoiThanhToan = "Nguyễn Văn E",
                    TinhTrangThanhToan = "Đã thanh toán",
                    GhiChu = "Thanh toán đủ vào ngày 20/12",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 7)
                },
                // Thanh toán cho Phòng 109
                new ThanhToan
                {
                    MaThanhToan = 8,
                    MaHoaDon = 8,
                    SoTienThanhToan = 4750000,
                    NgayThanhToan = null,
                    HinhThucThanhToan = "Chưa thanh toán",
                    NguoiThanhToan = "",
                    TinhTrangThanhToan = "Chưa thanh toán",
                    GhiChu = "",
                    HoaDon = HoaDons.First(h => h.MaHoaDon == 8)
                }
            };

            HopDongs = new List<HopDong>
            {
                // Phòng 101: 2 người (1 chủ phòng, 1 khách trọ)
                new HopDong
                {
                    MaHopDong = 1,
                    MaPhongTro = 101,
                    MaChuPhong = 1, //Chủ Phòng 101
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 1, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 12,
                    TienCoc = 3000000,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 101",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của chủ phòng 101"
                },
                new HopDong
                {
                    MaHopDong = 2,
                    MaPhongTro = 101,
                    MaChuPhong = 1, //Chủ Phòng 101
                    MaKhachTro = 1, //Khách trọ 1
                    NgayBatDauHopDong = new DateTime(2024, 1, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 101",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của khách trọ phòng 101"
                },

                // Phòng 103: 1 người (chỉ có chủ phòng)
                new HopDong
                {
                    MaHopDong = 3,
                    MaPhongTro = 103,
                    MaChuPhong = 3, //Chủ Phòng 103
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 2, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 11,
                    TienCoc = 3000000,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 103",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của chủ phòng 103"
                },

                // Phòng 104: 2 người (1 chủ phòng, 1 khách trọ)
                new HopDong
                {
                    MaHopDong = 4,
                    MaPhongTro = 104,
                    MaChuPhong = 4, //Chủ Phòng 104
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 3, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 10,
                    TienCoc = 2000000,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 104",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của chủ phòng 104"
                },
                new HopDong
                {
                    MaHopDong = 5,
                    MaPhongTro = 104,
                    MaChuPhong = 4, //Chủ Phòng 104
                    MaKhachTro = 2, //Khách trọ 1
                    NgayBatDauHopDong = new DateTime(2024, 3, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 10,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 104",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của khách trọ phòng 104"
                },

                // Phòng 105: 1 người (chỉ có chủ phòng)
                new HopDong
                {
                    MaHopDong = 6,
                    MaPhongTro = 105,
                    MaChuPhong = 5, // Chủ phòng  105
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 4, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 9,
                    TienCoc = 2000000,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 105",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của chủ phòng 105"
                },

                // Phòng 106: 1 người (chỉ có chủ phòng)
                new HopDong
                {
                    MaHopDong = 7,
                    MaPhongTro = 106,
                    MaChuPhong = 6,  // Chủ phòng  106
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 5, 1),
                    NgayKetThucHopDong = new DateTime(2024, 12, 31),
                    ThoiHanHopDong = 8,
                    TienCoc = 2000000,
                    DieuKhoanHopDong = "Điều khoản hợp đồng phòng 106",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của chủ phòng 106"
                },

                //Phòng 107: Số người ở là 3 (1 chủ phòng, 2 khách trọ)
                new HopDong
                {
                    MaHopDong = 8,
                    MaPhongTro = 107,
                    MaChuPhong = 7, // Chủ phòng  107
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 8, 1),
                    NgayKetThucHopDong = new DateTime(2025, 8, 1),
                    ThoiHanHopDong = 12, // 12 tháng
                    TienCoc = 4000000,
                    DieuKhoanHopDong = "Không được gây tiếng ồn, giữ gìn vệ sinh chung.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng dành cho chủ phòng."
                },
                new HopDong
                {
                    MaHopDong = 9,
                    MaPhongTro = 107,
                    MaChuPhong = 7, // Chủ phòng 107
                    MaKhachTro = 3, // Khách trọ 1
                    NgayBatDauHopDong = new DateTime(2024, 8, 1),
                    NgayKetThucHopDong = new DateTime(2025, 8, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Không được gây tiếng ồn, giữ gìn vệ sinh chung.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách trọ 1."
                },
                new HopDong
                {
                    MaHopDong = 10,
                    MaPhongTro = 107,
                    MaChuPhong = 7, // Chủ phòng 107
                    MaKhachTro = 4, // Khách trọ 2
                    NgayBatDauHopDong = new DateTime(2024, 8, 1),
                    NgayKetThucHopDong = new DateTime(2025, 8, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Không được gây tiếng ồn, giữ gìn vệ sinh chung.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách trọ 2."
                },

                //Phòng 108: Số người ở là 5 (1 chủ phòng, 4 khách trọ)
                new HopDong
                {
                    MaHopDong = 11,
                    MaPhongTro = 108,
                    MaChuPhong = 8,
                    MaKhachTro = null, // Chủ phòng 108
                    NgayBatDauHopDong = new DateTime(2024, 9, 1),
                    NgayKetThucHopDong = new DateTime(2025, 9, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 4000000,
                    DieuKhoanHopDong = "Không được gây tiếng ồn, giữ gìn vệ sinh chung.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng dành cho chủ phòng."
                },
                new HopDong
                {
                    MaHopDong = 12,
                    MaPhongTro = 108,
                    MaChuPhong = 8, // Chủ phòng 108
                    MaKhachTro = 5, //Khách trọ 1
                    NgayBatDauHopDong = new DateTime(2024, 9, 1),
                    NgayKetThucHopDong = new DateTime(2025, 9, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Khách thuê liên quan đến chủ phòng.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là người thân của chủ phòng.",
                },
                new HopDong
                {
                    MaHopDong = 13,
                    MaPhongTro = 108,
                    MaChuPhong = 8, // Chủ phòng 108
                    MaKhachTro = 6, //Khách trọ 2
                    NgayBatDauHopDong = new DateTime(2024, 9, 1),
                    NgayKetThucHopDong = new DateTime(2025, 9, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Khách thuê liên quan đến chủ phòng.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là người thân của chủ phòng.",
                },
                new HopDong
                {
                    MaHopDong = 14,
                    MaPhongTro = 108,
                    MaChuPhong = 8, // Chủ phòng 108
                    MaKhachTro = 7, //Khách trọ 3
                    NgayBatDauHopDong = new DateTime(2024, 9, 1),
                    NgayKetThucHopDong = new DateTime(2025, 9, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Khách thuê liên quan đến chủ phòng.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là người thân của chủ phòng.",
                },
                new HopDong
                {
                    MaHopDong = 15,
                    MaPhongTro = 108,
                    MaChuPhong = 8, // Chủ phòng 108
                    MaKhachTro = 8, //Khách trọ 4
                    NgayBatDauHopDong = new DateTime(2024, 9, 1),
                    NgayKetThucHopDong = new DateTime(2025, 9, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Khách thuê liên quan đến chủ phòng.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là bạn của chủ phòng.",
                },
                
                //Phòng 109: Số người ở là 4 (1 chủ phòng, 3 khách trọ)
                new HopDong
                {
                    MaHopDong = 16,
                    MaPhongTro = 109,
                    MaChuPhong = 9, // Chủ phòng 109
                    MaKhachTro = null,
                    NgayBatDauHopDong = new DateTime(2024, 10, 1),
                    NgayKetThucHopDong = new DateTime(2025, 10, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 4000000,
                    DieuKhoanHopDong = "Chủ phòng là người ký hợp đồng chính.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Hợp đồng của chủ phòng.",
                },
                new HopDong
                {
                    MaHopDong = 17,
                    MaPhongTro = 109,
                    MaChuPhong = 9, // Chủ phòng 109
                    MaKhachTro = 9, //Khách trọ 1
                    NgayBatDauHopDong = new DateTime(2024, 10, 1),
                    NgayKetThucHopDong = new DateTime(2025, 10, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Khách thuê liên quan đến chủ phòng.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là bạn bè của chủ phòng.",
                },
                new HopDong
                {
                    MaHopDong = 18,
                    MaPhongTro = 109,
                    MaChuPhong = 9, // Chủ phòng 109
                    MaKhachTro = 10, //Khách trọ 2
                    NgayBatDauHopDong = new DateTime(2024, 10, 1),
                    NgayKetThucHopDong = new DateTime(2025, 10, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Khách thuê liên quan đến chủ phòng.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là bạn bè của chủ phòng.",
                },
                new HopDong
                {
                    MaHopDong = 19,
                    MaPhongTro = 109,
                    MaChuPhong = 9, // Chủ phòng 109
                    MaKhachTro = 11, //Khách trọ 3
                    NgayBatDauHopDong = new DateTime(2024, 10, 1),
                    NgayKetThucHopDong = new DateTime(2025, 10, 1),
                    ThoiHanHopDong = 12,
                    TienCoc = 0,
                    DieuKhoanHopDong = "Không được gây tiếng ồn, giữ gìn vệ sinh chung.",
                    TrangThaiHopDong = "Hiệu lực",
                    GiaHanHopDong = false,
                    NgayGiaHanHopDong = null,
                    GhiChu = "Khách thuê là bạn bè của chủ phòng.",
                },
            };

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                QuanLyPhongTroDBContext dbContext = new QuanLyPhongTroDBContext();

                // 1. Lọc các phòng trọ đang cho thuê
                var roomsForRent = dbContext.PhongTros.Where(p => p.TrangThai == "Đang cho thuê").ToList();
                Console.WriteLine("1.Phòng đang cho thuê: " + string.Join(", ", roomsForRent.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 2. Lọc các phòng có diện tích lớn hơn 20m²
                var largeRooms = dbContext.PhongTros.Where(p => p.DienTich > 20).ToList();
                Console.WriteLine("2.Phòng có diện tích lớn hơn 20m²: " + string.Join(", ", largeRooms.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 3. Tìm phòng có giá thuê cao nhất
                // Tìm giá phòng cao nhất
                var maxPrice = dbContext.PhongTros.Max(p => p.GiaPhong);
                //Lọc tất cả các phòng có giá thuê bằng với giá cao nhất
                var maxPriceRooms = dbContext.PhongTros.Where(p => p.GiaPhong == maxPrice).ToList();
                //In ra tên các phòng và giá thuê
                Console.WriteLine("3.Phòng có giá thuê cao nhất:");
                foreach (var room in maxPriceRooms)
                {
                    Console.WriteLine($"Phòng: {room.TenPhong}, Giá: {room.GiaPhong}");
                }
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 4. Liệt kê các dịch vụ cho phòng 101
                var room101Services = dbContext.PhongTros.First(p => p.MaPhongTro == 1).DichVus;
                Console.WriteLine("4.Dịch vụ của Phòng 101: " + string.Join(", ", room101Services.Select(d => d.TenDichVu)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 5. Tìm phòng có số người thuê nhiều nhất
                var maxTenantRoom = dbContext.PhongTros.OrderByDescending(p => p.SoNguoiDangThue).FirstOrDefault();
                Console.WriteLine($"5.Phòng có số người thuê nhiều nhất: {maxTenantRoom.TenPhong}, Số người thuê: {maxTenantRoom.SoNguoiDangThue}");
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 6. Lọc các phòng có giá thuê dưới 3 triệu
                var cheapRooms = dbContext.PhongTros.Where(p => p.GiaPhong < 3000000).ToList();
                Console.WriteLine("6.Phòng có giá dưới 3 triệu: " + string.Join(", ", cheapRooms.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 7. Lọc các dịch vụ mà phòng 105 sử dụng
                var room105Services2 = dbContext.PhongTros.First(p => p.MaPhongTro == 5).DichVus;
                Console.WriteLine("7.Dịch vụ của Phòng 105: " + string.Join(", ", room105Services2.Select(d => d.TenDichVu)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 8. Tìm phòng có ghi chú chứa từ khóa "sạch"
                var cleanRooms = dbContext.PhongTros.Where(p => p.GhiChu.Contains("sạch")).ToList();
                Console.WriteLine("8.Phòng có ghi chú chứa từ 'sạch': " + string.Join(", ", cleanRooms.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 9. Sắp xếp phòng theo diện tích từ lớn đến nhỏ
                var roomsBySizeDesc = dbContext.PhongTros.OrderByDescending(p => p.DienTich).ToList();
                Console.WriteLine("9.Phòng sắp xếp theo diện tích (từ lớn đến nhỏ): " + string.Join(", ", roomsBySizeDesc.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 10. Tính tổng diện tích các phòng
                var totalArea = dbContext.PhongTros.Sum(p => p.DienTich);
                Console.WriteLine($"10.Tổng diện tích các phòng: {totalArea} m²");
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 11. Lọc các phòng có giá thuê dưới 3 triệu và đang cho thuê
                var cheapRoomsForRent = dbContext.PhongTros.Where(p => p.GiaPhong < 3000000 && p.TrangThai == "Đang cho thuê").ToList();
                Console.WriteLine("11.Phòng dưới 3 triệu và đang cho thuê: " + string.Join(", ", cheapRoomsForRent.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 12. Tìm phòng có diện tích lớn hơn 25m²
                var roomsLargerThan25m2 = dbContext.PhongTros.Where(p => p.DienTich > 25).ToList();
                Console.WriteLine("12.Phòng có diện tích lớn hơn 25m²: " + string.Join(", ", roomsLargerThan25m2.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 13. Lọc các hợp đồng đang hiệu lực
                // Danh sách các phòng trọ có hóa đơn chưa thanh toán và tiền điện lớn hơn 100.000 VND

                var phongTroChuaThanhToanVaTienDienLon100k = from hd in dbContext.HoaDons
                                                             join cs in dbContext.ChiSoDienNuocs on hd.MaPhongTro equals cs.MaPhongTro
                                                             where hd.TrangThaiThanhToanHoaDon == "Chưa thanh toán" && cs.ThanhTienDien > 100000
                                                             select hd.MaPhongTro;
                Console.WriteLine("\n13.Danh sách các phòng trọ có hóa đơn chưa thanh toán và tiền điện lớn hơn 100.000 VND:");
                foreach (var maPhong in phongTroChuaThanhToanVaTienDienLon100k)
                {
                    Console.WriteLine($"Phòng trọ: {maPhong}");
                }
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 14. Lọc các hợp đồng có tiền cọc từ 1 triệu trở lên
                var contractsWithDepositOver1Million = dbContext.HopDongs.Where(hd => hd.TienCoc >= 1000000).ToList();
                Console.WriteLine("14.Hợp đồng có tiền cọc từ 1 triệu trở lên: " + string.Join(", ", contractsWithDepositOver1Million.Select(h => h.MaHopDong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 15. Lọc phòng trọ có diện tích nhỏ hơn 20m²
                var smallRooms = dbContext.PhongTros.Where(p => p.DienTich < 20).ToList();
                Console.WriteLine("15.Phòng diện tích dưới 20m²: " + string.Join(", ", smallRooms.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 16. Tìm phòng có số người thuê nhiều nhất
                var mostOccupiedRoom = dbContext.PhongTros.OrderByDescending(p => p.SoNguoiDangThue).FirstOrDefault();
                Console.WriteLine($"16.Phòng có số người thuê nhiều nhất: {mostOccupiedRoom.TenPhong}, Số người thuê: {mostOccupiedRoom.SoNguoiDangThue}");
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 17. Liệt kê các hợp đồng hết hạn trong tháng 12
                var contractsEndingInDecember = dbContext.HopDongs.Where(hd => hd.NgayKetThucHopDong.Month == 12).ToList();
                Console.WriteLine("17.Hợp đồng hết hạn trong tháng 12: " + string.Join(", ", contractsEndingInDecember.Select(h => h.MaHopDong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 18. Lọc các dịch vụ có giá dưới 100.000 VND
                var cheapServices = dbContext.DichVus.Where(d => d.DonGiaDichVu < 100000).ToList();
                Console.WriteLine("18.Dịch vụ có giá dưới 100.000 VND: " + string.Join(", ", cheapServices.Select(d => d.TenDichVu)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 19. Tìm phòng trọ có giá thuê cao nhất
                var highestPriceRoom = dbContext.PhongTros.OrderByDescending(p => p.GiaPhong).FirstOrDefault();
                Console.WriteLine($"19.Phòng có giá thuê cao nhất: {highestPriceRoom.TenPhong}, Giá: {highestPriceRoom.GiaPhong}");
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 20. Liệt kê các hợp đồng có thời hạn trên 12 tháng
                var longTermContracts = dbContext.HopDongs.Where(hd => hd.ThoiHanHopDong > 10).ToList();
                Console.WriteLine("20.Hợp đồng có thời hạn trên 10 tháng: " + string.Join(", ", longTermContracts.Select(h => h.MaHopDong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 21. Tìm khách trọ có ngày sinh trước năm 1990
                var tenantsBornBefore1990 = dbContext.KhachTros.Where(kh => kh.NgaySinh.Year < 1990).ToList();
                Console.WriteLine("21.Khách trọ sinh trước năm 1990: " + string.Join(", ", tenantsBornBefore1990.Select(k => k.HoTenKhachTro)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 22. Liệt kê các phòng có giá thuê dưới 2 triệu và đang trống
                var roomsUnder2Million = dbContext.PhongTros.Where(p => p.GiaPhong <= 3000000 && p.TrangThai == "Trống").ToList();
                Console.WriteLine("22.Phòng dưới 3 triệu và trống: " + string.Join(", ", roomsUnder2Million.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 23. Tính tổng số khách trọ của tất cả các phòng
                var totalTenantsInRooms = dbContext.PhongTros.Sum(p => p.SoNguoiDangThue);
                Console.WriteLine($"23.Tổng số khách trọ: {totalTenantsInRooms}");
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 24. Lọc phòng trọ có diện tích từ 15m² đến 25m²
                var mediumSizeRooms2 = dbContext.PhongTros.Where(p => p.DienTich >= 15 && p.DienTich <= 25).ToList();
                Console.WriteLine("24.Phòng diện tích từ 15m² đến 25m²: " + string.Join(", ", mediumSizeRooms2.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 25. Lọc phòng trọ có ghi chú chứa từ khóa "mới"
                var newRooms = dbContext.PhongTros.Where(p => p.GhiChu.Contains("mới")).ToList();
                Console.WriteLine("25.Phòng có ghi chú chứa từ 'mới': " + string.Join(", ", newRooms.Select(p => p.TenPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 26. Tìm phòng trọ có diện tích lớn nhất
                // Tìm diện tích lớn nhất
                var maxArea = dbContext.PhongTros.Max(p => p.DienTich);
                // Lọc tất cả các phòng có diện tích bằng với diện tích lớn nhất
                var largestRooms = dbContext.PhongTros.Where(p => p.DienTich == maxArea).ToList();
                // In ra tên các phòng và diện tích
                Console.WriteLine("26.Phòng có diện tích lớn nhất:");
                foreach (var room in largestRooms)
                {
                    Console.WriteLine($"Phòng: {room.TenPhong}, Diện tích: {room.DienTich}");
                }
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 27. Tìm các hợp đồng có trạng thái "Hiệu lực" và tiền cọc > 0
                var activeContractsWithDeposit = dbContext.HopDongs.Where(hd => hd.TrangThaiHopDong == "Hiệu lực" && hd.TienCoc >= 3000000).ToList();
                Console.WriteLine("27.Hợp đồng đang có hiệu lực và có tiền cọc >= 3.000.000: " + string.Join(", ", activeContractsWithDeposit.Select(h => h.MaHopDong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                // 28. Liệt kê các chủ phòng có số điện thoại bắt đầu với "09"
                var landlordsWithPhone09 = dbContext.ChuPhongs
                .Where(c => c.SDT.ToString().PadLeft(10, '0').StartsWith("09"))
                .ToList();

                Console.WriteLine("28.Chủ phòng có số điện thoại bắt đầu với '09': " + string.Join(", ", landlordsWithPhone09.Select(c => c.HoTenChuPhong)));
                Console.WriteLine("\n----------------------------------------------------------------\n");

                //29. Danh sách chi tiết về các phòng trọ, bao gồm thông tin hóa đơn, tổng tiền dịch vụ và khách trọ
                var thongTinPhongTro = from pt in dbContext.PhongTros
                                       join hd in dbContext.HoaDons on pt.MaPhongTro equals hd.MaPhongTro
                                       join cthd in dbContext.ChiTietHoaDons on hd.MaHoaDon equals cthd.MaHoaDon
                                       join kt in dbContext.KhachTros on pt.MaPhongTro equals kt.MaPhongTro
                                       join dv in dbContext.DichVus on pt.MaPhongTro equals dv.PhongTro
                                       select new
                                       {
                                           TenPhong = pt.TenPhong,
                                           TongTienHoaDon = hd.TongTienHoaDon,
                                           TongTienDichVu = cthd.TongTienDichVu,
                                           TenKhachTro = kt.HoTenKhachTro,
                                           TenDichVu = dv.TenDichVu
                                       };

                Console.WriteLine("\n29. Thông tin chi tiết phòng trọ:");
                foreach (var info in thongTinPhongTro)
                {
                    Console.WriteLine($"Phòng: {info.TenPhong}, Tổng hóa đơn: {info.TongTienHoaDon}, " +
                                      $"Tổng dịch vụ: {info.TongTienDichVu}, Khách trọ: {info.TenKhachTro}, Dịch vụ: {info.TenDichVu}");
                }

                //30. Tổng hợp số lượng dịch vụ và tổng tiền dịch vụ cho mỗi phòng trọ

                var tongDichVuTheoPhong = from pt in dbContext.PhongTros
                                          join dv in dbContext.DichVus on pt.MaPhongTro equals dv.PhongTro
                                          group dv by new { pt.MaPhongTro, pt.TenPhong } into g
                                          select new
                                          {
                                              MaPhong = g.Key.MaPhongTro,
                                              TenPhong = g.Key.TenPhong,
                                              SoLuongDichVu = g.Count(),
                                              TongTienDichVu = g.Sum(x => x.DonGiaDichVu)
                                          };

                Console.WriteLine("\n30. Tổng hợp dịch vụ và tiền dịch vụ cho mỗi phòng trọ:");
                foreach (var info in tongDichVuTheoPhong)
                {
                    Console.WriteLine($"Phòng: {info.TenPhong}, Số lượng dịch vụ: {info.SoLuongDichVu}, Tổng tiền dịch vụ: {info.TongTienDichVu}");
                }


                Console.ReadKey();

            }
        }
    }
}
