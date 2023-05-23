using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.History.Encodings;

namespace Bitmovin.Api.Sdk.Encoding.History
{
    public class HistoryApi
    {
        public HistoryApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Encodings = new EncodingsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of HistoryApi
        /// </summary>
        public static BitmovinApiBuilder<HistoryApi> Builder => new BitmovinApiBuilder<HistoryApi>();

        public EncodingsApi Encodings { get; }
    }
}
