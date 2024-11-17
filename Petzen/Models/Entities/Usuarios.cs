namespace Petzen.Models.Entities
{
    public class Usuarios : BaseEntity
    {
        public string Name { get; set; }
        public string NumeroTelefone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
