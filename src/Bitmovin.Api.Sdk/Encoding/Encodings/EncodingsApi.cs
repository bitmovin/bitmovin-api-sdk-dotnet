using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live;
using Bitmovin.Api.Sdk.Encoding.Encodings.MachineLearning;
using Bitmovin.Api.Sdk.Encoding.Encodings.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions;
using Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars;
using Bitmovin.Api.Sdk.Encoding.Encodings.Keyframes;

namespace Bitmovin.Api.Sdk.Encoding.Encodings
{
    public class EncodingsApi
    {
        private readonly IEncodingsApiClient _apiClient;

        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEncodingsApiClient>();

            Live = new LiveApi(apiClientFactory);
            MachineLearning = new MachineLearningApi(apiClientFactory);
            Customdata = new CustomdataApi(apiClientFactory);
            Streams = new StreamsApi(apiClientFactory);
            InputStreams = new InputStreamsApi(apiClientFactory);
            Muxings = new MuxingsApi(apiClientFactory);
            Captions = new CaptionsApi(apiClientFactory);
            Sidecars = new SidecarsApi(apiClientFactory);
            Keyframes = new KeyframesApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        public LiveApi Live { get; private set; }
        public MachineLearningApi MachineLearning { get; private set; }
        public CustomdataApi Customdata { get; private set; }
        public StreamsApi Streams { get; private set; }
        public InputStreamsApi InputStreams { get; private set; }
        public MuxingsApi Muxings { get; private set; }
        public CaptionsApi Captions { get; private set; }
        public SidecarsApi Sidecars { get; private set; }
        public KeyframesApi Keyframes { get; private set; }
        
        /// <summary>
        /// Create Encoding
        /// </summary>
        /// <param name="encoding">The request payload</param>
        public async Task<Models.Encoding> CreateAsync(Models.Encoding encoding)
        {
            return await _apiClient.CreateAsync(encoding);
        }
        
        /// <summary>
        /// Delete Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId)
        {
            return await _apiClient.DeleteAsync(encodingId);
        }
        
        /// <summary>
        /// Encoding Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        public async Task<Models.Encoding> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }
        
        /// <summary>
        /// Encoding Start Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        public async Task<Models.StartEncodingRequest> GetStartRequestAsync(string encodingId)
        {
            return await _apiClient.GetStartRequestAsync(encodingId);
        }
        
        /// <summary>
        /// List all Encodings
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Encoding>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        /// <summary>
        /// Reprioritize Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="reprioritizeEncodingRequest">The request payload</param>
        public async Task<Models.BitmovinResponse> ReprioritizeAsync(string encodingId, Models.ReprioritizeEncodingRequest reprioritizeEncodingRequest)
        {
            return await _apiClient.ReprioritizeAsync(encodingId, reprioritizeEncodingRequest);
        }
        
        /// <summary>
        /// Reschedule Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="rescheduleEncodingRequest">The request payload</param>
        public async Task<Models.BitmovinResponse> RescheduleAsync(string encodingId, Models.RescheduleEncodingRequest rescheduleEncodingRequest)
        {
            return await _apiClient.RescheduleAsync(encodingId, rescheduleEncodingRequest);
        }
        
        /// <summary>
        /// Start Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        /// <param name="startEncodingRequest">The request payload</param>
        public async Task<Models.BitmovinResponse> StartAsync(string encodingId, Models.StartEncodingRequest startEncodingRequest = null)
        {
            return await _apiClient.StartAsync(encodingId, startEncodingRequest);
        }
        
        /// <summary>
        /// Encoding Status
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        public async Task<Models.ServiceTaskStatus> StatusAsync(string encodingId)
        {
            return await _apiClient.StatusAsync(encodingId);
        }
        
        /// <summary>
        /// Stop Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding</param>
        public async Task<Models.BitmovinResponse> StopAsync(string encodingId)
        {
            return await _apiClient.StopAsync(encodingId);
        }
        
        internal interface IEncodingsApiClient
        {
            
            [Post("/encoding/encodings")]
            [AllowAnyStatusCode]
            Task<Models.Encoding> CreateAsync([Body] Models.Encoding encoding);
            
            [Delete("/encoding/encodings/{encoding_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId);
            
            [Get("/encoding/encodings/{encoding_id}")]
            [AllowAnyStatusCode]
            Task<Models.Encoding> GetAsync([Path("encoding_id")] string encodingId);
            
            [Get("/encoding/encodings/{encoding_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.StartEncodingRequest> GetStartRequestAsync([Path("encoding_id")] string encodingId);
            
            [Get("/encoding/encodings")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Encoding>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
            [Post("/encoding/encodings/{encoding_id}/reprioritize")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> ReprioritizeAsync([Path("encoding_id")] string encodingId, [Body] Models.ReprioritizeEncodingRequest reprioritizeEncodingRequest);
            
            [Post("/encoding/encodings/{encoding_id}/reschedule")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> RescheduleAsync([Path("encoding_id")] string encodingId, [Body] Models.RescheduleEncodingRequest rescheduleEncodingRequest);
            
            [Post("/encoding/encodings/{encoding_id}/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("encoding_id")] string encodingId, [Body] Models.StartEncodingRequest startEncodingRequest);
            
            [Get("/encoding/encodings/{encoding_id}/status")]
            [AllowAnyStatusCode]
            Task<Models.ServiceTaskStatus> StatusAsync([Path("encoding_id")] string encodingId);
            
            [Post("/encoding/encodings/{encoding_id}/stop")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StopAsync([Path("encoding_id")] string encodingId);
            
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
            /// Order list result according an encoding resource attribute
            /// </summary>
            public ListQueryParams Sort(string Sort) => SetQueryParam("sort", Sort);

            /// <summary>
            /// Filter encodings to only show the ones with the type specified.
            /// </summary>
            public ListQueryParams Type(string Type) => SetQueryParam("type", Type);

            /// <summary>
            /// Filter encodings to only show the ones with the status specified.
            /// </summary>
            public ListQueryParams Status(string Status) => SetQueryParam("status", Status);

            /// <summary>
            /// Filter encodings to only show the ones with the cloudRegion specified.
            /// </summary>
            public ListQueryParams CloudRegion(Models.CloudRegion CloudRegion) => SetQueryParam("cloudRegion", CloudRegion);

            /// <summary>
            /// Filter encodings to only show the ones with the encoderVersion specified.
            /// </summary>
            public ListQueryParams EncoderVersion(string EncoderVersion) => SetQueryParam("encoderVersion", EncoderVersion);

            /// <summary>
            /// Filter encodings to only show the ones with this exact name.
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

            /// <summary>
            /// The search query string for advanced filtering.  We are using the [Apache Lucene](https://lucene.apache.org/) query syntax here.  Only lucene queries equivalent to exact matching and startsWith are supported. Also only AND conjunctions supported at the moment.  Please be aware that our filters are **case-insensitive**  Examples of supported lucene queries: + &#x60;name:MyEncoding1&#x60; - This searches for encodings with names that are equal to &#x60;myencoding1&#x60;  + &#x60;name:\&quot;My Encoding\&quot;&#x60; - This searches for encodings with names that are equal to &#x60;my encoding&#x60;  + &#x60;name:MyEncoding\\*&#x60; - This searches for encodings with names that are equal to &#x60;myencoding*&#x60; Please have a look at the [Lucene Documentation - Escaping Special Characters](https://lucene.apache.org/core/8_1_1/queryparser/org/apache/lucene/queryparser/classic/package-summary.html#Escaping_Special_Characters) section to see what characters have to be escaped.  + &#x60;name:test*&#x60; - This searches for encodings with names that start with &#x60;test&#x60;  + &#x60;name:test* AND labels:Customer1&#x60; - This searches for encodings with names starting with &#x60;test&#x60; and labels containing an entry that is equal to &#x60;customer1&#x60;  Available search fields: + &#x60;name&#x60;  + &#x60;labels&#x60;  Please be aware to send these queries url encoded.  If you provide fields or lucene queries that are not supported, it will result in an error response. 
            /// </summary>
            public ListQueryParams Search(string Search) => SetQueryParam("search", Search);

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
