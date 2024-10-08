﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinemas
    {
        [Key]
        public int Id { get; set; }
        public string? logo { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<Movies>? Movies { get; set; }
    }
}
