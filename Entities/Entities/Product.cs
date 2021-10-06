using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Product: Base
    {
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Nome")]
        public bool Ativo { get; set; }
    }
}
