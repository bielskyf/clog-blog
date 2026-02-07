namespace clog_api.Models
{
    public class Comentario
    {
        public int Id { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public int Upvotes { get; private set; }
        public int Downvotes { get; private set; }
        public int UsuarioId { get; private set; }
        public int PostId { get; private set; }
    }
}
