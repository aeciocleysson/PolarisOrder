namespace PolarisOrder.Domain.Models
{
    public class CategoriaAlimento : BaseModel
    {
        public string Nome { get; set; }
        public List<Alimento> Alimentos { get; set; } = [];
    }
}