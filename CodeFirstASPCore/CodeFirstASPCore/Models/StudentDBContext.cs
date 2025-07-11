using Microsoft.EntityFrameworkCore;

namespace CodeFirstASPCore.Models
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext(DbContextOptions options): base(options) 
        {
                
        }
        public DbSet<Student> Student { get; set; }
    }
}
