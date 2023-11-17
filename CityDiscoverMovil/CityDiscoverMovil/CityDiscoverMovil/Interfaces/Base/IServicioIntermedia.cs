
namespace CityDiscoverMovil.Interfaces
{
    public interface IServicioIntermedia<TEntidad>
        : IInsertar<TEntidad>, IEliminar<TEntidad>, IListar<TEntidad, TEntidad>
    {
    }
}
