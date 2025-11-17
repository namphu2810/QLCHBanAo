namespace QLCHBanAo.Models
{
    public class TonKhoSP
    {
        public int Id { get; set; }

        public int CuaHang_ID { get; set; }
        public int BienThe_ID { get; set; }

        public int SoLuongTon { get; set; }
        public double DonGia { get; set; }

        public CuaHang CuaHang { get; set; }
        public BienThe BienThe { get; set; }
    }
}

