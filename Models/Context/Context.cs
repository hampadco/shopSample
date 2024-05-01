
using Microsoft.EntityFrameworkCore;

public class Context :DbContext
{

    public DbSet<Product> Tbl_Product { get; set; }
    
    public DbSet<order> Tbl_order { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=shop;Trusted_Connection=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=true");
    }



    
}