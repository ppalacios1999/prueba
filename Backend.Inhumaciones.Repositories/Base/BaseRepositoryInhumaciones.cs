namespace Backend.Inhumaciones.Repositories.Base
{
    /// <summary>
    /// Base Repository Inhumaciones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="BaseRepository{T}" />
    /// <seealso cref="Entities.Interface.Repository.IBaseRepositoryInhumaciones{T}" />
    public class BaseRepositoryInhumaciones<T> : BaseRepository<T>, Entities.Interface.Repository.IBaseRepositoryInhumaciones<T> where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepositoryInhumaciones{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BaseRepositoryInhumaciones(Context.InhumacionesContext context)
        {
            AppContext = context;
        }
    }
}