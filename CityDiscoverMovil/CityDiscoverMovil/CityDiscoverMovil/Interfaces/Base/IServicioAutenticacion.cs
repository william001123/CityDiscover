
namespace CityDiscoverMovil.Interfaces
{
    public interface IServicioAutenticacion<TEntidad, TEntidadID>
        : IInsertar<TEntidad>
    {
        TEntidad ObtenerAutenticacion(TEntidadID Usuario, TEntidadID Contrasena);
        string Token(TEntidadID Usuario);
    }
}
