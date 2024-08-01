using eTickets.Data.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movies
    {
        [Key]
        public int id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double Price { get; set; }
        public string? CinemaName { get; set; }
        public string? ImageURL { get; set; }

        public MovieCategory? MovieCategory { get; set; }
        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }

        //Cinema
        public int? CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinemas? Cinemas { get; set; }
        //Producer
        public int? ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
    }
}
