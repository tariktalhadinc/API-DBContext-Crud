using System.Reflection.Metadata;

namespace PersonalService.Model
{

    public class Personal
    {
        public int Id { get; set; } 

        public string? NationalId { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

    }
}