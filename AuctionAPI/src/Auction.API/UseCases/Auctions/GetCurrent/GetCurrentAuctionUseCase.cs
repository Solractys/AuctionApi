using Auction.API.Entities;
using Auction.API.Repository;

namespace Auction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public AuctionEnt Execute()
    {
        var repository = new AuctionAPIDbContext();
        return repository.Auctions.First();
    }
}
