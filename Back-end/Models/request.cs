

namespace talentum.Models
{
    public class request
    {
        public request()
        {

        }
        public int idrequest { get; set; }

        public int idPerfilProfesional { get; set; }
        public int idConsumidor { get; set; }
        public DateTime fechaSolicitud { get; set; }

        public enum solicitud
        {

        }
        public solicitud estadoSolicitud{get;set;}

        public string decripcionTrabajo{get;set;}

    }
}