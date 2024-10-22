
namespace talentum.Models
{
    public class testimony
    {
        public testimony()
        {

        }
        public int idtestimony { get; set; }
        public int userId { get; set; }
        public string contenido { get; set; }
        public DateTime fechaCreacion { get; set; }
        
    }
}