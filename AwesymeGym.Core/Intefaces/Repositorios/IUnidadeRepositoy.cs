using AwesymeGym.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Intefaces.Repositorios
{
    public interface IUnidadeRepository
    {
        Task<int> Adicionar(Unidade unidade);
        Task<List<Unidade>> ObterTodos();
        Task<Unidade> ObterPorId(int id);
    }
}
