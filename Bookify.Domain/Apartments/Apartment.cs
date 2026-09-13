using Bookify.Domain.Shared;

namespace Bookify.Domain.Apartments;
using Abstractions; 

public sealed class Apartment(Guid id, Name name, Description description, Address address, Money price, Money cleaningFee, IEnumerable<Amenity> amenities) : Entity(id)
{
    private readonly List<Amenity> _amenities = amenities.ToList();
    
    public Name Name { get; private set; } = name;
    
    public Description Description  { get; private set; }   = description;
    
    public Address Address  { get; private set; }  = address;

    public Money Price { get; private set; }   = price;
    
    public Money CleaningFee { get; private set; }  = cleaningFee;
    
    public DateTime? LastBookedOnUtc { get; internal set; }

    public IReadOnlyCollection<Amenity> Amenities => _amenities.AsReadOnly();}
