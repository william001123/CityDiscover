using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityDiscoverMovil.Interfaces
{
    public interface IListar<TEntidad, TEntidadID>
    {
        Task<List<TEntidad>> ObtenerTodo();

        Task<TEntidad> ObtenerPorID(TEntidadID entidadID);
    }
}
