using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Type;
using Bitmovin.Api.Sdk.Encoding.Filters.Conform;
using Bitmovin.Api.Sdk.Encoding.Filters.Watermark;
using Bitmovin.Api.Sdk.Encoding.Filters.AudioVolume;
using Bitmovin.Api.Sdk.Encoding.Filters.AzureSpeechToCaptions;
using Bitmovin.Api.Sdk.Encoding.Filters.EnhancedWatermark;
using Bitmovin.Api.Sdk.Encoding.Filters.Crop;
using Bitmovin.Api.Sdk.Encoding.Filters.Rotate;
using Bitmovin.Api.Sdk.Encoding.Filters.Deinterlace;
using Bitmovin.Api.Sdk.Encoding.Filters.EnhancedDeinterlace;
using Bitmovin.Api.Sdk.Encoding.Filters.AudioMix;
using Bitmovin.Api.Sdk.Encoding.Filters.DenoiseHqdn3d;
using Bitmovin.Api.Sdk.Encoding.Filters.EbuR128SinglePass;
using Bitmovin.Api.Sdk.Encoding.Filters.Text;
using Bitmovin.Api.Sdk.Encoding.Filters.Interlace;
using Bitmovin.Api.Sdk.Encoding.Filters.Unsharp;
using Bitmovin.Api.Sdk.Encoding.Filters.Scale;

namespace Bitmovin.Api.Sdk.Encoding.Filters
{
    /// <summary>
    /// API for FiltersApi
    /// </summary>
    public class FiltersApi
    {
        private readonly IFiltersApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the FiltersApi class
        /// </summary>
        /// <param name="apiClientFactory">The API client factory</param>
        public FiltersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFiltersApiClient>();
            Type = new TypeApi(apiClientFactory);
            Conform = new ConformApi(apiClientFactory);
            Watermark = new WatermarkApi(apiClientFactory);
            AudioVolume = new AudioVolumeApi(apiClientFactory);
            AzureSpeechToCaptions = new AzureSpeechToCaptionsApi(apiClientFactory);
            EnhancedWatermark = new EnhancedWatermarkApi(apiClientFactory);
            Crop = new CropApi(apiClientFactory);
            Rotate = new RotateApi(apiClientFactory);
            Deinterlace = new DeinterlaceApi(apiClientFactory);
            EnhancedDeinterlace = new EnhancedDeinterlaceApi(apiClientFactory);
            AudioMix = new AudioMixApi(apiClientFactory);
            DenoiseHqdn3d = new DenoiseHqdn3dApi(apiClientFactory);
            EbuR128SinglePass = new EbuR128SinglePassApi(apiClientFactory);
            Text = new TextApi(apiClientFactory);
            Interlace = new InterlaceApi(apiClientFactory);
            Unsharp = new UnsharpApi(apiClientFactory);
            Scale = new ScaleApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of FiltersApi
        /// </summary>
        public static BitmovinApiBuilder<FiltersApi> Builder => new BitmovinApiBuilder<FiltersApi>();

        /// <summary>
        /// Gets the Type API
        /// </summary>
        public TypeApi Type { get; }
        /// <summary>
        /// Gets the Conform API
        /// </summary>
        public ConformApi Conform { get; }
        /// <summary>
        /// Gets the Watermark API
        /// </summary>
        public WatermarkApi Watermark { get; }
        /// <summary>
        /// Gets the AudioVolume API
        /// </summary>
        public AudioVolumeApi AudioVolume { get; }
        /// <summary>
        /// Gets the AzureSpeechToCaptions API
        /// </summary>
        public AzureSpeechToCaptionsApi AzureSpeechToCaptions { get; }
        /// <summary>
        /// Gets the EnhancedWatermark API
        /// </summary>
        public EnhancedWatermarkApi EnhancedWatermark { get; }
        /// <summary>
        /// Gets the Crop API
        /// </summary>
        public CropApi Crop { get; }
        /// <summary>
        /// Gets the Rotate API
        /// </summary>
        public RotateApi Rotate { get; }
        /// <summary>
        /// Gets the Deinterlace API
        /// </summary>
        public DeinterlaceApi Deinterlace { get; }
        /// <summary>
        /// Gets the EnhancedDeinterlace API
        /// </summary>
        public EnhancedDeinterlaceApi EnhancedDeinterlace { get; }
        /// <summary>
        /// Gets the AudioMix API
        /// </summary>
        public AudioMixApi AudioMix { get; }
        /// <summary>
        /// Gets the DenoiseHqdn3d API
        /// </summary>
        public DenoiseHqdn3dApi DenoiseHqdn3d { get; }
        /// <summary>
        /// Gets the EbuR128SinglePass API
        /// </summary>
        public EbuR128SinglePassApi EbuR128SinglePass { get; }
        /// <summary>
        /// Gets the Text API
        /// </summary>
        public TextApi Text { get; }
        /// <summary>
        /// Gets the Interlace API
        /// </summary>
        public InterlaceApi Interlace { get; }
        /// <summary>
        /// Gets the Unsharp API
        /// </summary>
        public UnsharpApi Unsharp { get; }
        /// <summary>
        /// Gets the Scale API
        /// </summary>
        public ScaleApi Scale { get; }

        /// <summary>
        /// Get Filter Details
        /// </summary>
        /// <param name="filterId">Id of the filter (required)</param>
        public async Task<Models.Filter> GetAsync(string filterId)
        {
            return await _apiClient.GetAsync(filterId);
        }

        /// <summary>
        /// List all Filters
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Filter>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IFiltersApiClient
        {
            [Get("/encoding/filters/{filter_id}")]
            [AllowAnyStatusCode]
            Task<Models.Filter> GetAsync([Path("filter_id")] string filterId);

            [Get("/encoding/filters")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Filter>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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

            /// <summary>
            /// Filter filters by name. Multiple names are separated with a &#x60;,&#x60;
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

            /// <summary>
            /// Order list result according to a filter resource attribute. The fields that can be used for sorting are: + &#x60;id&#x60; + &#x60;createdAt&#x60; + &#x60;modifiedAt&#x60; + &#x60;type&#x60; + &#x60;name&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter filters by type. Multiple types are separated with a &#x60;,&#x60;
            /// </summary>
            public ListQueryParams Type(string type) => SetQueryParam("type", type);

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
