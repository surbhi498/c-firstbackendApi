namespace RecipeApp.DTO{
    public record LoginUserDTO(string username, string password);
    public class UserDTO{
        
       
    public int Id{get; set;}
    public string Username{get; set;}
    
    public DateTime CreatedAt{get; set;}
    public DateTime UpdatedAt{get;set;}
         

    
    }
}