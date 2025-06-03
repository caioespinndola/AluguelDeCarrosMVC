namespace AluguelDeCarrosMVC.Models
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int CarroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Status { get; set; }

        public Carro? Carro { get; set; }
        public WebApplication1.Models.Usuario? Usuario { get; set; }
    }
}