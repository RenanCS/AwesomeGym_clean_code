using AwesymeGym.Core.DTOs;
using AwesymeGym.Core.Entidades;

namespace AwesymeGym.Core.Intefaces.Servicos
{
    public interface IInscricaoService
    {
        ResultadoInscricaoDTO Realizar(Aluno aluno, Unidade unidade, TurmaAtividade turmaAtividade);
    }
}
