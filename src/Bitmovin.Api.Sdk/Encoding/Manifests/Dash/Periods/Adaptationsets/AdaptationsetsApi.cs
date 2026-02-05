using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Type;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Audio;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Video;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Subtitle;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Image;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Contentprotection;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets
{
    /// <summary>
    /// API for AdaptationsetsApi
    /// </summary>
    public class AdaptationsetsApi
    {
        private readonly IAdaptationsetsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the AdaptationsetsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public AdaptationsetsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAdaptationsetsApiClient>();
            Type = new TypeApi(apiClientFactory);
            Audio = new AudioApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Subtitle = new SubtitleApi(apiClientFactory);
            Image = new ImageApi(apiClientFactory);
            Representations = new RepresentationsApi(apiClientFactory);
            Contentprotection = new ContentprotectionApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AdaptationsetsApi
        /// </summary>
        public static BitmovinApiBuilder<AdaptationsetsApi> Builder => new BitmovinApiBuilder<AdaptationsetsApi>();

        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the Audio API
        /// </summary>
        public AudioApi Audio { get; }
        /// <summary>
        /// Gets the Video API
        /// </summary>
        public VideoApi Video { get; }
        /// <summary>
        /// Gets the Subtitle API
        /// </summary>
        public SubtitleApi Subtitle { get; }
        /// <summary>
        /// Gets the Image API
        /// </summary>
        public ImageApi Image { get; }
        /// <summary>
        /// Gets the Representations API
        /// </summary>
        public RepresentationsApi Representations { get; }
        /// <summary>
        /// Gets the Contentprotection API
        /// </summary>
        public ContentprotectionApi Contentprotection { get; }

        /// <summary>
        /// List all AdaptationSets
        /// </summary>
        /// <param name="manifestId">Id of the Manifest (required)</param>
        /// <param name="periodId">Id of the Period (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AdaptationSet>> ListAsync(string manifestId, string periodId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, q);
        }

        internal interface IAdaptationsetsApiClient
        {
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AdaptationSet>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
        }

        /// <summary>
        /// Query parameters for List
        /// </summary>
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}
