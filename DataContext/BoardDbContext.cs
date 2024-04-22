using AspCoreBoardProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCoreBoardProject.DataContext;

public class BoardDbContext : DbContext
{
    public BoardDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Board> Boards { get; set; }
}