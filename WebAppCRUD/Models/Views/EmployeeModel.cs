using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Models.Views
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required, Display(Name = "Employee No")]
        public required string EmployeeNo { get; set; }
        [Required, Display(Name = "Employee Name")]
        public required string EmployeeName { get; set; }
        [Required]
        public required string Occupation { get; set; }
        [Required]
        public required string Department { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true)]
        [Display(Name ="Hired Date")]
        public required DateOnly HiredDate { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true)]
        public required DateOnly TerminationDate { get; set; }
        [Required, DisplayFormat(ApplyFormatInEditMode = true)]

        [Display(Name ="Date Of Birth")]
        public required DateOnly DOB { get; set; }
        [Display(Name ="Mobile")]
        public required string ContactNumber { get; set; }
        [Display(Name ="Contact Address")]
        public required string ContactAddress { get; set; }
        [Display(Name ="IC Number")]
        public required string ICNumber { get; set; }
        public required string Gender { get; set; }
        public required string Title { get; set; }
        public string? Photo { get; set; }
    }
}
