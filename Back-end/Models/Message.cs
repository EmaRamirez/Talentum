

namespace talentum.Models
{
    public class message
    {
        public int idMessage { get; set; }
        public int EmisorId { get; set; }
        public int receptor { get; set; }
        public string text { get; set; }
        public DateTime dateTime { get; set; }
    }
}