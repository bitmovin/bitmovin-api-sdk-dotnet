using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Analytics.Alerting.Rules;
using Bitmovin.Api.Sdk.Analytics.Alerting.Incidents;

namespace Bitmovin.Api.Sdk.Analytics.Alerting
{
    public class AlertingApi
    {
        public AlertingApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Rules = new RulesApi(apiClientFactory);
            Incidents = new IncidentsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AlertingApi
        /// </summary>
        public static BitmovinApiBuilder<AlertingApi> Builder => new BitmovinApiBuilder<AlertingApi>();

        public RulesApi Rules { get; }
        public IncidentsApi Incidents { get; }
    }
}
