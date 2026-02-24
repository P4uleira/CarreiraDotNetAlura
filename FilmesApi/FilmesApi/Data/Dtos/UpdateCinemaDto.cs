using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obragatório.")]
    public String Nome { get; set; }
}
