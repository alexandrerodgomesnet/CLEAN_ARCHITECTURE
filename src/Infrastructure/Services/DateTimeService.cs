using CLEAN_ARCHITECTURE.Application.Common.Interfaces;

namespace CLEAN_ARCHITECTURE.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
