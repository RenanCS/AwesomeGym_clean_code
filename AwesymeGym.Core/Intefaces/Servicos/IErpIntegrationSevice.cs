using AwesymeGym.Core.DTOs;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Intefaces.Servicos
{
    public interface IErpIntegrationService
    {
        Task AdicionarPessoa(AdicionarPessoaErpDTO pessoa);
    }
}
