using DurableFunction.Configuration;
using DurableFunction.Infra;
using DurableFunction.Infra.Contratos;
using DurableFunction.Infra.Repositorio;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(Startup))]

namespace DurableFunction.Configuration;

public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        var connectionString = Environment.GetEnvironmentVariable("SqlServer");
        
        builder.Services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer("Server=localhost;Database=Fiap;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));


        builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
    }
}
