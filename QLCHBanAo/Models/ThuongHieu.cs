namespace QLCHBanAo.Models
{
    public class ThuongHieu
    {
        public int Id { get; set; }
        public string TenThuongHieu { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }

        public ICollection<BienThe> BienThe { get; set; }
    }
}
