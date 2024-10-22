namespace talentum.Models
{
    public class Notification
    {
        public Notification()
        {

        }
        public int idNotification { get; set; }
        public int idUser { get; set; }
        public string tipoNotificacion { get; set; }
        public string mensaje { get; set; }
        public DateTime fechaEnvio { get; set; }
        public int leido { get; set; }
    }
}