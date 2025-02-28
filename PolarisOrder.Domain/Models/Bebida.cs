namespace PolarisOrder.Domain.Models
{
    public class Bebida : BaseModel
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Quantidade { get; set; }
        public string UrlImagem { get; set; }
        public int CategoriaBebidaId { get; set; }
        public int CardapioId { get; set; }
        public CategoriaBebida CategoriaBebida { get; set; }
        public Cardapio Cardapio { get; set; }
    }
}