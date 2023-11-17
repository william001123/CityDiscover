
using System.Threading.Tasks;

namespace CityDiscoverMovil.Interfaces
{
    public interface IActualizar<TEntidad>
    {
        Task<bool> Actualizar(TEntidad entidad);

    }
}
