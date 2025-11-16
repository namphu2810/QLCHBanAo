namespace QLCHBanAo.Models
{
    public class NguoiDungCuaHang
    {
        public int Id { get; set; }

        public int NguoiDungId { get; set; }
        public int CuaHangId { get; set; }

        public NguoiDung NguoiDung { get; set; }
        public CuaHang CuaHang { get; set; }
    }
}
