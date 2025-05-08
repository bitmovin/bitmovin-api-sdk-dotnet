using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live;
using Bitmovin.Api.Sdk.Encoding.Encodings.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Streams;
using Bitmovin.Api.Sdk.Encoding.Encodings.InputStreams;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings;
using Bitmovin.Api.Sdk.Encoding.Encodings.Template;
using Bitmovin.Api.Sdk.Encoding.Encodings.TransferRetries;
using Bitmovin.Api.Sdk.Encoding.Encodings.OutputPaths;
using Bitmovin.Api.Sdk.Encoding.Encodings.Captions;
using Bitmovin.Api.Sdk.Encoding.Encodings.Sidecars;
using Bitmovin.Api.Sdk.Encoding.Encodings.Keyframes;
using Bitmovin.Api.Sdk.Encoding.Encodings.Scte35Triggers;

namespace Bitmovin.Api.Sdk.Encoding.Encodings
{
    public class EncodingsApi
    {
        private readonly IEncodingsApiClient _apiClient;

        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IEncodingsApiClient>();
            Live = new LiveApi(apiClientFactory);
            Customdata = new CustomdataApi(apiClientFactory);
            Streams = new StreamsApi(apiClientFactory);
            InputStreams = new InputStreamsApi(apiClientFactory);
            Muxings = new MuxingsApi(apiClientFactory);
            Template = new TemplateApi(apiClientFactory);
            TransferRetries = new TransferRetriesApi(apiClientFactory);
            OutputPaths = new OutputPathsApi(apiClientFactory);
            Captions = new CaptionsApi(apiClientFactory);
            Sidecars = new SidecarsApi(apiClientFactory);
            Keyframes = new KeyframesApi(apiClientFactory);
            Scte35Triggers = new Scte35TriggersApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        public LiveApi Live { get; }
        public CustomdataApi Customdata { get; }
        public StreamsApi Streams { get; }
        public InputStreamsApi InputStreams { get; }
        public MuxingsApi Muxings { get; }
        public TemplateApi Template { get; }
        public TransferRetriesApi TransferRetries { get; }
        public OutputPathsApi OutputPaths { get; }
        public CaptionsApi Captions { get; }
        public SidecarsApi Sidecars { get; }
        public KeyframesApi Keyframes { get; }
        public Scte35TriggersApi Scte35Triggers { get; }

        /// <summary>
        /// Create Encoding
        /// </summary>
        /// <param name="encoding">The Encoding to be created</param>
        public async Task<Models.Encoding> CreateAsync(Models.Encoding encoding)
        {
            return await _apiClient.CreateAsync(encoding);
        }

        /// <summary>
        /// Delete Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId)
        {
            return await _apiClient.DeleteAsync(encodingId);
        }

        /// <summary>
        /// Encoding Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.Encoding> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        /// <summary>
        /// Encoding Start Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
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
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="reprioritizeEncodingRequest">Reprioritization options</param>
        public async Task<Models.BitmovinResponse> ReprioritizeAsync(string encodingId, Models.ReprioritizeEncodingRequest reprioritizeEncodingRequest)
        {
            return await _apiClient.ReprioritizeAsync(encodingId, reprioritizeEncodingRequest);
        }

        /// <summary>
        /// Reschedule Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        /// <param name="rescheduleEncodingRequest">Rescheduling options</param>
        public async Task<Models.BitmovinResponse> RescheduleAsync(string encodingId, Models.RescheduleEncodingRequest rescheduleEncodingRequest)
        {
            return await _apiClient.RescheduleAsync(encodingId, rescheduleEncodingRequest);
        }

        /// <summary>
        /// Start VoD Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="startEncodingRequest">Encoding Startup Options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string encodingId, Models.StartEncodingRequest startEncodingRequest = null)
        {
            return await _apiClient.StartAsync(encodingId, startEncodingRequest);
        }

        /// <summary>
        /// Encoding Status
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.ServiceTaskStatus> StatusAsync(string encodingId)
        {
            return await _apiClient.StatusAsync(encodingId);
        }

        /// <summary>
        /// Stop Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
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
            Task<Models.PaginationResponse<Models.Encoding>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);

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
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

            /// <summary>
            /// A boolean indicating whether the total count should be returned as well. Default is false. Setting this flag to true is discouraged.
            /// </summary>
            public ListQueryParams IncludeTotalCount(bool? includeTotalCount) => SetQueryParam("includeTotalCount", includeTotalCount);

            /// <summary>
            /// Order list result according an encoding resource attribute. The fields that can be used for sorting are: + &#x60;id&#x60; + &#x60;startedAt&#x60; + &#x60;createdAt&#x60; + &#x60;modifiedAt&#x60; + &#x60;finishedAt&#x60; + &#x60;type&#x60; + &#x60;name&#x60; + &#x60;status&#x60; + &#x60;cloudRegion&#x60; + &#x60;encoderVersion&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter encodings to only show the ones with the type specified.
            /// </summary>
            public ListQueryParams Type(string type) => SetQueryParam("type", type);

            /// <summary>
            /// Filter encodings to only show the ones with the status specified.
            /// </summary>
            public ListQueryParams Status(string status) => SetQueryParam("status", status);

            /// <summary>
            /// Filter encodings to only show the ones with the cloudRegion specified.
            /// </summary>
            public ListQueryParams CloudRegion(Models.CloudRegion cloudRegion) => SetQueryParam("cloudRegion", cloudRegion);

            /// <summary>
            /// Filter encodings to only show the ones with the selectedCloudRegion specified which was selected when cloudregion:AUTO was set
            /// </summary>
            public ListQueryParams SelectedCloudRegion(Models.CloudRegion selectedCloudRegion) => SetQueryParam("selectedCloudRegion", selectedCloudRegion);

            /// <summary>
            /// Filter encodings to only show the ones with the encoderVersion specified.
            /// </summary>
            public ListQueryParams EncoderVersion(string encoderVersion) => SetQueryParam("encoderVersion", encoderVersion);

            /// <summary>
            /// Filter encodings to only show the ones with the encoderVersion specified that was actually used for the encoding.
            /// </summary>
            public ListQueryParams SelectedEncoderVersion(string selectedEncoderVersion) => SetQueryParam("selectedEncoderVersion", selectedEncoderVersion);

            /// <summary>
            /// Filter encodings to only show the ones with the encodingMode specified that was actually used for the encoding.
            /// </summary>
            public ListQueryParams SelectedEncodingMode(Models.EncodingMode selectedEncodingMode) => SetQueryParam("selectedEncodingMode", selectedEncodingMode);

            /// <summary>
            /// Filter encodings to only show the ones with this exact name.
            /// </summary>
            public ListQueryParams Name(string name) => SetQueryParam("name", name);

            /// <summary>
            /// The search query string for advanced filtering.  We are using the [Apache Lucene](https://lucene.apache.org/) query syntax here.  Only lucene queries equivalent to exact matching and startsWith are supported. Also only AND conjunctions supported at the moment.  Please be aware that our filters are **case-insensitive**  Examples of supported lucene queries: + &#x60;name:MyEncoding1&#x60; - This searches for encodings with names that are equal to &#x60;myencoding1&#x60;  + &#x60;name:\&quot;My Encoding\&quot;&#x60; - This searches for encodings with names that are equal to &#x60;my encoding&#x60;  + &#x60;name:MyEncoding\\*&#x60; - This searches for encodings with names that are equal to &#x60;myencoding*&#x60; Please have a look at the [Lucene Documentation - Escaping Special Characters](https://lucene.apache.org/core/8_1_1/queryparser/org/apache/lucene/queryparser/classic/package-summary.html#Escaping_Special_Characters) section to see what characters have to be escaped.  + &#x60;name:test*&#x60; - This searches for encodings with names that start with &#x60;test&#x60;  + &#x60;name:test* AND labels:Customer1&#x60; - This searches for encodings with names starting with &#x60;test&#x60; and labels containing an entry that is equal to &#x60;customer1&#x60;  Available search fields: + &#x60;name&#x60;  + &#x60;labels&#x60;  Please be aware to send these queries url encoded.  If you provide fields or lucene queries that are not supported, it will result in an error response. 
            /// </summary>
            public ListQueryParams Search(string search) => SetQueryParam("search", search);

            /// <summary>
            /// Filter encodings to only return those created after this exact time, provided in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams CreatedAtNewerThan(DateTime? createdAtNewerThan) => SetQueryParam("createdAtNewerThan", createdAtNewerThan);

            /// <summary>
            /// Filter encodings to only return those created before this exact time, provided in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams CreatedAtOlderThan(DateTime? createdAtOlderThan) => SetQueryParam("createdAtOlderThan", createdAtOlderThan);

            /// <summary>
            /// Filter encodings to only return those started after this exact time, provided in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams StartedAtNewerThan(DateTime? startedAtNewerThan) => SetQueryParam("startedAtNewerThan", startedAtNewerThan);

            /// <summary>
            /// Filter encodings to only return those started before this exact time, provided in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
            /// </summary>
            public ListQueryParams StartedAtOlderThan(DateTime? startedAtOlderThan) => SetQueryParam("startedAtOlderThan", startedAtOlderThan);

            /// <summary>
            /// Filter encodings to only return those finished at newer than this exact time, provided in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ Available for all encodings started after REST API Service release v1.50.0 (Changelogs for more information https://bitmovin.com/docs/encoding/changelogs/rest) 
            /// </summary>
            public ListQueryParams FinishedAtNewerThan(DateTime? finishedAtNewerThan) => SetQueryParam("finishedAtNewerThan", finishedAtNewerThan);

            /// <summary>
            /// Filter encodings to only return those finished at older than this exact time, provided in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ Available for all encodings started after REST API Service release v1.50.0 (Changelogs for more information https://bitmovin.com/docs/encoding/changelogs/rest) 
            /// </summary>
            public ListQueryParams FinishedAtOlderThan(DateTime? finishedAtOlderThan) => SetQueryParam("finishedAtOlderThan", finishedAtOlderThan);

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
