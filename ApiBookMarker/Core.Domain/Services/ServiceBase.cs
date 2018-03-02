using BookMarker.Core.Domain.Interfaces;

namespace BookMarker.Core.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
    }
}
