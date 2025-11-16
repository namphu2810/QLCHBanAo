namespace QLCHBanAo.Models
{
    public class KichThuoc
    {
        public int Id { get; set; }
        public string TenKichThuoc { get; set; }

        public ICollection<BienThe> BienThe { get; set; }
    }
}
