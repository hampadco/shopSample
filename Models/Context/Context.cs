
using Microsoft.EntityFrameworkCore;

public class Context :DbContext
{

    public DbSet<Product> Tbl_Product { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=ShopDB;Trusted_Connection=True;");
    }



    
}