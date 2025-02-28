namespace PolarisOrder.Domain.Models
{
    public class Cardapio : BaseModel
    {
        public List<Alimento> Alimentos { get; set; } = [];
        public List<Bebida> Bebidas { get; set; } = [];
    }
}