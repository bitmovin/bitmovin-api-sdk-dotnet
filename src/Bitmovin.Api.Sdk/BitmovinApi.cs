using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account;
using Bitmovin.Api.Sdk.AiSceneAnalysis;
using Bitmovin.Api.Sdk.Analytics;
using Bitmovin.Api.Sdk.Encoding;
using Bitmovin.Api.Sdk.General;
using Bitmovin.Api.Sdk.Notifications;
using Bitmovin.Api.Sdk.Player;
using Bitmovin.Api.Sdk.Streams;

namespace Bitmovin.Api.Sdk
{
    /// <summary>
    /// API for BitmovinApi
    /// </summary>
    public class BitmovinApi
    {
        /// <summary>
        /// Initializes a new instance of the BitmovinApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public BitmovinApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Account = new AccountApi(apiClientFactory);
            AiSceneAnalysis = new AiSceneAnalysisApi(apiClientFactory);
            Analytics = new AnalyticsApi(apiClientFactory);
            Encoding = new EncodingApi(apiClientFactory);
            General = new GeneralApi(apiClientFactory);
            Notifications = new NotificationsApi(apiClientFactory);
            Player = new PlayerApi(apiClientFactory);
            Streams = new StreamsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of BitmovinApi
        /// </summary>
        public static BitmovinApiBuilder<BitmovinApi> Builder => new BitmovinApiBuilder<BitmovinApi>();

        /// <summary>
        /// Gets the Account API
        /// </summary>
        public AccountApi Account { get; }
        /// <summary>
        /// Gets the AiSceneAnalysis API
        /// </summary>
        public AiSceneAnalysisApi AiSceneAnalysis { get; }
        /// <summary>
        /// Gets the Analytics API
        /// </summary>
        public AnalyticsApi Analytics { get; }
        /// <summary>
        /// Gets the Encoding API
        /// </summary>
        public EncodingApi Encoding { get; }
        /// <summary>
        /// Gets the General API
        /// </summary>
        public GeneralApi General { get; }
        /// <summary>
        /// Gets the Notifications API
        /// </summary>
        public NotificationsApi Notifications { get; }
        /// <summary>
        /// Gets the Player API
        /// </summary>
        public PlayerApi Player { get; }
        /// <summary>
        /// Gets the Streams API
        /// </summary>
        public StreamsApi Streams { get; }
    }
}
