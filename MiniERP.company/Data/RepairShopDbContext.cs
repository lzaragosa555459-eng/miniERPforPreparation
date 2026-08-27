using Microsoft.EntityFrameworkCore;
using MiniERP.Company.Entities;

namespace MiniERP.Company.Data;

public class RepairShopDbContext : DbContext
{
    public RepairShopDbContext(
        DbContextOptions<RepairShopDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();
}