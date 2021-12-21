using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Simple.Jobs.Vod
{
    public class VodApi
    {
        private readonly IVodApiClient _apiClient;

        public VodApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVodApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of VodApi
        /// </summary>
        public static BitmovinApiBuilder<VodApi> Builder => new BitmovinApiBuilder<VodApi>();

        /// <summary>
        /// Create a Simple Encoding VOD Job
        /// </summary>
        /// <param name="simpleEncodingVodJobRequest">The Simple Encoding VOD Job to be created.  Check out our [Simple Encoding API Documentation](https://bitmovin.com/docs/encoding/articles/simple-encoding-api) for additional information about the Simple Encoding API. </param>
        public async Task<Models.SimpleEncodingVodJobResponse> CreateAsync(Models.SimpleEncodingVodJobRequest simpleEncodingVodJobRequest)
        {
            return await _apiClient.CreateAsync(simpleEncodingVodJobRequest);
        }

        /// <summary>
        /// Simple Encoding VOD Job details
        /// </summary>
        /// <param name="simpleEncodingJobId">Id of the Simple Encoding VOD Job (required)</param>
        public async Task<Models.SimpleEncodingVodJobResponse> GetAsync(string simpleEncodingJobId)
        {
            return await _apiClient.GetAsync(simpleEncodingJobId);
        }

        /// <summary>
        /// List all Simple Encoding VOD Jobs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.SimpleEncodingVodJobResponse>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IVodApiClient
        {
            [Post("/encoding/simple/jobs/vod")]
            [AllowAnyStatusCode]
            Task<Models.SimpleEncodingVodJobResponse> CreateAsync([Body] Models.SimpleEncodingVodJobRequest simpleEncodingVodJobRequest);

            [Get("/encoding/simple/jobs/vod/{simple_encoding_job_id}")]
            [AllowAnyStatusCode]
            Task<Models.SimpleEncodingVodJobResponse> GetAsync([Path("simple_encoding_job_id")] string simpleEncodingJobId);

            [Get("/encoding/simple/jobs/vod")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.SimpleEncodingVodJobResponse>> ListAsync([QueryMap(SerializationMethod = QuerySerializationMethod.Serialized)] IDictionary<String, Object> queryParams);
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
            /// Order list result according to a Simple Encoding VOD Job attribute. The fields that can be used for sorting are: + &#x60;createdAt&#x60; 
            /// </summary>
            public ListQueryParams Sort(string sort) => SetQueryParam("sort", sort);

            /// <summary>
            /// Filter Simple Encoding VOD Jobs to only show the ones with the status specified.
            /// </summary>
            public ListQueryParams Status(string status) => SetQueryParam("status", status);

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
