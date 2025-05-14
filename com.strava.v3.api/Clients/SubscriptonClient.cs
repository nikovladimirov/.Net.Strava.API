using System;
using System.Threading.Tasks;
using com.strava.v3.api.Api;
using com.strava.v3.api.Authentication;

namespace com.strava.v3.api.Clients
{
    /// <summary>
    /// Used to get activity data from Strava.
    /// </summary>
    public class SubscriptionClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        /// <param name="auth">A IAuthenticator object that contains a valid Strava access token.</param>
        public SubscriptionClient(IAuthentication auth) : base(auth) { }

        #region Async

        /// <summary>
        /// Post create a subscription.
        /// </summary>
        /// <param name="clientId">Strava API application ID</param>
        /// <param name="clientSecret">Strava API application secret</param>
        /// <param name="callbackUrl">Address where webhook events will be sent; maximum length of 255 characters</param>
        /// <param name="verifyToken">String chosen by the application owner for client security. An identical string will be included in the validation request made by Strava's subscription service</param>
        /// <returns></returns>
        public async Task<string> PostCreateSubscription(string clientId, string clientSecret, string callbackUrl, string verifyToken)
        {
            var postUrl = $"{Endpoints.Subscriptions}?client_id={clientId}&client_secret={clientSecret}&callback_url={callbackUrl}&verify_token={verifyToken}";
            
            return await Http.WebRequest.SendPostAsync(new Uri(postUrl));
        }
        
        /// <summary>
        /// Get a subscription from StravaApp
        /// </summary>
        /// <param name="clientId">StravaApp client Id</param>
        /// <param name="clientSecret">StravaApp client secret</param>
        /// <returns></returns>
        public async Task<string> GetSubscriptions(string clientId, string clientSecret)
        {
            var getUrl = $"{Api.Endpoints.Subscriptions}?client_id={clientId}&client_secret={clientSecret}";
            var json = await Http.WebRequest.SendGetAsync(new Uri(getUrl));

            // return Unmarshaller<Activity>.Unmarshal(json);
            return json;
        }

        /// <summary>
        /// Deletes a subscription on Strava.
        /// </summary>
        /// <param name="subscriptionId">The Strava Id of the subscription to delete</param>
        /// <param name="clientId">StravaApp client Id</param>
        /// <param name="clientSecret">StravaApp client secret</param>
        /// <returns></returns>
        public async Task<string> DeleteSubscription(string subscriptionId, string clientId, string clientSecret)
        {
            var deleteUrl = $"{Endpoints.Subscriptions}/{subscriptionId}?client_id={clientId}&client_secret={clientSecret}";
            return await Http.WebRequest.SendDeleteAsync(new Uri(deleteUrl));
        }
        
        #endregion
    }
}
