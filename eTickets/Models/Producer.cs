using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string? ProfilePictureURL { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }
        //Relationships
        public List<Movies>? Movie { get; set; }
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}