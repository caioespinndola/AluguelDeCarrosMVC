namespace WebApplication1.Models
{
    public class SuporteMensagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}