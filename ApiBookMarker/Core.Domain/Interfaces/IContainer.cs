namespace BookMarker.Core.Domain.Interfaces
{
    public interface IContainer
    {
        T GetInstance<T>();
    }
}
