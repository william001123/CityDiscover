
using System.Threading.Tasks;

namespace CityDiscoverMovil.Interfaces
{
    public interface IEliminar<TEntidadID>
    {
        Task<bool> Eliminar(TEntidadID entidadID);
    }
}
