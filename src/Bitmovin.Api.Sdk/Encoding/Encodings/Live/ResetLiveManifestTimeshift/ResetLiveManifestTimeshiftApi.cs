using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live.ResetLiveManifestTimeshift
{
    public class ResetLiveManifestTimeshiftApi
    {
        private readonly IResetLiveManifestTimeshiftApiClient _apiClient;

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
        /// <param name="resetLiveManifestTimeShift">Removes older segments from live manifests. This resets or reduces the time-shift (DVR) window. The &#x60;residualPeriod&#x60; value determines how many seconds will remain in the time-shift window. The original time-shift window does not change. Newer segments will be added and not removed from the  manifest until the original time-shift duration is reached again.  Currently, only HLS live manifests are supported. </param>
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
