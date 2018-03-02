using BookMarker.Domain.Leitores;
using BookMarker.Domain.Leitores.Repository;
using System.Threading.Tasks;

namespace BookMarker.Infra.Data.Repositories
{
    public class RepositoryLeitor : RepositoryBase<Leitor>, IRepositoryLeitor
    {
        public async Task<LeitorUsuario> EfetuarLoginAsync(string login, string senha)
        {
            await Task.Delay(0);

            return new LeitorUsuario { Login = login, Leitor = new Leitor { Nome = "Eli Pedro dos Santos" } };
        }
    }
}
