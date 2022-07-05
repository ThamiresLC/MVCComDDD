using System.ComponentModel.DataAnnotations;

namespace WebMVCComDDD.Application.ViewsModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }

        [Display (Name = "Nome")]
        [MaxLength (30, ErrorMessage = "Tamanho máximo de 30 caracteres.")]
        [Required(ErrorMessage = "Nome obrigatorio.")]
        public string Nome { get; set; }

        [Display(Name = "Marca")]
        [MaxLength(30, ErrorMessage = "Tamanho máximo de 30 caracteres.")]
        public string Marca { get; set; }
    }
}
