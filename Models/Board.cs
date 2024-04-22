using System.ComponentModel.DataAnnotations;

namespace AspCoreBoardProject.Models;

public class Board
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string PostTitle { get; set; }
    [Required]
    public string PostStory { get; set; }

}