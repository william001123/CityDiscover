
using System.Threading.Tasks;

namespace CityDiscoverMovil.Interfaces
{
    public interface IInsertar<TEntidad>
    {
        Task<TEntidad> Insertar(TEntidad entidad);
    }
}
