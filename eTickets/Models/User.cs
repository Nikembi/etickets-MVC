using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName {  get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full Name must be between 2 and 100 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }




    }
}
