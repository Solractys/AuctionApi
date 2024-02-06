using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction Execute()
    {
        var repository = new AuctionAPIDbContext();
            return repository
            .Auctions
            .Include(auction => auction.Items).First();
    }
}
