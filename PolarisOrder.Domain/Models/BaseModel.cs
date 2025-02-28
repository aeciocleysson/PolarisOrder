using System.ComponentModel.DataAnnotations;

namespace PolarisOrder.Domain.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Atualizacao { get; set; }

        protected BaseModel()
        {
            DataCriacao = DateTime.Now;
        }
    }
}