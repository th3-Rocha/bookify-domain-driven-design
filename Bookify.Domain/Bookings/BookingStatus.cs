namespace Bookify.Domain.Bookings;
#pragma warning disable CA1700
public enum BookingStatus
{
        None = 0,
        Reserved = 1,
        Confirmed = 2,
        Rejected = 3,
        Cancelled = 4,
        Completed = 5
}