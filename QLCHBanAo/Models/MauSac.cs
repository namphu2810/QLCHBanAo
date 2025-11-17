namespace QLCHBanAo.Models
{
    public class MauSac
    {
        public int Id { get; set; }
        public string TenMau { get; set; }

        public ICollection<BienThe> BienThe { get; set; }
    }
}
