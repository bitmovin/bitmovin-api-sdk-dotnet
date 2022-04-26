using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Simple.Jobs.Live
{
    public class LiveApi
    {
        private readonly ILiveApiClient _apiClient;

        public LiveApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveApi
        /// </summary>
        public static BitmovinApiBuilder<LiveApi> Builder => new BitmovinApiBuilder<LiveApi>();

        /// <summary>
        /// Create a Simple Encoding Live Job
        /// </summary>
        /// <param name="simpleEncodingLiveJobRequest">The Simple Encoding Live Job to be created.  Check out our [Simple Encoding API Live Documentation](https://bitmovin.com/docs/encoding/articles/simple-encoding-api-live) for additional information about the Simple Encoding API Live. </param>
        public async Task<Models.SimpleEncodingLiveJobResponse> CreateAsync(Models.SimpleEncodingLiveJobRequest simpleEncodingLiveJobRequest)
        {
            return await _apiClient.CreateAsync(simpleEncodingLiveJobRequest);
        }

        /// <summary>
        /// Simple Encoding Live Job details
        /// </summary>
        /// <param name="simpleEncodingJobId">Id of the Simple Encoding Live Job (required)</param>
        public async Task<Models.SimpleEncodingLiveJobResponse> GetAsync(string simpleEncodingJobId)
        {
            return await _apiClient.GetAsync(simpleEncodingJobId);
        }

        internal interface ILiveApiClient
        {
            [Post("/encoding/simple/jobs/live")]
            [AllowAnyStatusCode]
            Task<Models.SimpleEncodingLiveJobResponse> CreateAsync([Body] Models.SimpleEncodingLiveJobRequest simpleEncodingLiveJobRequest);

            [Get("/encoding/simple/jobs/live/{simple_encoding_job_id}")]
            [AllowAnyStatusCode]
            Task<Models.SimpleEncodingLiveJobResponse> GetAsync([Path("simple_encoding_job_id")] string simpleEncodingJobId);
        }
    }
}
