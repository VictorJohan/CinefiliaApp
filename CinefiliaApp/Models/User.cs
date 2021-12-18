namespace CinefiliaApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Language { get; set; }

        public User()
        {
            Language = "es";
        }
    }
}
