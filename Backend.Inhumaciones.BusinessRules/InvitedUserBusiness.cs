using Backend.Inhumaciones.Entities.DTOs;
using Backend.Inhumaciones.Entities.Interface.Business;
using Backend.Inhumaciones.Entities.Responses;
using Backend.Inhumaciones.Utilities.Services.Graph;
using Backend.Inhumaciones.Utilities.Telemetry;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using System;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class InvitedUserBusiness : IInvitedUserBusiness
    {
        #region Attributes

        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly ITelemetryException TelemetryException;

        /// <summary>
        /// The application inhumaciones
        /// </summary>
        private readonly string AppInhumaciones;

        /// <summary>
        /// The client identifier
        /// </summary>
        private readonly string ClientId;

        /// <summary>
        /// The client secret
        /// </summary>
        private readonly string ClientSecret;

        /// <summary>
        /// The authority
        /// </summary>
        private readonly string Authority;

        #endregion

        #region Constructor                        
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitedUserBusiness"/> class.
        /// </summary>
        /// <param name="telemetryException">The telemetry exception.</param>
        /// <param name="configuration">The configuration.</param>
        public InvitedUserBusiness(ITelemetryException telemetryException,
                                   IConfiguration configuration)
        {
            TelemetryException = telemetryException;
            AppInhumaciones = configuration.GetValue<string>(Utilities.Constants.KeyVault.AppInhumaciones);
            ClientId = configuration.GetValue<string>(Utilities.Constants.KeyVault.Audience);
            ClientSecret = configuration.GetValue<string>(Utilities.Constants.KeyVault.ClientSecret);
            Authority = configuration.GetValue<string>(Utilities.Constants.KeyVault.Authority);
        }
        #endregion

        #region Methods

        /// <summary>
        /// Inviteds the user email address.
        /// </summary>
        /// <param name="inviteUserModel"></param>
        /// <returns></returns>
        public async Task<ResponseBase<InviteUserModel>> InvitedUserEmailAddress(InviteUserModel inviteUserModel)
        {
            try
            {
                var graphServiceClient = GraphServiceClientHelper.CreateGraphServiceClient(ClientId, ClientSecret, Authority);

                var invitation = await graphServiceClient.Invitations.Request().AddAsync(new Invitation
                {
                    InviteRedirectUrl = AppInhumaciones,
                    InvitedUserEmailAddress = inviteUserModel.EmailAddress,
                    SendInvitationMessage = true,
                    InvitedUser = new User { Id = inviteUserModel.InvitedUser }
                });

                inviteUserModel.Status = invitation.Status;

                return new ResponseBase<InviteUserModel>(code: System.Net.HttpStatusCode.OK, message: "solicitud ok", data: inviteUserModel);
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new ResponseBase<InviteUserModel>(code: System.Net.HttpStatusCode.InternalServerError, message: ex.Message);
            }
        }
        #endregion
    }
}
