using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Dvbsub;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Srt;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles.Assa;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.BurnInSubtitles
{
    /// <summary>
    /// API for BurnInSubtitlesApi
    /// </summary>
    public class BurnInSubtitlesApi
    {
        /// <summary>
        /// Initializes a new instance of the BurnInSubtitlesApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public BurnInSubtitlesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Dvbsub = new DvbsubApi(apiClientFactory);
            Srt = new SrtApi(apiClientFactory);
            Assa = new AssaApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of BurnInSubtitlesApi
        /// </summary>
        public static BitmovinApiBuilder<BurnInSubtitlesApi> Builder => new BitmovinApiBuilder<BurnInSubtitlesApi>();

        /// <summary>
        /// Gets the Dvbsub API
        /// </summary>
        public DvbsubApi Dvbsub { get; }
        /// <summary>
        /// Gets the Srt API
        /// </summary>
        public SrtApi Srt { get; }
        /// <summary>
        /// Gets the Assa API
        /// </summary>
        public AssaApi Assa { get; }
    }
}
