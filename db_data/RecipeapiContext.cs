using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.db_data
{
    public class RecipeapiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        
        public RecipeapiContext(DbContextOptions<RecipeapiContext> options): base(options) {}
    }
}