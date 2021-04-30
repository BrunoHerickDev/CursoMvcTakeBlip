using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoMvcTakeBlip.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
