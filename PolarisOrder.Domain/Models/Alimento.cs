namespace PolarisOrder.Domain.Models
{
    public class Alimento : BaseModel
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Quantidade { get; set; }
        public string UrlImagem { get; set; }
        public int CategoriaAlimentoId { get; set; }
        public int CardapioId { get; set; }
        public CategoriaAlimento CategoriaAlimento { get; set; }
        public Cardapio Cardapio { get; set; }
    }
}