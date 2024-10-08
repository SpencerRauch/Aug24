#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;

public class Pet
{
    [Required(ErrorMessage = "Plz gib ur naem")]
    [DisplayName("Display Name")]
    // [Display(Name="Pet Name")]
    [NoZNames]
    public string Name { get;set; }

    // [DataType(DataType.Password)]
    [MinLength(3)]
    // [Options]
    [ProvidedOptions("Bear","Bobcat","Raccoon")]
    public string Species { get;set; }

    public bool Fun { get;set; }
    
    [Required]
    public int? Age { get;set; }
}

public class NoZNamesAttribute : ValidationAttribute
{    
    // Call upon the protected IsValid method
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        // We are expecting the value coming in to be a string
        // so we need to do a bit of type casting to our object
        // Strings work similarly to arrays under the hood 
        // so we can grab the first letter using its index   
        // If we discover that the first letter of our string is z...  
        if (value == null || ((string)value).ToLower()[0] == 'z')
        {        
            // we return an error message in ValidationResult we want to render    
            return new ValidationResult("No names that start with Z allowed!");   
        } else {   
            // Otherwise, we were successful and can report our success  
            return ValidationResult.Success;  
        }  
    }
}

public class OptionsAttribute : ValidationAttribute
{    
    
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        string[] ValidOptions = ["Dog","Fish","Cat"]; //these should really be coming from a db
        if (value == null || !ValidOptions.Contains((string)value))
        {        

            return new ValidationResult("Please pick one of the valid options!");   
        } else {   

            return ValidationResult.Success;  
        }  
    }
}

public class ProvidedOptionsAttribute : ValidationAttribute
{    
    public string[] Options { get;set; }

    public ProvidedOptionsAttribute(params string[] options)
    {
        Options = options;
    }
    
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        if (value == null || !Options.Contains((string)value))
        {        

            return new ValidationResult("Please pick one of the valid options!");   
        } else {   

            return ValidationResult.Success;  
        }  
    }
}