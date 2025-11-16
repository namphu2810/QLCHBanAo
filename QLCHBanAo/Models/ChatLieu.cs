namespace QLCHBanAo.Models
{
    public class ChatLieu
    {
        public int Id { get; set; }
        public string TenChatLieu { get; set; }

        public ICollection<BienThe> BienThe { get; set; }
    }
}
