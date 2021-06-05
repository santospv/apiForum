using System.ComponentModel.DataAnnotations;

namespace apiForum.Models
{
    public class Subcathegory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage="Este campo não pode ter mais do que 100 caracteres")]
        [MinLength(1, ErrorMessage="Este campo deve ser preenchido")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage="Categoria é obrigatório")]
        public Cathegory Cathegory { get; set; }
    }
}