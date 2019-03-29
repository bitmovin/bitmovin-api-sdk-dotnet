using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Account;
using Bitmovin.Api.Sdk.Analytics;
using Bitmovin.Api.Sdk.Encoding;
using Bitmovin.Api.Sdk.Notifications;
using Bitmovin.Api.Sdk.Player;

namespace Bitmovin.Api.Sdk
{
    public class BitmovinApi
    {
        public BitmovinApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Account = new AccountApi(apiClientFactory);
            Analytics = new AnalyticsApi(apiClientFactory);
            Encoding = new EncodingApi(apiClientFactory);
            Notifications = new NotificationsApi(apiClientFactory);
            Player = new PlayerApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of BitmovinApi
        /// </summary>
        public static BitmovinApiBuilder<BitmovinApi> Builder => new BitmovinApiBuilder<BitmovinApi>();

        public AccountApi Account { get; private set; }
        public AnalyticsApi Analytics { get; private set; }
        public EncodingApi Encoding { get; private set; }
        public NotificationsApi Notifications { get; private set; }
        public PlayerApi Player { get; private set; }

    }
}
