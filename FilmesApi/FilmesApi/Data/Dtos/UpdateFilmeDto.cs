using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O titulo é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genero é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho nao pode ser maior que 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duracao deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
