namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int? MovieId { get; set; }
        public Movies? Movie { get; set; }
        public int? ActorId { get; set; }
        public Actor? Actor { get; set; }
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }
    }
}