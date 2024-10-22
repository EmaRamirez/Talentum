namespace talentum.Models
{
    public class activityconsumer
    {
        public activityconsumer() { }

        public int idActivityConsumer{get;set;}
        public int idUser {get;set;}

        public string accion{get;set;}
        public DateTime fechaHora{get;set;}
        public string descripcion {get;set;}
    
    }
}