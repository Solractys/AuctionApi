using Auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auction.API.Repository;

public class AuctionAPIDbContext : DbContext
{
    public DbSet<AuctionEnt> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\carlo\\OneDrive\\Área de Trabalho\\Db\\leilaoDbNLW.db");
    }
}
