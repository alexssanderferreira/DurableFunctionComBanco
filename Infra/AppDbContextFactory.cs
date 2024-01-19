using DurableFunction.Infra;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DurableFunction.Infra;
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost;Database=Fiap;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

        return new AppDbContext(optionsBuilder.Options);
    }
}