namespace AluguelDeCarrosMVC.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public bool Disponivel { get; set; }
    }
}