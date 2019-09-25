using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Qc.Psnr;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Streams.Qc
{
    public class QcApi
    {
        public QcApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Psnr = new PsnrApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of QcApi
        /// </summary>
        public static BitmovinApiBuilder<QcApi> Builder => new BitmovinApiBuilder<QcApi>();

        public PsnrApi Psnr { get; private set; }

    }
}
