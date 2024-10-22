namespace talentum.Models
{
    public class ratingReview
    {
        public ratingReview()
        {

        }
        public int idRatingReview { get; set; }

        public int idProfessionalProfile { get; set; }

        public int idConsumidor { get; set; }
        public int puntuacion { get; set; }
        public string comentario { get; set; }
        public DateTime fechaReseña { get; set; }
    }
}