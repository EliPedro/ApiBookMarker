using BookMarker.Core.Domain.Interfaces;
using BookMarker.Domain.Leitores;
using System.Threading.Tasks;

namespace BookMarker.Application.Interfaces
{
    public interface IAppLoginService : IServiceBase<LeitorUsuario>
    {
        Task<LeitorUsuario> EfetuarLoginAsync(string login, string senha);
    }
}