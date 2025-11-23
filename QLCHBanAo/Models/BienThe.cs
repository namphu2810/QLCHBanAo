using System.Drawing;

namespace QLCHBanAo.Models
{
    public class BienThe
    {
        public int Id { get; set; }

        public int SanPham_ID { get; set; }
        public int Color_ID { get; set; }
        public int Size_ID { get; set; }
        public int ChatLieu_ID { get; set; }
        public int ThuongHieu_ID { get; set; }

        public string BienTheHinhAnh { get; set; }

        public SanPham? SanPham { get; set; }
        public MauSac? MauSac { get; set; }
        public KichThuoc? KichThuoc { get; set; }
        public ChatLieu? ChatLieu { get; set; }
        public ThuongHieu? ThuongHieu { get; set; }

        public ICollection<TonKhoSP> TonKhoSP { get; set; }
    }
}
