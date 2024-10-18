namespace talentum.Models
{
    public class user
    {
        public user()
        {

        }
        public user(string name, string lastname, string email, string password, TypeUser type, DateTime date)
        {
            this.name = name;
            this.lastName = lastname;
            this.email = email;
            this.password = password;
            this.typeUser = type;
            this.dateRegister = date;

        }
        public int userId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public enum TypeUser
        {
            candidato,
            consumidor
        }
        public TypeUser typeUser { get; set; }
        public DateTime dateRegister { get; set; }

        //public int mensajeId {get;set;}
    }
}