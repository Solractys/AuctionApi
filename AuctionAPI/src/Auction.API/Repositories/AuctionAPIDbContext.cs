using RocketseatAuction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace RocketseatAuction.API.Repository;

public class AuctionAPIDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\carlo\\OneDrive\\Área de Trabalho\\Db\\leilaoDbNLW.db");
    }
}
