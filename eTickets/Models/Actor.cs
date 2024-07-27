using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [DataType(DataType.ImageUrl)]
        public string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full Name must be between 2 and 100 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000, ErrorMessage = "Bio cannot exceed 1000 characters")]
        public string Bio { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [NotMapped]
        public int Age => DateOfBirth.HasValue
            ? DateTime.Today.Year - DateOfBirth.Value.Year
            : 0;

        // Relationships
        public virtual ICollection<Actor_Movie> Actor_Movies { get; set; }

        public Actor()
        {
            Actor_Movies = new List<Actor_Movie>();
        }
    }
}