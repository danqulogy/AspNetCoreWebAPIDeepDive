namespace CourseLibrary.API.Models
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } =String.Empty;

        public DateTimeOffset DateOfBirth { get; set; }
        public int Age { get; set; }
        public string MainCategory { get; set; } = string.Empty;

        public ICollection<CourseForCreationDto> Courses {  get; set; } = new List<CourseForCreationDto>(); 


    }
}
