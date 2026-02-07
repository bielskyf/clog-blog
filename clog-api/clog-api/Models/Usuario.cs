using System.ComponentModel.DataAnnotations;

namespace clog_api.Models
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        [EmailAddress] public string Email { get; private set; }
        public string Senha { get; private set; }
    }
}
