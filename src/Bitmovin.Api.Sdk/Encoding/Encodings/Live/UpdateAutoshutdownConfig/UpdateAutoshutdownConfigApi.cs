using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.UpdateAutoshutdownConfig
{
    /// <summary>
    /// API for UpdateAutoshutdownConfigApi
    /// </summary>
    public class UpdateAutoshutdownConfigApi
    {
        private readonly IUpdateAutoshutdownConfigApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the UpdateAutoshutdownConfigApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public UpdateAutoshutdownConfigApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IUpdateAutoshutdownConfigApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of UpdateAutoshutdownConfigApi
        /// </summary>
        public static BitmovinApiBuilder<UpdateAutoshutdownConfigApi> Builder => new BitmovinApiBuilder<UpdateAutoshutdownConfigApi>();

        /// <summary>
        /// Replace Live Auto Shutdown Configuration
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="liveAutoShutdownConfigurationUpdateRequest">Applies a new auto shutdown configuration to a Live Encoding that is already running, without interrupting the stream.  **The body is a full replacement, not a partial update.** Every field that is omitted or set to &#x60;null&#x60; disarms the corresponding timer, and an empty body &#x60;{}&#x60; disarms all timers. Always send the complete configuration you want the encoding to run with, including the values you want to keep.  **&#x60;streamTimeoutMinutes&#x60; is counted from this call, not from the start of the encoding.** The encoding is stopped that many minutes after the update is accepted, whereas in the start request the same field is counted from when the encoding started. An encoding started at 12:00 with &#x60;streamTimeoutMinutes&#x60; of 120 is scheduled to stop at 14:00; updating it at 13:30 with &#x60;streamTimeoutMinutes&#x60; of 150 moves the shutdown to 16:00, not to 14:30. &#x60;bytesReadTimeoutSeconds&#x60; is relative by nature, as it always counts from the last byte received, and &#x60;waitingForFirstConnectTimeoutMinutes&#x60; has no effect once the input is connected.  The organization&#39;s maximum live encoding runtime still bounds the total runtime of the encoding, measured from the start of the encoding. An update that would push the shutdown past that limit is rejected rather than extending the encoding beyond it.  **Do not leave the call to the last few seconds.** The update is rejected with &#x60;409&#x60; when any armed shutdown timer is within 10 seconds of firing, because at that point the shutdown sequence is effectively already in flight. </param>
        public async Task<Models.LiveAutoShutdownConfigurationUpdateResponse> CreateAsync(string encodingId, Models.LiveAutoShutdownConfigurationUpdateRequest liveAutoShutdownConfigurationUpdateRequest)
        {
            return await _apiClient.CreateAsync(encodingId, liveAutoShutdownConfigurationUpdateRequest);
        }

        internal interface IUpdateAutoshutdownConfigApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/update-autoshutdown-config")]
            [AllowAnyStatusCode]
            Task<Models.LiveAutoShutdownConfigurationUpdateResponse> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.LiveAutoShutdownConfigurationUpdateRequest liveAutoShutdownConfigurationUpdateRequest);
        }
    }
}
