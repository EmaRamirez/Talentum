
namespace talentum.Models
{
    public class Skills
    {
        public Skills()
        {

        }

        public int idSkills { get; set; }

        public int idProfessionalProfile { get; set; }
        public string nombreHabilidad { get; set; }
        public enum nivelCompetencia
        {

        }

        public nivelCompetencia nivel { get; set; }
    }
}