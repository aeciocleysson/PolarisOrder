using PolarisOrder.Domain.Enum;

namespace PolarisOrder.Domain.Models
{
    public class Pessoa : BaseModel
    {
        public Pessoa(TipoPessoa eTipoPessoa, string nome)
        {
            ETipoPessoa = eTipoPessoa;
            Nome = nome;
        }

        public TipoPessoa ETipoPessoa { get; set; }
        public string Nome { get; set; }
    }
}