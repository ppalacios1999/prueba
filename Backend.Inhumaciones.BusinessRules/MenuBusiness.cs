using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class MenuBusiness : Entities.Interface.Business.IMenuBusiness
    {
        /// <summary>
        /// The repository menu
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryAdministracion<Entities.Models.Administracion.Menu> RepositoryMenu;
        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly Utilities.Telemetry.ITelemetryException TelemetryException;
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuBusiness"/> class.
        /// </summary>
        /// <param name="repositoryMenu">The repository menu.</param>
        public MenuBusiness(Entities.Interface.Repository.IBaseRepositoryAdministracion<Entities.Models.Administracion.Menu> repositoryMenu,
                              Utilities.Telemetry.ITelemetryException telemetryException)
        {
            RepositoryMenu = repositoryMenu;
            TelemetryException = telemetryException;
        }
        /// <summary>
        /// Adds the menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>> AddMenu(Entities.Models.Administracion.Menu menu)
        {
            try
            {
                if (menu == null || string.IsNullOrEmpty(menu.Titulo))
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.BadRequest, message: "Los parámetros son obligatorios");
                }
                await RepositoryMenu.AddAsync(menu);
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.OK, "Solicitud ok");
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }
        /// <summary>
        /// Deletes the menu.
        /// </summary>
        /// <param name="idmenu">The idmenu.</param>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>> DeleteMenu(string idmenu)
        {
            try
            {
                if (idmenu == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.BadRequest, message: "Los parámetros son obligatorios");
                }

                var menuBD = await RepositoryMenu.GetAsync(w => w.IdMenu == Convert.ToInt32(idmenu));

                if (menuBD == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.BadRequest, "No se encontró el código del modulo para actualizar.");
                }
                menuBD.Estado = 0;

                await RepositoryMenu.UpdateAsync(menuBD);

                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.OK, "Solicitud ok");
            }
            catch (Exception)
            {
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }
        /// <summary>
        /// Gets the menu.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Menu>>> GetMenu()
        {
            try
            {
                var menu = await RepositoryMenu.GetAllAsync();
                return new Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Menu>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: menu.ToList(), count: menu.Count());
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Menu>>(code: System.Net.HttpStatusCode.InternalServerError, message: "Error en el servidor!");
            }
        }
        /// <summary>
        /// Updates the menu.
        /// </summary>
        /// <param name="menu">The modulo.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>> UpdateMenu(Entities.Models.Administracion.Menu menu)
        {
            try
            {
                if (menu == null || string.IsNullOrEmpty(menu.Titulo))
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.BadRequest, message: "Los parámetros son obligatorios");
                }

                var menuBD = await RepositoryMenu.GetAsync(w => w.IdMenu == menu.IdMenu);

                if (menuBD == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.BadRequest, "No se encontró el código del modulo para actualizar.");
                }

                menuBD.IdModulo = menu.IdModulo;
                menuBD.IdMenuPadre = menu.IdMenuPadre;
                menuBD.IdPermiso = menu.IdPermiso;
                menuBD.Titulo = menu.Titulo;
                menuBD.Descripcion = menu.Descripcion;
                menuBD.Url = menu.Url;
                menuBD.Orden = menu.Orden;
                menuBD.Icono = menu.Icono;
                menuBD.Estado = menu.Estado;
                menuBD.IdUsuarioCrea = menu.IdUsuarioCrea;
                menuBD.FechaRegistro = menu.FechaRegistro;
                menuBD.IdUsuaioModifica = menu.IdUsuaioModifica;
                menuBD.FechaModifica = menu.FechaModifica;

                await RepositoryMenu.UpdateAsync(menuBD);

                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.OK, "Solicitud ok");
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }
    }
}
