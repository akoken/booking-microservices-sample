using BuildingBlocks.Core.Model;
using BuildingBlocks.IdsGenerator;

namespace Flight.Airports.Models;

using Features.CreatingAirport.V1;

public record Airport : Aggregate<long>
{
    public string Name { get; private set; }
    public string Address { get; private set; }
    public string Code { get; private set; }

    public static Airport Create(long id, string name, string address, string code, bool isDeleted = false)
    {
        var airport = new Airport
        {
            Id = id,
            Name = name,
            Address = address,
            Code = code
        };

        var @event = new AirportCreatedDomainEvent(
            airport.Id,
            airport.Name,
            airport.Address,
            airport.Code,
            isDeleted);

        airport.AddDomainEvent(@event);

        return airport;
    }
}
