namespace QLCHBanAo.Models
{
    public class SanPham
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }

        public ICollection<BienThe> BienThe { get; set; }
    }
}
