using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var today = DateTime.Now;

        var repository = new AuctionAPIDbContext();
            return repository
            .Auctions
            .Include(auction => auction.Items).FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
