using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Finished;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Error;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.LiveEncodingHeartbeat;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.TransferError;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.LiveInputStreamChanged;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.EncodingStatusChanged;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings
{
    public class EncodingsApi
    {
        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Finished = new FinishedApi(apiClientFactory);
            Error = new ErrorApi(apiClientFactory);
            LiveEncodingHeartbeat = new LiveEncodingHeartbeatApi(apiClientFactory);
            TransferError = new TransferErrorApi(apiClientFactory);
            LiveInputStreamChanged = new LiveInputStreamChangedApi(apiClientFactory);
            EncodingStatusChanged = new EncodingStatusChangedApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        public FinishedApi Finished { get; }
        public ErrorApi Error { get; }
        public LiveEncodingHeartbeatApi LiveEncodingHeartbeat { get; }
        public TransferErrorApi TransferError { get; }
        public LiveInputStreamChangedApi LiveInputStreamChanged { get; }
        public EncodingStatusChangedApi EncodingStatusChanged { get; }
    }
}
