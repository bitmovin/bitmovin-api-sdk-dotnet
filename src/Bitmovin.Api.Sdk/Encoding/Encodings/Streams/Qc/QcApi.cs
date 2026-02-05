using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Qc.Psnr;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Qc
{
    /// <summary>
    /// API for QcApi
    /// </summary>
    public class QcApi
    {
        /// <summary>
        /// Initializes a new instance of the QcApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public QcApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Psnr = new PsnrApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of QcApi
        /// </summary>
        public static BitmovinApiBuilder<QcApi> Builder => new BitmovinApiBuilder<QcApi>();

        /// <summary>
        /// Gets the Psnr API
        /// </summary>
        public PsnrApi Psnr { get; }
    }
}
