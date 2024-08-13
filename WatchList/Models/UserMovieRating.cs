#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
// Add this using statement to access NotMapped
using System.ComponentModel.DataAnnotations.Schema;
namespace WatchList.Models;

public class UserMovieRating
{        
    [Key]        
    public int UserMovieRatingId { get; set; }

    [Required]
    [Range(1,6)]
    public int Rating { get;set; }

    //fk
    public int UserId { get;set; }
    public int MovieId { get;set; }

    //nav props
    public User? RatingUser { get;set; }
    public Movie? RatedMovie { get;set; }
}
