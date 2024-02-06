namespace Auction.API.Entities;

public class AuctionEnt
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
}
