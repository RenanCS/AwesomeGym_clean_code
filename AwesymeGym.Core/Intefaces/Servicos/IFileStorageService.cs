using System.Threading.Tasks;

namespace AwesymeGym.Core.Intefaces.Servicos
{
    public interface IFileStorageService
    {
        Task AddFile(byte[] content, string fileName);
    }
}
