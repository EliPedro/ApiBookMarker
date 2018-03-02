using BookMarker.Core.Domain.Handles;
using BookMarker.Core.Domain.Interfaces;

namespace BookMarker.Core.Domain.Events
{
    public class DomainEvent
    {
        public static IContainer Container { get; set; }
        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if (Container == null) return;

            var obj = Container.GetInstance<IHandler<T>>();
            ((IHandler<T>)obj).Handle(args);
        }
    }
}
