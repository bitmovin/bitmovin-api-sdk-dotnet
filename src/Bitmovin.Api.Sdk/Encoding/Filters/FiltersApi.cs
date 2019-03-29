using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Filters.Watermark;
using Bitmovin.Api.Sdk.Encoding.Filters.AudioVolume;
using Bitmovin.Api.Sdk.Encoding.Filters.EnhancedWatermark;
using Bitmovin.Api.Sdk.Encoding.Filters.Crop;
using Bitmovin.Api.Sdk.Encoding.Filters.Rotate;
using Bitmovin.Api.Sdk.Encoding.Filters.Deinterlace;
using Bitmovin.Api.Sdk.Encoding.Filters.AudioMix;
using Bitmovin.Api.Sdk.Encoding.Filters.DenoiseHqdn3d;
using Bitmovin.Api.Sdk.Encoding.Filters.Text;
using Bitmovin.Api.Sdk.Encoding.Filters.Interlace;
using Bitmovin.Api.Sdk.Encoding.Filters.Unsharp;
using Bitmovin.Api.Sdk.Encoding.Filters.Scale;
using Bitmovin.Api.Sdk.Encoding.Filters.Type;

namespace Bitmovin.Api.Sdk.Encoding.Filters
{
    public class FiltersApi
    {
        private readonly IFiltersApiClient _apiClient;

        public FiltersApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFiltersApiClient>();

            Watermark = new WatermarkApi(apiClientFactory);
            AudioVolume = new AudioVolumeApi(apiClientFactory);
            EnhancedWatermark = new EnhancedWatermarkApi(apiClientFactory);
            Crop = new CropApi(apiClientFactory);
            Rotate = new RotateApi(apiClientFactory);
            Deinterlace = new DeinterlaceApi(apiClientFactory);
            AudioMix = new AudioMixApi(apiClientFactory);
            DenoiseHqdn3d = new DenoiseHqdn3dApi(apiClientFactory);
            Text = new TextApi(apiClientFactory);
            Interlace = new InterlaceApi(apiClientFactory);
            Unsharp = new UnsharpApi(apiClientFactory);
            Scale = new ScaleApi(apiClientFactory);
            Type = new TypeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of FiltersApi
        /// </summary>
        public static BitmovinApiBuilder<FiltersApi> Builder => new BitmovinApiBuilder<FiltersApi>();

        public WatermarkApi Watermark { get; private set; }
        public AudioVolumeApi AudioVolume { get; private set; }
        public EnhancedWatermarkApi EnhancedWatermark { get; private set; }
        public CropApi Crop { get; private set; }
        public RotateApi Rotate { get; private set; }
        public DeinterlaceApi Deinterlace { get; private set; }
        public AudioMixApi AudioMix { get; private set; }
        public DenoiseHqdn3dApi DenoiseHqdn3d { get; private set; }
        public TextApi Text { get; private set; }
        public InterlaceApi Interlace { get; private set; }
        public UnsharpApi Unsharp { get; private set; }
        public ScaleApi Scale { get; private set; }
        public TypeApi Type { get; private set; }
        
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
            
            [Get("/encoding/filters")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Filter>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            /// <summary>
            /// Filter filters by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
