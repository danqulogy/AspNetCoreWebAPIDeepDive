using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models;

public abstract class CourseForManipulationDto: IValidatableObject
{
    [Required(ErrorMessage = "You should fill out a tile")]
    [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters")]
    public string Title { get; set; } = string.Empty;
    
    [MaxLength(1000, ErrorMessage = "The description should not have more than 1500 characters")]
    public virtual string Description { get; set; } = string.Empty;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Title == Description)
        {
            // Yield return means that the result is returned and after which code execution will continue
            yield return new ValidationResult(
                "The provided description should be different from the title.",
                new[] { "Course" });
        }
    }
}