namespace Backend.Inhumaciones.Entities.Interface.Repository
{
    /// <summary>
    /// Interfaz Base Repository Inhumaciones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="IBaseRepository{T}" />
    public interface IBaseRepositoryInhumaciones<T> : IBaseRepository<T> where T : class
    {
    }
}