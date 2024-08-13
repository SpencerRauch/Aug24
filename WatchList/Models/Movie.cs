#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
// Add this using statement to access NotMapped
using System.ComponentModel.DataAnnotations.Schema;
namespace WatchList.Models;

public class Movie
{        
    [Key]        
    public int MovieId { get; set; }
    
    [Required]        
    public string Title { get; set; }
    
    //fk
    public int UserId { get;set; }

    //nav props
    public User? AddingUser { get;set; }
    public List<UserMovieRating> UserRatings { get;set; } = [];




}

