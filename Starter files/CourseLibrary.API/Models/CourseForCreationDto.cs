using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models;

public class CourseForCreationDto
{
    [Required(ErrorMessage = "You should fill out a tile")]
    [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters")]
    public string Title { get; set; } = string.Empty;
    
    [MaxLength(1000, ErrorMessage = "The description should have more than 1500 characters")]
    public string? Description { get; set; } = string.Empty;
}

