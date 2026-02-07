namespace clog_api.Models
{
    public class Postagem
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public int Upvotes { get; private set; }
        public int Downvotes { get; private set; }
        public int UsuarioId { get; private set; }
        public int NichoId { get; private set; }
    }
}
