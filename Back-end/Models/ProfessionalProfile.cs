
namespace talentum.Models
{
    public class ProfessionalProfile
    {
        public ProfessionalProfile()
        {

        }

        public int idProfessionalProfile { get; set; }

        public int idUser { get; set; }
        public string profesion { get; set; }
        public string descripcion { get; set; }
        public string experiencia { get; set; }
        public string formacion { get; set; }
        public string ubicacion { get; set; }
        public enum disponibilidad
        {

        }
        public disponibilidad disponible { get; set; }
        
    }
}