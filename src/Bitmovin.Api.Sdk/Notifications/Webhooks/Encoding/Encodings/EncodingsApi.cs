using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Finished;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Error;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.LiveEncodingHeartbeat;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.TransferError;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.LiveInputStreamChanged;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.EncodingStatusChanged;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings
{
    /// <summary>
    /// API for EncodingsApi
    /// </summary>
    public class EncodingsApi
    {
        /// <summary>
        /// Initializes a new instance of the EncodingsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
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

        /// <summary>
        /// Gets the Finished API
        /// </summary>
        public FinishedApi Finished { get; }
        /// <summary>
        /// Gets the Error API
        /// </summary>
        public ErrorApi Error { get; }
        /// <summary>
        /// Gets the LiveEncodingHeartbeat API
        /// </summary>
        public LiveEncodingHeartbeatApi LiveEncodingHeartbeat { get; }
        /// <summary>
        /// Gets the TransferError API
        /// </summary>
        public TransferErrorApi TransferError { get; }
        /// <summary>
        /// Gets the LiveInputStreamChanged API
        /// </summary>
        public LiveInputStreamChangedApi LiveInputStreamChanged { get; }
        /// <summary>
        /// Gets the EncodingStatusChanged API
        /// </summary>
        public EncodingStatusChangedApi EncodingStatusChanged { get; }
    }
}
