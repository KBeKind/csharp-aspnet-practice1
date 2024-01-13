namespace core_web_app1.Models
{
    public class LoginViewModel
    {
        // THE ? MAKES IT POSSIBLE TO BE NULL
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
