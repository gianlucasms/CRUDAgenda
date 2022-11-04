using System.ComponentModel.DataAnnotations;

namespace CrudLL.Models
{
    public class TabelaBd
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo idade é obrigatorio")]
        public int? Idade { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo telefone é obrigatorio")]
        [StringLength(11, ErrorMessage = "O campo telefone deve conter entre 10 - 11 caracteres", MinimumLength = 10)]
        public string? Telefone { get; set; }
    }
}
