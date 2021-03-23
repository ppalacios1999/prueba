using Backend.Inhumaciones.Entities.DTOs;
using Backend.Inhumaciones.Entities.Responses;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IInvitedUserBusiness
    /// </summary>
    public interface IInvitedUserBusiness
    {
        /// <summary>
        /// Inviteds the user email address.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        Task<ResponseBase<InviteUserModel>> InvitedUserEmailAddress(InviteUserModel inviteUserModel);


    }
}
