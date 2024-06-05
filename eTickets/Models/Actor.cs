using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key] public int ActorId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Biography { get; set; }
        [Required] public string ProfilePicURL { get; set; }

        public ICollection<Actor_Movie> Actors_Movies { get; set; }
    }
}
