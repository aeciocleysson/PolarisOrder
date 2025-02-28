namespace PolarisOrder.Domain.Models
{
    public class Mesa : BaseModel
    {
        public string Nome { get; set; }
        public string QrCode { get; set; }
    }
}