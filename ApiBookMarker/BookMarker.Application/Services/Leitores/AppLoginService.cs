using BookMarker.Application.Interfaces;
using BookMarker.Domain.Leitores;
using BookMarker.Domain.Leitores.Interfaces;
using System.Threading.Tasks;

namespace BookMarker.Application.Services.Leitores
{
    public class AppLoginService : IAppLoginService
    {
        private readonly ILeitorUsuarioService _leitorUsuarioService;

        public AppLoginService(ILeitorUsuarioService leitorUsuarioService)
        {
            _leitorUsuarioService = leitorUsuarioService;
        }

        public async Task<LeitorUsuario> EfetuarLoginAsync(string login, string senha)
        {
            return await _leitorUsuarioService.EfetuarLoginAsync(login, senha);
        }
    }
}