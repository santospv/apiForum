using System.ComponentModel.DataAnnotations;

namespace apiForum.Models
{
    public class Cathegory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage="Este campo não pode ter mais do que 100 caracteres")]
        [MinLength(1, ErrorMessage="Este campo deve ser preenchido")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage="Este campo não pode ter mais do que 500 caracteres")]
        [MinLength(1, ErrorMessage="Este campo deve ser preenchido")]
        public string Description { get; set; }
    }
}