using BookMarker.Domain.Leitores.Interfaces;
using BookMarker.Domain.Leitores.Repository;
using System.Threading.Tasks;

namespace BookMarker.Domain.Leitores.Service
{
    public class LeitorUsuarioService : ILeitorUsuarioService
    {
        private readonly IRepositoryLeitor _repositoryLeitor;
        public LeitorUsuarioService(IRepositoryLeitor repositoryLeitor)
        {
            _repositoryLeitor = repositoryLeitor;
        }
        public async Task<LeitorUsuario> EfetuarLoginAsync(string login, string senha)
        {
            return await _repositoryLeitor.EfetuarLoginAsync(login, senha);
        }
    }
}
