using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models{
    public class User:BaseModel{
       
    [Required, MinLength(2), MaxLength(50)]   
    public string Username{get; set;}
    [Required, MaxLength(512)]
    public string Password{get;set;}
         

    }
}