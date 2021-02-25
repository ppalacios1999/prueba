namespace Backend.Inhumaciones.Repositories.Base
{
    /// <summary>
    /// Base Repository Administracion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="BaseRepository{T}" />
    /// <seealso cref="Entities.Interface.Repository.IBaseRepositoryAdministracion{T}" />

    public class BaseRepositoryAdministracion<T> : BaseRepository<T>, Entities.Interface.Repository.IBaseRepositoryAdministracion<T> where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepositoryAdministracion{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseRepositoryAdministracion(Context.AdministracionContext context)
        {
            AppContext = context;
        }
    }
}