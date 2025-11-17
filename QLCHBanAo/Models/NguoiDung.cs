namespace QLCHBanAo.Models
{
    public class NguoiDung
    {
        public int Id { get; set; }

        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string TenNguoiDung { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTao { get; set; }
        public string SoDienThoai { get; set; }
        public bool HoatDong { get; set; }

        // Quyền hạn : 0 - Admin, 1 - Quản lý, 2 - Nhân viên
        public int QuyenHan { get; set; }

        public ICollection<NguoiDungCuaHang> NguoiDungCuaHang { get; set; }
    }
}
