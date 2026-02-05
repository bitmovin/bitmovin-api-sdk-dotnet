using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Type;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Vtt;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Imsc;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Sprite;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Fmp4;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.ChunkedText;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Cmaf;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Mp4;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.Webm;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations.ProgressiveWebm;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Dash.Periods.Adaptationsets.Representations
{
    /// <summary>
    /// API for RepresentationsApi
    /// </summary>
    public class RepresentationsApi
    {
        private readonly IRepresentationsApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the RepresentationsApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public RepresentationsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IRepresentationsApiClient>();
            Type = new TypeApi(apiClientFactory);
            Vtt = new VttApi(apiClientFactory);
            Imsc = new ImscApi(apiClientFactory);
            Sprite = new SpriteApi(apiClientFactory);
            Fmp4 = new Fmp4Api(apiClientFactory);
            ChunkedText = new ChunkedTextApi(apiClientFactory);
            Cmaf = new CmafApi(apiClientFactory);
            Mp4 = new Mp4Api(apiClientFactory);
            Webm = new WebmApi(apiClientFactory);
            ProgressiveWebm = new ProgressiveWebmApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of RepresentationsApi
        /// </summary>
        public static BitmovinApiBuilder<RepresentationsApi> Builder => new BitmovinApiBuilder<RepresentationsApi>();

        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the Vtt API
        /// </summary>
        public VttApi Vtt { get; }
        /// <summary>
        /// Gets the Imsc API
        /// </summary>
        public ImscApi Imsc { get; }
        /// <summary>
        /// Gets the Sprite API
        /// </summary>
        public SpriteApi Sprite { get; }
        /// <summary>
        /// Gets the Fmp4 API
        /// </summary>
        public Fmp4Api Fmp4 { get; }
        /// <summary>
        /// Gets the ChunkedText API
        /// </summary>
        public ChunkedTextApi ChunkedText { get; }
        /// <summary>
        /// Gets the Cmaf API
        /// </summary>
        public CmafApi Cmaf { get; }
        /// <summary>
        /// Gets the Mp4 API
        /// </summary>
        public Mp4Api Mp4 { get; }
        /// <summary>
        /// Gets the Webm API
        /// </summary>
        public WebmApi Webm { get; }
        /// <summary>
        /// Gets the ProgressiveWebm API
        /// </summary>
        public ProgressiveWebmApi ProgressiveWebm { get; }

        /// <summary>
        /// List all DASH Representations
        /// </summary>
        /// <param name="manifestId">Id of the manifest (required)</param>
        /// <param name="periodId">Id of the period (required)</param>
        /// <param name="adaptationsetId">Id of the adaptation set (required)</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.DashRepresentation>> ListAsync(string manifestId, string periodId, string adaptationsetId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, periodId, adaptationsetId, q);
        }

        internal interface IRepresentationsApiClient
        {
            [Get("/encoding/manifests/dash/{manifest_id}/periods/{period_id}/adaptationsets/{adaptationset_id}/representations")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.DashRepresentation>> ListAsync([Path("manifest_id")] string manifestId, [Path("period_id")] string periodId, [Path("adaptationset_id")] string adaptationsetId, [QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
