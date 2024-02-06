using Auction.API.Entities;

namespace Auction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public AuctionEnt Execute()
    {
        return new AuctionEnt
        {
            Id = 1,
            Name = "teste",
            Starts = DateTime.Now,
            Ends = DateTime.Now,
        };
    }
}
