using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Live.Encodings.Actions
{
    /// <summary>
    /// API for ActionsApi
    /// </summary>
    public class ActionsApi
    {
        private readonly IActionsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the ActionsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public ActionsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IActionsApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of ActionsApi
        /// </summary>
        public static BitmovinApiBuilder<ActionsApi> Builder => new BitmovinApiBuilder<ActionsApi>();

        /// <summary>
        /// Update the ingest points of a Redundant RTMP Input
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="updateEncodingRtmpIngestPointRequest">The list of the RTMP ingest points to update.</param>
        public async Task<Models.UpdateEncodingRtmpIngestPointResponse> PatchAsync(string encodingId, Models.UpdateEncodingRtmpIngestPointRequest updateEncodingRtmpIngestPointRequest)
        {
            return await _apiClient.PatchAsync(encodingId, updateEncodingRtmpIngestPointRequest);
        }

        internal interface IActionsApiClient
        {
            [Patch("/encoding/live/encodings/{encoding_id}/actions/update-rtmp-ingest-points")]
            [AllowAnyStatusCode]
            Task<Models.UpdateEncodingRtmpIngestPointResponse> PatchAsync([Path("encoding_id")] string encodingId, [Body] Models.UpdateEncodingRtmpIngestPointRequest updateEncodingRtmpIngestPointRequest);
        }
    }
}
