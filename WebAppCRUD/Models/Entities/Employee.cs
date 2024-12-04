using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Models.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public required string EmployeeNo { get; set; }
        [Required, MaxLength(100)]
        public required string EmployeeName { get; set; }
        [Required, MaxLength(50)]
        public required string Occupation { get; set; }
        [Required, MaxLength(200)]
        public required string Department { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true)]
        public required DateOnly HiredDate { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true)]
        public required DateOnly TerminationDate { get; set; }
        [Required,DisplayFormat(ApplyFormatInEditMode = true)]
        public required DateOnly DOB { get; set; }
        public required string ContactNumber { get; set; }
        public required string ContactAddress { get; set; }
        public required string ICNumber { get; set; }
        public required string Gender { get; set; }
        public required string Title { get; set; }
        public string? Photo { get; set; }
    }
}