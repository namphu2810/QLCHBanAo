using Microsoft.AspNetCore.Identity;

namespace QLCHBanAo.Models
{
    public class CuaHang
    {
        public int Id { get; set; }
        public string TenCuaHang { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public ICollection<TonKhoSP> TonKhoSP { get; set; }
        public ICollection<NguoiDungCuaHang> NguoiDungCuaHang { get; set; }
    }
}
