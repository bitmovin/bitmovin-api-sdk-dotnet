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
    public class BitmovinApi
    {
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

        public AccountApi Account { get; }
        public AiSceneAnalysisApi AiSceneAnalysis { get; }
        public AnalyticsApi Analytics { get; }
        public EncodingApi Encoding { get; }
        public GeneralApi General { get; }
        public NotificationsApi Notifications { get; }
        public PlayerApi Player { get; }
        public StreamsApi Streams { get; }
    }
}
