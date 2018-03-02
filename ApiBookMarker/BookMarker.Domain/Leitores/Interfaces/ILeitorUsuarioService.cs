using System.Threading.Tasks;

namespace BookMarker.Domain.Leitores.Interfaces
{
    public interface ILeitorUsuarioService
    {
        Task<LeitorUsuario> EfetuarLoginAsync(string login, string senha);
    }
}
