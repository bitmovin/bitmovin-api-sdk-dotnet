using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.ResetLiveManifestTimeshift
{
    /// <summary>
    /// API for ResetLiveManifestTimeshiftApi
    /// </summary>
    public class ResetLiveManifestTimeshiftApi
    {
        private readonly IResetLiveManifestTimeshiftApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ResetLiveManifestTimeshiftApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ResetLiveManifestTimeshiftApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IResetLiveManifestTimeshiftApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ResetLiveManifestTimeshiftApi
        /// </summary>
        public static BitmovinApiBuilder<ResetLiveManifestTimeshiftApi> Builder => new BitmovinApiBuilder<ResetLiveManifestTimeshiftApi>();

        /// <summary>
        /// Reset Live manifest time-shift
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="resetLiveManifestTimeShift">Removes older segments from live manifests, resetting or reducing the time-shift (DVR) window. You can set &#x60;residualPeriodInSeconds&#x60; to specify how many seconds of content remain in the manifest after the reset, or &#x60;offsetInSeconds&#x60; to remove all segments before a position measured from the start of the live event. Do not set both parameters. If neither parameter is set, only the most recent segment remains. For DASH manifests that use SegmentTemplate, the duration retained by &#x60;residualPeriodInSeconds&#x60; (or when neither parameter is set) also includes the configured &#x60;liveEdgeOffset&#x60;. The configured time-shift window does not change. After the reset, new segments are added without removing older ones until the configured window duration is reached again. This operation supports HLS live manifests and, with encoder version 2.235.0 or later, DASH live manifests. The live encoding must have the &#x60;RUNNING&#x60; status. The request is processed asynchronously. </param>
        public async Task<Models.ResetLiveManifestTimeShift> CreateAsync(string encodingId, Models.ResetLiveManifestTimeShift resetLiveManifestTimeShift)
        {
            return await _apiClient.CreateAsync(encodingId, resetLiveManifestTimeShift);
        }

        internal interface IResetLiveManifestTimeshiftApiClient
        {
            [Post("/encoding/encodings/{encoding_id}/live/reset-live-manifest-timeshift")]
            [AllowAnyStatusCode]
            Task<Models.ResetLiveManifestTimeShift> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.ResetLiveManifestTimeShift resetLiveManifestTimeShift);
        }
    }
}
