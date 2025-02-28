namespace PolarisOrder.Domain.Models
{
    public class CategoriaBebida : BaseModel
    {
        public string Nome { get; set; }
        public List<Bebida> Bebidas { get; set; } = [];
    }
}