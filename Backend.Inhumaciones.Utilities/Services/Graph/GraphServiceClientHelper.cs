using Microsoft.Graph;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Utilities.Services.Graph
{
    public static class GraphServiceClientHelper
    {
        #region Methods        
        /// <summary>
        /// Creates the graph service client.
        /// </summary>
        /// <param name="ClientId">The client identifier.</param>
        /// <param name="ClientSecret">The client secret.</param>
        /// <param name="Authority">The authority.</param>
        /// <returns></returns>
        public static GraphServiceClient CreateGraphServiceClient(string ClientId, string ClientSecret, string Authority)
        {
            var clientCredential = new ClientCredential(ClientId, ClientSecret);

            var authenticationContext = new AuthenticationContext($"https://login.microsoftonline.com/{Authority}");

            var authenticationResult = authenticationContext.AcquireTokenAsync("https://graph.microsoft.com", clientCredential).Result;

            var delegateAuthProvider = new DelegateAuthenticationProvider((requestMessage) =>
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", authenticationResult.AccessToken);

                return Task.FromResult(0);
            });

            return new GraphServiceClient(delegateAuthProvider);
        }
        #endregion
    }
}