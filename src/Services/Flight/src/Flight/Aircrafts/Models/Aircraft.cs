using BuildingBlocks.Core.Model;

namespace Flight.Aircrafts.Models;

using Features.CreatingAircraft.V1;

public record Aircraft : Aggregate<long>
{
    public string Name { get; private set; }
    public string Model { get; private set; }
    public int ManufacturingYear { get; private set; }

    public static Aircraft Create(long id, string name, string model, int manufacturingYear, bool isDeleted = false)
    {
        var aircraft = new Aircraft
        {
            Id = id,
            Name = name,
            Model = model,
            ManufacturingYear = manufacturingYear
        };

        var @event = new AircraftCreatedDomainEvent(
            aircraft.Id,
            aircraft.Name,
            aircraft.Model,
            aircraft.ManufacturingYear,
            isDeleted);

        aircraft.AddDomainEvent(@event);

        return aircraft;
    }
}
