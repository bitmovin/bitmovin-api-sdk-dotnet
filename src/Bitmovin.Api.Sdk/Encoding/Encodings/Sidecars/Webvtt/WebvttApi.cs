using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars.Webvtt
{
    public class WebvttApi
    {
        private readonly IWebvttApiClient _apiClient;

        public WebvttApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IWebvttApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of WebvttApi
        /// </summary>
        public static BitmovinApiBuilder<WebvttApi> Builder => new BitmovinApiBuilder<WebvttApi>();

        
        /// <summary>
        /// Add WebVTT sidecar file
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="webVttSidecarFile">The request payload</param>
        public async Task<Models.WebVttSidecarFile> CreateAsync(string encodingId, Models.WebVttSidecarFile webVttSidecarFile)
        {
            return await _apiClient.CreateAsync(encodingId, webVttSidecarFile);
        }
        
        /// <summary>
        /// Delete Sidecar
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="sidecarId">Id of the sidecar.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.DeleteAsync(encodingId, sidecarId);
        }
        
        /// <summary>
        /// WebVTT Sidecar Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="sidecarId">Id of the sidecar.</param>
        public async Task<Models.WebVttSidecarFile> GetAsync(string encodingId, string sidecarId)
        {
            return await _apiClient.GetAsync(encodingId, sidecarId);
        }
        
        internal interface IWebvttApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/sidecars/webvtt")]
            [AllowAnyStatusCode]
            Task<Models.WebVttSidecarFile> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.WebVttSidecarFile webVttSidecarFile);
            
            [Delete("/encoding/encodings/{encoding_id}/sidecars/webvtt/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);
            
            [Get("/encoding/encodings/{encoding_id}/sidecars/webvtt/{sidecar_id}")]
            [AllowAnyStatusCode]
            Task<Models.WebVttSidecarFile> GetAsync([Path("encoding_id")] string encodingId, [Path("sidecar_id")] string sidecarId);
            
        }
        
    }
}
