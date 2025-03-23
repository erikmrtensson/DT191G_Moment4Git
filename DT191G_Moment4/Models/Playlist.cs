using System.ComponentModel.DataAnnotations;


namespace DT191G_Moment4.Models;

public class Playlist
{
    // Properties
    public int Id { get; set; }

    [Required(ErrorMessage = "Ange en artist")]
    public string? Artist { get; set; }

    [Required(ErrorMessage = "Ange en låttitel")]
    public string? Title { get; set; }

    public int Length { get; set; }

    public string? Category { get; set; }
}