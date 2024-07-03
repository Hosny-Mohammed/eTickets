using eTickets.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key] public int MovieId { get; set; }
        [Required] public string? Title { get; set; }
        [Required] public string? Description { get; set; }
        [Required] public double? Price { get; set; }
        [Required] public DateTime? StartDate { get; set; }
        [Required] public DateTime? EndDate { get;  set; }
        [Required] public string? MovieImgURL { get; set; }
        [Required] public MovieCategory? MovieCategory { get; set; }

        // Relations

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        public ICollection<Actor_Movie>? Actors_Movies { get; set; }
    }
}
