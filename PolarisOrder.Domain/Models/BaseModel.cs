using System.ComponentModel.DataAnnotations;

namespace PolarisOrder.Domain.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Atualizacao { get; set; }
        public DateTime Exclusao { get; set; }
        public bool Excluido { get; set; }
        public bool Ativo { get; set; }

        protected BaseModel()
        {
            DataCriacao = DateTime.Now;
            Excluido = false;
            Ativo = true;
        }

        public void Delete()
        {
            Excluido = true;
            Ativo = false;
            Exclusao = DateTime.Now;
        }
    }
}