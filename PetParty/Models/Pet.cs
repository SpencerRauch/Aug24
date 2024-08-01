#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;

public class Pet
{
    [Required(ErrorMessage = "Plz gib ur naem")]
    [Display(Name="Pet Name")]
    public string Name { get;set; }

    [DataType(DataType.Password)]
    [MinLength(3)]
    public string Species { get;set; }

    public bool Fun { get;set; }
    
    [Required]
    public int? Age { get;set; }
}