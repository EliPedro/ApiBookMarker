using BookMarker.Core.Domain.Repository;
using System.Threading.Tasks;

namespace BookMarker.Domain.Leitores.Repository
{
    public interface IRepositoryLeitor : IRepositoryBase<Leitor>
    {
        Task<LeitorUsuario> EfetuarLoginAsync(string login, string senha);
    }
}
