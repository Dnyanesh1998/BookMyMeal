using Microsoft.EntityFrameworkCore;
namespace BookMyMeal.MealDbContext
{
    public class MealDbContext:DbContext
    {
        public MealDbContext(DbContextOptions<MealDbContext> options):base(options) { 
        
        
        }

    }
}
